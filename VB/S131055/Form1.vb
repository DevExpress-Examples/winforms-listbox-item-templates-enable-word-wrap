Imports DevExpress.Utils.Text
Imports DevExpress.XtraEditors
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace S131055
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            categoriesBindingSource.DataSource = GetCategoriesDataTable()
        End Sub

        Private Function GetCategoriesDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "Categories"
            table.Columns.Add(New DataColumn("CategoryID", GetType(Integer)))
            table.Columns.Add(New DataColumn("Description", GetType(String)))
            Dim random As Random = New Random()
            Dim PossibleItems As String() = New String() {"Tea", "Coffee", "Butter", "Lemon", "Apple", "Orange", "Milk", "Chocolate"}

            For i As Integer = 0 To 20 - 1
                Dim index As Integer = i + 1
                Dim items As String = String.Empty

                For j As Integer = 0 To random.Next(3, 14) - 1
                    items += PossibleItems(random.Next(0, 8)) & " "
                Next

                table.Rows.Add(index, items)
            Next

            Return table
        End Function

        Private Sub listBoxControl1_DrawItem(ByVal sender As Object, ByVal e As ListBoxDrawItemEventArgs) Handles listBoxControl1.DrawItem
            Dim control As ListBoxControl = CType(sender, ListBoxControl)
            e.Appearance.DrawBackground(e.Cache, e.Bounds)
            TextUtils.DrawString(e.Graphics, control.GetItemText(e.Index), control.Appearance.Font, control.Appearance.ForeColor, e.Bounds)
            e.Handled = True
        End Sub

        Private Sub listBoxControl1_MeasureItem(ByVal sender As Object, ByVal e As MeasureItemEventArgs) Handles listBoxControl1.MeasureItem
            Dim control As ListBoxControl = CType(sender, ListBoxControl)
            Dim text As String = control.GetItemText(e.Index)
            Dim textSize As Size = TextUtils.GetStringSize(e.Graphics, text, control.Appearance.Font, StringFormat.GenericDefault, control.ClientRectangle.Width)
            e.ItemHeight = textSize.Height + 5
        End Sub
    End Class
End Namespace
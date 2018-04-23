Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Text

Namespace S131055
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)

		End Sub

		Private Sub listBoxControl1_MeasureItem(ByVal sender As Object, ByVal e As MeasureItemEventArgs) Handles listBoxControl1.MeasureItem
			Dim control As ListBoxControl = CType(sender, ListBoxControl)
			Dim text As String = control.GetItemText(e.Index)
			Dim textSize As Size = TextUtils.GetStringSize(e.Graphics, text, control.Appearance.Font, StringFormat.GenericDefault, control.ClientRectangle.Width)
			e.ItemHeight = textSize.Height + 5
		End Sub

		Private Sub listBoxControl1_DrawItem(ByVal sender As Object, ByVal e As ListBoxDrawItemEventArgs) Handles listBoxControl1.DrawItem
			Dim control As ListBoxControl = CType(sender, ListBoxControl)
			e.Appearance.DrawBackground(e.Cache, e.Bounds)
			TextUtils.DrawString(e.Graphics, control.GetItemText(e.Index), control.Appearance.Font, control.Appearance.ForeColor, e.Bounds)
			e.Handled = True
		End Sub
	End Class
End Namespace
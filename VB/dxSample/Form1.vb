Imports dxSample.Data

Namespace dxSample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            regularTemplateListBox.ItemAutoHeight = True
            htmlTemplateListBox.ItemAutoHeight = True
            categoriesBindingSource.DataSource = GetCategories()
        End Sub
    End Class
End Namespace

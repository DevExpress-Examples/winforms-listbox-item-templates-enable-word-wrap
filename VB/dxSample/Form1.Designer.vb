Namespace dxSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim itemTemplateBase1 As DevExpress.XtraEditors.TableLayout.ItemTemplateBase = New DevExpress.XtraEditors.TableLayout.ItemTemplateBase()
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim templatedItemElement1 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim templatedItemElement2 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dxSample.Form1))
            Me.regularTemplateListBox = New DevExpress.XtraEditors.ListBoxControl()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
            Me.htmlTemplateListBox = New DevExpress.XtraEditors.ListBoxControl()
            Me.htmlTemplate1 = New DevExpress.Utils.Html.HtmlTemplate()
            Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType((Me.regularTemplateListBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl2.SuspendLayout()
            CType((Me.htmlTemplateListBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.categoriesBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' regularTemplateListBox
            ' 
            Me.regularTemplateListBox.DataSource = Me.categoriesBindingSource
            Me.regularTemplateListBox.DisplayMember = "Description"
            Me.regularTemplateListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.regularTemplateListBox.ItemHeight = 100
            Me.regularTemplateListBox.Location = New System.Drawing.Point(2, 23)
            Me.regularTemplateListBox.Name = "regularTemplateListBox"
            Me.regularTemplateListBox.Size = New System.Drawing.Size(256, 543)
            Me.regularTemplateListBox.TabIndex = 0
            itemTemplateBase1.Columns.Add(tableColumnDefinition1)
            templatedItemElement1.FieldName = "Description"
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            templatedItemElement1.RowIndex = 1
            templatedItemElement1.Text = "Description"
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            templatedItemElement2.Appearance.Normal.FontSizeDelta = 4
            templatedItemElement2.Appearance.Normal.Options.UseFont = True
            templatedItemElement2.FieldName = "Name"
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            templatedItemElement2.Text = "Name"
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            itemTemplateBase1.Elements.Add(templatedItemElement1)
            itemTemplateBase1.Elements.Add(templatedItemElement2)
            itemTemplateBase1.Name = "Main"
            tableRowDefinition1.Length.Value = 30R
            tableRowDefinition2.AutoHeight = True
            tableRowDefinition2.Length.Value = 60R
            itemTemplateBase1.Rows.Add(tableRowDefinition1)
            itemTemplateBase1.Rows.Add(tableRowDefinition2)
            Me.regularTemplateListBox.Templates.Add(itemTemplateBase1)
            Me.regularTemplateListBox.ValueMember = "CategoryID"
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Controls.Add(Me.regularTemplateListBox)
            Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.groupControl1.Location = New System.Drawing.Point(0, 0)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(260, 568)
            Me.groupControl1.TabIndex = 2
            Me.groupControl1.Text = "Regular Template"
            ' 
            ' groupControl2
            ' 
            Me.groupControl2.Controls.Add(Me.htmlTemplateListBox)
            Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Right
            Me.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.groupControl2.Location = New System.Drawing.Point(404, 0)
            Me.groupControl2.Name = "groupControl2"
            Me.groupControl2.Size = New System.Drawing.Size(260, 568)
            Me.groupControl2.TabIndex = 3
            Me.groupControl2.Text = "HTML-CSS Template"
            ' 
            ' htmlTemplateListBox
            ' 
            Me.htmlTemplateListBox.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlTemplateListBox.DataSource = Me.categoriesBindingSource
            Me.htmlTemplateListBox.DisplayMember = "Description"
            Me.htmlTemplateListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmlTemplateListBox.HtmlTemplates.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.htmlTemplate1})
            Me.htmlTemplateListBox.ItemAutoHeight = True
            Me.htmlTemplateListBox.Location = New System.Drawing.Point(2, 23)
            Me.htmlTemplateListBox.Name = "htmlTemplateListBox"
            Me.htmlTemplateListBox.Size = New System.Drawing.Size(256, 543)
            Me.htmlTemplateListBox.TabIndex = 0
            Me.htmlTemplateListBox.ValueMember = "CategoryID"
            ' 
            ' htmlTemplate1
            ' 
            Me.htmlTemplate1.Name = "htmlTemplate1"
            Me.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles")
            Me.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template")
            ' 
            ' categoriesBindingSource
            ' 
            Me.categoriesBindingSource.DataSource = GetType(dxSample.Data.Category)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(664, 568)
            Me.Controls.Add(Me.groupControl2)
            Me.Controls.Add(Me.groupControl1)
            Me.MinimumSize = New System.Drawing.Size(600, 400)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.regularTemplateListBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl2.ResumeLayout(False)
            CType((Me.htmlTemplateListBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.categoriesBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private regularTemplateListBox As DevExpress.XtraEditors.ListBoxControl

        Private categoriesBindingSource As System.Windows.Forms.BindingSource

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private groupControl2 As DevExpress.XtraEditors.GroupControl

        Private htmlTemplateListBox As DevExpress.XtraEditors.ListBoxControl

        Private htmlTemplate1 As DevExpress.Utils.Html.HtmlTemplate
    End Class
End Namespace

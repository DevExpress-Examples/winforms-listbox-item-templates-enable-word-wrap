Imports Microsoft.VisualBasic
Imports System
Namespace S131055
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
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
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.DataSource = Me.categoriesBindingSource
            Me.listBoxControl1.DisplayMember = "Description"
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControl1.Location = New System.Drawing.Point(0, 0)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(161, 273)
            Me.listBoxControl1.TabIndex = 0
            Me.listBoxControl1.ValueMember = "CategoryID"
            ' 
            ' categoriesBindingSource
            ' 
            Me.categoriesBindingSource.DataMember = "Categories"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(161, 273)
            Me.Controls.Add(Me.listBoxControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            '			Me.Load += New System.EventHandler(Me.Form1_Load);
            CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
        Private categoriesBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace


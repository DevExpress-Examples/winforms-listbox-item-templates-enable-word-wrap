namespace dxSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.regularTemplateListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.htmlTemplateListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.regularTemplateListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlTemplateListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // regularTemplateListBox
            // 
            this.regularTemplateListBox.DataSource = this.categoriesBindingSource;
            this.regularTemplateListBox.DisplayMember = "Description";
            this.regularTemplateListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regularTemplateListBox.ItemHeight = 100;
            this.regularTemplateListBox.Location = new System.Drawing.Point(2, 23);
            this.regularTemplateListBox.Name = "regularTemplateListBox";
            this.regularTemplateListBox.Size = new System.Drawing.Size(256, 543);
            this.regularTemplateListBox.TabIndex = 0;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            templatedItemElement1.FieldName = "Description";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.RowIndex = 1;
            templatedItemElement1.Text = "Description";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            templatedItemElement2.Appearance.Normal.FontSizeDelta = 4;
            templatedItemElement2.Appearance.Normal.Options.UseFont = true;
            templatedItemElement2.FieldName = "Name";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Text = "Name";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Name = "Main";
            tableRowDefinition1.Length.Value = 30D;
            tableRowDefinition2.AutoHeight = true;
            tableRowDefinition2.Length.Value = 60D;
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            itemTemplateBase1.Rows.Add(tableRowDefinition2);
            this.regularTemplateListBox.Templates.Add(itemTemplateBase1);
            this.regularTemplateListBox.ValueMember = "CategoryID";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.regularTemplateListBox);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(260, 568);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Regular Template";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.htmlTemplateListBox);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(404, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(260, 568);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "HTML-CSS Template";
            // 
            // htmlTemplateListBox
            // 
            this.htmlTemplateListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlTemplateListBox.DataSource = this.categoriesBindingSource;
            this.htmlTemplateListBox.DisplayMember = "Description";
            this.htmlTemplateListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTemplateListBox.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.htmlTemplate1});
            this.htmlTemplateListBox.ItemAutoHeight = true;
            this.htmlTemplateListBox.Location = new System.Drawing.Point(2, 23);
            this.htmlTemplateListBox.Name = "htmlTemplateListBox";
            this.htmlTemplateListBox.Size = new System.Drawing.Size(256, 543);
            this.htmlTemplateListBox.TabIndex = 0;
            this.htmlTemplateListBox.ValueMember = "CategoryID";
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            this.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles");
            this.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template");
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(dxSample.Data.Category);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 568);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.regularTemplateListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmlTemplateListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl regularTemplateListBox;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ListBoxControl htmlTemplateListBox;
        private DevExpress.Utils.Html.HtmlTemplate htmlTemplate1;
    }
}


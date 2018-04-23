using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Text;

namespace S131055 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);

        }

        private void listBoxControl1_MeasureItem(object sender, MeasureItemEventArgs e) {
            ListBoxControl control = (ListBoxControl)sender;
            string text = control.GetItemText(e.Index);
            Size textSize = TextUtils.GetStringSize(e.Graphics, text, control.Appearance.Font,
                StringFormat.GenericDefault, control.ClientRectangle.Width);
            e.ItemHeight = textSize.Height + 5;
        }

        private void listBoxControl1_DrawItem(object sender, ListBoxDrawItemEventArgs e) {
            ListBoxControl control = (ListBoxControl)sender;
            e.Appearance.DrawBackground(e.Cache, e.Bounds);
            TextUtils.DrawString(e.Graphics, control.GetItemText(e.Index), control.Appearance.Font,
                control.Appearance.ForeColor, e.Bounds);
            e.Handled = true;
        }
    }
}
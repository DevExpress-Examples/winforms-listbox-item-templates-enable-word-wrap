using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace S131055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            categoriesBindingSource.DataSource = GetCategoriesDataTable();
        }

        DataTable GetCategoriesDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Categories";
            table.Columns.Add(new DataColumn("CategoryID", typeof(int)));
            table.Columns.Add(new DataColumn("Description", typeof(string)));
            Random random = new Random();
            string[] PossibleItems = new string[] { "Tea", "Coffee", "Butter", "Lemon", "Apple", "Orange", "Milk", "Chocolate" };
            for(int i = 0; i < 20; i++)
            {
                int index = i + 1;
                string items = string.Empty;
                for(int j = 0; j < random.Next(3, 14); j++)
                    items += PossibleItems[random.Next(0, 8)] + " ";
                table.Rows.Add(index, items);
            }
            return table;
        }

        private void listBoxControl1_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            ListBoxControl control = (ListBoxControl)sender;
            e.Appearance.DrawBackground(e.Cache, e.Bounds);
            TextUtils.DrawString(e.Graphics, control.GetItemText(e.Index), control.Appearance.Font,
                control.Appearance.ForeColor, e.Bounds);
            e.Handled = true;
        }

        private void listBoxControl1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBoxControl control = (ListBoxControl)sender;
            string text = control.GetItemText(e.Index);
            Size textSize = TextUtils.GetStringSize(e.Graphics, text, control.Appearance.Font,
                StringFormat.GenericDefault, control.ClientRectangle.Width);
            e.ItemHeight = textSize.Height + 5;
        }
    }
}
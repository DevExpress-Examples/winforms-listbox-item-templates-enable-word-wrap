using dxSample.Data;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {

        public Form1() {
            InitializeComponent();
            regularTemplateListBox.ItemAutoHeight = true;
            htmlTemplateListBox.ItemAutoHeight = true;

            categoriesBindingSource.DataSource = CategoryData.GetCategories();
        }   
    }
}
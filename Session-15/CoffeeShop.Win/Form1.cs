using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using DevExpress.XtraEditors;

namespace CoffeeShop.Win {
    public partial class Form1 : XtraForm {
        private IEntityRepo<ProductCategory> _productCatsRepo;

        private List<ProductCategory> _productsCats = new List<ProductCategory>();

        public Form1(IEntityRepo<ProductCategory> productRepo) {
            InitializeComponent();
            _productCatsRepo = productRepo;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Text = "Product Categories";
            RefreshList();
        }
        private void RefreshList() {
            _productsCats = _productCatsRepo.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _productsCats;

            dataGridView1.Refresh();
            dataGridView1.Update();

        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            addNewProductCategory();
        }
        private void addNewProductCategory() {
            var newProd = new ProductCategory() {
                Code = textEdit1.Text,
                Description = textEdit2.Text,
                ProductType = ProductType.Food
            };
            _productCatsRepo.Create(newProd);
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedProductCat = selectedRow.DataBoundItem as ProductCategory;
                if (selectedProductCat is not null) {
                    selectedProductCat.ProductType = ProductType.Beverages;
                    _productCatsRepo.Update(selectedProductCat.ID, selectedProductCat);
                    RefreshList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedProductCat = selectedRow.DataBoundItem as ProductCategory;
                if (selectedProductCat is not null) {
                    
                    _productCatsRepo.Delete(selectedProductCat.ID);
                    RefreshList();
                }
            }
        }
    }
}
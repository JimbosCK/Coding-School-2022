using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;

namespace CoffeeShop.Win {
    public partial class Form1 : Form {
        private IEntityRepo<ProductCategory> _productCatsRepo;

        private List<ProductCategory> _productsCats = new List<ProductCategory>();

        public Form1(IEntityRepo<ProductCategory> productRepo) {
            InitializeComponent();
            _productCatsRepo = productRepo;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Text = "Product Categories";
            RefreshProducts();
        }
        private void RefreshProducts() {
            _productsCats = _productCatsRepo.GetAll();
            gridControl1.DataSource = null;
            gridControl1.DataSource = _productsCats;
            
            //dataGridView1.DataSource = _products;
            gridControl1.Refresh();
            gridControl1.Update();
            //dataGridView1.Refresh();
            //dataGridView1.Update();
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
            RefreshProducts();
        }
    }
}
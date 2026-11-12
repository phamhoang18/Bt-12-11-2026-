using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ProductList
{
    public partial class frmProducts : Form
    {
        private readonly List<Product> products = new List<Product>();
        private readonly BindingSource bsProducts = new BindingSource();
        private string currentKeyword = "";
        private Product selectedProduct = null;
        public frmProducts()
        {
            InitializeComponent();
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            InitGrid();
            dgvProducts.DataSource = bsProducts;

            products.Add(new Product { ProductId = "SP001", ProductName = "Tai nghe Bluetooth", UnitPrice = 450000, Quantity = 25, Category = "Điện tử" });
            products.Add(new Product { ProductId = "SP002", ProductName = "Nồi cơm điện 1.8L", UnitPrice = 890000, Quantity = 12, Category = "Gia dụng" });
            products.Add(new Product { ProductId = "SP003", ProductName = "Bánh quy bơ", UnitPrice = 35000, Quantity = 200, Category = "Thực phẩm" });
            products.Add(new Product { ProductId = "SP004", ProductName = "Áo thun nam", UnitPrice = 150000, Quantity = 60, Category = "Thời trang" });

            RefreshGrid();
            ClearInputs();
        }

        private void InitGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã SP", DataPropertyName = "ProductId", FillWeight = 12 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên sản phẩm", DataPropertyName = "ProductName", FillWeight = 34 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Đơn giá",
                DataPropertyName = "UnitPrice",
                FillWeight = 18,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Số lượng",
                DataPropertyName = "Quantity",
                FillWeight = 12,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Danh mục", DataPropertyName = "Category", FillWeight = 24 });
        }

        private void RefreshGrid()
        {
            List<Product> shown = products;

            if (!string.IsNullOrWhiteSpace(currentKeyword))
            {
                shown = products
                    .Where(p => p.ProductName.IndexOf(currentKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }

            bsProducts.DataSource = shown;
            bsProducts.ResetBindings(false);                     
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;                        

            Product p = dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
            if (p == null) return;

            selectedProduct = p;
            txtProductId.Text = p.ProductId;
            txtProductName.Text = p.ProductName;
            txtUnitPrice.Text = p.UnitPrice.ToString();
            numQuantity.Value = p.Quantity;
            cboCategory.SelectedItem = p.Category;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(null, out decimal price)) return;

            Product p = new Product
            {
                ProductId = txtProductId.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                UnitPrice = price,
                Quantity = (int)numQuantity.Value,
                Category = cboCategory.Text
            };

            products.Add(p);                               
            RefreshGrid();                                      
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Hãy click chọn một dòng trong danh sách để sửa!", "Chưa chọn dòng",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput(selectedProduct, out decimal price)) return;

            selectedProduct.ProductId = txtProductId.Text.Trim();
            selectedProduct.ProductName = txtProductName.Text.Trim();
            selectedProduct.UnitPrice = price;
            selectedProduct.Quantity = (int)numQuantity.Value;
            selectedProduct.Category = cboCategory.Text;

            RefreshGrid();
            MessageBox.Show("Đã cập nhật sản phẩm.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Hãy click chọn một dòng cần xóa!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm \"" + selectedProduct.ProductName + "\"?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                products.Remove(selectedProduct);
                RefreshGrid();
                ClearInputs();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentKeyword = txtSearch.Text.Trim();            
            RefreshGrid();

            if (currentKeyword != "" && bsProducts.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào có tên chứa \"" + currentKeyword + "\".", "Kết quả tìm kiếm",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateInput(Product editing, out decimal price)
        {
            price = 0;

            string id = txtProductId.Text.Trim();
            if (id == "")
            {
                Warn("Mã sản phẩm không được để trống!", txtProductId);
                return false;
            }
            if (products.Any(x => x != editing && string.Equals(x.ProductId, id, StringComparison.OrdinalIgnoreCase)))
            {
                Warn("Mã sản phẩm \"" + id + "\" đã tồn tại!", txtProductId);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                Warn("Tên sản phẩm không được để trống!", txtProductName);
                return false;
            }
            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out price) || price < 0)
            {
                Warn("Đơn giá phải là số không âm hoặc không để trống!", txtUnitPrice);
                return false;
            }
            if (cboCategory.SelectedIndex < 0)
            {
                Warn("Vui lòng chọn danh mục!", cboCategory);
                return false;
            }
            return true;
        }

        private void Warn(string message, Control control)
        {
            MessageBox.Show(message, "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private void ClearInputs()
        {
            selectedProduct = null;

            int n = 1;
            while (products.Any(x => x.ProductId == "SP" + n.ToString("000")))
                n++;
            txtProductId.Text = "SP" + n.ToString("000");    

            txtProductName.Clear();
            txtUnitPrice.Clear();
            numQuantity.Value = 0;
            cboCategory.SelectedIndex = -1;
            dgvProducts.ClearSelection();
            txtProductName.Focus();
        }
    }
    public class Product
    {
        public string ProductId { get; set; } = "";
        public string ProductName { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; } = "";
    }
}

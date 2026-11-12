using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace LISTBOX___COMBOBOX
{
    public class Service
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            return Name + "  -  " + Price.ToString("N0") + " đ";
        }
    }

    public partial class frmBilling : Form
    {
        private readonly List<Service> catalog = new List<Service>
        {
            new Service { Category = "Khám bệnh",    Name = "Khám tổng quát",        Price = 150000 },
            new Service { Category = "Khám bệnh",    Name = "Khám nội",              Price = 200000 },
            new Service { Category = "Khám bệnh",    Name = "Khám tai mũi họng",     Price = 180000 },
            new Service { Category = "Khám bệnh",    Name = "Khám da liễu",          Price = 220000 },

            new Service { Category = "Xét nghiệm",   Name = "Xét nghiệm máu",        Price = 250000 },
            new Service { Category = "Xét nghiệm",   Name = "Xét nghiệm nước tiểu",  Price = 120000 },
            new Service { Category = "Xét nghiệm",   Name = "Đo đường huyết",        Price = 80000 },
            new Service { Category = "Xét nghiệm",   Name = "Chức năng gan",         Price = 300000 },

            new Service { Category = "Chụp X-Quang", Name = "X-Quang phổi",          Price = 200000 },
            new Service { Category = "Chụp X-Quang", Name = "X-Quang cột sống",      Price = 280000 },
            new Service { Category = "Chụp X-Quang", Name = "X-Quang xương khớp",    Price = 220000 },

            new Service { Category = "Vắc-xin",      Name = "Cúm mùa",               Price = 350000 },
            new Service { Category = "Vắc-xin",      Name = "Viêm gan B",            Price = 280000 },
            new Service { Category = "Vắc-xin",      Name = "Uốn ván",               Price = 150000 },
            new Service { Category = "Vắc-xin",      Name = "HPV",                   Price = 1800000 }
        };

        public frmBilling()
        {
            InitializeComponent();
        }
        private void frmBilling_Load(object sender, EventArgs e)
        {
            cboCategory.SelectedIndex = 0;                       
            UpdateTotals();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailable();
        }

        private void LoadAvailable()
        {
            lstAvailableServices.BeginUpdate();                 
            lstAvailableServices.Items.Clear();

            foreach (Service s in catalog)
            {
                if (s.Category == cboCategory.Text && !lstSelectedServices.Items.Contains(s))
                    lstAvailableServices.Items.Add(s);
            }

            lstAvailableServices.EndUpdate();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MoveToSelected();
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            MoveToSelected();
        }

        private void MoveToSelected()
        {
            if (lstAvailableServices.SelectedItems.Count == 0) return;

            List<Service> picked = new List<Service>();
            foreach (Service s in lstAvailableServices.SelectedItems)
                picked.Add(s);

            foreach (Service s in picked)
            {
                lstAvailableServices.Items.Remove(s);
                lstSelectedServices.Items.Add(s);
            }

            UpdateTotals();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MoveBack();
        }

        private void lstSelectedServices_DoubleClick(object sender, EventArgs e)
        {
            MoveBack();
        }

        private void MoveBack()
        {
            if (lstSelectedServices.SelectedItems.Count == 0) return;

            List<Service> picked = new List<Service>();
            foreach (Service s in lstSelectedServices.SelectedItems)
                picked.Add(s);

            foreach (Service s in picked)
            {
                lstSelectedServices.Items.Remove(s);
                if (s.Category == cboCategory.Text)             
                    lstAvailableServices.Items.Add(s);
            }

            UpdateTotals();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            LoadAvailable();                                   
            UpdateTotals();
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            decimal subtotal = 0;
            foreach (Service s in lstSelectedServices.Items)
                subtotal += s.Price;

            decimal discountPercent = numDiscount.Value;                    
            decimal total = subtotal * (100 - discountPercent) / 100;      

            txtSubtotal.Text = subtotal.ToString("N0") + " đ";
            lblTotal.Text = total.ToString("N0") + " đ";
        }
    }
}

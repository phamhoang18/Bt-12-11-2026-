using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Departments
{
    public partial class Form1 : Form
    {
        private readonly List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }
        private void frmDepartments_Load(object sender, EventArgs e)
        {
            InitImages();                                      
            SeedEmployees();                               
            BuildTree();                                 

            cboView.SelectedIndex = 0;                        

            tvDepartments.ExpandAll();                        
            tvDepartments.SelectedNode = tvDepartments.Nodes[0];
        }

        private void InitImages()
        {
            AddIcon("company", SystemIcons.WinLogo);
            AddIcon("department", SystemIcons.Shield);
            AddIcon("group", SystemIcons.Application);
            AddIcon("employee", SystemIcons.Information);
        }

        private void AddIcon(string key, Icon icon)
        {
            imgSmall.Images.Add(key, new Icon(icon, 16, 16).ToBitmap());
            imgLarge.Images.Add(key, new Icon(icon, 32, 32).ToBitmap());
        }

        private void BuildTree()
        {
            TreeNode root = MakeNode("Công ty ABC", "company");

            TreeNode sales = MakeNode("Phòng Kinh doanh", "department");
            sales.Nodes.Add(MakeNode("Nhóm Bán hàng online", "group"));
            sales.Nodes.Add(MakeNode("Nhóm Khách hàng doanh nghiệp", "group"));

            TreeNode tech = MakeNode("Phòng Kỹ thuật", "department");
            tech.Nodes.Add(MakeNode("Nhóm Phát triển phần mềm", "group"));
            tech.Nodes.Add(MakeNode("Nhóm Hạ tầng - Mạng", "group"));

            TreeNode hr = MakeNode("Phòng Nhân sự", "department");
            hr.Nodes.Add(MakeNode("Nhóm Tuyển dụng", "group"));
            hr.Nodes.Add(MakeNode("Nhóm Đào tạo", "group"));

            root.Nodes.Add(sales);
            root.Nodes.Add(tech);
            root.Nodes.Add(hr);

            tvDepartments.Nodes.Add(root);
        }

        private TreeNode MakeNode(string text, string imageKey)
        {
            TreeNode node = new TreeNode(text);
            node.ImageKey = imageKey;
            node.SelectedImageKey = imageKey;
            return node;
        }

        private void SeedEmployees()
        {
            Add("NV001", "Nguyễn Văn An", "Trưởng nhóm", new DateTime(2019, 3, 15), "Phòng Kinh doanh", "Nhóm Bán hàng online");
            Add("NV002", "Trần Thị Bình", "Nhân viên", new DateTime(2021, 7, 1), "Phòng Kinh doanh", "Nhóm Bán hàng online");
            Add("NV003", "Lê Hoàng Cường", "Nhân viên", new DateTime(2022, 1, 10), "Phòng Kinh doanh", "Nhóm Bán hàng online");
            Add("NV004", "Phạm Thu Dung", "Trưởng nhóm", new DateTime(2018, 11, 20), "Phòng Kinh doanh", "Nhóm Khách hàng doanh nghiệp");
            Add("NV005", "Võ Minh Đức", "Nhân viên", new DateTime(2022, 5, 2), "Phòng Kinh doanh", "Nhóm Khách hàng doanh nghiệp");

            Add("NV006", "Hoàng Gia Huy", "Trưởng nhóm", new DateTime(2017, 9, 5), "Phòng Kỹ thuật", "Nhóm Phát triển phần mềm");
            Add("NV007", "Đỗ Thanh Hà", "Lập trình viên", new DateTime(2020, 2, 17), "Phòng Kỹ thuật", "Nhóm Phát triển phần mềm");
            Add("NV008", "Bùi Quốc Khánh", "Lập trình viên", new DateTime(2023, 3, 6), "Phòng Kỹ thuật", "Nhóm Phát triển phần mềm");
            Add("NV009", "Ngô Văn Lâm", "Kỹ sư mạng", new DateTime(2019, 8, 12), "Phòng Kỹ thuật", "Nhóm Hạ tầng - Mạng");
            Add("NV010", "Đặng Mỹ Linh", "Kỹ sư hệ thống", new DateTime(2021, 10, 25), "Phòng Kỹ thuật", "Nhóm Hạ tầng - Mạng");

            Add("NV011", "Lý Thị Mai", "Chuyên viên", new DateTime(2020, 6, 8), "Phòng Nhân sự", "Nhóm Tuyển dụng");
            Add("NV012", "Trương Bảo Ngọc", "Chuyên viên", new DateTime(2022, 9, 19), "Phòng Nhân sự", "Nhóm Đào tạo");
        }

        private void Add(string id, string name, string position, DateTime start, string department, string group)
        {
            employees.Add(new Employee
            {
                Id = id,
                FullName = name,
                Position = position,
                StartDate = start,
                Department = department,
                Group = group
            });
        }

        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadEmployees(e.Node);
        }

        private void LoadEmployees(TreeNode node)
        {
            IEnumerable<Employee> list;
            if (node.Level == 0)
                list = employees;
            else if (node.Level == 1)
                list = employees.Where(x => x.Department == node.Text);
            else
                list = employees.Where(x => x.Group == node.Text);

            lsvEmployees.BeginUpdate();                        
            lsvEmployees.Items.Clear();

            int count = 0;
            foreach (Employee emp in list)
            {
                ListViewItem item = new ListViewItem(emp.Id, "employee");
                item.SubItems.Add(emp.FullName);                 
                item.SubItems.Add(emp.Position);                 
                item.SubItems.Add(emp.StartDate.ToString("dd/MM/yyyy")); 
                item.ToolTipText = emp.FullName + " - " + emp.Position;    
                lsvEmployees.Items.Add(item);
                count++;
            }

            lsvEmployees.EndUpdate();

            tslInfo.Text = "Đang xem: " + node.FullPath + "   |   " + count + " nhân viên";
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvEmployees.View = (View)Enum.Parse(typeof(View), cboView.Text);
        }
    }
    
    public class Employee
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public string Department { get; set; }
        public string Group { get; set; }
    }
}

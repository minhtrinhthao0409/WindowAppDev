using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaitapTuan5_TrinhThaoMinh
{
    public partial class Form1 : Form
    {
        List<Khoa> dsKhoa = new List<Khoa>();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            treeView1.AfterSelect += treeView1_AfterSelect;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Khoa cntt = new Khoa { TenKhoa = "Khoa CNTT Kinh doanh" };
            Lop lop1 = new Lop { TenLop = "Class 111-22-111" };
            lop1.DsSinhVien.Add(new SinhVien { ID = 105, HoTen = "Full name #5", Email = "email5@ueh.edu.vn" });
            lop1.DsSinhVien.Add(new SinhVien { ID = 106, HoTen = "Full name #6", Email = "email6@ueh.edu.vn" });
            cntt.DsLop.Add(lop1);

            Lop lop2 = new Lop { TenLop = "Class 111-22-222" };
            lop2.DsSinhVien.Add(new SinhVien { ID = 109, HoTen = "Full name #9", Email = "email9@ueh.edu.vn" });
            cntt.DsLop.Add(lop2);


            Khoa ketoan = new Khoa { TenKhoa = "Khoa Kế toán" };
            Lop lop3 = new Lop { TenLop = "Class 222-33-111" };
            lop3.DsSinhVien.Add(new SinhVien { ID = 107, HoTen = "Full name #7", Email = "email7@ueh.edu.vn" });
            ketoan.DsLop.Add(lop3);

            Khoa taiChinh = new Khoa { TenKhoa = "Khoa Tài chính - Ngân hàng" };
            Lop lop4 = new Lop { TenLop = "Class 333-44-111" };
            lop4.DsSinhVien.Add(new SinhVien { ID = 108, HoTen = "Full name #8", Email = "email8@ueh.edu.vn" });
            taiChinh.DsLop.Add(lop4);

            dsKhoa.Add(cntt);
            dsKhoa.Add(ketoan);
            dsKhoa.Add(taiChinh);

            LoadTreeView();
        }

        private void LoadTreeView()
        {
            treeView1.Nodes.Clear();
            foreach (Khoa khoa in dsKhoa)
            {
                TreeNode nodeKhoa = new TreeNode(khoa.TenKhoa);
                foreach (Lop lop in khoa.DsLop)
                {
                    TreeNode nodeLop = new TreeNode(lop.TenLop) { Tag = lop };
                    nodeKhoa.Nodes.Add(nodeLop);
                }
                treeView1.Nodes.Add(nodeKhoa);
            }
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Lop lop)
            {
                dataGridView1.DataSource = lop.DsSinhVien.Select(sv => new
                {
                    sv.ID,
                    sv.HoTen,
                    sv.Email
                }).ToList();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                lblId.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                lblName.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            }
        }
    }
}

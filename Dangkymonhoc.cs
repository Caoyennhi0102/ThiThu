using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiThu
{
    public partial class Dangkymonhoc : Form
    {
        public Dangkymonhoc()
        {
            InitializeComponent();
        }
        private void Dangkymonhoc_Load(object sender, EventArgs e)
        {


            combonienkhoa.Items.Add("2020");
            combonienkhoa.Items.Add("2021");
            combonienkhoa.Items.Add("2023");
            combonienkhoa.Items.Add("2024");
            combonienkhoa.Items.Add("2025");
            combonienkhoa.SelectedIndex = 0;

            comboBoxLop.Items.Add("Ứng Dụng Phần Mềm 1");
            comboBoxLop.Items.Add("Ứng Dụng Phần Mềm 2");
            comboBoxLop.Items.Add("Ứng Dụng Phần Mềm 3");
            comboBoxLop.Items.Add("Thiết Kế Đồ Họa 1");
            comboBoxLop.Items.Add("Thiết Kế Đồ Họa 2");
            comboBoxLop.Items.Add("Quản Trị Mạng 1");
            comboBoxLop.Items.Add("Quản Trị Mạng 2");

            comboBoxLop.SelectedIndex = 0;
            radio1.Checked = true;

            checkBoxLTWIN.Checked = true;
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            string info;
            info = "Mã Số Sinh Viên : " + txtMSSV.Text;
            info += "\nHọ Và Tên : " + txthovaten.Text;
            info += "\nNien Khóa : " + combonienkhoa.SelectedItem;
            info += "\nLop : " + comboBoxLop.SelectedItem;

            string hocky = "";
            if (radio1.Checked)
            {
                hocky = radio1.Text;
            }
            if (radio2.Checked)
            {
                hocky = radio2.Text;
            }
            if (radio3.Checked)
            {
                hocky = radio3.Text;

            }
            if (radio4.Checked)
            {
                hocky = radio4.Text;
            }
           info = "\n Học Kì: " + hocky.ToString();

            string monhoc = "";
            if (checkBoxLTWIN.Checked)
            {
                monhoc = checkBoxLTWIN.Text;
            }
            if (checkBoxMANGMAYTINH.Checked)
            {
                monhoc = checkBoxMANGMAYTINH.Text;
            }
            if (checkBoxLTINTERNET.Checked)
            {
                monhoc = checkBoxLTINTERNET.Text;
            }
            if (checkBoxUML.Checked)
            {
                monhoc = checkBoxUML.Text;
            }
            for(int i = 1; i <= monhoc.Length; i++)
            {
                info = monhoc;
            }

           


        }

        
    }
}

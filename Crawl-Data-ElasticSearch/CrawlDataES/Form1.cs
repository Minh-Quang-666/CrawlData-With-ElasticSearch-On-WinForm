using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlDataES
{
    public partial class Form1 : Form
    {
        // khởi tạo hàm xử lý 
        handleForm handle;

        public Form1()
        {
            InitializeComponent();
            handle = new handleForm(this);
        }
        // hàm crawl và lưu
        private void btnSave_Click(object sender, EventArgs e)
        {
            handle.Save();
        }
        // chuyển trang tiếp
        private void next_Click(object sender, EventArgs e)
        {
            handle.nextPage();
        }
        // trở về trang cũ
        private void prev_Click(object sender, EventArgs e)
        {
            handle.prevPage();
        }
        // Ấn Nút Tìm Kiếm
        private void btnfind_Click(object sender, EventArgs e)
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            string dateSeach;
            if (month.Length == 1)
            {
                dateSeach = year + "-0" + month + "-" + day + "T00:00:00+07:00";
            }
            else
            {
                dateSeach = year + "-" + month + "-" + day + "T00:00:00+07:00";
            }
            string textSearch = tbfind.Text;
            string status = cbStatus.Text;
            handle.SearchDocuMent(textSearch , dateSeach , status);
        }
        // Load lại dữ liệu lỗi và mới sau 5 phút
        private void LoadAgentData(object sender, EventArgs e)
        {
            timer1.Start();
            handle.LoadAgentData();
        }
    }
}

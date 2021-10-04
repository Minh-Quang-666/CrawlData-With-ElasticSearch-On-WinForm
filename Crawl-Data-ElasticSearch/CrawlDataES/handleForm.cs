using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlDataES
{
    public class handleForm
    {
        // lấy dữ liệu từ form1
        public Form1 form1;
        // list data để show lên
        public List<Data> listData = new List<Data>();
        // trang hiện tại
        public int pageNumber = 1;
        // số lượng dòng trong 1 trang
        public int numberRecord = 10;
        // khởi tạo kết nối với ES
        ConnectES connectionElastic;
        HttpClient http;
        public handleForm(Form1 form1)
        {
            this.form1 = form1;
            connectionElastic = new ConnectES();
            http = new HttpClient();
        }
        // Crawl Data từ 1 link
        string CrawlDatafromurl(string url)
        {
            string html = "";
            html = http.GetStringAsync(url).Result.ToString();
            return html;
        }
        // Xử Lý Crawl Data
        public async Task CrawlData(string url) 
        {
            Task get_data = new Task(
               () =>
               {
                   string data = "";
                   // xử lý data 
                   string title = "";
                   string content = "";
                   string status = "";
                   DateTime date = DateTime.Now.Date.AddDays(-1);
                   try
                   {
                       data = CrawlDatafromurl(url);
                       // xử lý data 
                       title = Regex.Match(data, "<title>(.|\n)*?</title>").ToString();
                       content = Regex.Match(data, @"<(\s)*body(\s)*(.|\n)*?>(.|\n)*?<\/(\s)*body(\s)*>").ToString();
                       status = "Thành Công";
                   }
                   catch(Exception)
                   {
                       status = "Lỗi";
                   }
                   finally
                   {
                       Data data_web = new Data(url, title, content, status, date);
                       var result = connectionElastic.InsertDocument(data_web);
                       if (!result.Result)
                       {
                           MessageBox.Show("Có lỗi xảy ra trong quá trình thêm mới !");
                           data_web.Status = "Lỗi";
                       }
                       // đưa lên kết quả mới nhât
                       listData.Insert(0, data_web);
                   }
               }
            );
            get_data.Start();
            await get_data;
            LoadDataGridView();
        }
        // lưu dữ liệu Vào ES
        public void Save()
        {
            listData.Clear();
            pageNumber = 1;
            form1.cbStatus.Text = "Tất Cả";
            string[] list_posts = form1.rtblistlink.Text.Split('\n');
            // Nếu như không nhập
            if (form1.rtblistlink.Text.Length == 0)
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập Link", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            else
            {
                foreach (var post in list_posts)
                {
                    CrawlData(post);
                }
            }
        }
        // Load Dữ Liệu Trong 1 trang hiện tại
        public List<Data> LoadRecore(int pageNumber, int recordNumber)
        {
            List<Data> result = new List<Data>();
            result = listData.Skip((pageNumber - 1) * recordNumber).Take(numberRecord).ToList();
            return result;
        }

        public void SearchDocuMent(string text, string date , string status)
        {
           if(status != "Tất Cả")
            {
                listData = connectionElastic.SearchDocument(text, date, status);
            } else
            {
                listData = connectionElastic.SearchDocument(text, date, "Thành Công").Concat(listData = connectionElastic.SearchDocument(text, date, "Lỗi")).ToList();
            }
            LoadDataGridView();
        }
        // Sau 5 Phút Thì Load Lịa dữ liệu lỗi và Mới
        public void LoadAgentData()
        {
              listData.Clear();
              pageNumber = 1;
              form1.cbStatus.Text = "Tất Cả";
              List<string> listLinkCralwAgent = connectionElastic.GetDocumentLoi();
              string[] list_posts = form1.rtblistlink.Text.Split('\n');
              foreach (var post in list_posts)
              {
                 listLinkCralwAgent.Add(post);
              }
              foreach (var post in listLinkCralwAgent)
              {
                 CrawlData(post);
              }
        }
        // Load lại dữ liệu hiển thị
        public void LoadDataGridView()
        {
            BindingSource source = new BindingSource();
            source.DataSource = LoadRecore(pageNumber , numberRecord);
            form1.dgvCrawldata.DataSource = source;
            form1.page.Text = pageNumber.ToString();
        }
        // chuyển trang tiếp
        public void nextPage()
        {
            if(pageNumber - 1 < listData.Count / numberRecord)
            {
                pageNumber++;
                LoadDataGridView();
            }
        }
        // Trở về Trang Cũ
        public void prevPage()
        {
            if (pageNumber - 1 > 0)
            {
                pageNumber--;
                LoadDataGridView();
            }
        }
    }
}

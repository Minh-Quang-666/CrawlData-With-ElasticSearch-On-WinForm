using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlDataES
{
    public class Data
    {
        private string url;
        private string title;
        private string content;
        private string status;
        private DateTime datetime;
 
        public Data () { 
        }
        public Data(string url, string title , string content ,string status, DateTime datetime)
        {
            this.url = url;
            this.title = title;
            this.content = content;
            this.status = status;
            this.datetime = datetime;
        }

        public string Url { get => url; set => url = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Datetime { get => datetime; set => datetime = value; }
    }
}

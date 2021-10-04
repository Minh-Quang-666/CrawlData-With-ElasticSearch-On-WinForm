using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlDataES
{
    public class ConnectES
    {
        string index_name = "crawl_data";

        // kết nối đến elastic
        ElasticClient elasticClient;

        public ConnectES()
        {
            // kết nối đến elasticsearch
            var settings = new ConnectionSettings().DefaultMappingFor<Data>(x => x.IndexName(index_name));
            elasticClient = new ElasticClient(settings);
        }
        // Hàm Thêm 1 doccument vào trong ElasticSearch
        public async Task<bool> InsertDocument(Data data)
        {
            var isInsertValid = await elasticClient.IndexDocumentAsync(data);

            return isInsertValid.IsValid;
        }
        // lấy dữ liệu từ ES theo trạng thái

        public List<Data> SearchDocument(string text, string date, string slectedStatus)
        {
            List<Data> listDocument = new List<Data>();

            var listResult = elasticClient.Search<Data>(s => s
            .Query(q => q
                .Bool(b => b
                    .Must(
                        m => m.MultiMatch(mm => mm
                            .Query(text)
                            .Fields(fs => fs
                            .Field(f => f.Url)
                            .Field(f => f.Title)
                            .Field(f => f.Content)
                        )
                        .Type(TextQueryType.Phrase)
                        .Slop(3)
                    ),
                    m => m.DateRange(dr => dr
                        .Field(f => f.Datetime)
                        .GreaterThanOrEquals(date)
                        .LessThanOrEquals(date)
                    ),
                    m => m.QueryString(qs => qs
                        .Query(slectedStatus)
                        .Fields(fs => fs
                            .Field(f => f.Status)
                        )
                    )
                )
            )
          )
    );
            var listSourceResult = listResult.Hits.ToList();
            foreach (var itemSource in listSourceResult)
            {
                Data itemData = itemSource.Source;
                listDocument.Add(itemData);
            }
            return listDocument;
            /*
            */
        }
        // lấy ra các document Lỗi
        public List<string> GetDocumentLoi()
        {
            List<string> listDocument = new List<string>();
            var listResult = elasticClient.Search<Data>(s => s
                .Query(q => q
                    .QueryString(qs => qs
                        .Query("Lỗi")
                        .Fields(fs => fs
                            .Field(f => f.Status) 
                        )
                    )
                  )
                .Source(sc => sc
                    .Includes(i => i
                        .Fields(
                            fs => fs.Url
                        )
                    )
                )
            );
            var listSourceResult = listResult.Hits.ToList();
            foreach (var itemSource in listSourceResult)
            {
                listDocument.Add(itemSource.Source.Url.ToString());
            }
            return listDocument;
        }
        /*
       // lấy dữ liệu từ ES theo ngày
       public List<Data> SearchDocumentFromDate(string date)
       {
           DateTime dateTime = DateTime.Now;
           List<Data> listDocument = new List<Data>();
           var listResult = elasticClient.Search<Data>(s => s
               .Query(q => q
                   .DateRange(dr => dr
                       .Field(f => f.Datetime)
                       .GreaterThanOrEquals(date)
                       .LessThanOrEquals(date)
                   )
                )
               .Size(2500)
           );
           var listSourceResult = listResult.Hits.ToList();
           foreach (var itemSource in listSourceResult)
           {
               Data itemData = itemSource.Source;
               listDocument.Add(itemData);
           }
           return listDocument;
       }
       /*
       public List<Data> SearchDocumentFromText(string text )
       {
           List<Data> listDocument = new List<Data>();
           var listResult = elasticClient.Search<Data>(s => s
               .Query(q => q 
                   .MultiMatch(mm => mm
                       .Query(text)
                       .Fields(fs => fs
                           .Field(f => f.Url) 
                           .Field(f => f.Title) 
                           .Field(f => f.Content)
                       )
                       .Type(TextQueryType.Phrase) 
                       .Slop(3)
                     )
                 )
           );

           var listSourceResult = listResult.Hits.ToList();
           foreach (var itemSource in listSourceResult)
           {
               Data itemData = itemSource.Source;
               listDocument.Add(itemData);
           }
           return listDocument;
       }
       */
    }
}

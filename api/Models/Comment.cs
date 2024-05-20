using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace api.Models
{
    public class Comment
    {

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;


        // navigation property
        public int? StockID { get; set; } // this is the key. by convention -> entitiy framework .net core will search code and connect link for us


        public Stock? Stock { get; set; }



    }
}
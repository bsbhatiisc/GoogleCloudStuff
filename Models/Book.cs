using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAppGCP.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Stream { get; set; }
        public string Location { get; set; }
    }
}
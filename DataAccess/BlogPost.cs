using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloginSystem.DataAccess
{
    public class BlogPost : BaseEntity
    {
        public string Title { get; set; }
        public string Authorname { get; set; }
        public DateTime CreatedAt { get; set; }
        public string BlogBody { get; set; }
    }
}

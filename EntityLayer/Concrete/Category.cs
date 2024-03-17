using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID {  get; set; }

        public string CategoryName { get; set; }

        public ICollection<Blog> Blogs { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comments
    {
        public int CommentID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string CommentText { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blogs { get; set; }
    }
}

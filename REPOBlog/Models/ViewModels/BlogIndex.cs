using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPOBlog.Models.BaseModels;

namespace REPOBlog.Models.ViewModels
{
    public class BlogIndex
    {
        public Post Post { get; set; }
        public List<Billede> Billede { get; set; }
    }
}

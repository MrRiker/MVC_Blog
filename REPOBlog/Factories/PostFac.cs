using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPOBlog.Models.BaseModels;
using REPOBlog.Models.ViewModels;

namespace REPOBlog
{
    public class PostFac : AutoFac<Post>
    {
        BilledeFac billedeFac = new BilledeFac();

        public List<BlogIndex> GetIndexData()
        {
            List<BlogIndex> listBlogindex = new List<BlogIndex>();
            foreach (var post in GetAll())
            {
                BlogIndex blogIndex = new BlogIndex();
                blogIndex.Post = post;
                blogIndex.Billede = billedeFac.GetBy("PostID", post.ID);
                listBlogindex.Add(blogIndex);
            }
            return listBlogindex;
        } 
    }
}

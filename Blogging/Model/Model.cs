using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogging.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public string URL { get; set; }

        //Rename _children to _posts and the model can be built.
        private List<Post> _children = new();
        public IReadOnlyCollection<Post> Posts => _children;

    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }

        public Blog Blog { get; set; }
    }
}

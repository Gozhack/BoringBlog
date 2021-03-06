using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaBoringBlog.Models
{
    [PostType(Title = "Blog post")]
    public class BlogPost  : Post<BlogPost>
    {
        /// <summary>
        /// Gets/sets the post heading.
        /// </summary>
        [Region]
        public Regions.Heading Heading { get; set; }
    }
}
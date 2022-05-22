using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ThumbNailImage { get; set; }

        public string Image { get; set; }

        public DateTime CreationDate { get; set; }

        public bool Status { get; set; }

        public int CategoryId { get; set; }


        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }

        public int WriterId { get; set; }


        [ForeignKey(nameof(WriterId))]
        public virtual Writer Writer { get; set; }


        public List<Comment> Comments { get; set; }

    }
}

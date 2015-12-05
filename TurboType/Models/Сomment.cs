using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TurboType.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        
        public string AuthorID { get; set; }
        
        public string Capation { get; set; }
        
        public string Content { get; set; }


        public virtual ICollection<Like> Likes { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}
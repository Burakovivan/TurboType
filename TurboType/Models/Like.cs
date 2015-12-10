using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurboType.Models
{
    public class Like
    {
        public long LikeId { get; set; }
        public int CommentId { get; set; }
        public bool isPositive { get; set; }
        public string UserId { get; set; }


        public virtual ApplicationUser User { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
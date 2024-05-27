using System.ComponentModel.DataAnnotations.Schema;

namespace KhumaloCraft.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual ICollection<OrderRequest> OrderRequests { get; set; } = new List<OrderRequest>();

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}

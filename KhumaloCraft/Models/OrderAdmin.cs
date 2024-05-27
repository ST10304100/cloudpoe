namespace KhumaloCraft.Models
{
    public class OrderAdmin
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserEmail { get; set; }
        public string? Status { get; set; }
    }
}

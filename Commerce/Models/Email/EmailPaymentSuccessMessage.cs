using Stripe;

namespace Commerce.Models.Email
{
    public class EmailPaymentSuccessMessage
    {
        public string? CustomerEmail { get; set; }
        public long? AmountTotal { get; set; }
        public Address CustomerAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public List<LineItem> LineItems { get; set; }
    }
}

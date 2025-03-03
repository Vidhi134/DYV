namespace DYV.Models
{
    public class CheckoutViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string PaymentMethod { get; set; }
        public decimal CartTotal { get; set; }
    }
}

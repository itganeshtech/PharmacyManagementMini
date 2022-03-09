namespace PharmacyManagementMini.Models
{
    public class CartItem
    {
        public string MediId { get; set; }
        public string MediName { get; set; }
        public string ExpireDate { get; set; }
        public string PricePerUnit { get; set; }
        public string NoOfUnits { get; set; }
        public string TotalPrice { get; set; }
    }
}

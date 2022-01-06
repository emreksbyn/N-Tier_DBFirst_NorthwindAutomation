namespace Northwind_BusinessLayer.Common
{
    public class SupplierResponseModel
    {
        public int EffectiveCount { get; set; }
        public object Suppliers { get; set; }
        public bool IsValid { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}

namespace Northwind_BusinessLayer.Common
{
    public class CustomerResponseModel
    {
        public int EffectiveCount { get; set; }
        public object Customers { get; set; }
        public bool IsValid { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}

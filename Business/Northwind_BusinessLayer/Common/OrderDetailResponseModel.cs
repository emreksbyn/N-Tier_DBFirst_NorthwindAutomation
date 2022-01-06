namespace Northwind_BusinessLayer.Common
{
    public class OrderDetailResponseModel
    {
        public int EffectiveCount { get; set; }
        public object OrderDetails { get; set; }
        public bool IsValid { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}

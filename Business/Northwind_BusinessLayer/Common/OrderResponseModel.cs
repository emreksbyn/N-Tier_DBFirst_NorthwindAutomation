namespace Northwind_BusinessLayer.Common
{
    public class OrderResponseModel
    {
        public int EffectiveCount { get; set; }
        public object Orders { get; set; }
        public bool IsValid { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}

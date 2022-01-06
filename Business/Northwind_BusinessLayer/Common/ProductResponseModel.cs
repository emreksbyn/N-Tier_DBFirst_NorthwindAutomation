namespace Northwind_BusinessLayer.Common
{
    public class ProductResponseModel
    {
        public int EffectiveCount { get; set; }
        public object Products { get; set; }
        public bool IsValid { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}

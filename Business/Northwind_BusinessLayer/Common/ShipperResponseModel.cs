namespace Northwind_BusinessLayer.Common
{
    public class ShipperResponseModel
    {
        public int EffectiveCount { get; set; }
        public object Shippers { get; set; }
        public bool IsValid { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}

namespace Northwind_BusinessLayer.Common
{
    public class CategoryResponseModel
    {
        public int EffectiveCount { get; set; }
        public object Categories { get; set; }
        public bool IsValid { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}

namespace IWantApp.Domain.Products
{
    public class Product : Entity
    {
        public int Code { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public int MyProperty { get; set; }
    }
}

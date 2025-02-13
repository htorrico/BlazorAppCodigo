namespace BlazorAppCodigo.Models
{
    public class ProductData
    {
        public int year { get; set; }
        public double price { get; set; }
        public string CPU_model { get; set; }
        public string Hard_disk_size { get; set; }
    }

    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public ProductData data { get; set; } = new ProductData();
    }
}

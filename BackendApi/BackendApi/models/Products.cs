namespace BackendApi.models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Boolean IsAvailable { get; set; }
        public DateTime DateTime { get; set; }

        public string ImageUrl { get; set; }

    }
}

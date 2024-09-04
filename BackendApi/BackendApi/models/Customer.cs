namespace BackendApi.models
{
    public class Customer
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public Boolean IsAdmin { get; set; }

        public string phone { get; set; }
        public string city { get; set; }
            
        public string state { get; set; }
        public string zipcode { get; set; }
    }
}

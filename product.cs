namespace ams_heranca_repository{
class Product{
        public string Name { get; set; }
        public string Price { get; set; }

        public Product(string name, string price)
        {
            Name = name;
            Price = price;
        }
    }
}
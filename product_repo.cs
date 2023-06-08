namespace ams_heranca_repository{
class ProductRepository : IRepositoryBase<Product>{
        private List<Product> products = new List<Product>();

        public void Add(Product product){
            products.Add(product);
        }

        public List<Product> GetAll(){
            return products;
        }

        public void SendMail(){
            Console.WriteLine("Envio de correio electrónico aos fornecedores de produtos...");
        }
    }
}
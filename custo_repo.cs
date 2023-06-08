namespace ams_heranca_repository{
 class CustomerRepository : IRepositoryBase<Customer>{
        private List<Customer> customers = new List<Customer>();

        public void Add(Customer customer){
            customers.Add(customer);
        }

        public List<Customer> GetAll(){
            return customers;
        }

        public void SendMail(){
            Console.WriteLine("Envio de mensagens electrónicas aos clientes...");
        }
    }
}
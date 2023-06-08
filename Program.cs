using System;
using System.Collections.Generic;

namespace ams_heranca_repository{
    class Program{
        static void Main(string[] args){
            CustomerRepository customerRepository = new CustomerRepository();
            ProductRepository productRepository = new ProductRepository();

            Customer customer1 = new Customer("João Miguel", "joao.souza914@etec.gov.sp.br");
            Customer customer2 = new Customer("Axel", "axel.leonardo@gmail.com");

            customerRepository.Add(customer1);
            customerRepository.Add(customer2);

            Console.WriteLine("Customers:");
            var customers = customerRepository.GetAll();
            foreach (var customer in customers){
                Console.WriteLine($"Nome da pessoa: {customer.Name}, Email: {customer.Email}");
                Console.WriteLine();
            }

            Console.WriteLine();

            Product product1 = new Product("Maçã", "R$5.40 o kilo");
            Product product2 = new Product("Banana", "R$7.90 o kilo");

            productRepository.Add(product1);
            productRepository.Add(product2);
            Console.WriteLine($"----------------------------------------------------");
            Console.WriteLine($"");
            Console.WriteLine("Products:");
            var products = productRepository.GetAll();
            foreach (var product in products){
                Console.WriteLine($"Nome do produto: {product.Name}, Valor: {product.Price:C}");
                Console.WriteLine();
            }
        }
    }

    interface IRepositoryBase<T>{
        void Add(T entity);
        List<T> GetAll();
        void SendMail();
    }
}
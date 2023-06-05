using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

record class Product(string name, int count);
record class Delivery(string date, List<Product> products);
record class Provider(int id, List<Delivery> deliveries);
class HelloWorld
{
    static void Main()
    {
        Provider[] providers = { 
            new Provider(1437, new List<Delivery>
            {
                new Delivery("31.05.23", new List<Product>
                {
                    new Product("Гречка", 55),
                    new Product("Кабачки", 7)
                }),
                new Delivery("30.05.23", new List<Product> {
                    new Product("Квас", 17),
                    new Product("Кефир", 11) 
                })
            }),
            new Provider(1388, new List<Delivery>
            {
                new Delivery("30.05.23", new List<Product>
                {
                    new Product("Гречка", 88),
                    new Product("Вода", 4)
                }),
                new Delivery("28.05.23", new List<Product>
                {
                    new Product("Соль", 44),
                    new Product("Кабачки", 8)
                })
            })
        };
        while (true)
        {
            Console.WriteLine(@"
Группировка по:
1. Поставщикам
2. Товарам
3. Датам
");
            var num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    var by_provider = from provider in providers
                        from delivery in provider.deliveries
                        from product in delivery.products
                        group product.name by provider.id.ToString();
                    Printer(by_provider);
                    break;

                case "2":
                    var by_product = from provider in providers
                        from delivery in provider.deliveries
                        from product in delivery.products
                        group provider.id.ToString() by product.name;
                    Printer(by_product);
                    break;

                case "3":
                    var by_date = from provider in providers
                        from delivery in provider.deliveries
                        from product in delivery.products
                        group product.name by delivery.date;
                    Printer(by_date);
                    break;
            }
        }
    }
    static void Printer(IEnumerable<IGrouping<string, string>> groups)
    {
        foreach (var group in groups)
        {
            Console.WriteLine(group.Key + ':');
            foreach (var element in group)
            {
                Console.WriteLine('\t' + element);
            }
        }
    }
}

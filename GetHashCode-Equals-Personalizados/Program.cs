using System;
using GetHashCode_Equals_Personalizados.Entities;

namespace GetHashCode_Equals_Personalizados {
    class Program {
        static void Main(string[] args) {

            Client a = new Client { Name = "Maria", Email = "maria@gmai.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmai.com" };

            Console.WriteLine(a.Equals(b)); // Compara pela referência
            Console.WriteLine(a == b); // Compara objetos na memória, CONTEÚDO
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}

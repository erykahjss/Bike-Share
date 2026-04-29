using System;
using System.Collections.Generic;

namespace BikeShareSP
{
    class Program
    {
        // Estrutura de dados simples para simular o banco de dados (UC1)
        static List<string> bicicletas = new List<string> { "Caloi City - ID 001", "Monark Urban - ID 002" };

        static void Main(string[] args)
        {
            Console.WriteLine("=== BikeShare SP - Sistema de Gestão (Versão Alpha) ===");
            
            bool emExecucao = true;
            while (emExecucao)
            {
                Console.WriteLine("\nSelecione uma opção:");
                Console.WriteLine("1 - Listar Bicicletas Disponíveis [REQ-01]");
                Console.WriteLine("2 - Cadastrar Nova Bicicleta [REQ-02]");
                Console.WriteLine("3 - Realizar Aluguel [REQ-03]");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ListarBikes(); // Implementado (UC1)
                        break;
                    case "2":
                        // TODO: Implementar Cadastro conforme [REQ-02] da UC4
                        Console.WriteLine("Funcionalidade em desenvolvimento...");
                        break;
                    case "3":
                        // TODO: Implementar Lógica de Aluguel conforme [REQ-03] da UC4
                        Console.WriteLine("Funcionalidade em desenvolvimento...");
                        break;
                    case "0":
                        emExecucao = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void ListarBikes()
        {
            Console.WriteLine("\n--- Bicicletas no Sistema ---");
            foreach (var bike in bicicletas)
            {
                Console.WriteLine($"- {bike}");
            }
        }
    }
}
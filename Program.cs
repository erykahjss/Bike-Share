using System;

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
                        Console.WriteLine("\n==== Cadastro de Novo Modelo ====\n");
                        Console.Write("Adicione o novo modelo de bike para cadastrar: ");
                        string novaBike = Console.ReadLine();

                        if (novaBike != "") //Verifica se o espaço não está vazio
                        {
                           bicicletas.Add(novaBike);
                           Console.WriteLine("Modelo cadastrado.");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Nome vazio.");
                        }
                        break;
                    case "3":
                        // TODO: Implementar Lógica de Aluguel conforme [REQ-03] da UC4
                        Console.WriteLine("\n==== Realizar Aluguel ====\n");
                        Console.Write("Qual bicicleta você deseja alugar? ");
                        string busca = Console.ReadLine();
                        bool encontrou = false;

                        for (int i = 0; i < bicicletas.Count; i++)
                        {
                            if (bicicletas[i] == busca)
                            {
                                bicicletas.RemoveAt(i);
                                Console.WriteLine("Aluguel realizado!");
                                encontrou = true;
                                break;
                            }
                        }

                        if (encontrou == false)
                        {
                            Console.WriteLine("Erro: Bicicleta não encontrada.");
                        }
                        break;
                    case "0":
                        emExecucao = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void ListarBikes()
        {
            Console.WriteLine("\n==== Bikes Disponíveis ====\n");
            foreach (var bike in bicicletas)
            {
                Console.WriteLine($"- {bike}");
            }
        }
    }
}
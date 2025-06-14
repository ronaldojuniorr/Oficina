﻿using System;
using Oficina.Models;

namespace Oficina
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nBem-Vindo ao Cadastro da Oficina!");
            Console.WriteLine("-------------------------------------\n");

            bool exec = true;
            bool execEdit = true;

            while (exec)
            {

                Console.WriteLine("===Oficina de Carros===\n");

                Console.WriteLine("[1] Novo Cadastro");
                Console.WriteLine("[2] Editar Cadastro");
                Console.WriteLine("[3] Remover Cadastro");
                Console.WriteLine("[4] Pesquisar");
                Console.WriteLine("[5] Adicionar Serviço");
                Console.WriteLine("[6] Listar");
                Console.WriteLine("[0] Sair");
                Console.Write("Selecione uma das opções: \n");
                var escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("=== Cadastro de Carros ===\n");

                        Console.Write("Placa: ");
                        string placa = Console.ReadLine()!;
                        Console.Write("Modelo: ");
                        string modelo = Console.ReadLine()!;
                        Console.Write("Cor: ");
                        string cor = Console.ReadLine()!;
                        Console.Write("Proprietário: ");
                        string propr = Console.ReadLine()!;

                        Executar.veiculos.Add(new Veiculo(placa, modelo, cor, propr));
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("=== Editar Cadastro ===\n");

                        Console.Write("Placa do cadastro a ser atualizado: ");
                        string y = Console.ReadLine()!;
                        Veiculo veiculoEncontrado = Executar.Pesquisar(y);

                        if (veiculoEncontrado != null)
                        {
                            //Serviços e outros
                        }
                        else
                        {
                            Console.WriteLine($"\nA {y} não está na lista de carros da oficina!");
                        }
                        break;

                    case "3":
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("=== Pesquisa de Carros ===\n");

                        Console.Write("Placa a ser pesquisada: ");
                        string x = Console.ReadLine()!;
                        Executar.Pesquisar(x);

                        Console.WriteLine("\nPesquisa realizada. Pressione qualquer tecla para continuar...\n");
                        Console.ReadKey();
                        break;



                    case "5":
                        Console.Clear();
                        Console.WriteLine("=== Adicionar Serviço ===\n");
                        Console.Write("Placa do carro em que o serviço foi feito: ");
                        string z = Console.ReadLine()!;
                        Veiculo veiculoz = Executar.Pesquisar(z);

                        if (veiculoz != null)
                        {
                            Console.Write("ID do serviço: ");
                            string tipo = (Console.ReadLine()!);

                            Console.Write("Data (dd/mm/aaaa): ");
                            DateTime data = DateTime.Parse(Console.ReadLine()!);

                            Console.Write("Responsável: ");
                            string resp = Console.ReadLine()!;

                            Console.Write("Diagnóstico: ");
                            string diag = Console.ReadLine()!;

                            ServicosFeitos novoServico = new ServicosFeitos(tipo, data, resp, diag);

                            veiculoz.ServicosF = novoServico;

                            Console.WriteLine("Serviço adicionado com sucesso!");
                        }
                        break;

                    case "6":
                        Executar.Listar();
                        break;

                    case "0":
                        exec = false;
                        break;
                }






            }


        }
    }
}
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

            Executar.LerXml();

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
                            execEdit = true;
                            while (execEdit)
                            {
                                Console.Clear();
                                Console.WriteLine("=== Editar Veículo ===");
                                Console.WriteLine($"[1] Placa: {veiculoEncontrado.Placa}");
                                Console.WriteLine($"[2] Modelo: {veiculoEncontrado.Modelo}");
                                Console.WriteLine($"[3] Cor: {veiculoEncontrado.Cor}");
                                Console.WriteLine($"[4] Proprietário: {veiculoEncontrado.Proprietario}");
                                Console.WriteLine("[0] Voltar");
                                Console.Write("\nEscolha o que deseja editar: ");
                                string opcaoEditar = Console.ReadLine()!;

                                switch (opcaoEditar)
                                {
                                    case "1":
                                        Console.Write("Nova placa: ");
                                        veiculoEncontrado.Placa = Console.ReadLine()!;
                                        Console.WriteLine("Placa atualizada com sucesso!");
                                        break;

                                    case "2":
                                        Console.Write("Novo modelo: ");
                                        veiculoEncontrado.Modelo = Console.ReadLine()!;
                                        Console.WriteLine("Modelo atualizado com sucesso!");
                                        break;

                                    case "3":
                                        Console.Write("Nova cor: ");
                                        veiculoEncontrado.Cor = Console.ReadLine()!;
                                        Console.WriteLine("Cor atualizada com sucesso!");
                                        break;

                                    case "4":
                                        Console.Write("Novo proprietário: ");
                                        veiculoEncontrado.Proprietario = Console.ReadLine()!;
                                        Console.WriteLine("Proprietário atualizado com sucesso!");
                                        break;

                                    case "0":
                                        execEdit = false;
                                        Console.WriteLine("Saindo da edição...");
                                        Console.Clear();
                                        break;

                                    default:
                                        Console.WriteLine("Opção inválida.");
                                        break;
                                }

                                if (execEdit)
                                {
                                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                                    Console.ReadKey();

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\nA Placa {y} não está na lista de carros da oficina!\n");
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("=== Remover Cadastro ===\n");

                        Console.Write("Placa do cadastro a ser removido: ");
                        string placaRemover = Console.ReadLine()!;

                        Veiculo veiculoParaRemover = Executar.Pesquisar(placaRemover);

                        if (veiculoParaRemover != null)
                        {
                            Console.WriteLine($"\nVeículo com a placa {placaRemover} encontrado.");
                            Console.WriteLine("Pressione ENTER para confirmar a remoção.");
                            Console.WriteLine("Ou pressione ESC para cancelar.");

                            ConsoleKeyInfo tecla = Console.ReadKey(true); // true: não exibe a tecla

                            if (tecla.Key == ConsoleKey.Enter)
                            {
                                Executar.veiculos.Remove(veiculoParaRemover);
                                Console.WriteLine("\nVeículo removido com sucesso!");
                            }
                            else if (tecla.Key == ConsoleKey.Escape)
                            {
                                Console.WriteLine("\nRemoção cancelada.");
                            }
                            else
                            {
                                Console.WriteLine("\nTecla inválida. Remoção cancelada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\nA Placa {placaRemover} não está na lista de carros da oficina!\n");
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
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
                            Console.Write("Qual serviço foi feito? ");
                            string tipo = (Console.ReadLine()!);

                            Console.Write("Data (dd/mm/aaaa): ");
                            DateTime data = DateTime.Parse(Console.ReadLine()!);

                            Console.Write("Responsável: ");
                            string resp = Console.ReadLine()!;

                            Console.Write("Diagnóstico: ");
                            string diag = Console.ReadLine()!;

                            ServicosFeitos novoServico = new ServicosFeitos(tipo, data, resp, diag);

                            veiculoz.ServicosF = novoServico;

                            Console.WriteLine("\nServiço adicionado com sucesso!\n");
                        }
                        else
                        {
                            Console.WriteLine($"\nA Placa {z} não está na lista de carros da oficina!\n");
                        }
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("=== Listar Cadastros ===\n");
                        Executar.Listar();
                        Console.WriteLine("========================\n");
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("=== Obrigado por utilizar o Cadastro da Oficina! ===\n");
                        Executar.SalvarXml();
                        exec = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }






            }


        }
    }
}
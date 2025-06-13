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

            while (exec)
            {

                Console.WriteLine("===Oficina de Carros===\n");

                Console.WriteLine("[1] Novo Cadastro");
                Console.WriteLine("[2] Editar Cadastro");
                Console.WriteLine("[3] Pesquisar");
                Console.WriteLine("[4] Adicionar Serviço");
                Console.WriteLine("[5] Listar");
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
                        Console.Write("Placa do cadastro a ser atualizado: ");
                        string y = Console.ReadLine()!;
                        Executar.Pesquisar(y);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("=== Pesquisa de Carros ===\n");

                        Console.Write("Placa a ser pesquisada: ");
                        string x = Console.ReadLine()!;
                        Executar.Pesquisar(x);

                        Console.WriteLine("\nPesquisa realizada. Pressione qualquer tecla para continuar...\n");
                        Console.ReadKey();
                        break;

                    case "4":
                        break;

                    case "5":
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
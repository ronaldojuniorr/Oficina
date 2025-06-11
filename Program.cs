﻿using System;
using Oficina.Models;

namespace Oficina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo ao Cadastro da Oficina!\n");
            Console.WriteLine("-------------------------------------");

            List<Veiculo> veiculos = new List<Veiculo>();
            bool exec = true;

            while (exec)
            {
                Console.Clear();
                Console.WriteLine("===Oficina de Carros===\n");

                Console.WriteLine("[1] Novo Cadastro");
                Console.WriteLine("[2] Pesquisar");
                Console.WriteLine("[3] Adicionar Serviço");
                Console.WriteLine("[4] Listar");
                Console.WriteLine("[0] Sair");
                Console.Write("Selecione uma das opções: \n");
                var escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("===Oficina de Carros===\n");

                        Console.Write("Placa: ");
                        string placa = Console.ReadLine()!;
                        Console.Write("Modelo: ");
                        string modelo = Console.ReadLine()!;
                        Console.Write("Cor: ");
                        string cor = Console.ReadLine()!;
                        Console.Write("Proprietário: ");
                        string propr = Console.ReadLine()!;

                        veiculos.Add(new Veiculo(placa, modelo, cor, propr));
                        break;

                    case "2":
                        break;

                    case "3":
                        break;
                }






            }


        }
    }
}
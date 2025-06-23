using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Oficina.Models;

namespace Oficina.Models
{
    public class Executar
    {
        public static List<Veiculo> veiculos = new List<Veiculo>();

        public static void LerXml()
        {
            Console.Write("Informe o caminho do arquivo XML: ");
            string caminho = Console.ReadLine()!;

            if (File.Exists(caminho))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Veiculo>));

                using (FileStream fs = new FileStream(caminho, FileMode.Open))
                {
                    veiculos = (List<Veiculo>)serializer.Deserialize(fs);
                }

                Console.WriteLine($"[INFO] {veiculos.Count} veículos carregados do XML.\n");
            }
            else
            {
                Console.WriteLine("[INFO] Arquivo XML não encontrado. Lista iniciada vazia.\n");
            }
        }

        public static void SalvarXml()
        {
            string caminho = "veiculos.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Veiculo>));
            using (FileStream fs = new FileStream(caminho, FileMode.Create))
            {
                serializer.Serialize(fs, veiculos);
            }

            Console.WriteLine("[INFO] Dados salvos no arquivo XML.");
        }

        public static Veiculo Pesquisar(string placa)
        {
            var encontrado = veiculos.FirstOrDefault(v => v.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));

            if (encontrado != null)
            {
                Console.WriteLine($"\nVeículo encontrado: {encontrado.Modelo} | {encontrado.Placa}");
                Console.WriteLine($"Cor: {encontrado.Cor}, Proprietário: {encontrado.Proprietario}");

                if (encontrado.ServicosF != null)
                {
                    Console.WriteLine(encontrado.ServicosF.ToString());
                }
                else
                {
                    Console.WriteLine("Nenhum serviço registrado para este veículo.");
                }

                return encontrado;
            }
            else
            {
                return null; // Arrumar o null
            }
        }
        public static void Listar()
        {
            foreach (var veiculo in veiculos)
            {
                Console.Write($"{veiculo.Placa} |  {veiculo.Modelo} \nCor: {veiculo.Cor} \nProprietário: {veiculo.Proprietario}\n");

                if (veiculo.ServicosF != null)
                {
                    Console.WriteLine(veiculo.ServicosF.ToString());
                }
                else
                {
                    Console.WriteLine("Nenhum serviço registrado para este veículo.\n");
                }
            }
        }
    }

}
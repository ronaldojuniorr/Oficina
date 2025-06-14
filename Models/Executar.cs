using System;

namespace Oficina.Models
{
    public class Executar
    {
        public static List<Veiculo> veiculos = new List<Veiculo>();

        public static Veiculo Pesquisar(string placa)
        {
            var encontrado = veiculos.FirstOrDefault(v => v.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));

            if (encontrado != null)
            {
                Console.WriteLine($"\nVeículo encontrado: {encontrado.Modelo} | {encontrado.Placa}");
                Console.WriteLine($"Cor: {encontrado.Cor}, Proprietário: {encontrado.Proprietario}");

                if (encontrado.ServicosF != null)
                {
                    Console.WriteLine("Serviço: " + encontrado.ServicosF.ToString());
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
                Console.WriteLine($"{veiculo.Modelo} {veiculo.Placa} {veiculo.Cor} {veiculo.Proprietario} {veiculo.ServicosF.ToString()}");
            }
        }
    }

}
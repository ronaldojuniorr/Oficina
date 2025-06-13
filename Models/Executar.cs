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
                return encontrado;
            }
            else
            {
                Console.WriteLine($"\nA {placa} não está na lista de carros da oficina!");
                return null;
            }
        }
        public static void Listar()
        {
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"{veiculo.Modelo} {veiculo.Placa} {veiculo.Cor} {veiculo.Proprietario}");
            }
        }
    }

}
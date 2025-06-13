using System;

namespace Oficina.Models
{
    public class Executar
    {
        public static List<Veiculo> veiculos = new List<Veiculo>();

        public static void Pesquisar(string placa)
        {
            var encontrado = veiculos.FirstOrDefault(v => v.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
            
            if (encontrado != null)
            {
                Console.WriteLine($"Veículo encontrado: {encontrado.Modelo} | {encontrado.Placa}");
                Console.WriteLine($"Cor: {encontrado.Cor}, Proprietário: {encontrado.Proprietario}");
            }
            else
            {
                Console.WriteLine($"A {placa} não está na lista de carros da oficina!");
            }
        }
    }

}
using System;

namespace Oficina.Models
{
    public class Veiculo
    {
        private string Placa { get; set; }
        private string Modelo { get; set; }
        private string Cor { get; set; }
        private string Proprietario { get; set; }


        public Veiculo (string a, string b, string c, string d)
        {
            Modelo = a;
            Cor = b;
            Placa = c;
            Proprietario = d;
        }

    }

}
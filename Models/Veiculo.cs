using System;

namespace Oficina.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Proprietario { get; set; }
        public ServicosFeitos ServicosF { get; set; }


        public Veiculo(string a, string b, string c, string d)
        {
            Placa = a;
            Modelo = b;
            Cor = c;
            Proprietario = d;
        }

    }

}
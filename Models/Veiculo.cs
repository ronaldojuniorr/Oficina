using System;

namespace Oficina.Models
{
    public class Veiculo
    {
        public string Placa { get;  set; }
        public string Modelo { get; private set; }
        public string Cor { get; private set; }
        public string Proprietario { get; private set; }
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
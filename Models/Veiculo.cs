using System;
using System.Xml.Serialization;

namespace Oficina.Models
{
    [Serializable]
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Proprietario { get; set; }
        public ServicosFeitos ServicosF { get; set; }

        public Veiculo() { }

        public Veiculo(string a, string b, string c, string d)
        {
            Placa = a;
            Modelo = b;
            Cor = c;
            Proprietario = d;
        }

    }

}
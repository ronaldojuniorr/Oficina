using System;
using System.Xml.Serialization;

namespace Oficina.Models
{
    [Serializable]
    public class ServicosFeitos
    {
        public string TipoServiço { get; set; }
        public DateTime data { get; set; } = DateTime.Now;
        public string Responsavel { get; set; }
        public string Diagnostico { get; set; }

        public ServicosFeitos() { }

        public ServicosFeitos(string a, DateTime b, string c, string d)
        {
            TipoServiço = a;
            data = b;
            Responsavel = c;
            Diagnostico = d;
        }
        public override string ToString()
        {
            return $"\nUltimo Serviço feito:\n{TipoServiço}, Data: {data:dd/MM/yyyy}, Responsável: {Responsavel}, Diagnóstico: {Diagnostico}\n";
        }
    }
}
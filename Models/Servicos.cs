using System;

namespace Oficina.Models
{
    public class ServicosFeitos
    {
        private int IdServico;
        private DateTime data { get; set; } = DateTime.Now;
        private string Responsavel;
        private string Diagnostico;

        public ServicosFeitos(int a, DateTime b, string c, string d)
        {
            IdServico = a;
            data = b;
            Responsavel = c;
            Diagnostico = d;
        }
    }
}
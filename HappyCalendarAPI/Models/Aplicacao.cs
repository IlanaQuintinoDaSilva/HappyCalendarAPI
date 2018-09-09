using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyCalendarAPI.Models
{
    public class Aplicacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double VlrAplicacao { get; set; }
        public double VlrResgate { get; set; }
        public DateTime DtAplicacao { get; set; }
        public DateTime Vencimento { get; set; }
    }
}
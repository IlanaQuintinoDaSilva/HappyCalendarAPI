using HappyCalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalendarAPI.BLL.Interfaces
{
    public interface IAplicacaoBLL
    {
        List<Aplicacao> GetAplicacoes();
    }
}

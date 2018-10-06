using HappyCalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalendarAPI.BLL.Interfaces
{
    public interface ICategoryBLL
    {
        List<Area> GetAreas();
        bool AddArea(Area model, ref ReturnModel result);

        List<Project> GetProjects();

        bool AddProject(Project model, ref ReturnModel result);
    }
}

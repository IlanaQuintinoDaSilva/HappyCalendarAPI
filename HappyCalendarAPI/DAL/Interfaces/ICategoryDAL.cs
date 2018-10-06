using HappyCalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalendarAPI.DAL.Interfaces
{
    public interface ICategoryDAL
    {
        List<Area> GetAreas();
        void AddArea(Area model, SqlConnection connection, SqlTransaction transaction);

        List<Project> GetProjects();
        void AddProject(Project model, SqlConnection connection, SqlTransaction transaction);

    }
}

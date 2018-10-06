using HappyCalendarAPI.BLL.Interfaces;
using HappyCalendarAPI.DAL;
using HappyCalendarAPI.DAL.Base;
using HappyCalendarAPI.DAL.Interfaces;
using HappyCalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HappyCalendarAPI.BLL
{
    public class CategoryBLL : ICategoryBLL
    {
        private readonly ICategoryDAL _categoryDAL = new CategoryDAL();

        public List<Area> GetAreas()
        {
            return _categoryDAL.GetAreas();
        }

        public bool AddArea(Area model, ref ReturnModel result)
        {
            using (var connection = new SqlConnection(BaseDAL.ConnectionStringSqlServer))
            {
                connection.Open();
                using(var transaction = connection.BeginTransaction())
                {
                    _categoryDAL.AddArea(model, connection, transaction);
                    transaction.Commit();
                }
                return true;
            }

        }

        public List<Project> GetProjects()
        {
            return _categoryDAL.GetProjects();
        }

        public bool AddProject(Project model, ref ReturnModel result)
        {
            using (var connection = new SqlConnection(BaseDAL.ConnectionStringSqlServer))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    _categoryDAL.AddProject(model, connection, transaction);
                    transaction.Commit();
                }
                return true;
            }

        }
    }
}
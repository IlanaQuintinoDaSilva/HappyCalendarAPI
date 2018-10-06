using Dapper;
using HappyCalendarAPI.DAL.Base;
using HappyCalendarAPI.DAL.Interfaces;
using HappyCalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HappyCalendarAPI.DAL
{
    public class CategoryDAL : ICategoryDAL
    {
        public List<Area> GetAreas()
        {
            using(var connection = new SqlConnection(BaseDAL.ConnectionStringSqlServer))
            {
                return connection.Query<Area>(
                    "spGetAreas",
                    commandType: System.Data.CommandType.StoredProcedure).ToList(); ;
            }
        }

        public void AddArea(Area model, SqlConnection connection, SqlTransaction transaction)
        {
            connection.Query("spAddArea",
            new {model.AreaName},
            commandType: CommandType.StoredProcedure,
            transaction: transaction);
        }

        public List<Project> GetProjects()
        {
            using (var connection = new SqlConnection(BaseDAL.ConnectionStringSqlServer))
            {
                return connection.Query<Project>(
                    "spGetProjects",
                    commandType: System.Data.CommandType.StoredProcedure).ToList(); ;
            }
        }
        public void AddProject(Project model, SqlConnection connection, SqlTransaction transaction)
        {
            connection.Query("spAddProject",
            new { model.Name, model.Description },
            commandType: CommandType.StoredProcedure,
            transaction: transaction);
        }
    }
}
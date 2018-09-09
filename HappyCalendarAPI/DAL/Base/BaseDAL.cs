using System.Configuration;

namespace HappyCalendarAPI.DAL.Base
{
    public class BaseDAL
    {
        public static readonly string ConnectionStringSqlServer =
            ConfigurationManager.ConnectionStrings["ConnectionSqlServer"].ConnectionString;
    }
}
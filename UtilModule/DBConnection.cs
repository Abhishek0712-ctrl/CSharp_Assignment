using Microsoft.Data.SqlClient;
namespace UtilModule
{
    public static class dbConnection
    {
        public static string _cn = null;
        static dbConnection()
        {
            _cn = "Data Source=.\\sqlexpress;Initial Catalog=CMS;Integrated Security=True;Trust Server Certificate=True";
        }
        public static string cnstring 
        { 
            get{return _cn;}
            set{_cn=value;}
        }
        public static SqlConnection getConnection()
        {
            SqlConnection cn = new SqlConnection(cnstring);
            return cn;
        }
        
}

}


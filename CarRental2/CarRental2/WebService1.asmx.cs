using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;


namespace CarRental2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public bool UsernameCheck(string UserName)
        {
            bool UserNameInUse = false;
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            using (con)
            {
                SqlCommand command = new SqlCommand("spUserNameExists", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@UserName",
                    Value = UserName

                });
                con.Open();
                UserNameInUse = Convert.ToBoolean(command.ExecuteScalar());
            }
            con.Close();
            return UserNameInUse;
        }
    }
}

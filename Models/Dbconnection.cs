using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using myproject.Models;
using System.Data;

namespace myproject.Models
{
    public class Dbconnection
    {
        // string constring = @"Data Source=172.16.12.14;Initial Catalog=GuviTrainingDatabase;User id =training1;password=Karomi@123";
        // SqlConnection con = new SqlConnection(constring);

         SqlConnection con = new SqlConnection("Data Source=172.16.12.14;Initial Catalog=GuviTrainingDatabase;User Id=training1;Password=Karomi@123");       
        SqlCommand cmd = null;                    
                        SqlDataAdapter da = null;
                        DataTable dt = null;

              
        public string Register(Register register)
        {
            cmd = new SqlCommand("Insert into register(firstname,lastname,email,gender,password,active) values ('"+register.firstname+ "','" + register.lastname + "','" + register.email + "','" + register.gender + "','" + register.password + "','" + register.active + "')");
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
    }
}
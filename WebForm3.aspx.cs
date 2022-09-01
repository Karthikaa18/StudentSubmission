using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
//using System.Windows.Forms;
using System.Drawing;
using System.Text;
namespace myproject
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter first name')", true);
                // MessageBox.Show("");
            }
            else if (txtlastname.Text == "")
            {
                //  MessageBox.Show("Enter password");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter last name')", true);
            }
            else if (txtemail.Text == "")
            {
                //  MessageBox.Show("Enter password");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter email')", true);
            }
            else if (txtpassword.Text == "")
            {
                //  MessageBox.Show("Enter password");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter password')", true);
            }
            else
            {
                string gender = string.Empty;
                if (male.Checked)
                {
                    gender = "Male";
                }
                else if (female.Checked)
                {
                    gender = "Female";
                }
                try
                {
                    string constring = @"Data Source=172.16.12.14;Initial Catalog=GuviTrainingDatabase;User id =training1;password=Karomi@123";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        using (SqlCommand cmd = new SqlCommand("Insert into register(firstname, lastname, email, gender, password, active) values('"+txtfirstname.Text+ "', '" + txtlastname.Text + "', '" + txtemail.Text + "', '" + gender + "', '" + txtpassword.Text + "', '0')", con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@firstname", txtfirstname.Text);
                            cmd.Parameters.AddWithValue("@lastname", txtlastname.Text);
                            cmd.Parameters.AddWithValue("@email", txtemail.Text);
                            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                            cmd.Parameters.AddWithValue("@gender", gender);
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    sda.Fill(dt);
                                    // dataGridView1.DataSource = dt;
                                    if (dt.Rows.Count >= 0)
                                    {
                                        //       MessageBox.Show("success");
                                        ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('success')", true);

                                        //   Response.Redirect("http://localhost:64472/WebForm2.aspx");
                                        Response.Redirect("~/WebForm1.aspx");
                                    }
                                    else
                                    {
                                        ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('not success')", true);
                                    }
                                }
                            }
                        }
                    }
                    //  SqlConnection conn = new SqlConnection("Data Source=172.16.12.14;Initial Catalog=GuviTrainingDatabase;User Id=training1;Password=Karomi@123");
                    //  SqlCommand cmd = new SqlCommand("select * from EmployeeUserDetails where employee_name=@employee_name and employee_contactno =@employee_contactno",conn);

                    //   SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //  DataTable dt = new DataTable();
                    //   da.Fill(dt);
                    //      MessageBox.Show("invalid");
                }
                catch (Exception)
                {
                    //   MessageBox.Show("Error");
                    ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('error')", true);
                }
            }
        }
    }
}
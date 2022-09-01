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
//using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace myproject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static String filelink;

        static Int32 applicationid;

        public string Label1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter name')", true);
                // MessageBox.Show("");
            }
            else if (TextBox2.Text == "")
            {
                //  MessageBox.Show("Enter password");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter id')", true);
            }
            else if (TextBox3.Text == "")
            {
                //  MessageBox.Show("Enter password");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter mobile')", true);
            }
            else if (TextBox6.Text == "")
            {
                //  MessageBox.Show("Enter password");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter email')", true);
            }
            else
            {
                try
                {
                    string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    filelink = "UploadedAssignment/" + filename + ".pdf";
                    int studentnumber;
                    bool isParsable = Int32.TryParse(TextBox2.Text, out studentnumber);
                    string constring = @"Data Source=172.16.12.14;Initial Catalog=GuviTrainingDatabase;User id =training1;password=Karomi@123";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        using (SqlCommand cmd = new SqlCommand("Insert into studentfile(studentid, studentname, email, phone, uploadfilename, filestatus) values('" + studentnumber + "', '" + TextBox1.Text + "', '" + TextBox6.Text + "', '" + TextBox3.Text + "', '" + filelink + "', 'submitted')", con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@studentid", studentnumber);
                            cmd.Parameters.AddWithValue("@studentname", TextBox1.Text);
                            cmd.Parameters.AddWithValue("@email", TextBox6.Text);
                            cmd.Parameters.AddWithValue("@phone", TextBox3.Text);
                            cmd.Parameters.AddWithValue("@uploadfilename", filelink);
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
                                        Response.Redirect("~/WebForm4.aspx");
                                    }
                                    else
                                    {
                                        ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('not success')", true);
                                    }
                                }
                            }
                        }
                    }
                    
                }
                    //if (uploadresume() == true)
                    //   {
                    //string contenttypee = "application/pdf"
               
                catch (Exception)
                {
                    //   MessageBox.Show("Error");
                    ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Already submitted')", true);
                }
            }
        }
        private Boolean uploadresume()
        {
            Boolean resumesaved = false;
            if (FileUpload1.HasFile == true)
            {
                String contenttype = FileUpload1.PostedFile.ContentType;
                if (contenttype == "application/pdf")
                {
                    int filesize;
                    filesize = FileUpload1.PostedFile.ContentLength;

                    //getapplicationid();
                    FileUpload1.SaveAs(Server.MapPath("~/UploadedResume/") + TextBox2.Text + ".pdf");
                    filelink = "UploadedResume/" + TextBox2.Text + ".pdf";
                    resumesaved = true;
                    Label1 = "";
                }
                else
                {
                    Label1 = "Upload Resume in PDF Format Only";
                }

            }
            else
            {
                Label1 = "Kindly Upload Resume Before Apply in PDF Format";
            }


            return resumesaved;
        }
    }
}
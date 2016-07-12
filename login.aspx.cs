using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;

public partial class _Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
    }

    protected void login_Click(object sender, EventArgs e)
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(s);
        SqlCommand cmd = new SqlCommand("select * from login where userid='" + userid.Text + "' and password='" + password.Text + "'", con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@userid", userid.Text);
        cmd.Parameters.AddWithValue("@password", password.Text);

        cmd.Connection = con;
        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;
            Panel4.Visible = false;

        }
        else
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = true;
        
        }

        dr.Close();
        
        con.Close();
            
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string filepath = TextBox1.Text;

        StreamReader sr = new StreamReader(filepath);
        SqlConnection con = new SqlConnection(s);

        string line = sr.ReadLine();
        string[] value = line.Split(',');
        DataTable dt = new DataTable();
        DataRow row;
        foreach (string dc in value)
        {
            dt.Columns.Add(new DataColumn(dc));
        }

        while (!sr.EndOfStream)
        {
            value = sr.ReadLine().Split(',');
            if (value.Length == dt.Columns.Count)
            {
                row = dt.NewRow();
                row.ItemArray = value;
                dt.Rows.Add(row);
            }
        }
        SqlBulkCopy bc = new SqlBulkCopy(con.ConnectionString, SqlBulkCopyOptions.TableLock);
        bc.DestinationTableName = TextBox2.Text;
        bc.BatchSize = dt.Rows.Count;
        con.Open();
        bc.WriteToServer(dt);
        bc.Close();
        con.Close();
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
    }
    
    protected void Button1_Click(object sender, System.EventArgs e)
    {
        
    }
    protected void Button3_Click(object sender, System.EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;

    }
    protected void Button4_Click(object sender, System.EventArgs e)
    {

        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
    }
}
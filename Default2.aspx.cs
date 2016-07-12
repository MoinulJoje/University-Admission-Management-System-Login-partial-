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


public partial class _Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Panel1.Visible = false;
        Panel2.Visible = true;
        Panel3.Visible = false;

        Panel4.Visible = false;
        Panel5.Visible = false;
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(s);

        SqlConnection con1 = new SqlConnection(s);
        SqlConnection con2 = new SqlConnection(s);
        if (DropDownList2.SelectedValue == "Dhaka")
        {
            SqlCommand cmd = new SqlCommand("select * from dhaka where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);


            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {
                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();
                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();
                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();

                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;
            }


            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }

        if (DropDownList2.SelectedValue == "Chittagong")
        {
            SqlCommand cmd = new SqlCommand("select * from chittagong where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);


            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);

            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {
                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();

                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();
                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();

                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();


            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;

            }



            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }
        if (DropDownList2.SelectedValue == "Rajshahi")
        {
            SqlCommand cmd = new SqlCommand("select * from rajshahi where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);


            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);

            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd.ExecuteReader();
            SqlDataReader dr2 = cmd.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {

                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();

                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();
                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();

                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();

            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;
            }


            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }
        if (DropDownList2.SelectedValue == "Jessore")
        {
            SqlCommand cmd = new SqlCommand("select * from Jessore where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);

            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {

                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();

                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();
                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();

                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();

            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;
            }



            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }
        if (DropDownList2.SelectedValue == "Barishal")
        {
            SqlCommand cmd = new SqlCommand("select * from barishal where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);

            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {

                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();

                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();
                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();

                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;
            }


            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }
        if (DropDownList2.SelectedValue == "Comilla")
        {
            SqlCommand cmd = new SqlCommand("select * from comilla where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);


            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);

            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {

                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();

                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();

                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();

                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;
            }



            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }
        if (DropDownList2.SelectedValue == "Dinajpur")
        {
            SqlCommand cmd = new SqlCommand("select * from dinajpur where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);


            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);

            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {

                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();

                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();
                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();
                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;
            }


            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }
        if (DropDownList2.SelectedValue == "Sylhet")
        {
            SqlCommand cmd = new SqlCommand("select * from sylhet where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);


            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);

            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {

                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();

                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();
                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();

                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();


            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;
            }


            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }
        if (DropDownList2.SelectedValue == "Madrasah")
        {
            SqlCommand cmd = new SqlCommand("select * from madrasah where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);


            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);

            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {

                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();

                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();
                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();

                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;
            }


            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }
        if (DropDownList2.SelectedValue == "Vocational")
        {
            SqlCommand cmd = new SqlCommand("select * from vocational where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from subgpa where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("select * from subname where hroll='" + TextBox1.Text + "' and hyr='" + DropDownList1.SelectedValue + "' and hbrd='" + DropDownList2.SelectedValue + "' and sroll='" + TextBox3.Text + "'", con);

            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@hroll", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@hroll", TextBox1.Text);

            cmd.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd1.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);
            cmd2.Parameters.AddWithValue("@hyr", DropDownList1.SelectedValue);

            cmd.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd1.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);

            cmd2.Parameters.AddWithValue("@hbrd", DropDownList2.SelectedValue);


            cmd.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@sroll", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@sroll", TextBox3.Text);

            cmd.Connection = con;
            cmd1.Connection = con1;
            cmd2.Connection = con2;

            con.Open();
            con1.Open();
            con2.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            SqlDataReader dr2 = cmd2.ExecuteReader();


            if (dr.Read() && dr1.Read() && dr2.Read())
            {

                Label1.Text = dr["stdname"].ToString();
                Label2.Text = dr["stdfather"].ToString();
                Label3.Text = dr["stdmother"].ToString();
                Label4.Text = dr["stddatebirth"].ToString();

                Label4.Text = Convert.ToDateTime(Label4.Text).ToShortDateString();
                Label12.Text = dr["stdgender"].ToString();
                Label5.Text = dr["hgrp"].ToString();

                Label6.Text = DropDownList3.SelectedValue;
                Label13.Text = dr["hyr"].ToString();
                Label14.Text = dr["hroll"].ToString();
                Label15.Text = dr["hgpa"].ToString();
                Label16.Text = dr["gpax4thH"].ToString();
                Label17.Text = dr["syr"].ToString();
                Label18.Text = dr["sroll"].ToString();
                Label19.Text = dr["sgpa"].ToString();
                Label20.Text = dr["gpax4thS"].ToString();

                Label21.Text = dr2["sub1"].ToString();
                Label22.Text = dr2["sub2"].ToString();
                Label23.Text = dr2["sub3"].ToString();
                Label24.Text = dr2["sub4"].ToString();
                Label25.Text = dr2["sub5"].ToString();
                Label26.Text = dr2["sub6"].ToString();

                Label27.Text = dr1["sub1"].ToString();
                Label28.Text = dr1["sub2"].ToString();
                Label29.Text = dr1["sub3"].ToString();
                Label30.Text = dr1["sub4"].ToString();
                Label31.Text = dr1["sub5"].ToString();
                Label32.Text = dr1["sub6"].ToString();

            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = true;
                Panel5.Visible = false;
            }


            dr.Close();
            dr1.Close();
            dr2.Close();

            con.Close();
            con1.Close();
            con2.Close();
        }
    }
    


    protected void Button2_Click1(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        Panel5.Visible = false;

       Label37.Text = Label15.Text;
        Label38.Text = Label19.Text;
        float a = float.Parse(Label37.Text);
        float b = float.Parse(Label38.Text);
        float c = a + b;
        Label34.Text = Convert.ToString(c);

        if (c >= 6 && a>=3 && b>=3)
        {
            Label35.Text = "The following units are applicable for you:";
            Button5.Visible = true;
            Button3.Visible = false;
            Button4.Visible = false;
            Button6.Visible = false;
            Button7.Visible = false;
            Button8.Visible = false;
            Button9.Visible = false;
            Button10.Visible = false;

            Button13.Visible = false;
            if (c >= 7 && a >= 3.5 && b >= 3.5)
            {
                
                Button3.Visible = true;
                Button4.Visible = true;
                Button6.Visible = true;
                Button7.Visible = true;
                Button8.Visible = true;
                Button9.Visible = false;
                Button10.Visible = true;
                Button13.Visible = false;

                if (c >= 8 && a >= 4 && b >= 4)
                {
                    Button9.Visible = true;
                    Button13.Visible = false;

                    }
            }
          
        }
    
        else
        {
         Label35.Text = "Sorry, you are not eligible for any of the units.";
         Button5.Visible = false;
         Button3.Visible = false;
         Button4.Visible = false;
         Button6.Visible = false;
         Button7.Visible = false;
         Button8.Visible = false;
         Button9.Visible = false;

         Button10.Visible = false;

         Button13.Visible = true;
        }
        if (Label5.Text == "commerce" || Label5.Text == "arts")
        {
            Button3.Visible = false;
            Button6.Visible = false;
            Button10.Visible = false;
            Button13.Visible = false;
            }

        
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        TextBox1.Text = "";
        TextBox3.Text = "";
        DropDownList1.SelectedValue = "Select Year";
        DropDownList2.SelectedValue = "Select Board";
        DropDownList3.SelectedValue = "Select Quota";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
    }
}
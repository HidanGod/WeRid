using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace weRid
{
	
	public partial class PostRedaction : System.Web.UI.Page
	{
		public void Page_Load (object sender, EventArgs args)
		{

		}
		protected void Page_Init(object sender, EventArgs e)
		{
			if (Session ["name"] != null) {
				name.Text = Session ["login"].ToString ();

				avatar.ImageUrl = Session ["avatar"].ToString ();
			} 
			else
			{
				//Response.Redirect("../Default.aspx"); 
			}
		}



		public void dynamicButton_Click (object sender, EventArgs args)
		{
			string ctrlName = ((Control)sender).ID;
			TextBoxPoisk.Text =ctrlName;
		}
		public void PostCreat_cleked(object sender, EventArgs args)
		{
			Response.Redirect("PostCreated.aspx"); 
		}
		public void glbutton_cleked(object sender, EventArgs args)
		{
			Response.Redirect("Glavnaia.aspx"); 
		}
		public void add_cleked(object sender, EventArgs args)
		{
			string ctrlName = ((Control)sender).ID;
			TextBoxPoisk.Text =ctrlName;
		}
		public void mypage_cleked (object sender, EventArgs args)
		{
			//name.Text = Session ["name"].ToString ();
			Response.Redirect("MyPage.aspx?ID="+Session ["id"].ToString());
		}
		public void exit_cleked (object sender, EventArgs args)
		{
			Response.Redirect("../Default.aspx"); 
		}
		public void MyPosts_cleked(object sender, EventArgs args)
		{

			Response.Redirect("MyPosts.aspx"); 
		}
		public void givebutton_cleked(object sender, EventArgs args)
		{
			string ctrlName = ((Control)sender).ID;
			TextBoxPoisk.Text =ctrlName;
		}
		public void logo1_cleked(object sender, EventArgs args)
		{
			string ctrlName = ((Control)sender).ID;
			TextBoxPoisk.Text =ctrlName;
		}
		public void name_cleked(object sender, EventArgs args)
		{
			Response.Redirect("MyPage.aspx?ID="+Session ["id"].ToString());
		}
		public void avatar_cleked(object sender, EventArgs args)
		{
			Response.Redirect("MyPage.aspx?ID="+Session ["id"].ToString());
		}
		public void logo_cleked(object sender, EventArgs args)
		{
			string ctrlName = ((Control)sender).ID;
			TextBoxPoisk.Text =ctrlName;
		}
		public void poisk_cleked(object sender, EventArgs args)
		{
		}
	}
}


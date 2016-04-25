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
	
	public partial class PostCreated : System.Web.UI.Page
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
				Response.Redirect("../Default.aspx"); 
			}
		}

		public void PostCreat_cleked(object sender, EventArgs args)
		{
			if(TextZglavPosta.Text !="" & TextPosta.Value !="" & KratkTextPosta.Value !="" & Tipi.SelectedValue !="" & Session ["id"].ToString() !="" & Session ["Pictheload"].ToString()!="" & RazdelPostaText.Text!="")
			{
			//if (TextZglavPosta.Text != "" & TextPosta.Text != "" & RazdelPostaText.Text != "") {
				//string go = "INSERT post (zaglav, text, fone) VALUES (" + loginText.Text + ", " + PasswdText.Text + "," + NumTelText.Text + ")";
			string connStr = "Server=MYSQL5016.myASP.NET;Database=db_9fb8eb_2009;Uid=9fb8eb_2009;Pwd=iyg45HHed7;";
				MySqlConnection conn = new MySqlConnection (connStr);
				try {
					//login2.Text = "Connecting to MySQL...";
					//Console.WriteLine ("Connecting to MySQL...");
					conn.Open ();
					//string sql = "INSERT INTO post (avtor, email, date, pol)" +
					//	"VALUES ('Ivanov', 'dfgdfh', '12.12.2012', 3)";
					//string sql = "INSERT INTO post (avtor, text,zaglav, textkratk, karma, urlpictche, urlvideo, date)" +
					//	"VALUES ('Ivanov', 'teeeext', 'zaglav', 'в кратце че то тут произошло','234','/resource/kot.jpg','/resource/kot.jpg', 2012-11-11)";
					//	MySqlCommand cmd = new MySqlCommand(sql, conn);
					//string sql2 = "INSERT INTO user (name, email,date, pol, url, LOGAN, roles, fone)" +
					//	"VALUES ('jkhjkh', 'qw@qw.qw', '1535-12-12', 1,'/resource/kot.jpg','hjkhj','admin', 'hjkhjk')";
				    //Session ["Pictheload"] = SaveLocation;
				   //System.DateTime.Now.ToString();
					string day = DateTime.Today.Day.ToString() +DateTime.Today.Month.ToString() +DateTime.Today.Year.ToString();
					string sql2 = "INSERT INTO post (zaglav, text, textkratk, Tip, id_avtora,  urlpictche, razdel, date)" +
						"VALUES ('"+TextZglavPosta.Text+"','"+TextPosta.Value+"','"+KratkTextPosta.Value+"','"+Tipi.SelectedValue+"','"+Session ["id"].ToString()+"','"+Session ["Pictheload"].ToString()+"','"+RazdelPostaText.Text+"','"+day+"')";
					MySqlCommand cmd = new MySqlCommand (sql2, conn);
					cmd.ExecuteNonQuery ();
					conn.Close ();
					Response.Redirect("MyPosts.aspx"); 
					// Prform database operations
				} 
				catch (Exception ex) 
				{
				PostPictcheLoad.Text = ex.ToString ();
				}
				conn.Close ();
			}
			//else
		//	{
					//ZaglavPost.Text = "opa";

			//}
		}
		public void glbutton_cleked(object sender, EventArgs args)
		{
			Response.Redirect("Glavnaia.aspx"); 
		}
		public void add_cleked(object sender, EventArgs args)
		{
			//string ctrlName = ((Control)sender).ID;
			//TextBoxPoisk.Text =ctrlName;
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
			//string ctrlName = ((Control)sender).ID;
			//TextBoxPoisk.Text =ctrlName;
		}
		public void logo1_cleked(object sender, EventArgs args)
		{
			//string ctrlName = ((Control)sender).ID;
			//TextBoxPoisk.Text =ctrlName;
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
			//string ctrlName = ((Control)sender).ID;
			//TextBoxPoisk.Text =ctrlName;
		}
		public void poisk_cleked(object sender, EventArgs args)
		{
			
		}
		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			// 
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			// 
			InitializeComponent();
			base.OnInit(e);
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Submit1.ServerClick += new System.EventHandler(this.Submit1_ServerClick);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Submit1_ServerClick(object sender, System.EventArgs e)
		{
			if( ( File1.PostedFile != null ) && ( File1.PostedFile.ContentLength > 0 ) )
			{
				string fn = System.IO.Path.GetFileName(File1.PostedFile.FileName);
				string SaveLocation = Server.MapPath("../resource/Data/") +  fn;
				Session ["Pictheload"] = "/resource/Data/"+  fn;
				PostPictche.ImageUrl = "/resource/Data/"+  fn;
				Response.Write("Файл загружен.");
				try
				{
					File1.PostedFile.SaveAs(SaveLocation);
					Response.Write("Файл загружен.");

				}
				catch ( Exception ex )
				{
					Response.Write("Ошибка: " + ex.Message);

					//Note: Exception.Message returns a detailed message that describes the current exception. 
					//For security reasons, we do not recommend that you return Exception.Message to end users in 
					//production environments. It would be better to return a generic error message. 
				}
			}
			else
			{
				Response.Write("Пожалуйста выберите файл для загрузки.");
			}
		}
	}
}


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
	
	public partial class Default : System.Web.UI.Page
	{
		public void Page_Load (object sender, EventArgs args)
		{
			if (!this.IsPostBack)
				ViewState["LoginErrors"] = 0;
			//Response.Redirect("Page/login.aspx");

		}


		protected void Page_Init(object sender, EventArgs e)
		{
			panelfon2.Visible = false;
			panelfon.Visible = true;

		}
		protected void Login1_Authentication(object sender, EventArgs e)
		{
			string  xlogin = Login1.UserName;
			string  xpass= Login1.Password;
			//string ID = Request.QueryString["ID"]; 
			string go =string.Format("SELECT * FROM user");
			//string go ="SELECT * FROM user WHERE LOGAN";
			//string go = "select * from user WHERE LOGAN";
			string connStr = "Server=MYSQL5016.myASP.NET;Database=db_9fb8eb_2009;Uid=9fb8eb_2009;Pwd=iyg45HHed7;";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(go, conn);
				cmd.ExecuteNonQuery();
				MySqlDataReader rd = cmd.ExecuteReader();

				while(rd.Read())
				{
					Session ["lol"]=rd.GetString (6).ToString();
					if(rd.GetString (6).ToString()==xlogin)
					{
						// Сохраняем параметры пользователя в сессии
						Session ["login"] = xlogin;
						Session ["id"] = rd.GetString (0).ToString();
						Session ["roles"] = rd.GetString (7).ToString();
						Session ["postglav"] = "0";
						Session ["pol"] = rd.GetString (4).ToString();

						Session ["avatar"] =rd.GetString (10).ToString();
						Session ["name"] =rd.GetString (1).ToString();
						Session ["karma"] = rd.GetString (11).ToString();
						Session ["podpisan"] = rd.GetString (12).ToString();
						Session ["podpischiki"] = rd.GetString (13).ToString();
						Session ["posts"] =rd.GetString (17).ToString();

						Session ["date"] = rd.GetString (2).ToString();
						Session ["countri"] = rd.GetString (14).ToString();
						Session ["toun"] = rd.GetString (15).ToString();
						Session ["work"] = rd.GetString (16).ToString();

						Session ["lenta"] =  "0";
						Session ["lol"] = "был";
						//Cookie ck = new Cookie("name", "value"); 
						HttpCookie cookie = new HttpCookie("IdAvtora=34","34");
						Response.Redirect("Page/Glavnaia.aspx");
					}
				}

				rd.Close();

			}
			catch (Exception ex)
			{
				Session ["lol"]=ex.ToString();

				//Response.Redirect("Page/Glavnaia.aspx");
			}
			conn.Close();

		}

		protected void Login1_LoginError(object sender, EventArgs e)
		{
			// Если состояние LoginErrors не существует, создать его
			if (ViewState["LoginErrors"] == null) 
				ViewState["LoginErrors"] = 0;

			// Увеличить счетчик неудачных попыток входа
			int ErrorCount = (int)ViewState["LoginErrors"] + 1;
			ViewState["LoginErrors"] = ErrorCount;

			// Проверить количество неудачных попыток
			if ((ErrorCount > 3) && (Login1.PasswordRecoveryUrl != string.Empty))
				Response.Redirect(Login1.PasswordRecoveryUrl);
		}
		protected void LoginAction_Click(object sender, EventArgs e)
		{
			string  xlogin = Login1.UserName;
			string  xpass= Login1.Password;
			//Boolean nepizditli = false;
			//sdf.Text = "xlogin";
			//+" and Password="+xpass
			string go ="SELECT * FROM user";
			//Session ["lol"] = go;
			string connStr = "Server=MYSQL5016.myASP.NET;Database=db_9fb8eb_2009;Uid=9fb8eb_2009;Pwd=iyg45HHed7;";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(go, conn);
				cmd.ExecuteNonQuery();
				MySqlDataReader rd = cmd.ExecuteReader();

				while(rd.Read())
				{
					if(rd.GetString (6).ToString()==xlogin)
					{

						FormsAuthentication.RedirectFromLoginPage (xlogin, true);
					}
				}

				rd.Close();

				//Response.Redirect("Page/Glavnaia.aspx");
			}
			catch (Exception ex)
			{
				Session ["lol"]=ex.ToString();
				FormsAuthentication.RedirectFromLoginPage (xlogin, false);
				//Response.Redirect("Page/Glavnaia.aspx");
			}
			conn.Close();

		}

		protected void Registration_cleked(object sender, EventArgs e)
		{
		//	sdf.Text = Session ["lol"].ToString ();
			panelfon2.Visible = true;
			panelfon.Visible = false;

		}
		protected void Auterification_cleked(object sender, EventArgs e)
		{
			//	sdf.Text = Session ["lol"].ToString ();
			panelfon2.Visible = false;
			panelfon.Visible = true;
		}
		protected void Registration2_cleked(object sender, EventArgs e)
		{
			
		//регистрациия
			if (nameText.Text != "" & loginText.Text != "" & PasswdText.Text != "" & NumTelText.Text != "" & ProvText.Text != "") {
				string avatar = "/resource/avatar.jpg";
				if (polText.SelectedValue != "Мужской") {
					 avatar = "/resource/avatar2.jpg";
				} 
				string go = "INSERT INTO user (name, LOGAN, Password, pol, fone,roles,avatar) VALUES ('" + nameText.Text + "','" + loginText.Text + "','" + PasswdText.Text + "','"+polText.SelectedValue+"','" + NumTelText.Text + "','user','" + avatar + "')";
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
					string sql2 = "INSERT INTO user (name, email,date, pol, url, LOGAN, roles, fone)" +
						"VALUES ('"+loginText.Text+"', 'qw@qw.qw', '1535-12-12', 1,'/resource/kot.jpg','"+loginText.Text+"','user', '"+NumTelText.Text+"')";
					MySqlCommand cmd = new MySqlCommand (go, conn);
					cmd.ExecuteNonQuery ();
					conn.Close ();
					//после удачной регистрации переход на страницу пользователя
					 
					go =string.Format("SELECT * FROM user");
					//string go ="SELECT * FROM user WHERE LOGAN";
					//string go = "select * from user WHERE LOGAN";
					connStr = "Server=MYSQL5016.myASP.NET;Database=db_9fb8eb_2009;Uid=9fb8eb_2009;Pwd=iyg45HHed7;";
				    conn = new MySqlConnection(connStr);
					try
					{
						conn.Open();
					    cmd = new MySqlCommand(go, conn);
						cmd.ExecuteNonQuery();
						MySqlDataReader rd = cmd.ExecuteReader();

						while(rd.Read())
						{
							Session ["lol"]=rd.GetString (6).ToString();
							if(rd.GetString (6).ToString()==loginText.Text)
							{
								// Сохраняем параметры пользователя в сессии
								Session ["login"] = loginText.Text;
								Session ["id"] = rd.GetString (0).ToString();
								Session ["roles"] = rd.GetString (7).ToString();
								Session ["postglav"] = "0";
								Session ["pol"] = rd.GetString (4).ToString();

								Session ["avatar"] =rd.GetString (10).ToString();
								Session ["name"] =rd.GetString (1).ToString();
								Session ["karma"] = rd.GetString (11).ToString();
								Session ["podpisan"] = rd.GetString (12).ToString();
								Session ["podpischiki"] = rd.GetString (13).ToString();
								Session ["posts"] =rd.GetString (17).ToString();

								Session ["date"] = rd.GetString (2).ToString();
								Session ["countri"] = rd.GetString (14).ToString();
								Session ["toun"] = rd.GetString (15).ToString();
								Session ["work"] = rd.GetString (16).ToString();

								Session ["lenta"] =  "0";
								Session ["lol"] = "был";
								Response.Redirect("Page/MyPage.aspx?ID="+Session ["id"].ToString());
							}
						}

						rd.Close();

					}
					catch (Exception ex)
					{
						Session ["lol"]=ex.ToString();

						//Response.Redirect("Page/Glavnaia.aspx");
					}
					conn.Close();

				} 
				catch (Exception ex) 
				{
					NumTel.Text = ex.ToString ();
				}
				conn.Close ();
			}
			else
			{
				login2.Text = "opa";

			}
		}

	}
}
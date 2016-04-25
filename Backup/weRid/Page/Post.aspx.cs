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
	
	public partial class Post : System.Web.UI.Page
	{
		public void Page_Load (object sender, EventArgs args)
		{
			// Проверить достоверность предыдущей страницы        
			if (PreviousPage != null)        
			{            
				if (!PreviousPage.IsValid)            
				{                
					// Отобразить сообщение об ошибке           
				}           
				else            
				{                
					if (PreviousPage != null)       
					{
						//work.Text = Request.QueryString["recordID"]; 
						Session ["idPost"] = Request.QueryString["ID"];

					}
				}
			}
		}
		protected void Page_Init(object sender, EventArgs e)
		{
			if (Session ["name"] != null) {

				Session ["idPost"]=Request.QueryString["ID"];
				//tip.Text =  Session ["idPost"].ToString();

				string go = "select * from post WHERE id=" + Session ["idPost"].ToString();
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

						// Сохраняем параметры пользователя в сессии
						Session ["text"] =  rd.GetString (2).ToString();
						Session ["zaglav"] = rd.GetString (3).ToString();
						Session ["pros"] = rd.GetString (11).ToString();
						Session ["tip"] = rd.GetString (12).ToString();

					}
					rd.Close();

				}
				catch (Exception ex)
				{


				}
				conn.Close();
				if (Session ["name"] != null) {
					name.Text = Session ["login"].ToString ();

					avatar.ImageUrl = Session ["avatar"].ToString ();

				} 
				else
				{
					Response.Redirect("../Default.aspx"); 
				}
				//text.Text =Session ["text"].ToString();
				//Zaglav.Text = Session ["zaglav"].ToString()+"  ";
				//tip.Text =" ("+Session ["tip"].ToString()+")";
		

			} 
			else
			{
				Response.Redirect("../Default.aspx"); 
			}
		}


		[WebMethod]
		public static string Zapros_Page()
		{   
			//	if (!IsPostBack) {
			//Validate();
			//TextBoxPoisk.Text ="go";
			//создаем набор лист стиргов для класса сериализации
			List<string> urlcaptcha = new List<string> ();
			List<string> zaglav = new List<string> ();
			List<string> avtoravatar = new List<string> ();
			List<string> textkratk = new List<string> ();
			List<string> avtorname = new List<string> ();
			List<string> avtorid = new List<string> ();
			List<string> reitpost = new List<string> ();
			List<string> prosmotrov = new List<string> ();
			//int lenta = Convert.ToInt32(Session["postglav"].ToString());
			int lenta = 0;
			string go = "select MAX(id) from post";
			int i = 0;
			string connStr = "Server=MYSQL5016.myASP.NET;Database=db_9fb8eb_2009;Uid=9fb8eb_2009;Pwd=iyg45HHed7;";
			//подключаемся к бд
			MySqlConnection conn = new MySqlConnection (connStr);
			try {
				//TextBoxPoisk.Text ="Connecting to MySQL...";
				conn.Open ();
				//ищим последнюю запись
				MySqlCommand cmd = new MySqlCommand (go, conn);
				cmd.ExecuteNonQuery ();
				MySqlDataReader rd = cmd.ExecuteReader ();
				rd.Read ();
				//от последнего id вычитаем 12 что бы потом взять последни 12 записей
				i = Convert.ToInt32 (rd.GetString (0)) - 12;
				lenta = Convert.ToInt32(rd.GetString (0))-lenta;
				rd.Close ();
				//берем последних 12 записей
				string strSQL = "select * from post WHERE id>" + i +" And id<="+lenta;
				//string sql = "INSERT INTO post (avtor, text,zaglav, textkratk, karma, urlpictche, urlvideo, date)" +
				//"VALUES ('Ivanov', 'teeeext', 'zaglav', 'в кратце че то тут произошло','234','/resource/kot.jpg','/resource/kot.jpg', 2012-11-11)";
				cmd = new MySqlCommand (strSQL, conn);
				cmd.ExecuteNonQuery ();
				rd = cmd.ExecuteReader ();
				//rd.Read();
				while (rd.Read ()) {
					//TextBoxPoisk.Text = rd.GetString(6);
					//заполняем наши листы
					urlcaptcha.Add (rd.GetString (6));
					zaglav.Add (rd.GetString (3));
					avtoravatar.Add (rd.GetString (9));
					textkratk.Add (rd.GetString (4));
					avtorid.Add (rd.GetString (1));
					reitpost.Add(rd.GetString (10));
					prosmotrov.Add(rd.GetString (11));
				}
				rd.Close ();
				conn.Close ();
				conn.Open ();

				//в таблице юсеров ищем сходства по id
				for (int j = 0; j < avtorid.Count; j++) {
					go = "select * from user WHERE id=" + Convert.ToInt32 (avtorid [j]);
					cmd = new MySqlCommand (go, conn);
					cmd.ExecuteNonQuery ();
					rd = cmd.ExecuteReader ();
					rd.Read ();
					//TextBoxPoisk.Text +=rd.GetString(1);
					avtorname.Add (rd.GetString (1));					
					rd.Close ();
				}

			}
			catch (Exception ex)
			{
				//TextBoxPoisk.Text = ex.ToString ();
			}
			conn.Close ();

			jsonobjkt dave = new jsonobjkt ();
			dave.urlcaptcha = urlcaptcha;
			dave.zaglav = zaglav;
			dave.avtoravatar = avtoravatar;
			dave.textkratk = textkratk;
			dave.avtorname = avtorname;
			dave.reitpost = reitpost;
			dave.prosmotrov = prosmotrov;
			JavaScriptSerializer jss = new JavaScriptSerializer ();
			string json = jss.Serialize (dave);

			//	news (4, 3, json);
			//Session ["postglav"]=Convert.ToString(textkratk.Count+lenta);

			return json;
		}

		public void dynamicButton_Click (object sender, EventArgs args)
		{
			string ctrlName = ((Control)sender).ID;
			TextBoxPoisk.Text =ctrlName;
		}
		public void glbutton_cleked(object sender, EventArgs args)
		{
			Response.Redirect("Glavnaia.aspx"); 
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


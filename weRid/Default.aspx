<%@ Page Language="C#" Inherits="weRid.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">

<head runat="server">
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
 <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1/jquery-ui.min.js"></script>
  <script type="text/javascript" src="../js/go.js"></script>
	<title>Default</title>
    <link rel="stylesheet" type="text/css" href="/css/login.css" />
</head>
<body>
	<form id="form1" runat="server"    defaultfocus="Login1" >
       <asp:Panel id="panelfon1"  runat="server" CssClass="panelfon1">
          <asp:Button id="Registration" class="Registration" runat="server"  Text="Регестрация" OnClick="Registration_cleked"/>
          <asp:Button id="Auterification" class="Auterification" runat="server"  Text="Вход" OnClick="Auterification_cleked" />
          <asp:Panel id="panelfon"  runat="server" CssClass="panelfon">
             <asp:Button id="Registration" class="Registration" runat="server"  Text="Регестрация" OnClick="Registration_cleked"/>
          <asp:Button id="Auterification" class="Auterification" runat="server"  Text="Вход" OnClick="Auterification_cleked" />
          <asp:Panel id="panelfon"  runat="server" CssClass="panelfon"  defaultfocus="Auterification2">
                 <asp:Label id="LableZaglav" runat="server"  CssClass="TextLog" text="Пожалуйста введите данные для регистрации" />
	             <asp:Label id="LableLogin" runat="server"  CssClass="login2" text="Логин" />
	             <asp:TextBox id="TextLogin"  runat="server"  CssClass="loginText"   defaultfocus="Auterification2" />
	             <asp:Label id="LablePasswd" runat="server"  CssClass="Passwd" text="Пароль" />
	             <asp:TextBox id="TextPasswd"  runat="server"  CssClass="PasswdText"   defaultfocus="Auterification2" />
	             <asp:Button id="Auterification2" class="Registration2" runat="server"  Text="Вход" OnClick="LoginAction_Click"/>
	      </asp:Panel>
	      <asp:Panel id="panelfon2"  runat="server" CssClass="panelfon2">
	             <asp:Label id="TextReg" runat="server"  CssClass="TextReg" text="Пожалуйста введите данные для регистрации" />
	             <asp:Label id="name2" runat="server"  CssClass="name2" text="Имя" />
	             <asp:TextBox id="nameText"  runat="server"  CssClass="nameText"  />
	             <asp:Label id="login2" runat="server"  CssClass="login2" text="Логин" />
	             <asp:TextBox id="loginText"  runat="server"  CssClass="loginText"  />
	             <asp:Label id="Passwd" runat="server"  CssClass="Passwd" text="Пароль" />
	             <asp:TextBox id="PasswdText"  runat="server"  CssClass="PasswdText"/>
	             <asp:Label id="Passwd2" runat="server"  CssClass="Passwd2" text="введите пароль еще раз" />
	             <asp:TextBox id="PasswdText2"  runat="server"  CssClass="PasswdText2" />
	             <asp:Label id="pol" runat="server"  CssClass="pol" text="Пол" />
	             <asp:DropDownList id="polText" CssClass="polText" runat="server"> 
                    <asp:ListItem Selected="true">Мужской</asp:ListItem>
                    <asp:ListItem>Женский</asp:ListItem>
                 </asp:DropDownList>
	             <asp:Label id="NumTel" runat="server"  CssClass="NumTel" text="Номер телефона" />
	             <asp:TextBox id="NumTelText"  runat="server"  CssClass="NumTelText"  />
	             <asp:Label id="Prov" runat="server"  CssClass="Prov" text="Введите цифры с картики" />
	             <asp:ImageButton id="Prov2" AlternateText=" " class="Prov2" runat="server" Text="" />
	             <asp:TextBox id="ProvText"  runat="server"  CssClass="ProvText"  />
	             <asp:Button id="Registration2" class="Registration2" runat="server"  Text="Регистрация" OnClick="Registration2_cleked"/>

	      </asp:Panel>
	   </asp:Panel>

	</form>
</body>
</html>

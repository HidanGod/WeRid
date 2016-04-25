<%@ Page Language="C#" Inherits="weRid.PostCreated" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<head runat="server">
	<title>Default</title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.0.7/angular.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.3/jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="../css/PostCreated.css" />
    <link rel="stylesheet" type="text/css" href="../css/menu.css" />
    <script type="text/javascript" src="../js/size.js"></script>
     <script type="text/javascript" src="../js/upload.js"></script>
</head>
<body>
<form id="form1" runat="server"  class="form" >
 <div id="wrapper">
  <div class="block">1</div>
  </div>
  <asp:scriptmanager runat="server" id="scriptManager" EnablePageMethods="true">  
</asp:scriptmanager> 

      
        <asp:Panel ID="Paneltopmenu" class="Paneltopmenu" runat="server">
          <asp:ImageButton id="poisk" class="poisk" runat="server"  Text="" src="/resource/lupa.jpg" alt=" " OnClick="poisk_cleked"/>
          <input type="hidden" id="myHiddenField" name="myHiddenField" value="value before" />
          <asp:ImageButton id="avatar" AlternateText=" " class="avatar" runat="server" Text=""  OnClick="avatar_cleked"/>
          <asp:ImageButton id="exit1" class="exit" runat="server"  Text="exit" src="/resource/exit.gif" alt=" " OnClick="exit_cleked"/>
          <asp:TextBox id="TextBoxPoisk" class="TextBoxPoisk" runat="server" Text="" onfocus="clearSearchInput(this)" onblur="resetSearchInput(this)"/>
          <asp:LinkButton id="name" class="name" runat="server"  Text="Вася" OnClick="name_cleked" />
          <asp:ImageButton id="logo" class="logo" AlternateText=" " runat="server" Text="" src="/resource/logo.jpg" alt=" " OnClick="logo_cleked"/>
       </asp:Panel> 
       <asp:Panel ID="Panelmenu" class="panel" runat="server">
          <asp:Button id="glbutton" class="glbutton" runat="server"  Text="Главная" OnClick="glbutton_cleked"/>
          <asp:Button id="mypage" class="mypage" runat="server"  Text="Моя страница" OnClick="mypage_cleked" />
          <asp:Button id="MyPosts" class="MyPosts" runat="server"  Text="Мои посты" OnClick="MyPosts_cleked"/>
   
       </asp:Panel> 
          
       <asp:ImageButton id="add" class="add" AlternateText=" " runat="server" Text="" OnClick="add_cleked"/>
       <asp:Panel ID="MainPanel" class="MainPanel" runat="server">
          <asp:label ID="CreatPostText" class="CreatPostText" runat="server"  Text="Создать пост"/>  
          <asp:ImageButton id="PostPictche" AlternateText=" " class="PostPictche" src="/resource/kot.jpg" alt=" "  runat="server" Text=""/>


          <INPUT type=file id=File1 name=File1 runat="server" class="PostPictcheLoad">
          <input type="submit" id="Submit1" value="Загрузить" runat="server" NAME="Submit1" class="PostPictcheLoad1">
   
          <asp:label ID="TipePost" class="TipePost" runat="server"  Text="Тип: "/>   
          <asp:DropDownList id="Tipi" CssClass="Tipi" runat="server"> 
              <asp:ListItem Selected="true">Помощь</asp:ListItem>
              <asp:ListItem>Просьба</asp:ListItem>
          </asp:DropDownList>
          <asp:label ID="ZaglavPost" class="ZaglavPost" runat="server"  Text="Загаловок: "/> 
          <asp:TextBox id="TextZglavPosta" class="TextZglavPosta" runat="server" Text=""/>  
          <asp:label ID="TextPostaLable" class="TextPostaLable" runat="server"  Text="Текст: "/> 
          <TextArea id="TextPosta" class="TextPosta" runat="server" TextWrapping="Wrap" Padding="5" AutoWordSelection="True" Text=""/>  
          <asp:label ID="KratkText" class="KratkText" runat="server"  Text="Краткое содержание поста"/>   
          <TextArea id="KratkTextPosta" class="KratkTextPosta" runat="server" Text=""/>
          <asp:label ID="RazdelPosta" class="RazdelPosta" runat="server"  Text="Раздел"/>   
          <asp:TextBox id="RazdelPostaText" class="RazdelPostaText" runat="server" Text=""/>
          <asp:Panel ID="botPanelbutton" class="botPanelbutton" runat="server" >      
             <asp:ImageButton id="logo1" AlternateText=" " class="logo1" runat="server" Text=""  OnClick="logo1_cleked"/>
             <asp:label ID="info123" class="info" runat="server"  Text="создатели"/>    
          </asp:Panel> 
       </asp:Panel>
        <asp:Button id="PostCreat" class="PostCreat" runat="server"  Text="Создать пост" OnClick="PostCreat_cleked"/>
	</form>
</body>
</html>


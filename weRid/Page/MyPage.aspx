<%@ Page Language="C#" Inherits="weRid.MyPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<head >
	<title>Default</title>

    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.0.7/angular.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.3/jquery.min.js"></script>

	<script type="text/javascript" src="../js/MyPage.js"></script>
	<script type="text/javascript" src="../js/size.js"></script>

    <link rel="stylesheet" type="text/css" href="../css/menu.css" />
     <link rel="stylesheet" type="text/css" href="../css/mypage.css" />

</head>
<body>

	<form id="form1" runat="server" class="form" >
	   <asp:ScriptManager runat="server" EnablePageMethods="true" />
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
          <asp:Button id="mypage" class=" mypage" runat="server"  Text="Моя страница" OnClick="mypage_cleked" />
          <asp:Button id="MyPosts" class="MyPosts" runat="server"  Text="Мои посты" OnClick="MyPosts_cleked"/>
        
       </asp:Panel> 
       <asp:Label id="hiden" runat="server"  Text="0"/> 
       <asp:Panel ID="MainPanel" class="MainPanel" runat="server">
            <asp:ImageButton id="Foto" class="Foto1" AlternateText=" " runat="server" Text="" OnClick="Foto_cleked"/>
            <asp:Panel ID="infoPolzovat" class="infoPlzovat" runat="server" >      
               <asp:label ID="name1" class="name1" runat="server"  Text="Василий Алибабаевич"/>  
               <asp:label ID="karma" class="karma" runat="server"  Text="Карма: over999"/> 
               <asp:label ID="podpisan" class="podpisan" runat="server"  Text="podpisan: over999"/>  
               <asp:label ID="podpischiki" class="podpischiki" runat="server"  Text="podpischiki: over999"/>  
               <asp:label ID="posts" class="posts" runat="server"  Text="posts: over999"/>   
            </asp:Panel> 
            <asp:Panel ID="infoLichnaya" class="infoLichnaya" runat="server"  >  
               <asp:label ID="infoLichnayatext" class="infoLichnayatext" runat="server"  Text="Личная информация"/>      
               <asp:label ID="date" class="date" runat="server"  Text="09.09.1993"/>  
               <asp:label ID="countri" class="countri" runat="server"  Text="Россия"/>  
               <asp:label ID="toun" class="toun" runat="server"  Text="Ростов"/> 
               <asp:label ID="work" class="work" runat="server" /> 
               <asp:LinkButton id="izmenit" class="izmenit" runat="server"  Text="Изменить" OnClick="name_cleked" />
            </asp:Panel>

               <asp:label ID="posttabletext" class="posttabletext" runat="server"  Text="посты"/>      
                <table id="table1"  class="table">
                </table>
          <asp:Panel ID="botPanelbutton" class="botPanelbutton" runat="server" >      
             <asp:ImageButton id="logo123" AlternateText=" " class="logo1" runat="server" Text="" />
             <asp:label ID="info1" class="info" runat="server"  Text="создатели"/>    
          </asp:Panel> 
       </asp:Panel>


	</form>
</body>
</html>


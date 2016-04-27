<%@ Page Language="C#" Inherits="weRid.PostRedaction" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<head runat="server">
	<title>Default</title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.0.7/angular.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.3/jquery.min.js"></script>
    <script type="text/javascript" src="../js/size.js"></script>
    <link rel="stylesheet" type="text/css" href="../css/PostRedaction.css" />
    <link rel="stylesheet" type="text/css" href="../css/menu.css" />
    <link rel="stylesheet" type="text/css" href="../css/buton.css" />
</head>
<body>
<form id="form1" runat="server"  class="form" >
	  <asp:scriptmanager runat="server" id="scriptManager" EnablePageMethods="true">  
      </asp:scriptmanager> 
	   <asp:Button id="PostSave" class="PostCreat" runat="server"  Text="Сохранить" />  
	   <asp:label ID="zaglavpage" class="zaglavpage" runat="server"  Text="Редактировать"/>    
      <asp:Panel ID="Paneltopmenu" class="Paneltopmenu" runat="server">
          <asp:ImageButton id="poisk" class="poisk" runat="server"  Text="" src="/resource/lupa.jpg" alt=" " OnClick="poisk_cleked"/>
          <input type="hidden" id="myHiddenField" name="myHiddenField" value="value before" />
          <asp:ImageButton id="avatar" AlternateText=" " class="avatar" runat="server" Text=""  OnClick="avatar_cleked"/>
          <asp:ImageButton id="exit1" class="exit" runat="server"  Text="exit" src="/resource/exit.gif" alt=" " OnClick="exit_cleked"/>
          <asp:TextBox id="TextBoxPoisk" class="TextBoxPoisk" runat="server" Text="" onfocus="clearSearchInput(this)" onblur="resetSearchInput(this)"/>
          <asp:LinkButton id="name" class="name" runat="server"  Text="Вася" OnClick="name_cleked" />
          <asp:ImageButton id="logo" class="logo" AlternateText=" " runat="server" Text="" src="/resource/logo.jpg" alt=" " OnClick="logo_cleked"/>
       </asp:Panel> 
       <asp:ImageButton id="add" class="add" AlternateText=" " runat="server" Text="" OnClick="add_cleked"/>
       <asp:Panel ID="Panelmenu" class="panel" runat="server">
          <asp:Button id="glbutton" class="glbutton" runat="server"  Text="Главная" OnClick="glbutton_cleked"/>
          <asp:Button id="mypage" class="mypage" runat="server"  Text="Моя страница" OnClick="mypage_cleked" />
          <asp:Button id="MyPosts" class="MyPosts" runat="server"  Text="Мои посты" OnClick="MyPosts_cleked"/>
         
       </asp:Panel> 
       <asp:Panel ID="MainPanel" class="MainPanel1" runat="server">

           <asp:Panel ID="page2" class="page2" runat="server">
           <asp:ImageButton id="DopInfo" class="DopInfo" AlternateText="дополнительная информация" runat="server" Text=""/>
           <asp:CheckBox id="PostClose"  class="PostClose" runat="server" Text="Пост закрыт"/>
           <asp:label ID="LableAdd" class="LableAdd" runat="server"  Text="добавить учасников"/>   
           <textarea id="TextBoxAdd" class="TextBoxAdd" runat="server" Text=""/> 
           <asp:label ID="LableOpis" class="LableOpis" runat="server"  Text="описание сделанного"/>   
           <textarea id="TextBoxOpis" class="TextBoxOpis" runat="server" Text=""/> 
           <asp:label ID="LableAddFile" class="LableAddFile" runat="server"  Text="Прикрепить файл"/>
           </asp:Panel>
           <asp:Panel ID="botPanelbutton" class="botPanelbutton" runat="server" >      
              <asp:ImageButton id="logo1" AlternateText=" " class="logo1" runat="server" Text=""  OnClick="logo1_cleked"/>
              <asp:label ID="info123" class="info" runat="server"  Text="создатели"/>    
           </asp:Panel> 
       </asp:Panel>


	</form>
</body>
</html>


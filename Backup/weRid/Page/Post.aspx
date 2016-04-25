<%@ Page Language="C#" Inherits="weRid.Post" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<head runat="server">
	<title>Default</title>
	<script type="text/javascript" src="../js/size.js"></script>
    <link rel="stylesheet" type="text/css" href="../css/Post.css" />
    <link rel="stylesheet" type="text/css" href="../css/menu.css" />

   
</head>
<body>
<form id="form1" runat="server" class="form" >
  <div id="wrapper">
  <div class="block">1</div>
  </div>
  <asp:scriptmanager runat="server" id="scriptManager" EnablePageMethods="true">  
  </asp:scriptmanager> 
  <table id="table1" class="table">
  </table>
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
       <asp:Panel ID="MainPanel" class="MainPanel" runat="server">
          <asp:Panel ID="PostPart1" class="PostPart1" runat="server" >     
              <asp:label ID="Zaglav" class="Zaglav" runat="server"  Text="Загаловок"/>
              <asp:label ID="Tip" class="Tip" runat="server"  Text="(помощь)"/> 
              <asp:label ID="Prosmotrov" class="Prosmotrov" runat="server"  Text="Просмотров: 23"/>
              <asp:label ID="DataPosta" class="DataPosta" runat="server"  Text="Дата: 09.09.2015"/>
              <asp:ImageButton id="LikeImag" class="LikeImag" AlternateText=" " runat="server" Text=""  src="/resource/321.png" alt=" " />  
              <asp:label ID="LikeKall" class="LikeKall" runat="server"  Text="243"/>
              <asp:Panel ID="Postpikche" class="Postpikche" runat="server" >  
              </asp:Panel>  
              <asp:ImageButton id="AvtorImag" class="AvtorImag" AlternateText=" " runat="server" Text="" src="/resource/avatar.jpg" alt=" "/>  
              <asp:label ID="AvtorLable" class="AvtorLable" runat="server"  Text="автор"/>
              <asp:label ID="ReitAvtora" class="ReitAvtora" runat="server"  Text="Рейтинг: 23"/>
              <asp:ImageButton id="HeitImag" class="HeitImag" AlternateText="Пожаловаться" runat="server" Text=""/>  
          </asp:Panel>
          <asp:Panel ID="PostPart2" class="PostPart2" runat="server" >     
          <asp:label ID="TextPosta" class="TextPosta" runat="server"  Text="ттексттексттексттексттексттексттексттексттексттексттексттексттексттексттетексттексттексттексттексттексттексттексттексттексттексттексттексттексттеексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттекст"/>
          </asp:Panel>
          <asp:ImageButton id="ClosePost" class="ClosePost" AlternateText="OPEN" runat="server" Text=""/>  
          <asp:Panel ID="PostPart3" class="PostPart3" runat="server" >  
              <asp:label ID="Helper" class="Helper" runat="server"  Text="Участники"/>   
              <asp:label ID="ListHelper" class="ListHelper" runat="server"  Text="дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля, дима, коля"/>  
              <asp:Panel ID="HelperPikche" class="HelperPikche" runat="server" >  
              </asp:Panel>  
          </asp:Panel>
           <asp:Panel ID="PostPart4" class="PostPart2" runat="server" >     
          <asp:label ID="TextHelper" class="TextPosta" runat="server"  Text="ттексттексттексттексттексттексттексттексттексттексттексттексттексттексттетексттексттексттексттексттексттексттексттексттексттексттексттексттексттеексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттексттекст"/>
          </asp:Panel>
          <asp:Panel ID="PostPart5" class="PostPart5" runat="server" > 
              <asp:label ID="Koment" class="Koment" runat="server"  Text="Коментарии"/>   
              <asp:ImageButton id="KomentAvtorImag" class="KomentAvtorImag" AlternateText=" " runat="server" Text="" src="/resource/avatar.jpg" alt=" "/>
              <TextArea ID="KomentText" class="KomentText" runat="server"  Text=""/>   
          </asp:Panel>
          <asp:Panel ID="PostPart6" class="PostPart6" runat="server" >  
          </asp:Panel>
          <asp:Panel ID="botPanelbutton" class="botPanelbutton" runat="server" >      
             <asp:ImageButton id="logo1" AlternateText=" " class="logo1" runat="server" Text=""  OnClick="logo1_cleked"/>
             <asp:label ID="info123" class="info" runat="server"  Text="создатели"/>    
          </asp:Panel> 
       </asp:Panel>

      
	</form>
</body>

</html>

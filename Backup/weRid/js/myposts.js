$(document).ready(function (){
	         window.onload = function ()
		 {
		// sessionStorage['id'] = 'value';

	
	//	set_cookie ( "userName", "Vasya" );
		var id = get_cookie("IdAvtora");
	   //id.text = '54';
		//var session_view = ".$_SESSION['id'].";
		//var id = Call("id","1"); 
       // alert(id);
		PageMethods.Zapros_Page(id, CallServerResult);


		 // возвращает cookie с именем name, если есть, если нет, то undefined
       function get_cookie(name)
          {
             var matches = document.cookie.match(new RegExp( "(?:^|; )" + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + "=([^;]*)"));
             return matches ? decodeURIComponent(matches[1]) : undefined;
          }

          }

    function CallServerResult(result) {       
    user = JSON.parse(result);
    var go = calljson(user);
    //alert(go);
    var schet=0;
    for (var j=0; j<(go); j++) 
	{
    //var tr = document.getElementById('tr11'); //берем первую строку
	var table = document.getElementById('table1');
	    table.className = 'table';
	var tr = document.createElement('tr'); //создаем еще строку
		tr.className = 'cell';
  

	//таблица
    var td = document.createElement('td'); //создаем столбец
		td.className = 'cell';
		tr.appendChild(td);
    //панель в ячейке
	var div1 = document.createElement('div'); 
	    $(div1).addClass("newPanel");
	    td.appendChild(div1); 
	//загаловок
    var LinkButtonZaglav = document.createElement('LinkButton'); 
        LinkButtonZaglav.innerHTML =  user.zaglav[schet];
        LinkButtonZaglav.onclick = function(){document.location.href='PostRedaction.aspx'; };
        $(LinkButtonZaglav).addClass("zagalovok");
        div1.appendChild(LinkButtonZaglav);
    // тип поста
    var LableTip = document.createElement('label');  
        LableTip.innerHTML = "   ("+ user.tip[schet]+")";
        $(LableTip).addClass("Tip");
        div1.appendChild(LableTip);
    //удалить
    var ImageDelitePost = document.createElement('ImageButton'); 
        ImageDelitePost.onclick = function(){alert('Test23')};     
        $(ImageDelitePost).addClass("ImageDelitePost");
        div1.appendChild(ImageDelitePost);
    //редактировать
    var ImageRedaktirovatPost = document.createElement('ImageButton'); 
        ImageRedaktirovatPost.onclick = function(){document.location.href='PostRedaction.aspx'; };
        $(ImageRedaktirovatPost).addClass("ImageRedaktirovatPost");
        div1.appendChild(ImageRedaktirovatPost);
    //картинка поста
      var ImagePanelPost = document.createElement('ImageButton'); 
        ImagePanelPost.onclick = function(){alert('Test23')};      
        $(ImagePanelPost).addClass("pictche1");
        div1.appendChild(ImagePanelPost);
    var ImageButtonPost = document.createElement('img'); 
        ImageButtonPost.onclick = function(){alert('Test22')};
        ImageButtonPost.style.background =("url("+ user.urlcaptcha[schet] +") no-repeat");
        $(ImageButtonPost).addClass("pictche");
        ImagePanelPost.appendChild(ImageButtonPost);

    // количество просмотров
    var LablePros = document.createElement('label');  
        LablePros.innerHTML = "Просмотров: "+user.prosmotrov[schet];
        $(LablePros).addClass("prosmotrLabel");
        div1.appendChild(LablePros);
    // рейтинг поста
    var LableReit = document.createElement('label');  
        LableReit.innerHTML =  "карма: "+user.reitpost[schet];
        $(LableReit).addClass("reitLabel");
        div1.appendChild(LableReit);

    //текст поста
	var LinkButtonText = document.createElement('LinkButton');  
        LinkButtonText.innerHTML =  user.textkratk[schet];
        LinkButtonText.onclick = function(){alert('Test4')};
        $(LinkButtonText).addClass("textnews");
        div1.appendChild(LinkButtonText);   
     //привавляем +1 к счетчику вывода постов
        schet++;
	     //кладем в новосозданную строку первый новосозданный столбец
	
    //каждый раз футер приккрепляем к низу
	var documentHeight = $(document).height();
	var documentWidth = $(document).width();
	var MainPanel = document.getElementById("MainPanel");
	//MainPanel.style.width = documentWidth+"px";
	MainPanel.style.height = documentHeight-25+"px";
	MainPanel.style.background =("url('/resource/sky.jpg') no-repeat");
    // alert("Размер вьюпорта: "+ documentWidth +"х"+ documentHeight);
    var botPanelbutton = document.getElementById("botPanelbutton");
    botPanelbutton.style.top = documentHeight-150+"px";
    botPanelbutton.style.height = "150 px";
    botPanelbutton.style.width = documentWidth-25+" px";


	    table.appendChild(tr); //кладем в таблицу новосозданную строку (последней)
	    }
	 //считаем количество полученых постов
     function calljson(user)
       {
       var i=0;
	      while(user.reitpost[i])
            {
               i++;
            }          
	     return i;
	   }
   }


	}

		

	);


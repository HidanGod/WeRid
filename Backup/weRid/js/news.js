$(document).ready(function (){
	   $(window).scroll(function(){
	   var windowScroll = $(window).scrollTop();
	   var windowHeight = $(window).height();
	   var documentHeight = $(document).height();
	   //console.log(windowScroll +" " +windowHeight+" "+documentHeight);

	   if((windowScroll + windowHeight)>=(documentHeight-100))
	    {
	     
		  var lenta = get_cookie("Lenta");
		  // alert(lenta);
		  PageMethods.Zapros_Page(lenta, CallServerResult);
	    }
	   });
	   function getRandomInt(min,max)
	   {
	     return Math.floor(Math.random()*(max-min +1))+min;
	   }
	   function get_cookie(name)
          {
             var matches = document.cookie.match(new RegExp( "(?:^|; )" + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + "=([^;]*)"));
             return matches ? decodeURIComponent(matches[1]) : undefined;
          }
    function CallServerResult(result) {       
    user = JSON.parse(result);
    var go = calljson(user);
    //alert(go);
   
    var schet=0;
     if(go>1){
    for (var j=0; j<(go/3); j++) 
	{

    //var tr = document.getElementById('tr11'); //берем первую строку
	var table = document.getElementById('table1');
	    table.className = 'table';
	var tr = document.createElement('tr'); //создаем еще строку
		tr.className = 'cell';
  
		for (var i=0; i<3; i++) 
	{
	 if(user.idposta[schet]!=null){
	 var lenta = get_cookie("Lenta");
        lenta = sum(lenta,"1");
	  // alert(lenta);
	
	    document.cookie = 'Lenta='+lenta;
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
        LinkButtonZaglav.innerHTML =  user.idposta[schet];
        LinkButtonZaglav.id = user.idposta[schet];
        //alert(user.idposta[schet]);
        LinkButtonZaglav.onclick = function(){document.location.href='Post.aspx?ID='+this.id; };
        $(LinkButtonZaglav).addClass("zagalovok");
        div1.appendChild(LinkButtonZaglav);
    //картинка поста
    var ImageButtonPost = document.createElement('ImageButton'); 
        ImageButtonPost.id = user.idposta[schet];
        ImageButtonPost.onclick =function(){document.location.href='Post.aspx?ID='+this.id;  };
        ImageButtonPost.style.background =("url("+ user.urlcaptcha[schet] +") no-repeat");
        $(ImageButtonPost).addClass("pictche");
        div1.appendChild(ImageButtonPost);
    //аватарка автора
    var ImageButtonAvtor = document.createElement('ImageButton'); 
        ImageButtonAvtor.id = user.idavtor[schet];
        ImageButtonAvtor.onclick = function(){document.location.href='MyPage.aspx?ID='+this.id;};
        ImageButtonAvtor.style.background =("url("+ user.avtoravatar[schet] +") no-repeat");
        $(ImageButtonAvtor).addClass("avtorpictche");
        div1.appendChild(ImageButtonAvtor);
    // имя автора
    var LinkButtonAvtor = document.createElement('LinkButton');  
        LinkButtonAvtor.innerHTML = lenta;
        LinkButtonAvtor.id = user.idavtor[schet];
        LinkButtonAvtor.onclick = function(){document.location.href='MyPage.aspx?ID='+this.id;};
        $(LinkButtonAvtor).addClass("avtorLabel");
        div1.appendChild(LinkButtonAvtor);   
    //рейтинг автора
    var LableReitAvtor = document.createElement('label');  
        LableReitAvtor.innerHTML = "карма: "+user.reitpost[schet];
        $(LableReitAvtor).addClass("karmaavtorLabel");
        div1.appendChild(LableReitAvtor);
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
        LinkButtonText.id = user.idposta[schet];
        LinkButtonText.onclick =function(){document.location.href='Post.aspx?ID='+this.id; };
        $(LinkButtonText).addClass("textnews");
        div1.appendChild(LinkButtonText);   
         }
     //привавляем +1 к счетчику вывода постов
        schet++;
      
	     //кладем в новосозданную строку первый новосозданный столбец
	}

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
	      var lenta = get_cookie("Lenta");
	 
	    }
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
	  //сложение 2х чисел
	    function sum(a,b)
             {
         var z = Number (a) + Number (b);
         return z;
	   }
   }


	}

		

	);

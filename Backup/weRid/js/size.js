$(document).ready(function()
  {
 //каждый раз футер приккрепляем к низу
	var documentHeight = $(document).height();
	var documentWidth = $(document).width();
	var MainPanel = document.getElementById("MainPanel");
	//MainPanel.style.width = documentWidth+"px";
	MainPanel.style.height = documentHeight-25+"px";
	var leftotstp =(documentWidth-220-1000)/2+220;
	MainPanel.style.left = leftotstp+"px";
	MainPanel.style.background =("url('/resource/sky.jpg')");
    // alert("Размер вьюпорта: "+ documentWidth +"х"+ documentHeight);
    var botPanelbutton = document.getElementById("botPanelbutton");
    botPanelbutton.style.top = documentHeight-150+"px";
    botPanelbutton.style.height = "150 px";
    botPanelbutton.style.width = documentWidth-25+" px";
  });

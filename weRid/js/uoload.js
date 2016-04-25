function upload(file) {
 
  // файл из тега <input> или из Drag'n Drop
  // Является ли файл изображением?
 
  if (!file || !file.type.match(/image.*/)) return;
 
  // Это оно!
  // Создаём объект FormData
 
  var fd = new FormData();
  fd.append("image", file); // Append the file
  fd.append("key", "6528448c258cff474ca9701c5bab6927");
  // Получите собственный ключ: http://api.imgur.com/
 
  // Сделайте XHR (Cross-Domain XH, чёрт побери!!!)
  var xhr = new XMLHttpRequest();
  xhr.open("POST", "http://api.imgur.com/2/upload.json"); // Boooom!
  xhr.onload = function() {
    // Победа!
    // URL изображения:
    JSON.parse(xhr.responseText).upload.links.imgur_page;
   }
   // Я не рассматривал ошибки, чтобы пример был короче.
   // А сейчас отправляем formdata
   xhr.send(fd);
 }

<?php
$extensions = array('jpeg', 'jpg', 'png', 'gif');
$max_size = 500000;
$path = 'img_private/';
$response = '';
if ($_SERVER['REQUEST_METHOD'] === 'POST')
{
  if ($_FILES['image']['size'] > $max_size)
  {
    $response = 'Фото не более 1Мб';
  }
  else
  {
    $ext = strtolower(pathinfo($_FILES['image']['name'], PATHINFO_EXTENSION));
    if (in_array($ext, $extensions))
    {
      $path = $path . uniqid() . '.' . $ext;
 
      if (move_uploaded_file($_FILES['image']['tmp_name'], $path))
      {
        $response = "<img src='$path' />";
      }
    }
    else
    {
      $response = 'Загрузите фото!';
    }
  }
}
 
echo $response;

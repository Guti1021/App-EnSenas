<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);


//recibe los datos de unity, usamos el valor de estas variables
$userID = $_REQUEST['id'];
$nombre = $_REQUEST['nom'];
$dificultad = $_REQUEST['dif'];



  //insertar Valores en la base de datos Bonotes
  $adicionarDatos = mysqli_query($conect, "INSERT INTO ensenasCuento(id,nombre,dificultad) VALUES('$userID','$nombre','$dificultad')");

  echo "adicionado";





//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=1&nom=Animaletras&dif=1
//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=2&nom=1, 2, 3¿Cuántos ves?&dif=1
//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=3&nom=¿Cómo se Llama?&dif=2
//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=4&nom=Son tantas cosas&dif=2
//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=5&nom=Aquí veo&dif=2
//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=6&nom=Insectopedia&dif=2
//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=7&nom=Profesiones y oficios&dif=3
//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=8&nom=Oficios y profesiones en punto de cruz&dif=3
//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=9&nom=A la cama&dif=4
//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirCuento.php?id=10&nom=150 actividades para niños y niñas de 3 años&dif=4


?>


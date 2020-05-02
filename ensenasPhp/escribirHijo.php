<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);


//recibe los datos de unity, usamos el valor de estas variables
//$userID = $_REQUEST['id'];
$fkIdPapa=$_REQUEST['fkIdPa'];
$nombre = $_REQUEST['nom'];
$edad = $_REQUEST['eda'];




  //insertar Valores en la base de datos Bonotes
  $adicionarDatos = mysqli_query($conect, "INSERT INTO ensenasHijos(fkidPapa,nombre,edad) VALUES('$fkIdPapa','$nombre','$edad')");

  echo "adicionado";





//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirHijo.php?id=1&fkIdPa=1&nom=Amy&eda=10


?>


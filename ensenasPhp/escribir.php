d<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);


//recibe los datos de unity, usamos el valor de estas variables
$userID = $_REQUEST['id'];
$nombre = $_REQUEST['nom'];
$apellido = $_REQUEST['ape'];
$edad = $_REQUEST['eda'];



  //insertar Valores en la base de datos Bonotes
  $adicionarDatos = mysqli_query($conect, "INSERT INTO ensenasPapa(id,nombre,apellido,edad) VALUES('$userID','$nombre','$apellido','$edad')");

  echo "adicionado";





//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribir.php?id=1&nom=Christian&ape=Guti&eda=10
//localhost/ensenas/escribir.php?id=1&nom=Christian&ape=Guti&eda=10

?>


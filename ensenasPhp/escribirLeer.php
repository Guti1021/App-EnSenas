<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);


//recibe los datos de unity, usamos el valor de estas variables
$userID = $_REQUEST['id'];
$fkidPapa = $_REQUEST['idPapa'];
$fkidHijo = $_REQUEST['idHijo'];
$fkidCuento = $_REQUEST['idCuento'];
$dificultad = $_REQUEST['dif'];
$pregunta1 = $_REQUEST['preg1'];
$pregunta2 = $_REQUEST['preg2'];
$pregunta3 = $_REQUEST['preg3'];
$pregunta4 = $_REQUEST['preg4'];
$pregunta5 = $_REQUEST['preg5'];
$resultado = $_REQUEST['res'];


  //insertar Valores en la base de datos Bonotes
  $adicionarDatos = mysqli_query($conect, "INSERT INTO ensenasLeer(id,fkidPapa,fkidHijo,fkidCuento,itemDificultad,pregunta1,pregunta2,pregunta3,pregunta4,pregunta5,resultado) VALUES('$userID','$fkidPapa','$fkidHijo','$fkidCuento','$dificultad','$pregunta1','$pregunta2','$pregunta3','$pregunta4','$pregunta5','$resultado')");

  echo "adicionado";





//http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirLeer.php?id=1&idPapa=1&idHijo=1&idCuento=1&dif=1&preg1=0&preg2=1&preg3=0&preg4=1&preg5=0&res=2
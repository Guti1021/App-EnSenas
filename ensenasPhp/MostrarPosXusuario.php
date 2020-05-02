<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);

$userID = $_REQUEST['IDuser'];

//consultar la tabla
$consulta = mysqli_query($conect, "SELECT * FROM ensenasHijos WHERE fkidPapa ='$userID' ");


while($nombre= mysqli_fetch_array($consulta))
{
	echo$nom = $nombre['nombre'];
	echo "\n";
}



//http://tadeolabhack.com:8081/test/Datos/MostrarPosXusuario.php?IDuser=85

?>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUser : MonoBehaviour
{
    //private string UrlPosotion = "http://tadeolabhack.com:8081/test/Datos/ensenasPhp/MostrarPosXusuario.php?";
    private string UrlPosotion = "http://localhost/ensenas/MostrarPosXusuario.php?";

    public Text NombreUsuario;
    public int fkidPapa = 3;

    public void obtenerInfo()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
    //http://tadeolabhack.com:8081/test/Datos/ensenasPhp/MostrarPosXusuario.php?IDuser=1
    //http://localhost/ensenas/MostrarPosXusuario.php?IDuser=1

        string info = UrlPosotion + "?IDuser" + fkidPapa;

        WWW resultInfo = new WWW(info);
        yield return resultInfo;
        print(resultInfo.text);

        NombreUsuario.text = resultInfo.text;
    }
}

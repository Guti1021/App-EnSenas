using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Borrar : MonoBehaviour
{
    //private string UrlBorrar = "http://tadeolabhack.com:8081/test/Datos/ensenasPhp/BorrarDatos.php?";
    private string UrlBorrar = "http://localhost/ensenas/BorrarDatos.php?";
    public int IdUser = 2;

    public void borrarTodo()
    {
        StartCoroutine(borrarT());
    }

    private IEnumerator borrarT()
    {
        WWWForm form = new WWWForm();
       
        form.AddField("in", "BorrarTodo");
        form.AddField("userID", 0);

        WWW retroalimentacion = new WWW(UrlBorrar, form);
        yield return retroalimentacion;
        print(retroalimentacion.text);
    }

    public void borrarUsuario()
    {
        StartCoroutine(borrarU());
    }

    private IEnumerator borrarU()
    {
        WWWForm form = new WWWForm();

        form.AddField("in", "BorrarUsuario");
        form.AddField("userID", IdUser);

        WWW retroalimentacion = new WWW(UrlBorrar, form);
        yield return retroalimentacion;
        print(retroalimentacion.text);
    }

    public void borrarDatosUsuario()
    {
        StartCoroutine(borrarDU());
    }

    private IEnumerator borrarDU()
    {
        WWWForm form = new WWWForm();

        form.AddField("in", "BorrarDatosUsuario");
        form.AddField("userID", IdUser);

        WWW retroalimentacion = new WWW(UrlBorrar, form);
        yield return retroalimentacion;
        print(retroalimentacion.text);
    }
}

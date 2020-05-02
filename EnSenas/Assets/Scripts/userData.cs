using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class userData : MonoBehaviour
{
    //private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribir.php?";
    private string getUrlEscribir = "http://localhost/ensenas/escribir.php?";

    public int idUser = 10;
    private string nombre = "";
    private string apellido = "";
    private int edad = 0;

    public InputField campoNombre;
    public InputField campoApellido;
    public InputField campoEdad;

    public void SenData()
    {
        //LLama un método haciendo una pausa en la ejecución del programa
        StartCoroutine(enviarDatosUsuarios());
    }

    private IEnumerator enviarDatosUsuarios()
    {
        if (campoNombre.text != "")
        {
            nombre = campoNombre.text;
        }
        else
        {
            print("El campo de nombre está vacío.");
        }
        
        if (campoApellido.text != "")
        {
            apellido = campoApellido.text;
        }
        else
        {
            print("El campo de apellido está vacío.");
        }

        if (campoEdad.text != "")
        {
            edad = int.Parse(campoEdad.text);
        }
        else
        {
            print("El campo de edad está vacío.");
        }

        print(idUser + " " + nombre + " " + apellido + " " + edad);
        //print(nombre + " " + apellido + " " + edad);

        if (nombre == "" || apellido == "" || edad == 0)
        {
            print("Llena todos los campos de texto.");
        }
        else
        {
            WWWForm form = new WWWForm();
            //form.AddField("id", idUser);
            PlayerPrefs.GetInt("id", idUser);
            form.AddField("nom", nombre);
            form.AddField("ape", apellido);
            form.AddField("eda", edad);

            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;
            print(retroalimentacion.text);

            SceneManager.LoadScene("RegistroHijo");
        }

    }
}


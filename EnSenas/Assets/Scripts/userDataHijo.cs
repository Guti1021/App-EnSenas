using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class userDataHijo : MonoBehaviour
{
    //private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/ensenasPhp/escribirHijo.php?";
    private string getUrlEscribir = "http://localhost/ensenas/escribirHijo.php?";

    //public int idUser = 1;
    private int idPapa;
    private string nombre = "";
    private int edad = 0;

    public InputField campoNombre;
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
        
        if (campoEdad.text != "")
        {
            edad = int.Parse(campoEdad.text);
        }
        else
        {
            print("El campo de edad está vacío.");
        }

        //print(idUser + " " + nombre + " " + apellido + " " + edad);
        print(nombre + " " + edad);

        if (nombre == "" || edad == 0)
        {
            print("Llena todos los campos de texto.");
        }
        else
        {
            WWWForm form = new WWWForm();
            //form.AddField("id", idUser);
            PlayerPrefs.GetInt("id", idPapa);
            form.AddField("nom", nombre);
            form.AddField("eda", edad);

            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;
            print(retroalimentacion.text);

            SceneManager.LoadScene("Dificultad");
        }

    }
}


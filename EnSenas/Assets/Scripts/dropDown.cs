using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropDown : MonoBehaviour
{
    private Animator buttonAnim;
    private Boton boton;

    void Start()
    {
        buttonAnim = GetComponent<Animator>();
        boton = GameObject.Find("Code").GetComponent<Boton>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boton.showMenu)
            buttonAnim.SetBool("b_showMenu", true);
        if (!boton.showMenu)
            buttonAnim.SetBool("b_showMenu", false);
    }
}

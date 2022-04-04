using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstScene : MonoBehaviour
{
    // Start is called before the first frame update
    public int edad;
    public Text Prueba;
    public const int edadmaxima = 18;
    void Start()
    {
        if (edad > 18)
        {
            Prueba.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else
        {
            Prueba.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad");
        }
    }

}

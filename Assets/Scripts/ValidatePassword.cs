using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidatePassword : MonoBehaviour
{
    // Start is called before the first frame update
    string contraseñacorrecta;
    string contraseñausuario;
    public Text loginusuario;
    public Text respuesta;
    public GameObject cartelito;
    void Start()
    {
        contraseñacorrecta = "asdasd";
        cartelito.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ValidarContraseña()
    {
        contraseñausuario = loginusuario.text;
        if (contraseñausuario == contraseñacorrecta)
        {
            cartelito.SetActive(true);
            respuesta.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelito.SetActive(true);
            respuesta.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public string Contra = "Moneda";
    public InputField IngresoContra; 

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Contraseña()
    {
     if (IngresoContra.text == Contra)
        {
            Debug.Log("Access granted");
        }
     else
        {
            Debug.Log("Access denied");
        }
    }
}

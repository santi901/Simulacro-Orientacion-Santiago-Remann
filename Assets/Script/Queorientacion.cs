using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queorientacion : MonoBehaviour
{

    public string Nombre;
    public int Año;
    public string Orientacion;
    

    string T;
    string D;
    string H;
    string G;
    string M;


    // Start is called before the first frame update
    void Start()
    {
        if ( Nombre == "")
        {
            Debug.Log("Error ningun nombre fue ingresado");
            return;
        }
        {

        }
        if ( Año < 1 || Año > 5)
        {
            Debug.Log("El año ingresado esta fuera del rango posible");
            return;
        }
        if (Orientacion != "T" && Orientacion != "D" && Orientacion != "H" && Orientacion != "G" && Orientacion != "M")
        {
            Debug.Log("La orientacion ingresada no se encuntra en ORT");
            return;
        }

        if (Año < 3)
        {
            Debug.Log("Error.Aún estás en el ciclo básico");
            return;
        }

        Debug.Log("Muchas gracias " + Nombre +"!");
            
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

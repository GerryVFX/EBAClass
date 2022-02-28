using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesString : MonoBehaviour
{
    [SerializeField]
    string[] colores;
    int casos;
    string opcionColores;

    float castToString=152.97589f;
    string numeroFloat;

    string miNombre;
    [SerializeField]
    List<string> nombres;

    string cantidad1="25493";
    string cantidad2="38752";
    int cant1=0;
    int cant2=0;
    int resultado;

    string hola = "Hola soy Gerardo Serrano";
    string frace;
    
    

    
    void Start()
    {
        //Parte1 ejercicio4
        opcionColores = ("rojo, verde, azul, negro");
        colores = opcionColores.Split(',');
        casos = Random.Range(0, 3);

        //Parte1 ejercicio5
        numeroFloat = castToString.ToString();

        //Parte1 ejercicio6
        miNombre = "Gerardo Serrano Olascoaga";
        nombres = new List<string>(miNombre.Split(' '));
        foreach(var nombre in nombres)
        {
            print(nombre);
        }

        //Parte2 ejercicio1
        if (int.TryParse(cantidad1.ToString(), out cant1) && int.TryParse(cantidad2.ToString(),out cant2))
        {
            resultado = cant1 + cant2;
            print(resultado);
        }



       

        //Parte3 ejercicio3
        frace = "Practica modulo 8";
        print(frace);
        print(frace.Remove(0,5));


    }

 
    void Update()
    {
        //Parte1 ejercicio4
        switch (casos)
        {
            case 0:
                print($"La palabra es { colores[0]}");
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case 1:
                print($"La palabra es { colores[1]}");
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case 2:
                print($"La palabra es { colores[2]}");
                gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case 3:
                print($"La palabra es { colores[3]}");
                gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
        }

        //Parte2 ejercicio2
        for (int i = 0; i % 2 == 0 && i<hola.Length; i += 2)
        {
            print(hola[i]);
        }

        //Parte1 ejercicio5
        print("El numero casteado es: "+ numeroFloat.Substring(4));
    }
}

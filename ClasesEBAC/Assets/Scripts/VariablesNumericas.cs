using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    //Primeras dos variables
    
    public long incrementoUpdate;
    
    public double incrementoFixed;
    //Variables para operación y casteo
    float a, b;
    int c;
    //Variable para cambio de color
   
    public int numeroSecreto;

    
    void Start()
    {
        //Parte1 ejercicio1
        incrementoUpdate = 0;
        incrementoFixed = 1f;

        //Prte1 ejercicio2
        a = 4.6f;
        b = 8.9f;
        c = (int)(a * b);

        //Parte1 ejercicio3
        numeroSecreto = Random.Range(1, 10);
    }


    void Update()
    {
        //Parte1 ejercicio1
        incrementoUpdate += 1;
        print("Revisar incremento de primer variable en inspector de cube1");

        //Parte1 ejercicio2
        print($"El resultado de la opracion de dos flotantes y casteo en int es {c}");
    }

    private void FixedUpdate()
    {
        //Parte1 ejercicio1
        incrementoFixed *= 2;
        print("Revisar incremento de segunda variable en inspector de cube1");

        //Parte1 ejercicio3
        if (numeroSecreto % 2 == 0)
        {
            print("El numero secreto es par");
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            print("El numero secreto no es par");
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

}

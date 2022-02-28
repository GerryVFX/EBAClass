using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos : MonoBehaviour
{
    [SerializeField]
    int[] arr1=new int[5];
    [SerializeField]
    int[] arr2 = new int[5];
    [SerializeField]
    int[] arr3 = new int[5];

    string[] frace = new string[3] { "Desarrollo","de","juegos"};
    string pal;

    int[,] mat = new int[2, 3] { {9,2,6 },{3,4,6 } };
    int[] uni = new int[2] { 9, 6 };
    int[] unifinal = new int[2];
    int a, b, c, e, f, g;
    //(9 2 6)x(9)=(9)(9)+(2)(9)+(6)(9) 
    //(3 4 6) (6) (3)(6) (4)(6) (6)(6)


    void Start()
    {
        //Ejercicio1

       for(int i = 0; i < 5; i++)
        {
            arr1[i] = Random.Range(1, 25);
        }

        for (int y = 0; y < 5; y++)
        {
            arr2[y] = Random.Range(1, 25);
        }

        for (int x = 0; x < 5; x++)
        {
            arr3[x] = arr1[x] + arr2[x];
            print($"La suma de {arr1[x]}+{arr2[x]} es: {arr3[x]}");
        }

        //Ejercicio2
        foreach (string palabra in frace)
        {
            pal=pal+" "+palabra;
        }
        print("La palabra concatenada es " + pal);

        //Eejercicio3
        a = mat[0, 0] * uni[0];
        b = mat[0, 1] * uni[0];
        c = mat[0, 2] * uni[0];
        e = mat[1, 0] * uni[1];
        f = mat[1, 1] * uni[1];
        g = mat[1, 2] * uni[1];

        unifinal[0] = a + b + c;
        unifinal[1] = e + f + g;

        foreach(int resultado in unifinal)
        {
            print("Resultado de matriz: " + resultado);
        }
        
    }

   
}

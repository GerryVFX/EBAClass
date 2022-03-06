using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFIVE : MonoBehaviour
{
 
    GameObject cuboTres;
    GameObject cuboCuatro;

    
    void Start()
    {
        cuboTres = GameObject.Find("Cube3");
        cuboCuatro = GameObject.Find("Cube4");
      
    }

   

    private void FixedUpdate()
    {

        if (cuboTres.GetComponent<CubeTHREE>().micubo3 && cuboCuatro.GetComponent<CubeFOUR>().micubo4)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("Los cubos 3 y 4 son verdaderos");
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("Los cubos 3 y 4 son verdaderos");
        }
    }
}

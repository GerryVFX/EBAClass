using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFOUR : MonoBehaviour
{
    
    GameObject cube1;
    GameObject cube2;
    
    public bool micubo4;

    

    void Start()
    {
        cube1 = GameObject.Find("Cube1");
        cube2 = GameObject.Find("Cube2");

    }

    private void FixedUpdate()
    {
        if (cube1.GetComponent<CubeONE>().miColor||cube2.GetComponent<CubeTWO>().miColor2)
        {
            micubo4 = true;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("Uno de los cubos 1 y 2 es verdaderos");
        }
        else
        {
            micubo4 = false;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Los cubos 1 y 2 son falsos");
        }
    }
}

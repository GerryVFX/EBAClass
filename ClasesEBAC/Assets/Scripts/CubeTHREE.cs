using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTHREE : MonoBehaviour
{
    GameObject cube1;
    GameObject cube2;
    public bool micubo3;

   

    void Start()
    {
        cube1 = GameObject.Find("Cube1");
        cube2 = GameObject.Find("Cube2");

    }

    private void FixedUpdate()
    {
       if(cube1.GetComponent<CubeONE>().miColor && cube2.GetComponent<CubeTWO>().miColor2)
        {
            micubo3 = true;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("Los cubos 1 y 2 son verdaderos");
        }
        else
        {
            micubo3 = false;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Los cubos 1 y 2 son falsos");
        }
    }


}

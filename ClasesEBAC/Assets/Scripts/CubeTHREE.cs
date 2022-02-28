using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTHREE : MonoBehaviour
{
    CubeONE cubo1;
    CubeTWO cubo2;

   

    void Start()
    {
        cubo1 = FindObjectOfType<CubeONE>();
        cubo2 = FindObjectOfType<CubeTWO>();
        
    }

    private void FixedUpdate()
    {
       if(cubo1.miColor==true && cubo2.miColor == true)
        {
            
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("Los cubos 1 y 2 son verdaderos");
        }
        else
        {
            
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Los cubos 1 y 2 son falsos");
        }
    }


}

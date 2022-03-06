using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeONE : MonoBehaviour
{
    public bool miColor;
  


    private void FixedUpdate()
    {
        if (!miColor)
        {
            miColor = true;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            miColor = false;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}

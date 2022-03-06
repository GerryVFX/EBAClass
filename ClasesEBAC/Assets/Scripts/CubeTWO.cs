using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTWO : MonoBehaviour
{
    public bool miColor2;

    private void FixedUpdate()
    {
        int rango = Random.Range(0, 6);
        if (rango<=3)
        {
            miColor2 = true;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            miColor2 = false;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}

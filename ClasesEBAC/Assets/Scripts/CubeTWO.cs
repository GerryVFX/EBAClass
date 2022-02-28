using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTWO : MonoBehaviour
{
    public bool miColor;
    [SerializeField]
    int asignaValor;

    void Start()
    {
        asignaValor = Random.Range(0, 5);
    }

    private void FixedUpdate()
    {
        if (asignaValor >= 3)
        {
            miColor = true;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("Cubo 2 verdadero");
        }
        else
        {
            miColor = false;
            gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("Cubo 2 falso");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFIVE : MonoBehaviour
{
    CubeONE cubo1;
    CubeTWO cubo2;

    [SerializeField]
    int numCaso;

    void Start()
    {
        
        cubo1 = FindObjectOfType<CubeONE>();
        cubo2 = FindObjectOfType<CubeTWO>();
    }

    void AsignaCaso()
    {
        if (cubo1.miColor == true && cubo2.miColor == true) numCaso = 4;
        else if (cubo1.miColor == true || cubo2.miColor == true) numCaso = 2;
        else if (cubo1.miColor == false && cubo2.miColor == false) numCaso = 0;
    }

    private void FixedUpdate()
    {
        AsignaCaso();
        switch (numCaso)
        {
            case 0:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                Debug.Log("Ningun cubo es verdadero");
                break;
            case 2:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                Debug.Log("Al menos dos cubos son verdaderos");
                break;
            case 4:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.Log("Todos los cubos son verdaderos");
                break;
        }

    }
}

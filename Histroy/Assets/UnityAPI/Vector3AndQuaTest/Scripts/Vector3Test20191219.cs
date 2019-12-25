using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Test20191219 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 a = new Vector3(1,1,1);
        Vector3 b = new Vector3(5,5,5);

        Vector3 c = b - a;
        Debug.Log(c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

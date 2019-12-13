using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainderTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //var i = 10 % 3;
        //int j = Convert.ToInt32(10.5f / 3.3f);
        //Debug.Log(i);
        //Debug.Log(j);

        int i = Convert.ToInt32(Math.Ceiling(10f / 10.0f));

        Debug.Log(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

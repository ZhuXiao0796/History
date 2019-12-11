using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> testInt = new List<int>();
        testInt.Add(4);
        testInt.Add(4);
        testInt.Add(4);
        testInt.Add(4);
        testInt.Add(5);
        testInt.Add(5);
        testInt.Add(5);
        testInt.Add(5);
        testInt.Add(6);
        testInt.Add(6);
        testInt.Add(6);
        testInt.Add(6);

        testInt.RemovePlus(t=>t==5);

        testInt.ForEach(t=>Debug.Log(t));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

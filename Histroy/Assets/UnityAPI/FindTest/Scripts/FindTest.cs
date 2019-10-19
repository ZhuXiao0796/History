using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var sub = GetComponentsInChildren<Transform>();
        foreach (var item in sub)
        {
            Debug.Log(item.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

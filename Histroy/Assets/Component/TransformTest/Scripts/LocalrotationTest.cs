using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalrotationTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.localRotation = Quaternion.Euler(new Vector3(0,90,0));
        transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

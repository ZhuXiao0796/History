using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward*50,ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

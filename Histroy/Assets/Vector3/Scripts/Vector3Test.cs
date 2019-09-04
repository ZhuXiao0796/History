using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(5,5,5);
        Vector3 v2 = new Vector3(7,7,7);

        //求两个向量的夹角
        var angle = Vector3.Angle(v1,v2);

        //求两个向量的距离
        var dis = Vector3.Distance(v1,v2);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

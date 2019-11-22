using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.RigidbodyTest
{
    /// <summary>
    /// 这个类是专门用来每帧计算方向，然后用刚体的添加力的方法
    /// </summary>
    public class PerFrameDrag : MonoBehaviour
    {
        private Rigidbody Rigidbody;
        // Start is called before the first frame update
        void Start()
        {
            Rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            //GetComponent<SkinnedMeshRenderer>().material.color.a = 1;
            var dir = new Vector3(50,0,50)-transform.position;
            Rigidbody.AddForce(dir,ForceMode.Acceleration);
        }
    }
}
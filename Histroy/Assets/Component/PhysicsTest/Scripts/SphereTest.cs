using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.PhysicsTest
{
    public class SphereTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
          
        }
        Vector3 point = new Vector3();
        // Update is called once per frame
        void Update()
        {
            point = GetComponent<SphereCollider>().center;
            point = transform.TransformPoint(point);
            var colliders = Physics.OverlapSphere(point, 0.5f);
            if (colliders != null)
            {
                foreach (var item in colliders)
                {
                    Debug.Log(item.name);
                }
            }
        }
    }
}

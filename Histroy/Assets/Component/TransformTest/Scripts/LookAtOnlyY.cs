using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.TransformTest
{
    public class LookAtOnlyY : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            transform.LookAt(new Vector3(5,5,5));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

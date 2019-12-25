using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace space
{
   public class RigidbodyViolecyTest : MonoBehaviour
   {
        Rigidbody Rigidbody;
       void Start()
       {
            Rigidbody = GetComponent<Rigidbody>();
            //Rigidbody.velocity = new Vector3(5,0,0);
       }

        private void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                Rigidbody.velocity = new Vector3(5,0,0);
            }
        }
    }
}

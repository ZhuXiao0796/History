using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.PhysicsTest
{
    public class PhysicsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //var colliders = Physics.OverlapBox(new Vector3(0,0,0),new Vector3(1,2,1));
            //var colliders = Physics.OverlapSphere(new Vector3(0,0,0),5f);
            int id = LayerMask.NameToLayer("Ground");
            var colliders = Physics.OverlapCapsule(new Vector3(0,0,0),new Vector3(0,5,0),1f,1<<id);
            foreach (var item in colliders)
            {
                Debug.Log(item.name);
            }
        }
    }
}
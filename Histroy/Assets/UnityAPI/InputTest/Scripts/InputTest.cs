using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace space
{
   public class InputTest : MonoBehaviour
   {
       // Start is called before the first frame update
       void Start()
       {
           
       }

       // Update is called once per frame
       void Update()
       {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log(1111);
            }
       }

        private void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log(2222);
            }
        }
    }
}

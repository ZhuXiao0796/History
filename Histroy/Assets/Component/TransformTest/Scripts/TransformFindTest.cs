using History.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace space
{
   public class TransformFindTest : MonoBehaviour
   {
       // Start is called before the first frame update
       void Start()
       {
            var result = transform.FindChildByName("TransformParent");
            if (result != null)
            {
                Debug.LogError(result.ToString());
            }
            else
            {
                Debug.LogError("Have not found");
            }
       }

       // Update is called once per frame
       void Update()
       {
           
       }
   }
}

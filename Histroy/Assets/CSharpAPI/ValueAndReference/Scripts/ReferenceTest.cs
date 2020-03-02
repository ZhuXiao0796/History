using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.ValueAndReferenceTest
{
   public class ReferenceTest : MonoBehaviour
   {
        public GameObject A;
       // Start is called before the first frame update
       void Start()
        {
            if (A != null && A.activeInHierarchy)
            {
                Debug.Log(A.name);
            }
            if (A.activeInHierarchy && A != null)
            {
                Debug.Log(A.name);
            }
        }
    }
}

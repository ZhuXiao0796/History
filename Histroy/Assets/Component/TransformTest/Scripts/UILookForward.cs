using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.TransformTest
{
    public class UILookForward : MonoBehaviour
    {
        public GameObject Target;
        public void LookForward()
        {
            Target.transform.LookAt(Target.transform.forward);
        }
    }
}

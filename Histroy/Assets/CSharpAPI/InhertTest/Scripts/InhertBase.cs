using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.InhertTest
{
    public class InhertBase : MonoBehaviour
    {
        public int i = 5;
        public virtual void Debugger()
        {
            if (i<6)
            {
                return;
            }
            else
            {
                Debug.Log("父类方法");
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpTest
{
    /// <summary>
    /// 用来测试 If 方法中放方法的结果
    /// </summary>
    public class BoolValueTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            if (IfTest())
            {
                Debug.Log("True");
            }
        }

        private bool IfTest()
        {
            return true;
        }
     
    }
}

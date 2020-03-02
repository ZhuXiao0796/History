using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.AcionTest
{
    /// <summary>
    /// 这里测试的是不带返回值，不带参数的事件
    /// </summary>
    public class ActionTest : MonoBehaviour
    {
        private void Awake()
        {
            //ClassA classA = new ClassA();
            //ClassB classB = new ClassB();

            //classB.Action += classA.Debug02;

            //classB.Debug01();
        }
    }

    
    public class ClassA
    {
        public void Debug02()
        {
            Debug.Log(02);
        }
    }

    public class ClassB
    {
        public Action Action;

        public void Debug01()
        {
            Debug.Log(01);
            Action?.Invoke();
        }
    }
}

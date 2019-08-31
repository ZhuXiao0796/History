using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.DelegateTest
{
    /// <summary>
    /// 委托是将方法作为参数        在不确定调用哪个方法的情况下，可以用委托动态调用方法案例如下
    /// </summary>
    public class DelegateTestA : MonoBehaviour
    {
        public delegate void GreetingDelegate(string name);


        // Start is called before the first frame update
        void Start()
        {
            GreetPeople("Liker", EnglishGreeting);
            GreetPeople("李志中", ChineseGreeting);
        }

        private void EnglishGreeting(string name)
        {
            //Console.WriteLine("Good Morning, " + name);
            Debug.Log("Good Morning, " + name);
        }

        private void ChineseGreeting(string name)
        {
            //Console.WriteLine("早上好, " + name);
            Debug.Log("早上好, " + name);
        }

        private void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }
    }
}

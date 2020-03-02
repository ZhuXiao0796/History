using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace History.CSharpAPI.FuncTest
{
   public class FuncTest : MonoBehaviour
   {
       // Start is called before the first frame update
       void Start()
       {
            ClassA classA = new ClassA();
            ClassB classB = new ClassB();

            classA.Func += classB.DebugHi;
            string result = classA.DebugHi("Hi");

            Debug.Log(result);
       }

     
   }

    public class ClassA
    {
        public Func<string, string> Func;
        public string DebugHi(string name)
        {
            Debug.Log(name);
            name += "A";
            Func?.Invoke(name);
            return name;
        }
    }
    public class ClassB
    {
        public string DebugHi(string name)
        {
            Debug.Log(name);
            return "B" + name;
        }
    }
}

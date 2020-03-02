using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace History.CSharpAPI.AcionTest
{
   public class ActionTest02 : MonoBehaviour
   {
        public delegate void MiddleHandler(string s);
        public Action<string> SayHello;     
        // Start is called before the first frame update
        void Start()
       {
            ClassC classC = new ClassC();
            ClassD classD = new ClassD();
            classD.SayHello += classC.SayHi;
            classD.SayHi("123");
            SayHello = classC.SayHi;
            classD.SayHello -= SayHello;
            classD.SayHi("456");
       }
   }

    public class ClassC
    {
        public void SayHi(string hi)
        {
            Debug.Log(hi + "say");
        }
    }

    public class ClassD
    {
        public Action<string> SayHello;

        public void SayHi(string hi)
        {
            Debug.Log(hi);
            SayHello?.Invoke(hi);
        }
    }
}

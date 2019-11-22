using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace History.CSharpAPI.TypeTest
{
    public class TypeTest : MonoBehaviour
    {
        float A;
        float B;
        float C;
        float D;

        // Start is called before the first frame update
        void Start()
        {
            //string str = "var";
            //string var = "hello world";
            //var sentences = this.GetType().GetField(str).GetValue(this).ToString();
            //Debug.Log(sentences);
            var test = new TestType();
            var type = typeof(TestType);
            ListFields(type);
        }

        static void ListFields(Type type)
        {
            var fieldNames = from f in type.GetFields() select f.Name;
            Debug.Log("field");
            foreach (var item in fieldNames)
            {
                Debug.Log(item);
            }
            Debug.Log("prop");
            var propNames = from p in type.GetProperties() select p.Name;
            foreach (var item in propNames)
            {
                Debug.Log(item);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class TestType
    {
        public float A;
        float B;
        float C;
        float D;
        float E;
    }
}
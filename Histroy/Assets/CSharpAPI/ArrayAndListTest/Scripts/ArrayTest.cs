using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace History.CSharpAPI.ArrayTest
{
    public class ArrayTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            List<int> testInt = new List<int>();
            testInt.Add(4);
            testInt.Add(4);
            testInt.Add(4);
            testInt.Add(4);
            testInt.Add(5);
            testInt.Add(5);
            testInt.Add(5);
            testInt.Add(5);
            testInt.Add(6);
            testInt.Add(6);
            testInt.Add(6);
            testInt.Add(6);

            var temp = testInt.ToArray();
            Debug.Log(temp.Length);

            //temp.ToList().RemoveAll(t=>t==4);

            //temp = temp02.ToArray();

            //Debug.Log(temp.Length);

            //testInt.RemovePlus(t=>t==5);


            //testInt.ForEach(t=>Debug.Log(t));

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
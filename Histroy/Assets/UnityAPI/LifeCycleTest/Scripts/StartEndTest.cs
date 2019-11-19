using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.LifeCycleTest
{
    public class StartEndTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Start");
        }

        private void OnEnable()
        {
            Debug.Log("Enable");

        }
        //public void Add(params)
        //{
        //    int a = 1;
        //    int b = 2;
        //    ArrayList[] arrayLists = new ArrayList[]
        //    {
        //       a,b
        //    };
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.LifeCycleTest
{
    public class Timer : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(Time.realtimeSinceStartup+"Start 中的 Debug");
        }
        // Update is called once per frame
        void Update()
        {
            Debug.Log(Time.realtimeSinceStartup + "Update 中的 Debug");
        }
    }
}
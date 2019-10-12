using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.TimeScaleTest
{
    public class TimeScaleTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        private IEnumerator TimerTest()
        {
            while (true)
            {
                //yield return new WaitForSeconds();
                yield return null;
            }
        }
    }
}
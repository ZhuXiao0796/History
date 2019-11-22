using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.AndroidTest
{
    public class AndroidLogButton : MonoBehaviour
    {
        private GameObject A;
        // Start is called before the first frame update
        void Start()
        {

        }

        public void AndroidLog()
        {
            AndroidLogTest.Instance.AndroidWrite(System.DateTime.Now.ToString());
            try
            {
                float x = A.transform.position.x;
            }
            catch (System.Exception e)
            {
                AndroidLogTest.Instance.AndroidWrite(e.StackTrace);
            }
            try
            {
                float x = A.transform.position.x;
            }
            catch (System.Exception e)
            {
                AndroidLogTest.Instance.AndroidWrite(e.Message);
            }
            try
            {
                float x = A.transform.position.x;
            }
            catch (System.Exception e)
            {
                AndroidLogTest.Instance.AndroidWrite(e.TargetSite.ToString());
            }
        }
    }
}

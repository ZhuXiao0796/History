using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.ErrorTest
{
    public class ErroeTest : MonoBehaviour
    {
        // Start is called before the first frame update
        GameObject sk;
        void Start()
        {
            try
            {
                Debug.Log(sk.name);
                Debug.Log(222);
            }
            catch (System.Exception e)
            {
                Debug.Log(e.StackTrace);
                //return;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

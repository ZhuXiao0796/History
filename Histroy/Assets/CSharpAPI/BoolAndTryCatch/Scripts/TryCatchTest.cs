using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.TryCatchTest
{
    public class TryCatchTest : MonoBehaviour
    {
        public GameObject A;
        int i = 0;
        // Start is called before the first frame update
        void Start()
        {
            try
            {
                //if (i >= 0)
                //{
                //    return;
                //}
                //Debug.Log(A.name);
                GameObject gameObject = GameObject.Find("object");
                Debug.Log(gameObject.name);
            }
            catch (System.Exception e)
            {
                Debug.Log(e.StackTrace);
                Debug.Log(e.Source);
                Debug.Log(e.Message);
                Debug.Log(e.TargetSite.MemberType);
                throw;
            }
            finally
            {
                Debug.Log("Finally part");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

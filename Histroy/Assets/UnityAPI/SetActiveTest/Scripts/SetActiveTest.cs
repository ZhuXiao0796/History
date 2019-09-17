using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.SetActiveTest
{
    public class SetActiveTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(DebugPrivateI());

        }
        int i = 0;

        private void SetGOFalse()
        {
            gameObject.GetComponent<Collider>().enabled = false;
        }

        private IEnumerator DebugPrivateI()
        {
            while (true)
            {
                Debug.Log(i);
                yield return new WaitForSecondsRealtime(1f);
            }
        }
    }
}

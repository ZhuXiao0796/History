using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.ArrayTest
{
    public class ContinueTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            List<int> listInt = new List<int>(8);
            for (int i = 0; i < 8; i++)
            {
                listInt.Add(i);
            }
            foreach (var item in listInt)
            {
                if (item == 5)
                {
                    continue;
                }
                Debug.Log("No continue" + item);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
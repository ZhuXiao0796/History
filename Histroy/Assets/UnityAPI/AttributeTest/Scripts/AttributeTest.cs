using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.AttributeTest
{
    public class AttributeTest : MonoBehaviour
    {
        [SerializeField]
        private readonly float attribute = 5;
        // Start is called before the first frame update
        void Start()
        {
        }

        [ContextMenuItem("Reset", "ResetBiography")]
        [Multiline(8)]
        public string playerBiography = "dfdfdf";

        public void ResetBiography()
        {
            playerBiography = "dfdfdfd";
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Debug"))
            {
                Debug.Log(attribute);
            }
        }

    }
}
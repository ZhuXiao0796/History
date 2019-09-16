using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.LineRendererTest
{

    /// <summary>
    /// 用来测试线段渲染器
    /// </summary>
    public class LineRendererTest : MonoBehaviour
    {
        public GameObject endGO;
        LineRenderer line;
        // Start is called before the first frame update
        void Start()
        {
            line = GetComponent<LineRenderer>();
            
        }

        // Update is called once per frame
        void Update()
        {
            line.SetPosition(0, transform.position);
            line.SetPosition(1, endGO.transform.position);
            line.startColor = Color.blue;
            line.endColor = Color.blue;
            line.startWidth = 0.1f;
            line.endWidth = 0.1f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.ResourcesTest
{
    /// <summary>
    /// 这个类主要是用来测试，从 Resources 中加载的东西能还没有放到场景之前能否获取到身上的组件
    /// </summary>
    public class ResourcesTest : MonoBehaviour
    {
        public GameObject A;

        private void Start()
        {
            A = Resources.Load("Cube") as GameObject;
            float radius = A.GetComponent<BoxCollider>().size.x;
            Debug.Log(radius);
        }
    }
}

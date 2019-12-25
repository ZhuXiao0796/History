using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.PhysicsTest
{
    //主要是为了测试不同层级下的碰撞结果
    //如果不同层级的碰撞体大小不一样 碰撞体能否根据实际情况检测
    public class ColliderTest : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.gameObject.name + gameObject.name);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.PhysicsTest
{
    /// <summary>
    ///  测试了 物理射线中的 圆柱体射线
    /// </summary>
    public class PhysicsTest : MonoBehaviour
    {
        public GameObject end;
        public  Vector3 endPos = new Vector3(0,5,0);
        float height;
        // Start is called before the first frame update
        void Start()
        {
            //var capsule = gameObject.GetComponent<CapsuleCollider>();
            //height = capsule.height;
        }

        // Update is called once per frame
        void Update()
        {
            var colliders = Physics.OverlapCapsule(transform.position - transform.up, transform.position + transform.up, 1f);
            // PhysicsScene physicsScene = new PhysicsScene();
            
            if (colliders!=null)
            {
                foreach (var item in colliders)
                {
                    Debug.Log(item.name);
                }
            }
        }
    }
}

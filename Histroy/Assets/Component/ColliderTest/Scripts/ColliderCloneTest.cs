using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.ColliderTest
{
    public class ColliderCloneTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(MoveCor());
            //gameObject.transform.position = transform.position + transform.up * 5f;
        }

        private IEnumerator MoveCor()
        {
            var collider = gameObject.GetComponent<CapsuleCollider>();
            
            var add = gameObject.AddComponent<CapsuleCollider>();
            add.radius = collider.radius;
            add.center = collider.center;
            add.height = collider.height;

            while (true)
            {
                transform.position += Vector3.up * Time.deltaTime;
                add.center -= Vector3.up * Time.deltaTime;
                yield return null;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
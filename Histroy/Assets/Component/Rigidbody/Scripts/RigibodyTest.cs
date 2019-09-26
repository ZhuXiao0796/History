using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.RigidbodyTest
{
    /// <summary>
    /// 用来测试刚体的最大速度
    /// </summary>
    public class RigibodyTest : MonoBehaviour
    {
        private readonly bool move = true;
        new Rigidbody rigidbody;
        Vector3 endPos = new Vector3(5, 0, 5);

        // Start is called before the first frame update
        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();

            rigidbody.velocity = new Vector3(1,0,1);
            //rigidbody.MovePosition(new Vector3(50,0,50));

            //StartCoroutine(VelocityChange());
            //StartCoroutine(Force());
            //StartCoroutine(Acceleration());
            //StartCoroutine(Impulse());
        }
        private void Update()
        {
            if (Vector3.Distance(transform.position,new Vector3(50,0,50))<=0.1f)
            {
                rigidbody.Sleep();
            }
        }

        private IEnumerator VelocityChange()
        {
            while (move)
            {
                rigidbody.AddForce(endPos, ForceMode.VelocityChange);
                if (rigidbody.velocity.sqrMagnitude > 200)
                {
                    yield break;
                }
                yield return new WaitForFixedUpdate();
            }
        }

        private IEnumerator Force()
        {
            while (move)
            {
                rigidbody.AddForce(endPos.normalized*10, ForceMode.Acceleration);
                if (rigidbody.velocity.sqrMagnitude > 100)
                {
                    yield break;
                }
                yield return new WaitForFixedUpdate();
            }
        }

        private IEnumerator Acceleration()
        {
            while (move)
            {
                rigidbody.AddForce(endPos, ForceMode.Force);
                if (rigidbody.velocity.sqrMagnitude > 200)
                {
                    yield break;
                }
                yield return new WaitForFixedUpdate();
            }
        }

        private IEnumerator Impulse()
        {
            while (move)
            {
                rigidbody.AddForce(endPos, ForceMode.Impulse);
                if (rigidbody.velocity.sqrMagnitude > 200)
                {
                    yield break;
                }
                yield return new WaitForFixedUpdate();
            }
        }
    }
}

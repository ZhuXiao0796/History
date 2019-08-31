using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.RigidbodyTest
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
            //StartCoroutine(VelocityChange());
            StartCoroutine(Force());
            //StartCoroutine(Acceleration());
            //StartCoroutine(Impulse());
        }

        void MoveTo()
        {
            rigidbody.MovePosition(endPos);
        }

        private IEnumerator VelocityChange()
        {
            while (move)
            {
                Debug.Log(111111111);
                rigidbody.AddRelativeForce(endPos, ForceMode.VelocityChange);
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
                Debug.Log(111111111);
                //rigidbody.AddRelativeForce(endPos.normalized, ForceMode.Impulse);
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
                Debug.Log(111111111);
                rigidbody.AddRelativeForce(endPos, ForceMode.Force);
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
                Debug.Log(111111111);
                rigidbody.AddRelativeForce(endPos, ForceMode.Impulse);
                if (rigidbody.velocity.sqrMagnitude > 200)
                {
                    yield break;
                }
                yield return new WaitForFixedUpdate();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace History.ComponentTest.RigidbodyTest
{
    /// <summary>
    /// 用来测试刚体的API
    /// </summary>
    public class DragTest : MonoBehaviour
    {
        Rigidbody rigid;
        Text speed;
        // Start is called before the first frame update
        void Start()
        {
            //获取物体刚体引用
            rigid = GetComponent<Rigidbody>();
            //获取 UI Text 引用
            speed = GameObject.Find("Velocity").GetComponent<Text>();

            //给物体添加 Force 类型的力
            //StartCoroutine(ForceTest());

            //给物体添加 Acceleration 类型的力
            //StartCoroutine(AccelerationTest());

            //给物体添加一个 Impulse 类型的力
            //StartCoroutine(ImpulseTest());

            //给物体添加一个 VelocityChange 类型的力
            StartCoroutine(VelocityChange());
        }

        private void Update()
        {
            speed.text = rigid.velocity.ToString();
        }

        private IEnumerator ImpulseTest()
        {
            rigid.AddForce(new Vector3(50,0,0),ForceMode.Impulse);
            yield return null;
        }

        private IEnumerator VelocityChange()
        {
            rigid.AddForce(new Vector3(50,0,0),ForceMode.VelocityChange);
            yield return null;
        }

        private IEnumerator ForceTest()
        {
            while (true)
            {
                rigid.AddForce(new Vector3(50,0,0), ForceMode.Force);
                yield return null;
            }
            
        }

        private IEnumerator AccelerationTest()
        {
            while (true)
            {
                rigid.AddForce(new Vector3(50,0,0),ForceMode.Acceleration);
                yield return null;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CoroutineTest
{
    /// <summary>
    /// 测试了 当在协程内部用 While 进行判断，在外部打断  While 内的条件，则 While 中止。
    /// 测试了 协程内部运动 每帧运动是否需要加时间类
    /// </summary>
    public class WhileCoroutineTest : MonoBehaviour
    {
        private bool status;
        // Start is called before the first frame update
        void Start()
        {
            //status = true;
            //StartCoroutine(WhileTest());
            //Invoke("ChangeStatus", 5f);

            StartCoroutine(MoveToTarget(new Vector3 (100,0,0)));
        }

        private void ChangeStatus()
        {
            status = false;
        }

       private IEnumerator WhileTest()
        {
            while (status)
            {
                Debug.Log(11111);
                yield return new WaitForSeconds(1f);
            }
        }

        private IEnumerator MoveToTarget(Vector3 endPos)
        {
            while (Vector3.Distance(transform.position,endPos)>=0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position,endPos,Time.deltaTime*2f);
                yield return null;
            }
        }

        private IEnumerator Drag(float dis,Vector3 endPos,float speed)
        {
            while (Vector3.Distance(transform.position,endPos)<=dis)
            {
                transform.position = Vector3.MoveTowards(transform.position,endPos,speed * Time.deltaTime);
                yield return null;
            }
            yield break;
        }
    }
}

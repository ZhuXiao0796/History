using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    Collider Collider;
    // Start is called before the first frame update
    void Start()
    {
        Collider = GetComponent<BoxCollider>();
        StartCoroutine(TriggerBOXTest());
    }

    private IEnumerator TriggerBOXTest()
    {
        while (true)
        {
            Collider.enabled = true;
            //StartCoroutine(LastForSeconds(0.2f));
            yield return new WaitForSecondsRealtime(0.2f);
            Collider.enabled = false;
            yield return new WaitForSecondsRealtime(1f);
        }
    }

    private IEnumerator LastForSeconds(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Collider.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log(other.name);
    //}
}

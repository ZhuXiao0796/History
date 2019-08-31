using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroyTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject);
    }

    private void OnDisable()
    {
        Debug.Log("销毁之前的操作");
    }
}

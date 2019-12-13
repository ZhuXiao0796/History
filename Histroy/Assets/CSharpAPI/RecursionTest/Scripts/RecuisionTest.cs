using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuisionTest : MonoBehaviour
{
    private void Start()
    {
        var i = AddUp(1);
        Debug.Log(i);
    }

    private int AddUp(int i)
    {
        if (i<20)
        {
            i += 1;
            i = AddUp(i);
        }
        return i;
    }
}

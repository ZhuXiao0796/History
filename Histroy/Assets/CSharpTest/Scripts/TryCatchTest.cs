using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryCatchTest : MonoBehaviour
{
	public GameObject A;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            if (i>=0)
            {
                return;
            }
            Debug.Log(A.name);
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
            throw;
        }
        finally
        {
            Debug.Log("Finally part");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

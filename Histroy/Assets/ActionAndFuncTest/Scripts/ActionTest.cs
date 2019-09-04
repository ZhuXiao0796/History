using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTest : MonoBehaviour
{
    Action<string, int> ShowMessage;
    event Action OnHitRequest;
    // Start is called before the first frame update
    void Start()
    {
        //Action action = Update;
        ShowMessage = DisplayMessage;
        ShowMessage("Duan",5);

        OnHitRequest += ActionTest_OnHitRequest;
    }

    private void ActionTest_OnHitRequest()
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        
    }

    public  void DisplayMessage(string msg,int printCount)
    {
        for (int i = 0; i < printCount; i++)
        {
            Debug.Log(msg);
        }
    }
}

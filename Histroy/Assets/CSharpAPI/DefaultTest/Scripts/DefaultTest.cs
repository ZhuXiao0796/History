using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultTest : MonoBehaviour
{
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start() 
    {
        Debug.Log(default(int));
        
    }

    /// <summary>
    ///  
    /// </summary>
    public void MethodTest()
    {
         
    }
    
}

public class Cat
{
    string Name;
    public Cat()
    {
        Name = "Cat";
    }
}



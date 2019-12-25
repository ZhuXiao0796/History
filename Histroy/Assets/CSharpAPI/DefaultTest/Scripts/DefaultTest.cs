using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(default(Cat));
        if (default(Cat) == null)
        {

        }
    }

    public T DefaultTest01<T> (List<T>test)
    {
        var result = test.Find(t=>t.Equals(null));
        if (result!=default)
        {
            return result;
        }
        else
        {
            return default(T);
        }
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



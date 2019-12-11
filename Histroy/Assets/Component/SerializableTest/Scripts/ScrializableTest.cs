using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrializableTest : MonoBehaviour
{
    public string a = "123";
    public SerializableMine s = new SerializableMine();
}

[System.Serializable]
public class SerializableMine
{
    public string a = "456";
}

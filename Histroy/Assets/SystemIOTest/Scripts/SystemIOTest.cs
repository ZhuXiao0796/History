using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SystemIOTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    private void DirectoryInfoTest01()
    {
        DirectoryInfo dir1 = new DirectoryInfo(@"C:\Users\Shroud\Desktop\Mine");
        //Debug.Log(dir1.FullName);
        //Debug.Log(dir1.Name);
        //Debug.Log(dir1.Parent);
        //Debug.Log(dir1.CreationTime);
        //Debug.Log(dir1.Attributes);
        //Debug.Log(dir1.Root);


        //FileInfo[] fileInfo = dir1.GetFiles("*.txt",SearchOption.AllDirectories);
        FileInfo[] fileInfo = dir1.GetFiles("*", SearchOption.AllDirectories);
        Debug.Log(fileInfo.Length);

        foreach (var item in fileInfo)
        {
            Debug.Log(item.Name);
            Debug.Log(item.Length);
            Debug.Log(item.CreationTime);
            Debug.Log(item.Attributes);
        }
    }

    private void DirectoryInfoTest02()
    {

    }
}

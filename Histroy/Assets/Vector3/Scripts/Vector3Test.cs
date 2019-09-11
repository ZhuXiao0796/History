using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Test : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    // Start is called before the first frame update
    void Start()
    {
        //求两个向量的夹角
        //所以一般都是某物体的一个轴和另一个物体的某坐标轴
        //或者某物体的一个轴，和另一个物体的一个轴进行比较
        //var angle = Vector3.Angle(A.transform.position,B.transform.position);
        //Debug.Log(angle);
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Angle"))
        {
            Debug.Log(Vector3.Angle(A.transform.position,B.transform.position));
        }
        if (GUILayout.Button("SignedAngle"))
        {
            Debug.Log(Vector3.SignedAngle(A.transform.position-B.transform.position,A.transform.position,-transform.up));
        }
    }

}

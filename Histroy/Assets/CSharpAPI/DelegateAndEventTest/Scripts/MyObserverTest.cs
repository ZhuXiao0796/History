using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 本例子的作用
/// 当老师说上课：课代表说起立，所有的同学都说老师好
/// </summary>
namespace History.CSharpAPI.DelegateTest
{
    public class MyObserverTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            KeDaiBiao keDaiBiao = new KeDaiBiao();
            teacher.OnShangKeEvent += keDaiBiao.QiLi;
            teacher.OnShangKeEvent += student.Laoshihao;
            teacher.ShangKe();
        }
    }

    

    
    public class Teacher
    {
        private string Name;
        public delegate void ShangKeHandler();
        public event ShangKeHandler OnShangKeEvent;
        public void ShangKe()
        {
            Debug.Log("上课啦");
            //OnShangKeEvent?.Invoke();
            if (OnShangKeEvent != null)
            {
                OnShangKeEvent();
            }
            else
            {
                Debug.Log("Event is null");
            }
        }
    }

    public class Student
    {
        public void Laoshihao()
        {
            Debug.Log("老师好");
        }
    }

    public class KeDaiBiao
    {
        public void QiLi()
        {
            Debug.Log("起立");
        }
    }
}

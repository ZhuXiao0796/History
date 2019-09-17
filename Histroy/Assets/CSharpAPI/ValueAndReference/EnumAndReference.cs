using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.EnumAndReference
{
    /// <summary>
    /// 结论：关于引用类型的指针传递
    /// 当你修改了引用类型的指针，那么指向该引用类型指针的其他指针也会被随着修改
    /// 但是如果修改的是引用类型中的某个值数据类型的指针，比如某个类的 值类型数据，然后其他指针如果指向这个值，其他指针不会随着该值的改变而改变。
    /// </summary>
    public class EnumAndReference : MonoBehaviour
    {
        private void Start()
        {
            ReferenceA a = new ReferenceA();
            a.speed = 5;
            ReferenceB b = new ReferenceB();
            b.speed = a.speed;
            a.speed = 10;
            Debug.Log(b.speed);
        }
    }
    public class ReferenceA
    {
        public int speed;
    }

    public class ReferenceB
    {
        public int speed;
    }
}
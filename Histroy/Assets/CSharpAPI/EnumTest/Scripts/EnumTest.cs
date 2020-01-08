using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.EnumTest
{
    /// <summary>
    /// 测试结果，枚举和 int 可以强转然后相互比较
    /// 即使你在列表中添加多个相同的枚举值，列表仍然会存储每一个枚举值，而不是只存储一个
    /// </summary>
    public class EnumTest : MonoBehaviour
    {
        public List<RandomEnum> enums;
        // Start is called before the first frame update

        public RandomEnum test;
        void Start()
        {
             
            enums.Add(RandomEnum.A);
            enums.Add(RandomEnum.A);
            enums.Add(RandomEnum.A);
            enums.Add(RandomEnum.A);
            enums.ForEach(t=>Debug.Log(t));

            test = RandomEnum.C;
            if (test>= RandomEnum.C)
            {
                Debug.Log("大于枚举值");
            }
            if ((int)test >= 2)
            {
                Debug.Log("大于 int 值 ");
            }
        }
    }
    public enum RandomEnum
    {
        A,
        B,
        C,
        D,
    }
}

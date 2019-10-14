using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.EnumTest
{
    public class EnumTest : MonoBehaviour
    {
        public List<RandomEnum> enums;
        // Start is called before the first frame update
        void Start()
        {
            enums.Add(RandomEnum.A);
            enums.Add(RandomEnum.A);
            enums.Add(RandomEnum.A);
            enums.Add(RandomEnum.A);
            enums.ForEach(t=>Debug.Log(t));
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

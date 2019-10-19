using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.InhertTest
{
    public class InhertSub : InhertBase
    {
        public override void Debugger()
        {
            base.Debugger();
            Debug.Log("子类方法");
        }

        private void Start()
        {
            i = 5;
            Debugger();
        }
    }
}

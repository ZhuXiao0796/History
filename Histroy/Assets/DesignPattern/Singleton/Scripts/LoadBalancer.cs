using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.DesignPattern.SingleTon
{
    public class LoadBalancer
    {
        public string Boss = "SomeBody";

        public bool IfChecked = false;

        private static LoadBalancer instance = null;

        private LoadBalancer()
        {

        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (instance == null)
            {
                instance = new LoadBalancer();
            }
            return instance;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.DesignPattern.SingleTon
{
    public class SingletonTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            Debug.Log(balancer.Boss);
            Debug.Log(balancer.IfChecked);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.ParticleSystemTest
{
    public class PatricleSystemTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var ps = GetComponent<ParticleSystem>();
            ps.Play();
            ps.Stop();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

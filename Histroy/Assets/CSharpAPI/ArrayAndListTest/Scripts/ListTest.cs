using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.ListTest
{
    public class ListTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            List<Cat> catsA = new List<Cat>();
            List<Cat> catsB = new List<Cat>();

            Cat cat = new Cat();
            cat.name = "Dog";

            catsA.Add(cat);

            catsB.Add(cat);

            var temp = catsA.FindAll(t=>t.name == "Dog");
            temp.ForEach(t=> { catsB.Remove(t); }
            );

            Debug.Log(catsB.Count);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Cat
    {
        public string name = "Cat";
    }
}

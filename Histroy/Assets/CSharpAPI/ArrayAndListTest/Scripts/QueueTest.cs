using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
namespace History.CSharpAPI.QueueTest
{
    public class QueueTest : MonoBehaviour
    {
        public Queue<Dog> dogs;
        // Start is called before the first frame update
        void Start()
        {
            dogs = new Queue<Dog>();
            Dog dog = new Dog
            {
                Name = "1",
            };
            Dog dog02 = new Dog
            {
                Name = "2"
            };

            dogs.Enqueue(dog);
            dogs.Enqueue(dog02);

            foreach (var item in dogs)
            {
                Thread.Sleep(1000);
                Debug.Log(item.Name);
            }

            dogs.Dequeue();
            foreach (var item in dogs)
            {
                Thread.Sleep(1000);
                Debug.Log(item.Name);
            }
        }



        // Update is called once per frame
        void Update()
        {

        }
    }
    public class Dog
    {
        public string Name;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.ArrayTest
{
   public class ForTest : MonoBehaviour
   {
       // Start is called before the first frame update
       void Start()
       {
            Cat[] cats = new Cat[5];
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    var cat = new Cat(i.ToString());
                    cats[i] = cat;
                }
                catch (System.Exception)
                {
                    continue;
                }
            }

            cats[2] = null;

            foreach (var item in cats)
            {
                try
                {
                    //Debug.Log(item.Name);
                }
                catch (System.Exception)
                {
                    continue;
                }
                
            }
            for (int i = 0; i < cats.Length; i++)
            {
                try
                {
                    Debug.Log(cats[i].Name);
                }
                catch (System.Exception)
                {
                    continue;
                }
            }
       }

      
   }

    public class Cat
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }
    }
}

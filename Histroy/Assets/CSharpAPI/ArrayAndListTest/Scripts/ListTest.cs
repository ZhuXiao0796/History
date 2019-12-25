using System;
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
            #region 2019 12 10
            //List<Cat> catsA = new List<Cat>();
            //Cat cat01 = new Cat
            //{
            //    name = "Dog"
            //};

            //Cat cat02 = new Cat
            //{
            //    name = "Dog02"
            //};

            //catsA.Add(cat01);
            //catsA.Add(cat02);

            //List<Cat> catsB = new List<Cat>(catsA);
            //catsB.Remove(catsB[1]);

            //foreach (var item in catsA)
            //{
            //    Debug.Log(item.name);
            //}

            //List<int> testlist = new List<int>();
            //testlist.Add(5);
            //testlist.Add(5);


            //testlist.Add(6);

            //testlist.Add(5);
            //testlist.Add(5);
            //testlist.Add(5);
            //Debug.Log(testlist.Count);

            //testlist.ForEach(t =>
            //{
            //    if (t == 5)
            //    {
            //        Debug.Log("检测到了 退出");
            //        return;
            //    }
            //});

            //foreach (var item in testlist)
            //{
            //    if (item == 5)
            //    {
            //        //testlist.Remove(item);
            //        Debug.Log(2222);
            //        //return;
            //        break;
            //        //continue;
            //    }
            //    Debug.Log("1111");
            //}

            //testlist.ForEach(t=>
            //{
            //    if (t == 5)
            //    {
            //        Debug.Log(t);
            //        return;
            //    }
            //    Debug.Log("只有6 才会有这个 Debug" + t);
            //});

            //Debug.Log(testlist.Count + "123123123");
            #endregion

            #region  2019 12 19
            List<Cat> cats = new List<Cat>();
            Cat cat00 = new Cat("00");
            Cat cat01 = new Cat("01");
            Cat cat02 = new Cat("02");
            Cat cat03 = new Cat("03");
            Cat cat04 = new Cat("04");
            Cat cat05 = new Cat("05");
            Cat cat06 = new Cat("06");
            cats.Add(cat00);
            cats.Add(cat01);
            cats.Add(cat02);
            cats.Add(cat03);
            cats.Add(cat04);
            cats.Add(cat05);
            cats.Add(cat06);

            foreach (var item in cats)
            {
                Debug.Log(item.name);
                if (item.name == "02")
                {
                    foreach (var x in cats)
                    {
                        Debug.Log(x.name);
                    }
                }
            }

            #endregion
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Cat
    {
        public string name = "Cat";

        public Cat(string _name)
        {
            name = _name;
        }
    }

    public delegate bool DMethodA(int i);
    static class TestA
    {
        public static void DeleteItemA<T>(this List<T> lst, DMethodA dele)
        {
            //lst.ForEach(t=>
            //{
            //    if ( )
            //    {

            //    }
            //});
        }
        public static void DeleteItemA<T>(this List<T> lst, Func<bool> fun)
        {
            //lst.ForEach(delegate (T t)
            //{
            //    if (fun())
            //        lst.Remove(t);
            //});

        }
    }
}

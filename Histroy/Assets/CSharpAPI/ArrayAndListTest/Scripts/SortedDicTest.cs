using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace History.CSharpAPI.SortedDictionaryTest
{
    /// <summary>
    /// 用来测试 有顺序的键值对
    /// </summary>
    public class SortedDicTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            SortedDictionary<int, string> sortedpairs = new SortedDictionary<int, string>();
            sortedpairs.Add(1, ("dog01"));
            sortedpairs.Add(2, ("dog02"));
            sortedpairs.Add(3, ("dog03"));
            sortedpairs.Add(4, ("dog04"));

            KeyValuePair<int, string> temp = sortedpairs.ElementAt(0);
            Debug.Log(temp.Value + temp.Key);

            sortedpairs.Remove(1);

            //Debug.Log(sortedpairs.Keys.Count);
            foreach (KeyValuePair<int,string> pair  in sortedpairs)
            {
                Debug.Log(pair.Key);
            }
            foreach (KeyValuePair<int, string> pair in sortedpairs)
            {
                Debug.Log(pair.Value);
            }

            sortedpairs.Remove(2);

            foreach (KeyValuePair<int, string> pair in sortedpairs)
            {
                Debug.Log(pair.Key);
            }
            foreach (KeyValuePair<int, string> pair in sortedpairs)
            {
                Debug.Log(pair.Value);
            }


            //Dictionary<int, string> pairs = new Dictionary<int, string>();
            //pairs.Add(10,"100");
            //pairs.Add(11,"101");
            //pairs.Add(12,"102");
            //pairs.Add(13,"103");
            //pairs.Add(14, "104");
            //pairs.Add(15, "105");
            //pairs.Add(16, "106");
            //pairs.Add(17, "107");
            //pairs.Add(18, "108");
            //pairs.Add(19, "109");

            //foreach (var item in pairs)
            //{
            //    Debug.Log(item.Value);
            //}

            //pairs.Remove(12);

            //foreach (var item in pairs)
            //{
            //    Debug.Log(item.Value);
            //}

            //pairs.Remove(17);
            //foreach (var item in pairs)
            //{
            //    Debug.Log(item.Value);
            //}
        }
    }
}
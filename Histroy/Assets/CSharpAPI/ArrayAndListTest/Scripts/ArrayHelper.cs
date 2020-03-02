using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CSharpAPI.ArrayTest
{
    public static class ArrayHelper
    {
        public static List<T> RemovePlus<T>(this List<T> array, Func<T, bool> condition)
        {
            var remove = array.FindAll(t => condition(t));
            remove.ForEach(q =>
            {
                array.Remove(q);
            });
            return array;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.DelegateTest
{
    public class ObserverTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

            Heater heater = new Heater();
            Alarm alarm = new Alarm();
            heater.BoilEvent += alarm.MakeAlert; // 注册方法
            //heater.BoilEvent += (new Alarm()).MakeAlert; // 给匿名对象注册方法
            //heater.BoilEvent += Display.ShowMsg; // 注册静态方法
            heater.BoilWater(); // 烧水，会自动调用注册过对象的方法
        }
    }

    public class Heater
    {
        private int temperature;

        public delegate void BoilHandler(int param);

        public event BoilHandler BoilEvent;

        public void BoilWater()
        {
            for (int i = 0; i <= 100; i++)
            {
                temperature = i;
                if (BoilEvent != null)
                {
                    BoilEvent(temperature); // 调用所有注册对象的方法
                }
            }
        }
    }

    public class Alarm
    {
        public void MakeAlert(int param)
        {
            //Console.WriteLine("Alarm：嘀嘀嘀，水已经 {0} 度了：", param);
            Debug.LogFormat("Alarm：嘀嘀嘀，水已经 {0} 度了：", param);
        }
    }

    public class Display
    {
        public static void ShowMsg(int param) // 静态方法
        {
            //Console.WriteLine("Display：水快烧开了，当前温度：{0}度。", param);
            Debug.LogFormat("Display：水快烧开了，当前温度：{0}度。", param);
        }
    }
}
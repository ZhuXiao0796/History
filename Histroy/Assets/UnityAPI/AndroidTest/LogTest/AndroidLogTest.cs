using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace History.UnityAPI.AndroidTest
{
    public class AndroidLogTest : MonoBehaviour
    {
        public static AndroidLogTest Instance;

        private string folder_android;

        string datapath_Enemy;
        string datapath_Pet;
        string datapath_Animator;

        private string file_Enemy = "Enemy.txt";
        private string file_Pet = "Pet.txt";
        private string file_Animator = "Animator.txt";

        private void Awake()
        {
            Instance = this;
        }
        void Start()
        {
            folder_android = System.DateTime.Now.Day.ToString();
            if (Application.platform == RuntimePlatform.Android)
            {
                DirectoryInfo dir = new DirectoryInfo(Application.persistentDataPath + "/"+ folder_android);
                dir.Create();
                //文件夹内的文件指定
                datapath_Enemy = Application.persistentDataPath + "/"+ folder_android + "/" + file_Enemy;
                datapath_Pet = Application.persistentDataPath + "/"+ folder_android + "/" + file_Pet;
                datapath_Animator = Application.persistentDataPath+ "/" + folder_android + "/" + file_Animator;
            }
            else if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                DirectoryInfo dir = new DirectoryInfo("G:/" + folder_android);
                if (dir.Exists)
                {
                    dir.Delete(true);
                }
                dir.Create();
                //文件夹内的文件指定
                datapath_Enemy = "G:/" + folder_android + "/" + file_Enemy;
                datapath_Pet = "G:/" + folder_android + "/" + file_Pet;
                datapath_Animator = "G:/" + folder_android + "/" + file_Animator;
            }
        }
        /// <summary>
        /// 流 编辑器
        /// </summary>
        StreamWriter writer;

        public void AndroidWrite(string sentece)
        {
            WriteLine(datapath_Animator,sentece);
        }

        /// <summary>
        /// 只负责写入，不负责路径和平台
        /// </summary>
        /// <param name="datapath"></param>
        /// <param name="sentence"></param>
        void WriteLine(string datapath, string sentence)
        {
            FileInfo fileInfo = new FileInfo(datapath);
            if (!fileInfo.Exists)
            {
                writer = fileInfo.CreateText();
            }
            else
            {
                writer = fileInfo.AppendText();
            }
            //writer.AutoFlush = true;
            //以 行的方式写入
            writer.WriteLine(sentence);

            // 释放 流
            writer.Close();
            ////在这里清空流的缓存，但是不关闭流，因为一直会用到
            //writer.Flush();

        }
        private AndroidLogTest()
        {

        }
    }
}

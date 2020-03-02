using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace History.AndroidTest
{
    /// <summary>
    /// 这个类用来测试在安卓实机上获取的时间函数
    /// </summary>
   public class AndroidTimeGetTest : MonoBehaviour
   {
        /// <summary>
        /// 文件路径
        /// </summary>
        private string folderName;

        /// <summary>
        /// 文本名称
        /// </summary>
        private string txtName = "Duan.txt";

        /// <summary>
        /// 路径
        /// </summary>
        private string datapath;

        /// <summary>
        /// 流 编辑器
        /// </summary>
        StreamWriter writer;
        // Start is called before the first frame update
        void Start()
        {
            FolderCreate();
            var x1 = System.DateTime.Now.ToString();
            WriteLine(x1,datapath);

            var x2 = System.DateTime.Now.Date.ToString();
            WriteLine(x2,datapath);
        }

        private void FolderCreate()
        {
           
            folderName = System.DateTime.Now.Day.ToString() + "日" + System.DateTime.Now.Hour.ToString() + "时" +
                System.DateTime.Now.Minute.ToString() + "分";
            if (Application.platform == RuntimePlatform.Android)
            {
                DirectoryInfo dir = new DirectoryInfo(Application.persistentDataPath + "/" + folderName);
                dir.Create();

                //文件夹内的文件指定
                datapath = Application.persistentDataPath + "/" + folderName + "/" + txtName;

            }
            else if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                DirectoryInfo dir = new DirectoryInfo("F:/" + folderName);
                if (dir.Exists)
                {
                    dir.Delete(true);
                }
                dir.Create();

                //文件夹内的文件指定
                datapath = "F:/" + folderName + "/" + txtName;
            }
        }


        private void WriteLine(string sentence,string datapath)
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

            //写入
            writer.WriteLine(sentence);

            // 释放 流
            writer.Close();
        }
    }
}

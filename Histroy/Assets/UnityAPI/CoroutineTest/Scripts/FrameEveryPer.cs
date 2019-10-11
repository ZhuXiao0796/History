﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace History.UnityAPI.CoroutineTest
{
    /// <summary>
    /// 这个脚本用来在左上角显示当前帧数
    /// 不过帧数是预先写好的
    /// 并且要关掉 Unity 编辑器里面的垂直同步设置
    /// </summary>
    public class FrameEveryPer : MonoBehaviour
    {

        public int FixedFrame = 30;

        private float m_LastUpdateShowTime = 0f;    //上一次更新帧率的时间;

        private float m_UpdateShowDeltaTime = 0.01f;//更新帧率的时间间隔;

        private int m_FrameUpdate = 0;//帧数;

        private float m_FPS = 0;

        void Awake()
        {
            Application.targetFrameRate = FixedFrame;
        }

        //// Use this for initialization
        //void Start()
        //{
        //    m_LastUpdateShowTime = Time.realtimeSinceStartup;
        //}

        //// Update is called once per frame
        //void Update()
        //{
        //    m_FrameUpdate++;
        //    if (Time.realtimeSinceStartup - m_LastUpdateShowTime >= m_UpdateShowDeltaTime)
        //    {
        //        m_FPS = m_FrameUpdate / (Time.realtimeSinceStartup - m_LastUpdateShowTime);
        //        m_FrameUpdate = 0;
        //        m_LastUpdateShowTime = Time.realtimeSinceStartup;
        //    }
        //}

        //void OnGUI()
        //{
        //    GUI.Label(new Rect(Screen.width / 2, 0, 100, 100), "FPS: " + m_FPS);
        //}
    }
}

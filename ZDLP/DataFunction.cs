using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Common.ComponentCs.Log;
using Common.ComponentCs;

namespace ZDLP
{
    public class DataFunction
    {
        /// <summary>
        /// 数据存储路径
        /// </summary>
        private string path;
        /// <summary>
        /// 数据流
        /// </summary>
        private FileStream[] fs_nb = new FileStream[196];
        private FileStream[] fs_bb = new FileStream[60];
        /// <summary>
        /// 数据存储标志位
        /// </summary>
        public bool m_FlagSave = false;

        private double m_StartFreq = 0f;
        private double m_StopFreq = 0f;

        public DataFunction()
        {

        }

        bool m_FlagSaveLast = false;

        public void PushChannelData_NB(byte[] t, double StartFreq, int channel, TimeInfo timeInfo)
        {
            m_StartFreq = StartFreq;
            m_StopFreq = m_StartFreq + 0.5;

            /*记录文件初始化*/
            if (!m_FlagSaveLast && m_FlagSave)
            {
                string time = timeInfo.year.ToString("d") + "_" + timeInfo.month.ToString("d") + "_" + timeInfo.day_offset.ToString("d") + "_" + timeInfo.hour.ToString("d") + "_" + timeInfo.minute.ToString("d") + "_" + timeInfo.second.ToString("d") + "_" + timeInfo.millisecond.ToString("d") + "_" + timeInfo.microsecond.ToString("d");
                path = @"RecvData\" + @"NarrowBand\" + time;
                DirectoryInfo fi = new DirectoryInfo(path);
                if (!fi.Exists)
                    fi.Create();
                for (int i = 0; i < 196; ++i)
                    fs_nb[i] = new FileStream(path + @"\" + "CH_" + (i + 1).ToString("d3") + "_" + time + ".dat", FileMode.OpenOrCreate | FileMode.Append);
                m_FlagSaveLast = true;
            }
            else if (m_FlagSaveLast && !m_FlagSave)
            {
                for (int i = 0; i < 196; ++i)
                    fs_nb[i].Close();
                m_FlagSaveLast = false;
            }

            if (m_FlagSave)
            {
                fs_nb[channel].Write(t, 0, t.Length);
            }
        }

        public void PushChannelData_BB(byte[] t, double StartFreq, int channel, TimeInfo timeInfo)
        {
            m_StartFreq = StartFreq;
            m_StopFreq = m_StartFreq + 0.5;

            /*记录文件初始化*/
            if (!m_FlagSaveLast && m_FlagSave)
            {
                string time = timeInfo.year.ToString("d") + "_" + timeInfo.month.ToString("d") + "_" + timeInfo.day_offset.ToString("d") + "_" + timeInfo.hour.ToString("d") + "_" + timeInfo.minute.ToString("d") + "_" + timeInfo.second.ToString("d") + "_" + timeInfo.millisecond.ToString("d") + "_" + timeInfo.microsecond.ToString("d");
                path = @"RecvData\" + @"BroadBand\" + time;
                DirectoryInfo fi = new DirectoryInfo(path);
                if (!fi.Exists)
                    fi.Create();
                for (int i = 0; i < 60; ++i)
                    fs_bb[i] = new FileStream(path + @"\" + "CH_" + (i + 1).ToString("d3") + "_" + time + ".dat", FileMode.OpenOrCreate | FileMode.Append);
                m_FlagSaveLast = true;
            }
            else if (m_FlagSaveLast && !m_FlagSave)
            {
                for (int i = 0; i < 60; ++i)
                    fs_bb[i].Close();
                m_FlagSaveLast = false;
            }

            if (m_FlagSave)
            {
                fs_bb[channel].Write(t, 0, t.Length);
            }
        }

        #region 存储原始IQ数据
        public void StartSave()
        {
            if (m_FlagSave)
                return;
            m_FlagSave = true;
        }

        public void StopSave()
        {
            if (!m_FlagSave)
                return;
            m_FlagSave = false;
        }

        #endregion
    }
}

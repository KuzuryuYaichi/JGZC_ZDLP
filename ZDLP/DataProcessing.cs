using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.ComponentCs.Log;
using Common.ComponentCs;

namespace ZDLP
{
    public class DataProcessing
    {
        private int m_DataPacket = 4096;
        private int m_ChannelCount = 20;
        private int RF_WorkMode = 0;//初始化值，0常规，1低噪声

        #region UDP底层数据传输
        public udpRecv udpRecv;

        public int udpRecvInit(string LocalIP, string[] GroupIP, int GroupPort)//窄带宽带数据接收与处理
        {
            udpRecv = new udpRecv(LocalIP, GroupIP, GroupPort);//建立udp连接
            udpRecv.passParameter += new udpRecv.PassInformationr(udpRecv_passParameter);//委托
            udpRecv.Start();//开始接收数据
            return 0;
        }

        public void udpRecvDestroy()
        {
            if (udpRecv != null)
            {
                udpRecv.Stop();
            }
        }
        #endregion

        #region 通道、分辨率、是否进行性能测试选择、确定当前子带的中心频点和带宽

        // 选择数据包中的子带
        private int m_PacketBandNum = 1;

        /// 选择分辨率
        private int ResolutionIndex = 0;
        private int m_Resolution = 1;
        private double[] IQDataResolution;

        private int band = 0;//初始化子带号
        private double nbddcfreq = 1.70;//初始化窄带中心频点
        public double nbddcbandwidth = 0.05;//初始化窄带带宽
        private double wbddcfreq = 1.75;//初始化宽带中心频点
        private double fftddcfreq = 1.75;//初始化FFT中心频点

        #endregion

        #region 初始化
        public DataFunction DataFunction;
        private Transform Transform = new Transform();

        public DataProcessing()
        {
            IQDataResolution = new double[m_DataPacket / 4];//初始化分辨率变量
            DataFunction = new DataFunction();//存储数据、时标检测类
        }

        #endregion

        #region 解析数据

        void udpRecv_passParameter(udpRecv sender, byte[] t)//委托事件，udpRecv类传递的数据LX
        {
            double StartFreq = 0d;//初始化起始频率LX
            double StopFreq = 0d;//初始化终止频率LX
            int Header_DataType = Convert.ToInt32(t[1]);//数据包帧头中的数据类型LX
            switch (Header_DataType)
            {
                case 1:
                    m_DataPacket = 2048;//每路IQ数据长度LX
                    m_ChannelCount = 1;//每包中的通道数（路数）LX
                    byte[][] ChannelData = new byte[m_ChannelCount][];//存放IQ数据的二维数组LX
                    byte[] Data = new byte[m_DataPacket];
                    m_PacketBandNum = t[2];
                    for (int i = 0; i < m_ChannelCount; i++)
                    {
                        ChannelData[i] = new byte[m_DataPacket];
                        Buffer.BlockCopy(t, 96 + m_DataPacket * i, ChannelData[i], 0, m_DataPacket);//接收到的数据分通道放入二维数组
                    }
                    if (m_PacketBandNum >= 0 && m_PacketBandNum <= 195)
                    {
                        Buffer.BlockCopy(ChannelData[m_ChannelCount - 1], 0, Data, 0, m_DataPacket);//从二位数组中取出选择的一路数据
                    }

                    StartFreq = nbddcfreq - nbddcbandwidth / 2000;//窄带起始频率
                    StopFreq = nbddcfreq + nbddcbandwidth / 2000;//窄带终止频率
                    DataFunction.PushChannelData_NB(Data, StartFreq, m_PacketBandNum, new TimeInfo(t));//时标检测
                    break;
                case 2:
                    m_DataPacket = 2048;//每路IQ数据长度LX
                    m_ChannelCount = 20;//每包中的通道数（路数）LX//20200224test
                    ChannelData = new byte[m_ChannelCount][];//存放IQ数据的二维数组LX
                    m_PacketBandNum = t[2];
                    byte[] Data_temp = new byte[m_DataPacket];
                    TimeInfo time = new TimeInfo(t);
                    for (int i = 0; i < m_ChannelCount; i++)
                    {
                        ChannelData[i] = new byte[m_DataPacket];
                        Buffer.BlockCopy(t, 96 + m_DataPacket * i, ChannelData[i], 0, m_DataPacket);//接收到的数据分通道放入二维数组
                        DataFunction.PushChannelData_BB(ChannelData[i], StartFreq, i + m_PacketBandNum * 20, time);//时标检测
                    }
                    break;

                default:
                    break;
            }
        }
        #endregion
    }
}

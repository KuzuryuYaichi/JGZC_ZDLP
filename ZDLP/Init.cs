using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ZDLP
{
    public partial class Form1 : Form
    {
        public int DevNetCtrlInit()
        {
            int res = DLLImport.InitialzeDevice("128.0.1.1", 4001, 28672, "128.0.82.130");
            return res;
        }

        public int DevNetDataSourceInit()
        {
            int BoardID = 0;
            int NetID = 3;
            string ip = "10.168.4.103";
            int res = DLLImport.DataSourceIP_B(BoardID, NetID, ip);
            if (res != 0)
                return res;
            Thread.Sleep(1);
            return 0;
        }

        public int DevNetDataDestInit()
        {
            int BoardID = 0;
            int NetID = 3;
            int ConnectID = 0;
            for (int i = 0; i < 196; ++i)
            {
                string ip = "239.1.1." + (i + 1);
                ushort disPort = 400;
                ushort srcPort = Convert.ToUInt16(2300 + i + 1);
                int res = DLLImport.DataDestIP_B(BoardID, NetID, ConnectID++, ip, disPort, srcPort);
                if (res != 0)
                    return res;
                Thread.Sleep(1);
            }
            DLLImport.DataAllEnable(1);
            return 0;
        }
        public int DataLinkEnable()
        {
            int BoardID = 0;
            int NetID = 3;
            int Enable = 1;
            for (int i = 0; i < 204; i++)
            {
                int ConnectID = i;
                int res = DLLImport.DataLinkEnable_B(BoardID, NetID, ConnectID, Enable);
                if (res != 0)
                    return res;
                Thread.Sleep(1);
            }
            return 0;
        }

        void NetInit()
        {
            int res = DevNetCtrlInit();
            if (res != 0)
            {
                Console.WriteLine("\r\n控制网络初始化失败！");
                return;
            }
            else
            {
                Console.WriteLine("\r\n控制网络初始化成功！");
            }
            res = DevNetDataSourceInit();
            if (res != 0)
            {
                Console.WriteLine("\r\n万兆网源端初始化失败！");
            }
            else
            {
                Console.WriteLine("\r\n万兆网源端初始化成功！");
            }

            res = DataLinkEnable();
            if (res != 0)
            {
                Console.WriteLine("\r\n万兆网数据使能开启失败！");
            }
            else
            {
                Console.WriteLine("\r\n万兆网数据使能开启成功！");
            }

            res = DevNetDataDestInit();
            if (res != 0)
            {
                Console.WriteLine("\r\n万兆网目的端初始化失败！");
            }
            else
            {
                Console.WriteLine("\r\n万兆网目的端初始化成功！");
            }

            DLLImport.RFGainValue(0);

            //ZD_GroupIP("10.168.4.14", 400);
        }

        DataProcessing m_DataProcessing = new DataProcessing();

        private void ZD_GroupIP(string m_NetLocalIP, int m_NetLocalPort)
        {
            string[] MulticastGroupNB = new string[196];
            for (int i = 0; i < 196; i++)
            {
                MulticastGroupNB[i] = "239.1.1." + (i + 1);
            }
            m_DataProcessing.udpRecvDestroy();
            if (m_DataProcessing.udpRecv != null)
                m_DataProcessing.udpRecv.ClearQueue();
            m_DataProcessing.udpRecvInit(m_NetLocalIP, MulticastGroupNB, m_NetLocalPort);
        }

        private void KD_GroupIP(string m_NetLocalIP, int m_NetLocalPort)
        {
            string[] MulticastGroupWB = new string[5];
            for (int i = 0; i < 5; i++)
            {
                MulticastGroupWB[i] = "239.1.1." + (197 + i);
            }
            m_DataProcessing.udpRecvDestroy();
            if (m_DataProcessing.udpRecv != null)
                m_DataProcessing.udpRecv.ClearQueue();
            m_DataProcessing.udpRecvInit(m_NetLocalIP, MulticastGroupWB, m_NetLocalPort);
        }
    };
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDLP
{
    class NBDDC
    {
        public int NBDDCIndex;//窄带子带序号
        public double[] NBDDCFreq = new double[196];//196路中心频点数组
        public int NBDDCBandWidthindex;//千兆网DLL下发的中心频点序号
        public double[] NBDDCBandWidth = new double[196];//196路带宽数组
    }

    class NBDDC_Index
    {
        public double NBDDCFreq = 1.5;
        public double NBDDCBandWidth = 1;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

namespace ZDLP
{
    public partial class Form1 : Form
    {
        BindingList<ColumnProperties> dataSrc = new BindingList<ColumnProperties>();
        NumProperties[] NumDataSrc = new NumProperties[96];
        object[] BandNum = new object[96];

        public Form1()
        {
            InitializeComponent();
            NetInit();
            radioButtons = new RadioButton[5] { RadioUserDefined, RadioAverage, RadioManual, RadioSize, RadioTime };
            dataGridView1.AutoGenerateColumns = false;
            ColumnPriority.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.DataSource = dataSrc;
            RadioUserDefined.Checked = true;
            RadioTime.Checked = true;
            RadioNB.Checked = true;
            dataGridView1.DataError += DataGridView1_DataError;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0: break;
                case 1:
                    {
                        int val = dataSrc[e.RowIndex].StartNum;
                        if (val < 1 || val > 196)
                            dataSrc[e.RowIndex].StartNum = 1;
                        break;
                    }
                case 2:
                    {
                        int val = dataSrc[e.RowIndex].EndNum;
                        if (val < 1 || val > 196)
                            dataSrc[e.RowIndex].EndNum = 1;
                        break;
                    }
                case 3:
                    {
                        double val = dataSrc[e.RowIndex].BandWidth;
                        if (findIndex(BANDWIDTH, val) < 0)
                            dataSrc[e.RowIndex].BandWidth = 1;
                        else
                            dataSrc[e.RowIndex].BandWidth = val;
                        break;
                    }
                case 4:
                    {
                        double val = dataSrc[e.RowIndex].Freq;
                        if (val < 1.5 || val > 30)
                            dataSrc[e.RowIndex].Freq = 1.5;
                        break;
                    }
            }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataSrc.Add(new ColumnProperties(dataSrc.Count + 1, 1, 1, 1, 1.5));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Selected)
                        dataSrc.RemoveAt(i);
                }
                int cnt = 0;
                foreach (ColumnProperties row in dataSrc)
                {
                    row.Priority = ++cnt;
                }
            }
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    ColumnProperties tmp = dataSrc[i - 1];
                    dataSrc[i - 1] = dataSrc[i];
                    dataSrc[i] = tmp;
                }
            }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    ColumnProperties tmp = dataSrc[i + 1];
                    dataSrc[i + 1] = dataSrc[i];
                    dataSrc[i] = tmp;
                }
            }
        }

        RadioButton[] radioButtons;

        private void RadioUserDefined_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = ((RadioButton)sender).Checked;
            PanelUserDefined.Enabled = Checked;
            PanelAverage.Enabled = !Checked;
            PanelFromFile.Enabled = !Checked;
        }

        private void RadioAverage_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = ((RadioButton)sender).Checked;
            PanelAverage.Enabled = Checked;
            PanelUserDefined.Enabled = !Checked;
            PanelFromFile.Enabled = !Checked;
        }

        private void RadioFromFile_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = ((RadioButton)sender).Checked;
            PanelFromFile.Enabled = Checked;
            PanelUserDefined.Enabled = !Checked;
            PanelAverage.Enabled = !Checked;
        }

        private void RadioTime_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = ((RadioButton)sender).Checked;
            PanelTime.Enabled = Checked;
            PanelSize.Enabled = !Checked;
            PanelManual.Enabled = !Checked;
        }

        private void RadioSize_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = ((RadioButton)sender).Checked;
            PanelSize.Enabled = Checked;
            PanelTime.Enabled = !Checked;
            PanelManual.Enabled = !Checked;
        }

        private void RadioManual_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = ((RadioButton)sender).Checked;
            PanelManual.Enabled = Checked;
            PanelTime.Enabled = !Checked;
            PanelSize.Enabled = !Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        NBDDC nbddc = new NBDDC();

        private void button1_Click(object sender, EventArgs e)
        {
            if (RadioAverage.Checked)
            {
                for (int i = 0; i < 196; i++)
                {
                    nbddc.NBDDCIndex = i;//选定子带号
                    nbddc.NBDDCBandWidthindex = comboBandWidth.SelectedIndex; ;//带宽序号0~13（千兆网DLL下发）
                    nbddc.NBDDCFreq[nbddc.NBDDCIndex] = i * 0.1 + double.Parse(txtBaseBand.Text);//给选定子带的中心频点数组赋值
                    nbddc.NBDDCBandWidth[nbddc.NBDDCIndex] = Convert.ToDouble(comboBandWidth.Text);//给选定子带的带宽数组赋值
                    int ret = DLLImport.NBDDCFreqBand(nbddc.NBDDCIndex, nbddc.NBDDCBandWidthindex, nbddc.NBDDCFreq[nbddc.NBDDCIndex] * 10);
                    if (ret != 0)
                    {
                        Console.WriteLine("NarrowBand Channel " + i + " Configured Failed");
                    }
                }
            }
            else if (RadioUserDefined.Checked)
            {
                NBDDC_Index[] nbddc_index = new NBDDC_Index[196];
                for (int i= 0;i < 196; i++)
                {
                    nbddc_index[i] = new NBDDC_Index();
                }
                    
                for (int i = dataSrc.Count - 1; i >= 0; --i)
                {
                    ColumnProperties column = dataSrc[i];
                    for (int j = column.StartNum - 1; j < column.EndNum; ++j)
                    {
                        nbddc_index[j].NBDDCBandWidth = column.BandWidth;
                        nbddc_index[j].NBDDCFreq = column.Freq;
                    }
                }

                for (int i = 0; i < 196; i++)
                {
                    int ret = DLLImport.NBDDCFreqBand(i, findIndex(BANDWIDTH, nbddc_index[i].NBDDCBandWidth), nbddc_index[i].NBDDCFreq * 10);
                    if (ret != 0)
                    {
                        Console.WriteLine("NarrowBand Channel " + i + " Configured Failed");
                    }
                }
            }
        }

        int findIndex(double[] b, double a)
        {
            for (int i = 0; i < b.Length; i++)
                if (b[i] == a)
                    return i;
            return -1;
        }

        double[] BANDWIDTH = new double[]{1, 1.5, 2.1, 2.4, 2.7, 3.2, 4, 4.8, 6, 9, 12, 15, 30, 50};

    private void button4_Click(object sender, EventArgs e)
        {
            if (m_DataProcessing.DataFunction.m_FlagSave)
            {
                m_DataProcessing.DataFunction.StopSave();
                GroupBandSet.Enabled = true;
                button4.Text = "开始存储";
            }
            else
            {
                m_DataProcessing.DataFunction.StartSave();
                GroupBandSet.Enabled = false;
                button4.Text = "停止存储";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Thread((() =>
            {
                this.BeginInvoke(new AsyncCallback((r) =>
                {
                    PanelSize.Enabled = false;
                    PanelSize.Enabled = true;
                }), null);
                
            })).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread((() =>
            {
                this.BeginInvoke(new AsyncCallback((r) =>
                {
                    PanelTime.Enabled = false;
                    PanelTime.Enabled = true;
                }), null);

            })).Start();
        }

        private void RadioNB_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = ((RadioButton)sender).Checked;
            GroupBandSet.Enabled = Checked;
            if(Checked)
                ZD_GroupIP("10.168.4.14", 400);
        }

        private void RadioWB_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = ((RadioButton)sender).Checked;
            if (Checked)
                KD_GroupIP("10.168.4.14", 400);
            GroupBandSet.Enabled = !Checked;
            PanelAverage.Enabled = !Checked;
            PanelFromFile.Enabled = !Checked;
            PanelUserDefined.Enabled = !Checked;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string path = @"Config\";
            DirectoryInfo fi = new DirectoryInfo(path);
            if (!fi.Exists)
                fi.Create();
            FileStream fs = new FileStream(path + "\\" + "Config.json", FileMode.Create);
            string ConfigStr = JsonConvert.SerializeObject(dataSrc);
            byte[] bb = System.Text.Encoding.Default.GetBytes(ConfigStr);
            fs.Write(bb, 0, bb.Length);
            fs.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string path = @"Config\";
            DirectoryInfo fi = new DirectoryInfo(path);
            if (!fi.Exists)
                fi.Create();
            FileStream fs = new FileStream(path + "\\" + "Config.json", FileMode.OpenOrCreate);
            byte[] bb = new byte[4096];
            fs.Read(bb, 0, bb.Length);
            string ConfigStr = System.Text.Encoding.Default.GetString(bb);
            fs.Close();
            BindingList<ColumnProperties> config = JsonConvert.DeserializeObject<BindingList<ColumnProperties>>(ConfigStr);
            if (config != null)
            {
                dataGridView1.DataSource = dataSrc = config;
            }
        }
    }
}

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ZDLP
{
    public class ColumnProperties : INotifyPropertyChanged
    {
        private int _Priority;
        private int _StartNum;
        private int _EndNum;
        private double _BandWidth;
        private double _Freq;

        public int Priority
        {
            get { return _Priority; }
            set
            {
                if(value != _Priority)
                {
                    _Priority = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int StartNum
        {
            get { return _StartNum; }
            set
            {
                if (value != _StartNum)
                {
                    _StartNum = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int EndNum
        {
            get { return _EndNum; }
            set
            {
                if (value != _EndNum)
                {
                    _EndNum = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double BandWidth
        {
            get { return _BandWidth; }
            set
            {
                if (value != _BandWidth)
                {
                    _BandWidth = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double Freq
        {
            get { return _Freq; }
            set
            {
                if (value != _Freq)
                {
                    _Freq = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if(PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ColumnProperties(int Priority, int StartNum, int EndNum, double BandWidth, double Freq)
        {
            this.Priority = Priority;
            this.StartNum = StartNum;
            this.EndNum = EndNum;
            this.BandWidth = BandWidth;
            this.Freq = Freq;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSample
{
    public class SomeData : IDataErrorInfo, INotifyDataErrorInfo
    {
        private int _x;

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Y))
                {
                    if (Y > 25)
                    {
                        return "Wrong value in y";
                    }
                }
                return null;
            }
        }

        public int X
        {
            get => _x;
            set
            {
                if (value > 25) throw new Exception("bad bad value");
                _x = value;
            }
        }

        public int Y { get; set; }

        public string Error => throw new NotImplementedException();
    }
}

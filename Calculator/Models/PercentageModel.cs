using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class PercentageModel
    {
        private double _initialAmount;
        private double _percentage;
        private double _result;

        public double InitialAmount
        {
            get { return _initialAmount; }
            set { _initialAmount = value; }
        }

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public double Result
        {
            get { return _result; }
            set { _result = value; }
        }
    }
}

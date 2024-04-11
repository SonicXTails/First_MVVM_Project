using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    // Модель для основного калькулятора
    public class CalculatorModel
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string Operator { get; set; }
        public double Result { get; set; }
    }
}

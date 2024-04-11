using System.Collections.ObjectModel;
using Calculator.Models;

namespace Calculator.ViewModels
{
    internal class HistoryViewModel
    {
        public ObservableCollection<CalculatorModel> History { get; set; }

        public HistoryViewModel()
        {
            History = new ObservableCollection<CalculatorModel>();
        }
    }
}
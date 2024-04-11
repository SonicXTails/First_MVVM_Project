using System.Windows.Input;
using Calculator.Models;
using Calculator.ViewModels.Helpers;

namespace Calculator.ViewModels
{
    internal class PercentageCalculatorViewModel : ViewModelBase
    {
        private PercentageModel _percentageModel;

        public double InitialAmount
        {
            get { return _percentageModel.InitialAmount; }
            set
            {
                _percentageModel.InitialAmount = value;
                OnPropertyChanged(nameof(InitialAmount));
            }
        }

        public double Percentage
        {
            get { return _percentageModel.Percentage; }
            set
            {
                _percentageModel.Percentage = value;
                OnPropertyChanged(nameof(Percentage));
            }
        }

        public double Result
        {
            get { return _percentageModel.Result; }
            set
            {
                _percentageModel.Result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ICommand CalculatePercentageCommand { get; }

        public PercentageCalculatorViewModel()
        {
            _percentageModel = new PercentageModel();
            CalculatePercentageCommand = new BindableCommand(CalculatePercentage, CanCalculatePercentage);
        }

        private bool CanCalculatePercentage(object parameter)
        {
            if (InitialAmount == 0 || Percentage == 0)
                return false;
            if (InitialAmount < 0 || Percentage < 0)
                return false;

            return true;
        }

        private void CalculatePercentage(object parameter)
        {
            Result = InitialAmount * (Percentage / 100);
        }
    }
}

using Calculator.Models;
using Calculator.ViewModels.Helpers;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Calculator.Views;

namespace Calculator.ViewModels
{
    #region Свойства
    public class CalculatorViewModel : ViewModelBase
    {
        private CalculatorModel _calculator;
        public ObservableCollection<CalculatorModel> History { get; set; }

        public CalculatorViewModel()
        {
            _calculator = new CalculatorModel();
            History = new ObservableCollection<CalculatorModel>();
            CalculateCommand = new BindableCommand(Calculate);

            OpenHistoryCommand = new BindableCommand(OpenHistory);

            OpenPercentageCalculatorCommand = new BindableCommand(OpenPercentageCalculator);
        }

        private void AddToHistory()
        {
            History.Add(new CalculatorModel
            {
                FirstNumber = FirstNumber,
                SecondNumber = SecondNumber,
                Operator = Operator,
                Result = Result
            });
        }

        public double FirstNumber
        {
            get { return _calculator.FirstNumber; }
            set
            {
                _calculator.FirstNumber = value;
                OnPropertyChanged(nameof(FirstNumber));
            }
        }

        public double SecondNumber
        {
            get { return _calculator.SecondNumber; }
            set
            {
                _calculator.SecondNumber = value;
                OnPropertyChanged(nameof(SecondNumber));
            }
        }

        public string Operator
        {
            get { return _calculator.Operator; }
            set
            {
                _calculator.Operator = value;
                OnPropertyChanged(nameof(Operator));
            }
        }

        public double Result
        {
            get { return _calculator.Result; }
            set
            {
                _calculator.Result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
        #endregion

    #region Логика для калькулятора
        public ICommand CalculateCommand { get; }

        private void Calculate(object parameter)
        {
            if (string.IsNullOrEmpty(Operator))
            {
                MessageBox.Show("Не выбран оператор!");
                return;
            }

            switch (Operator)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    if (SecondNumber != 0)
                        Result = FirstNumber / SecondNumber;
                    else
                        MessageBox.Show("Деление на ноль не поддерживается!");
                    break;
                default:
                    MessageBox.Show("Вы выбрали несуществующий оператор! (хз как :) )");
                    break;
            }
            AddToHistory();
        }
        #endregion

    #region Открытие истории
        public ICommand OpenHistoryCommand { get; }

        private void OpenHistory(object parameter)
        {
            // Создание и отображение окна истории
            var historyWindow = new HistoryWindow();
            historyWindow.DataContext = new HistoryViewModel
            {
                History = this.History
            };
            historyWindow.Show();
        }

        public ICommand OpenPercentageCalculatorCommand { get; }
        private void OpenPercentageCalculator(object parameter)
        {
            // Создание и отображение окна калькулятора процентов
            var percentageCalculatorWindow = new PercentageCalculatorWindow();
            percentageCalculatorWindow.Show();
        }
    }
    #endregion

    #region Изменения полей
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #endregion
}

using Calculator.ViewModel.Algorithm;
using Calculator.ViewModel.Command;
using Calculator.ViewModel.Delegate;
using Calculator.ViewModel.Interfaces;
using Calculator.ViewModel.ObjectAsParameter;
using Calculator.ViewModel.Subtraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Calculator.ViewModel.MainViewModel.Standard
{
    public class StandardViewModel : INotifyPropertyChanged, IStandardViewModel
    {
        StatusEventArgs args = new StatusEventArgs();
        private StringBuilder CheckDetail = new StringBuilder();

        /*
        //SingleTon: 1.
        private static readonly StandardViewModel _instance = new StandardViewModel();
        public static StandardViewModel GetInstance()
        {
            return _instance;
        }
        private StandardViewModel(){}
        */
        public StandardViewModel()
        {

            AddCommand = new RelayCommand(Summing);
            SubtractCommand = new RelayCommand(Minusing);
            MultiplyCommand = new RelayCommand(Multiplying);
            DividCommand = new RelayCommand(Dividing);
            EqualCommand = new RelayCommand(EqualTo);
            CheckCommand = new RelayCommand(CheckEquationFlow);
            ClearAllCommand = new RelayCommand(ClearAllExpression);
            PowerCommand = new RelayCommand(PowerCalculation);
            RemainderCommand = new RelayCommand(RemainderCalculation);
            SqrtCommand = new RelayCommand(SqrtCalculation);
            PercentCommand = new RelayCommand(PercentageCalculation);

            FetchResult += FactchResult; //Normal delegate subscribe.

            OperationChanged += StandardViewModel_OperationChanged;

            /*
            //Delegate inference: need not to write "+=new StatusDelegate(StandardViewModel_OperationChanged)". 
            //Bring Typing effort down. Compiler will auto understand this is delegate.
            OperationChanged += StandardViewModel_OperationChanged; 

            //OR

            // Event handler directly hooked to delegate. {Delegate with anonymous methode}
            OperationChanged += delegate (object sender, StatusEventArgs e)
            {
                if (OperationChanged != null)
                {
                    File.AppendAllText("abc.txt", "\n" + args.OperationName);
                    CheckDetail.AppendLine(args.OperationName + args.OperationStatus);
                }
            };
            
            //OR
            // Lambdas With delegates.
            OperationChanged += (s, e) =>
            {
                if (OperationChanged != null)
                {
                    File.AppendAllText("abc.txt", "\n" + args.OperationName);
                    CheckDetail.AppendLine(args.OperationName + args.OperationStatus);
                }
                return s.ToString()+": "+ e.OperationName +": " + e.OperationStatus;
            };
            */
        }



        #region Event

        //Func<object, StatusEventArgs, string>: This can take n no of parameter and also return a value.
        Func<object, StatusEventArgs, string> OperationChanged;

        //Action<StatusEventArgs> return type always void.Inside action you can pass more then one parameter also i.e. Action<int, int> del1.
        //Action<object, StatusEventArgs> OperationChanged;
        //OR 
        //public event StatusDelegate OperationChanged;


        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<FetchResultArgs> FetchResult;

        //incase of action<T,T> return type should be void.
       // private void StandardViewModel_OperationChanged(object sender, StatusEventArgs e)
        private string StandardViewModel_OperationChanged(object sender, StatusEventArgs e)
        {
            if (OperationChanged != null)
            {
                File.AppendAllText("abc.txt", "\n" + args.OperationName);
                CheckDetail.AppendLine(args.OperationName + args.OperationStatus);
            }

            return "done";
        }

        
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        #region Methode 
        private void FactchResult(object sender, FetchResultArgs signpassed)
        {
            try
            {
                if (FetchResult != null)
                {
                    Regex re = new Regex(@"(?:[0-9]+)");
                    var SignList = re.Split(Expression);

                    var Values = Expression.Split('+', '-', '*', '/', '^', '\\', 'r', '%');
                    CalcultedValue = 0;
                    int i = 0;
                    CheckDetail.Clear();
                    CalcultedValue = CalcultedValue == 0 ? Convert.ToDouble(Values[i]) : CalcultedValue;
                    foreach (var item in Values)
                    {
                        double ValueTwo = Values.Length > 1 ? Convert.ToDouble(Values[i + 1]) : 0;
                        string sign = SignList.Length > 2 ? SignList[i + 1] : signpassed.ToString();
                        ICalculate Operation_ = CalCulationType.CalculationType.OperationType(sign);
                        CalcultedValue = Operation_.Calculate(CalcultedValue, Convert.ToDouble(ValueTwo));
                        //Thread.Sleep(1000);
                        args.OperationName = Operation_.ToString();
                        args.OperationStatus = $" = {CalcultedValue}";
                        string s = OperationChanged(this, args);
                        //OperationChanged(this, args);

                        if (Values.Length == 2)
                        {
                            break;
                        }
                        i++;
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (!Expression.EndsWith("+") && !Expression.EndsWith("-") && !Expression.EndsWith("*") && !Expression.EndsWith("/") && signpassed.sign != "=")
                {
                    Expression += signpassed.sign;
                }
            }
        }
        #endregion
        #endregion

        #region Commands
        public ICommand AddCommand { get; set; }
        public ICommand SubtractCommand { get; set; }
        public ICommand MultiplyCommand { get; set; }
        public ICommand DividCommand { get; set; }
        public ICommand EqualCommand { get; set; }
        public ICommand CheckCommand { get; set; }
        public ICommand ClearAllCommand { get; set; }
        public ICommand PowerCommand { get; set; }
        public ICommand RemainderCommand { get; set; }
        public ICommand SqrtCommand { get; set; }
        public ICommand PercentCommand { get; set; }


        #endregion

        #region Properties
        private double _calcultedValue = 0;
        public double CalcultedValue
        {
            get
            {
                return _calcultedValue;
            }
            set
            {
                _calcultedValue = value;
                RaisePropertyChanged("CalcultedValue");
            }
        }
        private string _expression = "0";
        public string Expression
        {
            get { return _expression; }
            set
            {
                try
                {

                    if (Regex.IsMatch(value, @"(?:[0-9+*/-])"))
                    {
                        _expression = value;
                    }
                    RaisePropertyChanged("Expression");
                }
                catch
                {
                    _expression = "0";
                }
            }
        }
        private string _operation = "Calculation will happen fron left to right. \nBODMAS rule is not implemented. \nAvailable operations Addition, Subtraction, Multiplication, Division and Equals.";
        public string Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                RaisePropertyChanged("Operation");
            }
        }

        #endregion

        #region Algorith
        public void Summing(object a)
        {
            Operation = Enum.OperatorEnum.Addition.ToString();
            FetchResultArgs resultArgs = new FetchResultArgs() { sign = "+" };
            FetchResult(this, resultArgs);
        }
        public void Minusing(object a)
        {
            Operation = Enum.OperatorEnum.subtraction.ToString();
            FetchResultArgs resultArgs = new FetchResultArgs() { sign = "-" };
            FetchResult(this, resultArgs);
        }
        public void Multiplying(object a)
        {
            Operation = Enum.OperatorEnum.Multipllication.ToString();
            FetchResultArgs resultArgs = new FetchResultArgs() { sign = "*" };
            FetchResult(this, resultArgs);
        }
        public void Dividing(object a)
        {
            Operation = Enum.OperatorEnum.Division.ToString();
            FetchResultArgs resultArgs = new FetchResultArgs() { sign = "/" };
            FetchResult(this, resultArgs);
        }
        public void EqualTo(object a)
        {
            Operation = Enum.OperatorEnum.Equal.ToString();
           FetchResultArgs resultArgs = new FetchResultArgs() { sign = "=" };
            FetchResult(this, resultArgs);
        }
        public void CheckEquationFlow(object a)
        {
            Operation = CheckDetail?.ToString();
        }
        public void ClearAllExpression(object a)
        {
            CheckDetail.Clear();
            Expression = "0";
        }
        public void PowerCalculation(object a)
        {
            Operation = Enum.OperatorEnum.Power.ToString();
            FetchResultArgs resultArgs = new FetchResultArgs() { sign = "^" };
            FetchResult(this, resultArgs);
        }
        public void RemainderCalculation(object a)
        {
            Operation = Enum.OperatorEnum.Remainder.ToString();
            FetchResultArgs resultArgs = new FetchResultArgs() { sign = "r" };
            FetchResult(this, resultArgs);
        }
        public void SqrtCalculation(object a)
        {
            Operation = Enum.OperatorEnum.SquareRoot.ToString(); 
            FetchResultArgs resultArgs = new FetchResultArgs() { sign = "\\" };
            FetchResult(this, resultArgs);
            Expression = "0";
        }
        public void PercentageCalculation(object a)
        {
            Operation = Enum.OperatorEnum.SquareRoot.ToString();
            FetchResultArgs resultArgs = new FetchResultArgs() { sign = "%" };
            FetchResult(this, resultArgs);
        }

        #endregion


    }
}

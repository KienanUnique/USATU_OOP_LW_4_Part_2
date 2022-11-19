namespace USATU_OOP_LW_4_Part_2
{
    public class ModelOfInequalityOfThreeNumbers
    {
        public delegate void NeedChangeNum(int newValue);

        public event NeedChangeNum UiUpdateA;
        public event NeedChangeNum UiUpdateB;
        public event NeedChangeNum UiUpdateC;

        private readonly int _maxValue, _minValue;
        private int _numA;
        private int _numB;
        private int _numC;

        public int NumA
        {
            get => _numA;
            private set => _numA = value;
        }

        public int NumB
        {
            get => _numB;
            private set
            {
                _numB = value;
                if (value < _numA)
                {
                    NumA = value;
                    UiUpdateA?.Invoke(NumA);
                }
            }
        }

        public int NumC
        {
            get => _numC;
            private set
            {
                _numC = value;
                if (value < NumB)
                {
                    NumB = value;
                    UiUpdateB?.Invoke(NumB);
                }
            }
        }

        public void TrySetA(string newValueString)
        {
            if (int.TryParse(newValueString, out var newValue))
            {
                TrySetA(newValue);
            }
            else
            {
                UiUpdateA?.Invoke(NumA);
            }
        }

        public void TrySetB(string newValueString)
        {
            if (int.TryParse(newValueString, out var newValue))
            {
                TrySetB(newValue);
            }
            else
            {
                UiUpdateB?.Invoke(NumB);
            }
        }

        public void TrySetC(string newValueString)
        {
            if (int.TryParse(newValueString, out var newValue))
            {
                TrySetC(newValue);
            }
            else
            {
                UiUpdateC?.Invoke(NumC);
            }
        }

        public void TrySetA(int newValue)
        {
            if (IsNumInAcceptableRange(newValue) && newValue <= NumB)
            {
                NumA = newValue;
            }

            UiUpdateA?.Invoke(NumA);
        }

        public void TrySetB(int newValue)
        {
            if (IsNumInAcceptableRange(newValue) && newValue <= NumC)
            {
                NumB = newValue;
            }

            UiUpdateB?.Invoke(NumB);
        }

        public void TrySetC(int newValue)
        {
            if (IsNumInAcceptableRange(newValue))
            {
                NumC = newValue;
            }

            UiUpdateC?.Invoke(NumC);
        }

        public ModelOfInequalityOfThreeNumbers(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
            _numA = minValue;
            _numB = (minValue + maxValue) / 2;
            _numC = maxValue;
        }

        private bool IsNumInAcceptableRange(int numToCheck)
        {
            return _minValue <= numToCheck && _maxValue >= numToCheck;
        }
    }
}
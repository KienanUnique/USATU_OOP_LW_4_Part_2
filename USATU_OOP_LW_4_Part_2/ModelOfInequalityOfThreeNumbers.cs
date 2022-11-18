namespace USATU_OOP_LW_4_Part_2
{
    public class ModelOfInequalityOfThreeNumbers
    {
        public delegate void NeedChangeNum(int newValue);

        public event NeedChangeNum ChangeA;
        public event NeedChangeNum ChangeB;
        public event NeedChangeNum ChangeC;

        private readonly int _maxValue, _minValue;
        private int _numA;
        private int _numB;
        private int _numC;

        public int NumA
        {
            get => _numA;
            private set
            {
                _numA = value;
                ChangeA?.Invoke(value);
            }
        }

        public int NumB
        {
            get => _numB;
            private set
            {
                _numB = value;
                ChangeB?.Invoke(value);
                if (value < _numA)
                {
                    NumA = value;
                }
            }
        }

        public int NumC
        {
            get => _numC;
            private set
            {
                _numC = value;
                ChangeC?.Invoke(value);
                if (value < NumB)
                {
                    NumB = value;
                }
            }
        }

        public bool TrySetA(int newValue)
        {
            if (_minValue <= NumA && _maxValue >= NumA && newValue < _numB)
            {
                NumA = newValue;
                return true;
            }

            return false;
        }

        public bool TrySetB(int newValue)
        {
            if (_minValue <= NumB && _maxValue >= NumB && newValue < _numC)
            {
                NumB = newValue;
                return true;
            }

            return false;
        }

        public bool TrySetC(int newValue) // TODO: return value itself
        {
            if (_minValue <= NumC && _maxValue >= NumC)
            {
                NumC = newValue;
                return true;
            }

            return false;
        }

        public ModelOfInequalityOfThreeNumbers(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
            _numA = minValue;
            _numB = (minValue + maxValue) / 2;
            _numC = maxValue;
        }
    }
}
namespace USATU_OOP_LW_4_Part_2
{
    public class ModelOfInequalityOfThreeNumbers
    {
        public delegate void NeedChangeNum(int newValue);

        public event NeedChangeNum UiUpdateA;
        public event NeedChangeNum UiUpdateB;
        public event NeedChangeNum UiUpdateC;

        public const int MaxValue = 100;
        public const int MinValue = 0;

        public int NumA { get; private set; }

        public int NumB { get; private set; }

        public int NumC { get; private set; }

        public ModelOfInequalityOfThreeNumbers()
        {
            if (FileStorageOfThreeNumbers.IsFileExists())
            {
                (NumA, NumB, NumC) = FileStorageOfThreeNumbers.GetThreeNumbersFromStorage();
                if (IsNumInAcceptableRange(NumA) && IsNumInAcceptableRange(NumB) && IsNumInAcceptableRange(NumC) &&
                    NumA <= NumB && NumA <= NumC && NumB <= NumC) return;
            }
            NumA = MinValue;
            NumB = (MinValue + MaxValue) / 2;
            NumC = MaxValue;
            FileStorageOfThreeNumbers.WriteThreeNumbersToStorage(NumA, NumB, NumC);
        }

        public void WriteDataToFile()
        {
            FileStorageOfThreeNumbers.WriteThreeNumbersToStorage(NumA, NumB, NumC);
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
            if (IsNumInAcceptableRange(newValue) && newValue >= NumA && newValue <= NumC)
            {
                NumB = newValue;
            }

            UiUpdateB?.Invoke(NumB);
        }

        public void TrySetC(int newValue)
        {
            if (IsNumInAcceptableRange(newValue) && newValue >= NumB)
            {
                NumC = newValue;
            }

            UiUpdateC?.Invoke(NumC);
        }

        private bool IsNumInAcceptableRange(int numToCheck)
        {
            return MinValue <= numToCheck && MaxValue >= numToCheck;
        }
    }
}
using System;
using System.Windows.Forms;

namespace USATU_OOP_LW_4_Part_2
{
    public partial class FormMain : Form
    {
        private const int MaxValue = 100;
        private const int MinValue = 0;
        private readonly ModelOfInequalityOfThreeNumbers _modelOfInequality = new(MinValue, MaxValue);

        private void UiUpdateValueA(int newValue)
        {
            textBoxA.Text = newValue.ToString();
            numericUpDownA.Value = newValue;
            trackBarA.Value = newValue;
        }
        
        private void UiUpdateValueB(int newValue)
        {
            textBoxB.Text = newValue.ToString();
            numericUpDownB.Value = newValue;
            trackBarB.Value = newValue;
        }
        
        private void UiUpdateValueC(int newValue)
        {
            textBoxC.Text = newValue.ToString();
            numericUpDownC.Value = newValue;
            trackBarC.Value = newValue;
        }
        public FormMain()
        {
            _modelOfInequality.ChangeA += UiUpdateValueA;
            _modelOfInequality.ChangeB += UiUpdateValueB;
            _modelOfInequality.ChangeC += UiUpdateValueC;
            InitializeComponent();
            numericUpDownA.Maximum = MaxValue;
            numericUpDownB.Maximum = MaxValue;
            numericUpDownC.Maximum = MaxValue;
            trackBarA.Maximum = MaxValue;
            trackBarB.Maximum = MaxValue;
            trackBarC.Maximum = MaxValue;
            trackBarA.Minimum = MinValue;
            trackBarB.Minimum = MinValue;
            trackBarC.Minimum = MinValue;
            numericUpDownA.Minimum = MinValue;
            numericUpDownB.Minimum = MinValue;
            numericUpDownC.Minimum = MinValue;
            UiUpdateValueA(_modelOfInequality.NumA);
            UiUpdateValueB(_modelOfInequality.NumB);
            UiUpdateValueC(_modelOfInequality.NumC);
        }

        private void textBoxA_TryChangeA()
        {
            if (!int.TryParse(textBoxA.Text, out var newValue) || !_modelOfInequality.TrySetA(newValue))
            {
                textBoxA.Text = _modelOfInequality.NumA.ToString();
            }
        }
        private void textBoxA_Leave(object sender, EventArgs e)
        {
            textBoxA_TryChangeA();
        }
        
        private void textBoxA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxA_TryChangeA();
            }
        }


        private void textBoxB_TryChangeB()
        {
            if (!int.TryParse(textBoxB.Text, out var newValue) || !_modelOfInequality.TrySetB(newValue))
            {
                textBoxB.Text = _modelOfInequality.NumB.ToString();
            }
        }
        
        private void textBoxB_Leave(object sender, EventArgs e)
        {
            textBoxB_TryChangeB();
        }
        
        private void textBoxB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxB_TryChangeB();
            }
        }
        
        private void textBoxC_TryChangeC()
        {
            if (!int.TryParse(textBoxC.Text, out var newValue) || !_modelOfInequality.TrySetC(newValue))
            {
                textBoxC.Text = _modelOfInequality.NumC.ToString();
            }
        }
        
        private void textBoxC_Leave(object sender, EventArgs e)
        {
            textBoxC_TryChangeC();
        }
        
        private void textBoxC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxC_TryChangeC();
            }
        }
    }
}
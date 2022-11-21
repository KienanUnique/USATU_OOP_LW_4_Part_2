using System;
using System.Windows.Forms;

namespace USATU_OOP_LW_4_Part_2
{
    public partial class FormMain : Form
    {
        private readonly ModelOfInequalityOfThreeNumbers _modelOfInequality = new();

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
            InitializeComponent();

            numericUpDownA.Maximum = ModelOfInequalityOfThreeNumbers.MaxValue;
            numericUpDownB.Maximum = ModelOfInequalityOfThreeNumbers.MaxValue;
            numericUpDownC.Maximum = ModelOfInequalityOfThreeNumbers.MaxValue;
            trackBarA.Maximum = ModelOfInequalityOfThreeNumbers.MaxValue;
            trackBarB.Maximum = ModelOfInequalityOfThreeNumbers.MaxValue;
            trackBarC.Maximum = ModelOfInequalityOfThreeNumbers.MaxValue;

            trackBarA.Minimum = ModelOfInequalityOfThreeNumbers.MinValue;
            trackBarB.Minimum = ModelOfInequalityOfThreeNumbers.MinValue;
            trackBarC.Minimum = ModelOfInequalityOfThreeNumbers.MinValue;
            numericUpDownA.Minimum = ModelOfInequalityOfThreeNumbers.MinValue;
            numericUpDownB.Minimum = ModelOfInequalityOfThreeNumbers.MinValue;
            numericUpDownC.Minimum = ModelOfInequalityOfThreeNumbers.MinValue;

            UiUpdateValueC(_modelOfInequality.NumC);
            UiUpdateValueB(_modelOfInequality.NumB);
            UiUpdateValueA(_modelOfInequality.NumA);

            textBoxA.KeyUp += TextControlsNumA_KeyUp;
            textBoxA.Leave += TextControlsNumA_TrySetValue;
            numericUpDownA.KeyUp += TextControlsNumA_KeyUp;
            numericUpDownA.Leave += TextControlsNumA_TrySetValue;
            trackBarA.ValueChanged += trackBarA_TrySetValue;


            textBoxB.KeyUp += TextControlsNumB_KeyUp;
            textBoxB.Leave += TextControlsNumB_TrySetValue;
            numericUpDownB.KeyUp += TextControlsNumB_KeyUp;
            numericUpDownB.Leave += TextControlsNumB_TrySetValue;
            trackBarB.ValueChanged += trackBarB_TrySetValue;

            textBoxC.KeyUp += TextControlsNumC_KeyUp;
            textBoxC.Leave += TextControlsNumC_TrySetValue;
            numericUpDownC.KeyUp += TextControlsNumC_KeyUp;
            numericUpDownC.Leave += TextControlsNumC_TrySetValue;
            trackBarC.ValueChanged += trackBarC_TrySetValue;

            _modelOfInequality.UiUpdateA += UiUpdateValueA;
            _modelOfInequality.UiUpdateB += UiUpdateValueB;
            _modelOfInequality.UiUpdateC += UiUpdateValueC;
        }

        private void TextControlsNumA_TrySetValue(object sender, EventArgs e)
        {
            var control = sender as Control;
            _modelOfInequality.TrySetA(control.Text);
        }

        private void TextControlsNumA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextControlsNumA_TrySetValue(sender, e);
            }
        }

        private void trackBarA_TrySetValue(object sender, EventArgs e)
        {
            _modelOfInequality.TrySetA(trackBarA.Value);
        }

        private void TextControlsNumB_TrySetValue(object sender, EventArgs e)
        {
            var control = sender as Control;
            _modelOfInequality.TrySetB(control.Text);
        }

        private void TextControlsNumB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextControlsNumB_TrySetValue(sender, e);
            }
        }

        private void trackBarB_TrySetValue(object sender, EventArgs e)
        {
            _modelOfInequality.TrySetB(trackBarB.Value);
        }

        private void TextControlsNumC_TrySetValue(object sender, EventArgs e)
        {
            var control = sender as Control;
            _modelOfInequality.TrySetC(control.Text);
        }

        private void TextControlsNumC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextControlsNumC_TrySetValue(sender, e);
            }
        }

        private void trackBarC_TrySetValue(object sender, EventArgs e)
        {
            _modelOfInequality.TrySetC(trackBarC.Value);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _modelOfInequality.WriteNumbersToFile();
        }
    }
}
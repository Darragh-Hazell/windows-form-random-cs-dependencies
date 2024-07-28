using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringMath;
using baconipsum;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Distinction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double inputToNumber(TextBox input)
        {
            try
            {
                return Convert.ToDouble(input.Text);
            }
            catch
            {
                return 0.0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baconText.Text = BaconIpsum.MakeBacon();
        }

        private void EVALUATE_Click(object sender, EventArgs e)
        {
            try
            {
                smOutput.Text = Convert.ToString(smInput.Text.Eval());
            }
            catch
            {
                smOutput.Text = "INVALID EXPRESSION";
            }
        }

        private void MULTIPLY_Click(object sender, EventArgs e)
        {
            Matrix<double> matrixOne = DenseMatrix.OfArray(new double[,] {
                {inputToNumber(matrix1_00), inputToNumber(matrix1_01)},
                {inputToNumber(matrix1_10), inputToNumber(matrix1_11)}
            });

            Matrix<double> matrixTwo = DenseMatrix.OfArray(new double[,] {
                {inputToNumber(matrix2_00), inputToNumber(matrix2_01)},
                {inputToNumber(matrix2_10), inputToNumber(matrix2_11)}
            });

            Matrix<double> result = matrixOne.Multiply(matrixTwo);
            matrixR_00.Text = Convert.ToString(result.Storage.At(0, 0));
            matrixR_01.Text = Convert.ToString(result.Storage.At(0, 1));
            matrixR_10.Text = Convert.ToString(result.Storage.At(1, 0));
            matrixR_11.Text = Convert.ToString(result.Storage.At(1, 1));
        }
    }
}

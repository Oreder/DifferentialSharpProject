using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Differential
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fBox.SelectedIndex = 0;
            problemBox.ReadOnly = true;
            edtX0.ReadOnly = true;
        }

        #region Functions

        private delegate double _function(double x, double y);

        private double f1(double x, double y)
        {
            return x * x + y * y;
        }

        private double f2(double x, double y)
        {
            return 1 + x * y;
        }

        private double f3(double x, double y)
        {
            return 2 * x * (1 + y);
        }

        #endregion

        #region Picards #1 - #4

        /// <summary>
        /// Picard's method (1st)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private double Picard_1(double x)
        {
            if (f == f1)
                return Math.Pow(x, 3) / 3;
            if (f == f2)
                return y0 * Math.Pow(x, 2) / 2 + x + y0;

            // case f = f3
            return Math.Pow(x, 2);
        }

        /// <summary>
        /// Picard's method (2nd)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private double Picard_2(double x)
        {
            if (f == f1)
                return Math.Pow(x, 3) / 3 + Math.Pow(x, 7) / 63;
            if (f == f2)
                return y0 + x + y0 * Math.Pow(x, 2) / 2 + Math.Pow(x, 3) / 3 + y0 * Math.Pow(x, 4) / 8;

            // case f = f3
            return Math.Pow(x, 2) + Math.Pow(x, 4) / 2;
        }

        /// <summary>
        /// Picard's method (3rd)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private double Picard_3(double x)
        {
            if (f == f1)
                return Math.Pow(x, 3) / 3 + Math.Pow(x, 7) / 63 + 2 * Math.Pow(x, 11) / 2079
                                          + Math.Pow(x, 15) / 59535;
            if (f == f2)
                return y0 + x + y0 * Math.Pow(x, 2) / 2 + Math.Pow(x, 3) / 3 + y0 * Math.Pow(x, 4) / 8
                          + Math.Pow(x, 5) / 15 + y0 * Math.Pow(x, 6) / 48;

            // case f = f3
            return Math.Pow(x, 2) + Math.Pow(x, 4) / 2 + Math.Pow(x, 6) / 6;
        }

        /// <summary>
        /// Picard's method (4th)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private double Picard_4(double x)
        {
            if (f == f1)
                return Math.Pow(x, 3) / 3 + Math.Pow(x, 7) / 63 + 2 * Math.Pow(x, 11) / 2079 + 13 * Math.Pow(x, 15) / 218295
                                          + 82 * Math.Pow(x, 19) / 37328445 + 662 * Math.Pow(x, 23) / 10438212015
                                          + 4 * Math.Pow(x, 27) / 3341878155 + Math.Pow(x, 31) / 109876902975;
            if (f == f2)
                return y0 + x + y0 * Math.Pow(x, 2) / 2 + Math.Pow(x, 3) / 3 + y0 * Math.Pow(x, 4) / 8 + Math.Pow(x, 5) / 15
                          + y0 * Math.Pow(x, 6) / 48 + Math.Pow(x, 7) / 105 + y0 * Math.Pow(x, 8) / 384;
            
            // case f = f3
            return Math.Pow(x, 2) + Math.Pow(x, 4) / 2 + Math.Pow(x, 6) / 6 + Math.Pow(x, 8) / 24;
        }

        #endregion

        #region Runge-Kutta (2 stages)

        /// <summary>
        /// Runge - Kutta's method
        /// </summary>
        /// <param name="X_prev"></param>
        /// <param name="Y_prev"></param>
        /// <param name="alpha">Alpha is given in range (0, 1].</param>
        /// <param name="h"></param>
        /// <returns></returns>
        private double Runge_Kutta(double X_prev, double Y_prev, double alpha, double h)
        {
            if (alpha == 0)
                return double.NaN;
            return Y_prev + (1 - alpha) * h * f(X_prev, Y_prev) 
                          + alpha * h * f(X_prev + h / (2 * alpha), Y_prev + h * f(X_prev, Y_prev) / (2 * alpha));
        }
        
        #endregion

        #region Explicit (Euler forward)

        /// <summary>
        /// Euler's forward method (exported from .M)
        /// Formula: y[n+1] = y[n] + step * f(x[n], y[n])
        /// </summary>
        /// <param name="X_prev"></param>
        /// <param name="Y_prev"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        private double explicit_f(double X_prev, double Y_prev, double h)
        {
            return Y_prev + h * f(X_prev, Y_prev);
        }

        #endregion

        #region Implicit (Euler backward)
        
        /// <summary>
        /// Euler's Backward method (exported from .M)
        /// Formula: y[n+1] = y[n] + step * f(x[n+1], y[n+1])
        /// </summary>
        /// <param name="X_prev"></param>
        /// <param name="Y_prev"></param>
        /// <param name="h">step</param>
        /// <returns></returns>
        private double implicit_f(double X_prev, double Y_prev, double h)
        {
            double ynew = Y_prev + h * f(X_prev, Y_prev);
            return Y_prev + h * f(X_prev + h, ynew);
        }

        /// <summary>
        /// Apply Euler's backward method into individual functions
        /// </summary>
        /// <param name="X_prev"></param>
        /// <param name="Y_prev"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        private double implicit_f_1(double X_prev, double Y_prev, double h)
        {
            if (h <= 0 || h >= 1)
                throw new Exception("Can not execute with a large step!");
            double X = X_prev + h;
            if (f == f1)        // EDIT HERE!!!
            {
                double d = 1 - 4 * h * (Y_prev + h * X * X);
                if (d >= 0)
                    return (1 - Math.Sqrt(d)) / 2 / h;
                return Double.NaN;
            }
            if (f == f2)
                return (Y_prev + h) / (1 - h * X);
            return (Y_prev + h * 2 * X) / (1 - 2 * h * X);
        }

        #endregion

        #region Euler's method (modified)

        /// <summary>
        /// Euler's modified method (exported from .M)
        /// </summary>
        /// <param name="X_prev"></param>
        /// <param name="Y_prev"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        private double modified_f(double X_prev, double Y_prev, double h)
        {
            double ynew = Y_prev + h * f(X_prev, Y_prev);
            return Y_prev + h * (f(X_prev, Y_prev) + f(X_prev + h, ynew)) / 2;
        }

        #endregion

        _function f;
        double y0, x1;
        
        /// <summary>
        /// Main table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showBtn_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(edtStep.Text);
            tab.RowCount = n + 1;
            double alpha = Double.Parse(edtAlpha.Text);

            y0 = Double.Parse(edtY.Text);
            x1 = Double.Parse(edtX1.Text);

            switch(fBox.SelectedIndex)
            {
                case 0: f = f1; break;
                case 1: f = f2; break;
                case 2: f = f3; break;
            }

            double py_1 = y0, py_2 = y0, py_0 = y0, Ny = y0, My = y0;
            double step = x1 / n;
            for (int i = 0; i <= n; i++)            
            {
                double x = i * step;        // Picard's method
                tab.Rows[i].Cells[0].Value = x.ToString();
                tab.Rows[i].Cells[1].Value = Picard_1(x).ToString();
                tab.Rows[i].Cells[2].Value = Picard_2(x).ToString();
                tab.Rows[i].Cells[3].Value = Picard_3(x).ToString();
                tab.Rows[i].Cells[4].Value = Picard_4(x).ToString();
                                            // Runge-Kutta's method
                tab.Rows[i].Cells[5].Value = py_1.ToString();
                py_1 = Runge_Kutta(x, py_1, 1, step);
                if (alpha > 0)
                {                           // Runge-Kutta's method with coefficient
                    tab.Rows[i].Cells[6].Value = py_2.ToString();
                    py_2 = Runge_Kutta(x, py_2, alpha, step);
                }
                                            // Explicit scheme
                tab.Rows[i].Cells[7].Value = py_0.ToString();
                py_0 = explicit_f(x, py_0, step);
                                            // Implicit scheme (EDIT HERE!!!)
                tab.Rows[i].Cells[8].Value = Ny.ToString();
                Ny = implicit_f(x, Ny, step);
                                            // Modified method
                tab.Rows[i].Cells[9].Value = My.ToString();
                My = modified_f(x, My, step);
            }
        }

        private void fBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (fBox.SelectedIndex)
            {
                case 0:
                    edtY.Text = "0";
                    edtY.ReadOnly = true;
                    break;
                case 1:
                    edtY.ReadOnly = false;
                    break;
                case 2:
                    edtY.Text = "0";
                    edtY.ReadOnly = true;
                    break;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculator.Library;

namespace Calculator.Web
{
    public partial class CalculatorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            int numerator = Convert.ToInt32(txtNumerator.Text);
            int denominator = Convert.ToInt32(txtDenominator.Text);
            int result = Calculator.Library.Calculator.Divide(numerator, denominator);
            lblResult.Text = result.ToString();
        }
        protected void btnSum_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumerator.Text);
            int num2 = Convert.ToInt32(txtDenominator.Text);
            int result = Calculator.Library.Calculator.Sum(num1, num2);
            lblResult.Text = result.ToString();
        }
    }
}
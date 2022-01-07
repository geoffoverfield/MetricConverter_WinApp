//  Metric Converter
//
//  Created by Geoffrey Overfield on 1/5/2022.
//  Copyright © 2019 Geoffrey Overfield. All rights reserved.

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MetricConverter_WinApp
{

    public partial class Form1 : Form
    {
        private bool allEnabled = true;
        private bool allHidden = false;
        private bool numPadEnabled = false;
        private string prevText, currText;
        private string UnitsFrom, UnitsTo;

        private Utils.Enumerations.ConversionType ConversionType { get; set; }
        private Converter m_pConverter;

        public Form1()
        {
            InitializeComponent();
            m_pConverter = new Converter();
            ConversionType = Utils.Enumerations.ConversionType.Invalid;
            setNumberPad();
        }

        private void addText(string value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(tbInput.Text);
            sb.Append(value);
            tbInput.Text = sb.ToString();
        }

        private void disableAll()
        {
            tbInput.Enabled     = false;
            lblFrom.Enabled     = false;
            lblTo.Enabled       = false;
            cmbxFrom.Enabled    = false;
            cmbxTo.Enabled      = false;
            btnConvert.Enabled  = false;
            lblOutput.Enabled   = false;
            
            allEnabled = false;
        }

        private void setNumberPad()
        {
            // Show/Hide the number pad
            numberPad.Enabled = numPadEnabled;
            numberPad.Visible = numPadEnabled;

            // Hide things that will get in the way or cause errors
            lblOutput.Visible   = !numPadEnabled;
            btnDistance.Visible = !numPadEnabled;
            btnSpeed.Visible    = !numPadEnabled;
            btnMass.Visible     = !numPadEnabled;
            btnVolume.Visible   = !numPadEnabled;
            btnInfo.Visible     = !numPadEnabled;
            lblOutput.Enabled   = !numPadEnabled;
            btnDistance.Enabled = !numPadEnabled;
            btnSpeed.Enabled    = !numPadEnabled;
            btnMass.Enabled     = !numPadEnabled;
            btnVolume.Enabled   = !numPadEnabled;
            btnInfo.Enabled     = !numPadEnabled;
        }

        private void enableAll()
        {
            tbInput.Enabled     = true;
            lblFrom.Enabled     = true;
            lblTo.Enabled       = true;
            cmbxFrom.Enabled    = true;
            cmbxTo.Enabled      = true;
            btnConvert.Enabled  = true;
            lblOutput.Enabled   = true;

            allEnabled = true;
        }

        private void hideAll()
        {
            tbInput.Visible     = false;
            lblFrom.Visible     = false;
            lblTo.Visible       = false;
            cmbxFrom.Visible    = false;
            cmbxTo.Visible      = false;
            btnConvert.Visible  = false;
            lblOutput.Visible   = false;

            allHidden = true;
        }

        private void showAll()
        {
            tbInput.Visible     = true;
            lblFrom.Visible     = true;
            lblTo.Visible       = true;
            cmbxFrom.Visible    = true;
            cmbxTo.Visible      = true;
            btnConvert.Visible  = true;
            lblOutput.Visible   = true;

            lblOutput.Text = String.Empty;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            allHidden = false;
        }

        private void showInfo()
        {
            string content = "[BOSS] Games\nbossgamesdevteam@gmail.com\nDenver, CO, USA";
            lblOutput.Text = content;
            lblOutput.Visible = true;
            lblOutput.TextAlign = ContentAlignment.TopCenter;
        }

        #region Event Handlers
        private void Form1_Click(object sender, EventArgs e)
        {
            numPadEnabled = false;
            setNumberPad();
        }

        private void tbInput_Click(object sender, EventArgs e)
        {
            numPadEnabled = true;
            setNumberPad();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            currText = tbInput.Text;
            if (currText == string.Empty) return;

            var currTextArray = currText.ToCharArray();
            var newText = new StringBuilder();
            int numOfDecimals = 0;

            foreach (var currChar in currTextArray)
            {
                int value = 0;
                bool isNumber = int.TryParse(currChar.ToString(), out value);
                if (currChar == '.')
                {
                    if (numOfDecimals < 1)
                    {
                        newText.Append(currChar);
                        numOfDecimals++;
                    }
                }
                else if (isNumber)
                {
                    newText.Append(currChar);
                }
            }

            double newValue = 0.0;
            bool isValid = double.TryParse(newText.ToString(), out newValue);
            if (isValid)
            {
                prevText = newText.ToString();
            }

            tbInput.Text = prevText;
            tbInput.SelectionStart = prevText.Length;
        }

        #region Button Clicks
        private void btnDistance_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.distance;
            if (!allEnabled)
                enableAll();
            if (allHidden)
                showAll();
            
            cmbxFrom.DataSource = Utils.Consts.DistanceUnits;
            cmbxTo.DataSource   = Utils.Consts.DistanceToUnits;
            ConversionType = Utils.Enumerations.ConversionType.Distance;
            lblOutput.Text = string.Empty;
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.speedometer;
            if (!allEnabled)
                enableAll();
            if (allHidden)
                showAll();

            cmbxFrom.DataSource = Utils.Consts.SpeedUnits;
            cmbxTo.DataSource   = Utils.Consts.SpeedToUnits;
            ConversionType = Utils.Enumerations.ConversionType.Speed;
            lblOutput.Text = string.Empty;
        }

        private void btnMass_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.scale;
            if (!allEnabled)
                enableAll();
            if (allHidden)
                showAll();

            cmbxFrom.DataSource = Utils.Consts.MassUnits;
            cmbxTo.DataSource   = Utils.Consts.MassToUnits;
            ConversionType = Utils.Enumerations.ConversionType.Mass;
            lblOutput.Text = string.Empty;
        }
        
        private void btnVolume_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.volume;
            if (!allEnabled)
                enableAll();
            if (allHidden)
                showAll();

            cmbxFrom.DataSource = Utils.Consts.VolumeUnits;
            cmbxTo.DataSource   = Utils.Consts.VolumeToUnits;
            ConversionType = Utils.Enumerations.ConversionType.Volume;
            lblOutput.Text = string.Empty;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BOSSGames;
            if (allEnabled)
                disableAll();
            if (!allHidden)
                hideAll();
            showInfo();

            ConversionType = Utils.Enumerations.ConversionType.Invalid;
            lblOutput.Text = string.Empty;
        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            numPadEnabled = false;
            setNumberPad();
            double input = 0.0;
            bool isValid = double.TryParse(tbInput.Text, out input);

            if (isValid)
                lblOutput.Text = m_pConverter.Convert(ConversionType, UnitsFrom, UnitsTo, input);
            else lblOutput.Text = Utils.Consts.NaN;
        }
        #endregion

        #region Combo Boxes
        private void cmbxFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            numPadEnabled = false;
            setNumberPad();
            UnitsFrom = cmbxFrom.SelectedValue.ToString();
        }

        private void cmbxTo_SelectedValueChanged(object sender, EventArgs e)
        {
            numPadEnabled = false;
            setNumberPad();
            UnitsTo = cmbxTo.SelectedValue.ToString();
        }
        #endregion

        #region Number Pad Buttons
        private void btn0_Click(object sender, EventArgs e)
        {
            addText("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addText("9");
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            addText(".");
        }

        #endregion
        #endregion

    }
}

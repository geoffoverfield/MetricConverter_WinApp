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
        private string prevText, currText;
        private string UnitsFrom, UnitsTo;

        private Utils.Enumerations.ConversionType ConversionType { get; set; }

        private Converter m_pConverter;

        public Form1()
        {
            InitializeComponent();
            m_pConverter = new Converter();
            ConversionType = Utils.Enumerations.ConversionType.Invalid;
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
        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
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
            UnitsFrom = cmbxFrom.SelectedValue.ToString();
        }

        private void cmbxTo_SelectedValueChanged(object sender, EventArgs e)
        {
            UnitsTo = cmbxTo.SelectedValue.ToString();
        }

        #endregion

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            currText = tbInput.Text;
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
        #endregion

    }
}

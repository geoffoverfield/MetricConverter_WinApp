//  Metric Converter
//
//  Created by Geoffrey Overfield on 1/5/2022.
//  Copyright © 2022 Geoffrey Overfield. All rights reserved.

namespace MetricConverter_WinApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDistance = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.btnMass = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cmbxFrom = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnVolume = new System.Windows.Forms.Button();
            this.cmbxTo = new System.Windows.Forms.ComboBox();
            this.numberPad = new System.Windows.Forms.Panel();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.numberPad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDistance
            // 
            this.btnDistance.BackgroundImage = global::MetricConverter_WinApp.Properties.Resources.Dist_Tab;
            this.btnDistance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDistance.Location = new System.Drawing.Point(6, 579);
            this.btnDistance.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(80, 92);
            this.btnDistance.TabIndex = 0;
            this.btnDistance.Text = " ";
            this.btnDistance.UseVisualStyleBackColor = true;
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.BackgroundImage = global::MetricConverter_WinApp.Properties.Resources.Speed_Tab;
            this.btnSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpeed.Location = new System.Drawing.Point(84, 579);
            this.btnSpeed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(80, 92);
            this.btnSpeed.TabIndex = 1;
            this.btnSpeed.Text = " ";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // btnMass
            // 
            this.btnMass.BackgroundImage = global::MetricConverter_WinApp.Properties.Resources.Weight_Tab;
            this.btnMass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMass.Location = new System.Drawing.Point(162, 579);
            this.btnMass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMass.Name = "btnMass";
            this.btnMass.Size = new System.Drawing.Size(80, 92);
            this.btnMass.TabIndex = 2;
            this.btnMass.Text = " ";
            this.btnMass.UseVisualStyleBackColor = true;
            this.btnMass.Click += new System.EventHandler(this.btnMass_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = global::MetricConverter_WinApp.Properties.Resources.Info;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.Location = new System.Drawing.Point(318, 579);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(80, 92);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = " ";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(103, 45);
            this.tbInput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(198, 27);
            this.tbInput.TabIndex = 4;
            this.tbInput.Click += new System.EventHandler(this.tbInput_Click);
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFrom.Location = new System.Drawing.Point(50, 96);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(121, 25);
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "CONVERT FROM:";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTo.Location = new System.Drawing.Point(250, 96);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(121, 25);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "CONVERT TO:";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbxFrom
            // 
            this.cmbxFrom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbxFrom.FormattingEnabled = true;
            this.cmbxFrom.Location = new System.Drawing.Point(50, 138);
            this.cmbxFrom.Name = "cmbxFrom";
            this.cmbxFrom.Size = new System.Drawing.Size(121, 28);
            this.cmbxFrom.TabIndex = 7;
            this.cmbxFrom.SelectedValueChanged += new System.EventHandler(this.cmbxFrom_SelectedValueChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Transparent;
            this.btnConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConvert.BackgroundImage")));
            this.btnConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConvert.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(103, 181);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(198, 198);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "CONVERT!";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(46, 447);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(325, 100);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolume
            // 
            this.btnVolume.BackgroundImage = global::MetricConverter_WinApp.Properties.Resources.Volume_Tab;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolume.Location = new System.Drawing.Point(240, 579);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(80, 92);
            this.btnVolume.TabIndex = 11;
            this.btnVolume.Text = " ";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // cmbxTo
            // 
            this.cmbxTo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbxTo.FormattingEnabled = true;
            this.cmbxTo.Location = new System.Drawing.Point(250, 138);
            this.cmbxTo.Name = "cmbxTo";
            this.cmbxTo.Size = new System.Drawing.Size(121, 28);
            this.cmbxTo.TabIndex = 12;
            this.cmbxTo.SelectedValueChanged += new System.EventHandler(this.cmbxTo_SelectedValueChanged);
            // 
            // numberPad
            // 
            this.numberPad.Controls.Add(this.btn0);
            this.numberPad.Controls.Add(this.btnPeriod);
            this.numberPad.Controls.Add(this.btn3);
            this.numberPad.Controls.Add(this.btn2);
            this.numberPad.Controls.Add(this.btn1);
            this.numberPad.Controls.Add(this.btn6);
            this.numberPad.Controls.Add(this.btn5);
            this.numberPad.Controls.Add(this.btn4);
            this.numberPad.Controls.Add(this.btn9);
            this.numberPad.Controls.Add(this.btn8);
            this.numberPad.Controls.Add(this.btn7);
            this.numberPad.Location = new System.Drawing.Point(84, 386);
            this.numberPad.Name = "numberPad";
            this.numberPad.Size = new System.Drawing.Size(236, 285);
            this.numberPad.TabIndex = 13;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(0, 233);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(158, 52);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(156, 233);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(80, 52);
            this.btnPeriod.TabIndex = 0;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(156, 155);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 80);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(78, 155);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 80);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(0, 155);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 80);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(156, 77);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 80);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(78, 77);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 80);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(0, 77);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 80);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(156, -1);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 80);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(78, -1);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 80);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(0, -1);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 80);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnTemperature
            // 
            this.btnTemperature.BackgroundImage = global::MetricConverter_WinApp.Properties.Resources.Thermometer_Tab;
            this.btnTemperature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTemperature.Location = new System.Drawing.Point(318, 579);
            this.btnTemperature.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(80, 92);
            this.btnTemperature.TabIndex = 14;
            this.btnTemperature.Text = " ";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 671);
            this.Controls.Add(this.btnTemperature);
            this.Controls.Add(this.numberPad);
            this.Controls.Add(this.cmbxTo);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbxFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnMass);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.btnDistance);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximumSize = new System.Drawing.Size(420, 710);
            this.MinimumSize = new System.Drawing.Size(420, 710);
            this.Name = "Form1";
            this.Text = "Metric Converter";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.numberPad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDistance;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button btnMass;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cmbxFrom;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.ComboBox cmbxTo;
        private System.Windows.Forms.Panel numberPad;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnTemperature;
    }
}


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
            this.tbInput.Location = new System.Drawing.Point(103, 120);
            this.tbInput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(198, 27);
            this.tbInput.TabIndex = 4;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFrom.Location = new System.Drawing.Point(50, 171);
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
            this.lblTo.Location = new System.Drawing.Point(250, 171);
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
            this.cmbxFrom.Location = new System.Drawing.Point(50, 213);
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
            this.btnConvert.Location = new System.Drawing.Point(103, 259);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(198, 198);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "CONVERT!";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(46, 484);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(325, 65);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "SAMPLE";
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
            this.cmbxTo.Location = new System.Drawing.Point(250, 213);
            this.cmbxTo.Name = "cmbxTo";
            this.cmbxTo.Size = new System.Drawing.Size(121, 28);
            this.cmbxTo.TabIndex = 12;
            this.cmbxTo.SelectedValueChanged += new System.EventHandler(this.cmbxTo_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 671);
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
    }
}


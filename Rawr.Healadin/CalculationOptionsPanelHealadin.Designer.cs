﻿namespace Rawr.Healadin
{
    partial class CalculationOptionsPanelHealadin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.cmbLength = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbSpiritual = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbSpriest = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbManaTime = new System.Windows.Forms.NumericUpDown();
			this.cmbManaAmt = new System.Windows.Forms.ComboBox();
			this.trkActivity = new System.Windows.Forms.TrackBar();
			this.lblActivity = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.chkBoL = new System.Windows.Forms.CheckBox();
			this.trkRatio = new System.Windows.Forms.TrackBar();
			this.nubHL2 = new System.Windows.Forms.NumericUpDown();
			this.nubHL1 = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labHL2 = new System.Windows.Forms.Label();
			this.labHL1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cmbLength)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbSpiritual)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbSpriest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbManaTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkActivity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkRatio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nubHL2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nubHL1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbLength
			// 
			this.cmbLength.DecimalPlaces = 1;
			this.cmbLength.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.cmbLength.Location = new System.Drawing.Point(97, 7);
			this.cmbLength.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.cmbLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.cmbLength.Name = "cmbLength";
			this.cmbLength.Size = new System.Drawing.Size(112, 20);
			this.cmbLength.TabIndex = 20;
			this.cmbLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.cmbLength.ValueChanged += new System.EventHandler(this.cmbLength_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 21;
			this.label3.Text = "Fight Length:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.cmbSpiritual);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.cmbSpriest);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.cmbManaTime);
			this.groupBox2.Controls.Add(this.cmbManaAmt);
			this.groupBox2.Location = new System.Drawing.Point(4, 113);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(205, 146);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Mana Buffs";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(101, 118);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "mana";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(171, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(28, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "mins";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(87, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "every";
			// 
			// cmbSpiritual
			// 
			this.cmbSpiritual.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.cmbSpiritual.Location = new System.Drawing.Point(19, 116);
			this.cmbSpiritual.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.cmbSpiritual.Name = "cmbSpiritual";
			this.cmbSpiritual.Size = new System.Drawing.Size(76, 20);
			this.cmbSpiritual.TabIndex = 8;
			this.cmbSpiritual.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.cmbSpiritual.ValueChanged += new System.EventHandler(this.cmbSpiritual_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Spiritual Attunement:";
			// 
			// cmbSpriest
			// 
			this.cmbSpriest.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.cmbSpriest.Location = new System.Drawing.Point(19, 77);
			this.cmbSpriest.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.cmbSpriest.Name = "cmbSpriest";
			this.cmbSpriest.Size = new System.Drawing.Size(76, 20);
			this.cmbSpriest.TabIndex = 6;
			this.cmbSpriest.ValueChanged += new System.EventHandler(this.cmbSpriest_ValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(101, 79);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(27, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "mp5";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Shadow Priest:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Mana Potions:";
			// 
			// cmbManaTime
			// 
			this.cmbManaTime.DecimalPlaces = 1;
			this.cmbManaTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.cmbManaTime.Location = new System.Drawing.Point(125, 38);
			this.cmbManaTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.cmbManaTime.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.cmbManaTime.Name = "cmbManaTime";
			this.cmbManaTime.Size = new System.Drawing.Size(40, 20);
			this.cmbManaTime.TabIndex = 1;
			this.cmbManaTime.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
			this.cmbManaTime.ValueChanged += new System.EventHandler(this.cmbManaTime_ValueChanged);
			// 
			// cmbManaAmt
			// 
			this.cmbManaAmt.DisplayMember = "2400";
			this.cmbManaAmt.Items.AddRange(new object[] {
            "0",
            "1800",
            "2200",
            "2400"});
			this.cmbManaAmt.Location = new System.Drawing.Point(19, 37);
			this.cmbManaAmt.Name = "cmbManaAmt";
			this.cmbManaAmt.Size = new System.Drawing.Size(61, 21);
			this.cmbManaAmt.TabIndex = 0;
			this.cmbManaAmt.Text = "2400";
			this.cmbManaAmt.ValueMember = "2400";
			this.cmbManaAmt.SelectedIndexChanged += new System.EventHandler(this.cmbManaAmt_SelectedIndexChanged);
			this.cmbManaAmt.TextUpdate += new System.EventHandler(this.cmbManaAmt_TextUpdate);
			// 
			// trkActivity
			// 
			this.trkActivity.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.trkActivity.Location = new System.Drawing.Point(94, 33);
			this.trkActivity.Maximum = 100;
			this.trkActivity.Minimum = 10;
			this.trkActivity.Name = "trkActivity";
			this.trkActivity.Size = new System.Drawing.Size(118, 45);
			this.trkActivity.TabIndex = 23;
			this.trkActivity.TickFrequency = 10;
			this.trkActivity.Value = 90;
			this.trkActivity.Scroll += new System.EventHandler(this.trkActivity_Scroll);
			// 
			// lblActivity
			// 
			this.lblActivity.AutoSize = true;
			this.lblActivity.Location = new System.Drawing.Point(105, 65);
			this.lblActivity.Name = "lblActivity";
			this.lblActivity.Size = new System.Drawing.Size(27, 13);
			this.lblActivity.TabIndex = 24;
			this.lblActivity.Text = "90%";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(13, 33);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 45);
			this.label9.TabIndex = 25;
			this.label9.Text = "Activity:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkBoL
			// 
			this.chkBoL.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkBoL.AutoSize = true;
			this.chkBoL.Checked = true;
			this.chkBoL.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBoL.Location = new System.Drawing.Point(59, 84);
			this.chkBoL.Name = "chkBoL";
			this.chkBoL.Size = new System.Drawing.Size(94, 23);
			this.chkBoL.TabIndex = 29;
			this.chkBoL.Text = "Blessing of Light";
			this.chkBoL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkBoL.UseVisualStyleBackColor = true;
			this.chkBoL.CheckedChanged += new System.EventHandler(this.chkBoL_CheckedChanged);
			// 
			// trkRatio
			// 
			this.trkRatio.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.trkRatio.Location = new System.Drawing.Point(47, 19);
			this.trkRatio.Maximum = 100;
			this.trkRatio.Name = "trkRatio";
			this.trkRatio.Size = new System.Drawing.Size(111, 45);
			this.trkRatio.TabIndex = 24;
			this.trkRatio.TickFrequency = 10;
			this.trkRatio.Value = 25;
			this.trkRatio.Scroll += new System.EventHandler(this.trkRatio_Scroll);
			// 
			// nubHL2
			// 
			this.nubHL2.Location = new System.Drawing.Point(164, 37);
			this.nubHL2.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
			this.nubHL2.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.nubHL2.Name = "nubHL2";
			this.nubHL2.Size = new System.Drawing.Size(35, 20);
			this.nubHL2.TabIndex = 25;
			this.nubHL2.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.nubHL2.ValueChanged += new System.EventHandler(this.nubHL2_ValueChanged);
			// 
			// nubHL1
			// 
			this.nubHL1.Location = new System.Drawing.Point(6, 37);
			this.nubHL1.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
			this.nubHL1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.nubHL1.Name = "nubHL1";
			this.nubHL1.Size = new System.Drawing.Size(35, 20);
			this.nubHL1.TabIndex = 26;
			this.nubHL1.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
			this.nubHL1.ValueChanged += new System.EventHandler(this.nubHL1_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labHL2);
			this.groupBox1.Controls.Add(this.labHL1);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.nubHL1);
			this.groupBox1.Controls.Add(this.nubHL2);
			this.groupBox1.Controls.Add(this.trkRatio);
			this.groupBox1.Location = new System.Drawing.Point(4, 265);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(205, 71);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Downranking";
			// 
			// labHL2
			// 
			this.labHL2.AutoSize = true;
			this.labHL2.Location = new System.Drawing.Point(122, 51);
			this.labHL2.Name = "labHL2";
			this.labHL2.Size = new System.Drawing.Size(27, 13);
			this.labHL2.TabIndex = 30;
			this.labHL2.Text = "25%";
			// 
			// labHL1
			// 
			this.labHL1.AutoSize = true;
			this.labHL1.Location = new System.Drawing.Point(52, 51);
			this.labHL1.Name = "labHL1";
			this.labHL1.Size = new System.Drawing.Size(27, 13);
			this.labHL1.TabIndex = 29;
			this.labHL1.Text = "75%";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(166, 19);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 28;
			this.label11.Text = "Rank";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 13);
			this.label10.TabIndex = 27;
			this.label10.Text = "Rank";
			// 
			// CalculationOptionsPanelHealadin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chkBoL);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lblActivity);
			this.Controls.Add(this.trkActivity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbLength);
			this.Name = "CalculationOptionsPanelHealadin";
			this.Size = new System.Drawing.Size(212, 349);
			((System.ComponentModel.ISupportInitialize)(this.cmbLength)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbSpiritual)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbSpriest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbManaTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkActivity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkRatio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nubHL2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nubHL1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cmbLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown cmbManaTime;
        private System.Windows.Forms.ComboBox cmbManaAmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trkActivity;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.NumericUpDown cmbSpriest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cmbSpiritual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkBoL;
        private System.Windows.Forms.TrackBar trkRatio;
        private System.Windows.Forms.NumericUpDown nubHL2;
        private System.Windows.Forms.NumericUpDown nubHL1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labHL1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labHL2;
    }
}

namespace gis_kyh_1
{
    partial class mainForm
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
            this.mainMap = new System.Windows.Forms.PictureBox();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSolidPentagram = new System.Windows.Forms.Button();
            this.btnSolidTriangle = new System.Windows.Forms.Button();
            this.btnSolidCircle = new System.Windows.Forms.Button();
            this.btnFan = new System.Windows.Forms.Button();
            this.btnPentagram = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.cmbColorPoint = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSizePoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxInterval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeneralLine = new System.Windows.Forms.Button();
            this.cmbColorLine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSizeLine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTwoLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainMap)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMap
            // 
            this.mainMap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainMap.Location = new System.Drawing.Point(12, 0);
            this.mainMap.Name = "mainMap";
            this.mainMap.Size = new System.Drawing.Size(426, 530);
            this.mainMap.TabIndex = 0;
            this.mainMap.TabStop = false;
            this.mainMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainMap_MouseClick);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.Location = new System.Drawing.Point(35, 179);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(75, 23);
            this.btnDrawCircle.TabIndex = 1;
            this.btnDrawCircle.Text = "空心圆";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(527, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(444, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(240, 449);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSolidPentagram);
            this.tabPage1.Controls.Add(this.btnSolidTriangle);
            this.tabPage1.Controls.Add(this.btnSolidCircle);
            this.tabPage1.Controls.Add(this.btnFan);
            this.tabPage1.Controls.Add(this.btnPentagram);
            this.tabPage1.Controls.Add(this.btnTriangle);
            this.tabPage1.Controls.Add(this.cmbColorPoint);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbxSizePoint);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnDrawCircle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(232, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "点状符号";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSolidPentagram
            // 
            this.btnSolidPentagram.Location = new System.Drawing.Point(126, 238);
            this.btnSolidPentagram.Name = "btnSolidPentagram";
            this.btnSolidPentagram.Size = new System.Drawing.Size(75, 23);
            this.btnSolidPentagram.TabIndex = 12;
            this.btnSolidPentagram.Text = "实心五角形";
            this.btnSolidPentagram.UseVisualStyleBackColor = true;
            this.btnSolidPentagram.Click += new System.EventHandler(this.btnSolidPentagram_Click);
            // 
            // btnSolidTriangle
            // 
            this.btnSolidTriangle.Location = new System.Drawing.Point(126, 208);
            this.btnSolidTriangle.Name = "btnSolidTriangle";
            this.btnSolidTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnSolidTriangle.TabIndex = 11;
            this.btnSolidTriangle.Text = "实心三角";
            this.btnSolidTriangle.UseVisualStyleBackColor = true;
            this.btnSolidTriangle.Click += new System.EventHandler(this.btnSolidTriangle_Click);
            // 
            // btnSolidCircle
            // 
            this.btnSolidCircle.Location = new System.Drawing.Point(126, 179);
            this.btnSolidCircle.Name = "btnSolidCircle";
            this.btnSolidCircle.Size = new System.Drawing.Size(75, 23);
            this.btnSolidCircle.TabIndex = 10;
            this.btnSolidCircle.Text = "实心圆";
            this.btnSolidCircle.UseVisualStyleBackColor = true;
            this.btnSolidCircle.Click += new System.EventHandler(this.btnSolidCircle_Click);
            // 
            // btnFan
            // 
            this.btnFan.Location = new System.Drawing.Point(35, 267);
            this.btnFan.Name = "btnFan";
            this.btnFan.Size = new System.Drawing.Size(75, 23);
            this.btnFan.TabIndex = 9;
            this.btnFan.Text = "扇形";
            this.btnFan.UseVisualStyleBackColor = true;
            this.btnFan.Click += new System.EventHandler(this.btnFan_Click);
            // 
            // btnPentagram
            // 
            this.btnPentagram.Location = new System.Drawing.Point(35, 238);
            this.btnPentagram.Name = "btnPentagram";
            this.btnPentagram.Size = new System.Drawing.Size(75, 23);
            this.btnPentagram.TabIndex = 8;
            this.btnPentagram.Text = "五角形";
            this.btnPentagram.UseVisualStyleBackColor = true;
            this.btnPentagram.Click += new System.EventHandler(this.btnPentagram_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(35, 208);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnTriangle.TabIndex = 7;
            this.btnTriangle.Text = "三角形";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // cmbColorPoint
            // 
            this.cmbColorPoint.FormattingEnabled = true;
            this.cmbColorPoint.Location = new System.Drawing.Point(126, 59);
            this.cmbColorPoint.Name = "cmbColorPoint";
            this.cmbColorPoint.Size = new System.Drawing.Size(100, 20);
            this.cmbColorPoint.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "符号颜色";
            // 
            // tbxSizePoint
            // 
            this.tbxSizePoint.Location = new System.Drawing.Point(126, 9);
            this.tbxSizePoint.Name = "tbxSizePoint";
            this.tbxSizePoint.Size = new System.Drawing.Size(100, 21);
            this.tbxSizePoint.TabIndex = 5;
            this.tbxSizePoint.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "符号大小";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTwoLine);
            this.tabPage2.Controls.Add(this.tbxInterval);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnGeneralLine);
            this.tabPage2.Controls.Add(this.cmbColorLine);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbxSizeLine);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(232, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "线状符号";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxInterval
            // 
            this.tbxInterval.Location = new System.Drawing.Point(116, 125);
            this.tbxInterval.Name = "tbxInterval";
            this.tbxInterval.Size = new System.Drawing.Size(100, 21);
            this.tbxInterval.TabIndex = 13;
            this.tbxInterval.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "线间距";
            // 
            // btnGeneralLine
            // 
            this.btnGeneralLine.Location = new System.Drawing.Point(25, 220);
            this.btnGeneralLine.Name = "btnGeneralLine";
            this.btnGeneralLine.Size = new System.Drawing.Size(75, 23);
            this.btnGeneralLine.TabIndex = 11;
            this.btnGeneralLine.Text = "普通线";
            this.btnGeneralLine.UseVisualStyleBackColor = true;
            this.btnGeneralLine.Click += new System.EventHandler(this.btnGeneralLine_Click);
            // 
            // cmbColorLine
            // 
            this.cmbColorLine.FormattingEnabled = true;
            this.cmbColorLine.Location = new System.Drawing.Point(116, 75);
            this.cmbColorLine.Name = "cmbColorLine";
            this.cmbColorLine.Size = new System.Drawing.Size(100, 20);
            this.cmbColorLine.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "符号颜色";
            // 
            // tbxSizeLine
            // 
            this.tbxSizeLine.Location = new System.Drawing.Point(116, 25);
            this.tbxSizeLine.Name = "tbxSizeLine";
            this.tbxSizeLine.Size = new System.Drawing.Size(100, 21);
            this.tbxSizeLine.TabIndex = 9;
            this.tbxSizeLine.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "线长度";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(232, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "面状符号";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnTwoLine
            // 
            this.btnTwoLine.Location = new System.Drawing.Point(116, 220);
            this.btnTwoLine.Name = "btnTwoLine";
            this.btnTwoLine.Size = new System.Drawing.Size(75, 23);
            this.btnTwoLine.TabIndex = 14;
            this.btnTwoLine.Text = "双线";
            this.btnTwoLine.UseVisualStyleBackColor = true;
            this.btnTwoLine.Click += new System.EventHandler(this.btnTwoLine_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 531);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mainMap);
            this.Controls.Add(this.btnClear);
            this.Name = "mainForm";
            this.Text = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainMap)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainMap;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxSizePoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbColorPoint;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnPentagram;
        private System.Windows.Forms.Button btnFan;
        private System.Windows.Forms.Button btnSolidCircle;
        private System.Windows.Forms.Button btnSolidTriangle;
        private System.Windows.Forms.Button btnSolidPentagram;
        private System.Windows.Forms.ComboBox cmbColorLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSizeLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGeneralLine;
        private System.Windows.Forms.TextBox tbxInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTwoLine;
    }
}


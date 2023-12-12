namespace LaboratoryWork_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBarKF = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarAngleF = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarAngleQ = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarOX = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarOY = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarK = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(511, 511);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // trackBarKF
            // 
            this.trackBarKF.Location = new System.Drawing.Point(534, 32);
            this.trackBarKF.Maximum = 50;
            this.trackBarKF.Minimum = 1;
            this.trackBarKF.Name = "trackBarKF";
            this.trackBarKF.Size = new System.Drawing.Size(391, 56);
            this.trackBarKF.TabIndex = 1;
            this.trackBarKF.Value = 1;
            this.trackBarKF.Scroll += new System.EventHandler(this.trackBarKF_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поворот Горизонтальный";
            // 
            // trackBarAngleF
            // 
            this.trackBarAngleF.Location = new System.Drawing.Point(534, 94);
            this.trackBarAngleF.Maximum = 360;
            this.trackBarAngleF.Minimum = -360;
            this.trackBarAngleF.Name = "trackBarAngleF";
            this.trackBarAngleF.Size = new System.Drawing.Size(391, 56);
            this.trackBarAngleF.TabIndex = 3;
            this.trackBarAngleF.Value = 1;
            this.trackBarAngleF.Scroll += new System.EventHandler(this.trackBarAngleF_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поворот Вертикальный";
            // 
            // trackBarAngleQ
            // 
            this.trackBarAngleQ.Location = new System.Drawing.Point(534, 156);
            this.trackBarAngleQ.Maximum = 180;
            this.trackBarAngleQ.Minimum = -180;
            this.trackBarAngleQ.Name = "trackBarAngleQ";
            this.trackBarAngleQ.Size = new System.Drawing.Size(391, 56);
            this.trackBarAngleQ.TabIndex = 5;
            this.trackBarAngleQ.Value = 1;
            this.trackBarAngleQ.Scroll += new System.EventHandler(this.trackBarAngleQ_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Сдвиг X";
            // 
            // trackBarOX
            // 
            this.trackBarOX.Location = new System.Drawing.Point(534, 218);
            this.trackBarOX.Maximum = 100;
            this.trackBarOX.Minimum = -100;
            this.trackBarOX.Name = "trackBarOX";
            this.trackBarOX.Size = new System.Drawing.Size(391, 56);
            this.trackBarOX.TabIndex = 7;
            this.trackBarOX.Value = 1;
            this.trackBarOX.Scroll += new System.EventHandler(this.trackBarOX_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сдвиг Y";
            // 
            // trackBarOY
            // 
            this.trackBarOY.Location = new System.Drawing.Point(534, 280);
            this.trackBarOY.Maximum = 100;
            this.trackBarOY.Minimum = -100;
            this.trackBarOY.Name = "trackBarOY";
            this.trackBarOY.Size = new System.Drawing.Size(391, 56);
            this.trackBarOY.TabIndex = 9;
            this.trackBarOY.Value = 1;
            this.trackBarOY.Scroll += new System.EventHandler(this.trackBarOY_Scroll);
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(534, 357);
            this.trackBarR.Maximum = 100;
            this.trackBarR.Minimum = -100;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(391, 56);
            this.trackBarR.TabIndex = 11;
            this.trackBarR.Value = 1;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "K";
            // 
            // trackBarK
            // 
            this.trackBarK.Location = new System.Drawing.Point(534, 437);
            this.trackBarK.Maximum = 100;
            this.trackBarK.Minimum = -100;
            this.trackBarK.Name = "trackBarK";
            this.trackBarK.Size = new System.Drawing.Size(391, 56);
            this.trackBarK.TabIndex = 13;
            this.trackBarK.Value = 1;
            this.trackBarK.Scroll += new System.EventHandler(this.trackBarK_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "А";
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(534, 499);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Minimum = -100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(391, 56);
            this.trackBarA.TabIndex = 15;
            this.trackBarA.Value = 1;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 560);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBarK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarOY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarAngleQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarAngleF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarKF);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 5";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngleQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private TrackBar trackBarKF;
        private Label label1;
        private Label label2;
        private TrackBar trackBarAngleF;
        private Label label3;
        private TrackBar trackBarAngleQ;
        private Label label4;
        private TrackBar trackBarOX;
        private Label label5;
        private TrackBar trackBarOY;
        private TrackBar trackBarR;
        private Label label6;
        private Label label7;
        private TrackBar trackBarK;
        private Label label8;
        private TrackBar trackBarA;
    }
}
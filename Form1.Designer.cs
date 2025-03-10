namespace LengthCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtYard = new System.Windows.Forms.TextBox();
            this.txtFt = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(22, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "公分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(154, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "公尺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(289, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "公里";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15F);
            this.label4.Location = new System.Drawing.Point(289, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "英碼";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15F);
            this.label5.Location = new System.Drawing.Point(154, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "英尺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15F);
            this.label6.Location = new System.Drawing.Point(22, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "英吋";
            // 
            // btnAllClear
            // 
            this.btnAllClear.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllClear.Location = new System.Drawing.Point(24, 34);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(110, 51);
            this.btnAllClear.TabIndex = 6;
            this.btnAllClear.Text = "清除";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnAllClear_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15F);
            this.label7.Location = new System.Drawing.Point(22, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "說明文字";
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(27, 160);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(100, 25);
            this.txtCM.TabIndex = 8;
            this.txtCM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textCM_KeyUp);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(159, 160);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 25);
            this.txtM.TabIndex = 9;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(294, 160);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(100, 25);
            this.txtKM.TabIndex = 10;
            // 
            // txtYard
            // 
            this.txtYard.Location = new System.Drawing.Point(294, 252);
            this.txtYard.Name = "txtYard";
            this.txtYard.Size = new System.Drawing.Size(100, 25);
            this.txtYard.TabIndex = 13;
            // 
            // txtFt
            // 
            this.txtFt.Location = new System.Drawing.Point(159, 252);
            this.txtFt.Name = "txtFt";
            this.txtFt.Size = new System.Drawing.Size(100, 25);
            this.txtFt.TabIndex = 12;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(27, 252);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(100, 25);
            this.txtIn.TabIndex = 11;
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(27, 360);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(367, 25);
            this.textInfo.TabIndex = 14;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LengthCalculator.Properties.Resources.FacesetActor01_2;
            this.pictureBox2.Location = new System.Drawing.Point(410, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 338);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(685, 439);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.txtYard);
            this.Controls.Add(this.txtFt);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtYard;
        private System.Windows.Forms.TextBox txtFt;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


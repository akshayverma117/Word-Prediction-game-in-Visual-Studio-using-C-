namespace Predict_game
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtc0 = new System.Windows.Forms.TextBox();
            this.txtc5 = new System.Windows.Forms.TextBox();
            this.txtc6 = new System.Windows.Forms.TextBox();
            this.txtc7 = new System.Windows.Forms.TextBox();
            this.txtc8 = new System.Windows.Forms.TextBox();
            this.txtc9 = new System.Windows.Forms.TextBox();
            this.txtc4 = new System.Windows.Forms.TextBox();
            this.txtc2 = new System.Windows.Forms.TextBox();
            this.txtc3 = new System.Windows.Forms.TextBox();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predict The Word";
            // 
            // txtc0
            // 
            this.txtc0.Location = new System.Drawing.Point(13, 106);
            this.txtc0.Name = "txtc0";
            this.txtc0.Size = new System.Drawing.Size(38, 20);
            this.txtc0.TabIndex = 1;
            // 
            // txtc5
            // 
            this.txtc5.Location = new System.Drawing.Point(233, 106);
            this.txtc5.Name = "txtc5";
            this.txtc5.Size = new System.Drawing.Size(38, 20);
            this.txtc5.TabIndex = 2;
            // 
            // txtc6
            // 
            this.txtc6.Location = new System.Drawing.Point(277, 106);
            this.txtc6.Name = "txtc6";
            this.txtc6.Size = new System.Drawing.Size(38, 20);
            this.txtc6.TabIndex = 3;
            // 
            // txtc7
            // 
            this.txtc7.Location = new System.Drawing.Point(321, 106);
            this.txtc7.Name = "txtc7";
            this.txtc7.Size = new System.Drawing.Size(38, 20);
            this.txtc7.TabIndex = 4;
            // 
            // txtc8
            // 
            this.txtc8.Location = new System.Drawing.Point(365, 106);
            this.txtc8.Name = "txtc8";
            this.txtc8.Size = new System.Drawing.Size(38, 20);
            this.txtc8.TabIndex = 5;
            this.txtc8.TextChanged += new System.EventHandler(this.txtc9_TextChanged);
            // 
            // txtc9
            // 
            this.txtc9.Location = new System.Drawing.Point(409, 106);
            this.txtc9.Name = "txtc9";
            this.txtc9.Size = new System.Drawing.Size(38, 20);
            this.txtc9.TabIndex = 6;
            // 
            // txtc4
            // 
            this.txtc4.Location = new System.Drawing.Point(189, 106);
            this.txtc4.Name = "txtc4";
            this.txtc4.Size = new System.Drawing.Size(38, 20);
            this.txtc4.TabIndex = 7;
            // 
            // txtc2
            // 
            this.txtc2.Location = new System.Drawing.Point(101, 106);
            this.txtc2.Name = "txtc2";
            this.txtc2.Size = new System.Drawing.Size(38, 20);
            this.txtc2.TabIndex = 8;
            this.txtc2.TextChanged += new System.EventHandler(this.txtc2_TextChanged);
            // 
            // txtc3
            // 
            this.txtc3.Location = new System.Drawing.Point(145, 106);
            this.txtc3.Name = "txtc3";
            this.txtc3.Size = new System.Drawing.Size(38, 20);
            this.txtc3.TabIndex = 9;
            this.txtc3.TextChanged += new System.EventHandler(this.txtc4_TextChanged);
            // 
            // txtc1
            // 
            this.txtc1.Location = new System.Drawing.Point(57, 106);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(38, 20);
            this.txtc1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Check Ans";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtc1);
            this.Controls.Add(this.txtc3);
            this.Controls.Add(this.txtc2);
            this.Controls.Add(this.txtc4);
            this.Controls.Add(this.txtc9);
            this.Controls.Add(this.txtc8);
            this.Controls.Add(this.txtc7);
            this.Controls.Add(this.txtc6);
            this.Controls.Add(this.txtc5);
            this.Controls.Add(this.txtc0);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtc0;
        private System.Windows.Forms.TextBox txtc5;
        private System.Windows.Forms.TextBox txtc6;
        private System.Windows.Forms.TextBox txtc7;
        private System.Windows.Forms.TextBox txtc8;
        private System.Windows.Forms.TextBox txtc9;
        private System.Windows.Forms.TextBox txtc4;
        private System.Windows.Forms.TextBox txtc2;
        private System.Windows.Forms.TextBox txtc3;
        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


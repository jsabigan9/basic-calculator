namespace basic_calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(23, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Fira Code", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(23, 41);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(446, 86);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.Text = "0";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(362, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(249, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(136, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "+/-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(136, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 63);
            this.button5.TabIndex = 8;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(249, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 63);
            this.button6.TabIndex = 7;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(362, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 63);
            this.button7.TabIndex = 6;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(23, 220);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 63);
            this.button8.TabIndex = 5;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(136, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 63);
            this.button9.TabIndex = 12;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(249, 289);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 63);
            this.button10.TabIndex = 11;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(362, 289);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 63);
            this.button11.TabIndex = 10;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(23, 289);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(107, 63);
            this.button12.TabIndex = 9;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(136, 358);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(107, 63);
            this.button13.TabIndex = 16;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(249, 358);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(107, 63);
            this.button14.TabIndex = 15;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Red;
            this.button15.Location = new System.Drawing.Point(362, 358);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(107, 63);
            this.button15.TabIndex = 14;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(23, 358);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(107, 63);
            this.button16.TabIndex = 13;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(249, 427);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(107, 63);
            this.button18.TabIndex = 19;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Red;
            this.button19.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(362, 427);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(107, 63);
            this.button19.TabIndex = 18;
            this.button19.Text = "=";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(23, 427);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(220, 63);
            this.button20.TabIndex = 17;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(494, 522);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.BtnNumberClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
    }
}


namespace BasicCalculator
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.calcResultText = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(12, 22);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(210, 20);
            this.UserInputText.TabIndex = 0;
            // 
            // calcResultText
            // 
            this.calcResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcResultText.Location = new System.Drawing.Point(13, 49);
            this.calcResultText.Name = "calcResultText";
            this.calcResultText.Size = new System.Drawing.Size(209, 17);
            this.calcResultText.TabIndex = 1;
            this.calcResultText.Text = "Enter an equation and press enter or =";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.ColumnCount = 4;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.Controls.Add(this.btnCE, 0, 0);
            this.buttonsPanel.Controls.Add(this.btnC, 1, 0);
            this.buttonsPanel.Controls.Add(this.btnBack, 2, 0);
            this.buttonsPanel.Controls.Add(this.btn7, 0, 1);
            this.buttonsPanel.Controls.Add(this.btn8, 1, 1);
            this.buttonsPanel.Controls.Add(this.btn9, 2, 1);
            this.buttonsPanel.Controls.Add(this.btnDevide, 3, 0);
            this.buttonsPanel.Controls.Add(this.btnx, 3, 1);
            this.buttonsPanel.Controls.Add(this.btn4, 0, 2);
            this.buttonsPanel.Controls.Add(this.btn5, 1, 2);
            this.buttonsPanel.Controls.Add(this.btn6, 2, 2);
            this.buttonsPanel.Controls.Add(this.btnMinus, 3, 2);
            this.buttonsPanel.Controls.Add(this.btn1, 0, 3);
            this.buttonsPanel.Controls.Add(this.btn2, 1, 3);
            this.buttonsPanel.Controls.Add(this.btn3, 2, 3);
            this.buttonsPanel.Controls.Add(this.btnPlus, 3, 3);
            this.buttonsPanel.Controls.Add(this.button16, 0, 4);
            this.buttonsPanel.Controls.Add(this.btn0, 1, 4);
            this.buttonsPanel.Controls.Add(this.button18, 2, 4);
            this.buttonsPanel.Controls.Add(this.btnEqual, 3, 4);
            this.buttonsPanel.Location = new System.Drawing.Point(12, 69);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 5;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.Size = new System.Drawing.Size(210, 200);
            this.buttonsPanel.TabIndex = 2;
            // 
            // btnCE
            // 
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.Location = new System.Drawing.Point(3, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(46, 34);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.Location = new System.Drawing.Point(55, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(46, 34);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(107, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 34);
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "◄";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 43);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 34);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(55, 43);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 34);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(107, 43);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 34);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btnDevide
            // 
            this.btnDevide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDevide.Location = new System.Drawing.Point(159, 3);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(48, 34);
            this.btnDevide.TabIndex = 6;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            // 
            // btnx
            // 
            this.btnx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnx.Location = new System.Drawing.Point(159, 43);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(48, 34);
            this.btnx.TabIndex = 7;
            this.btnx.Text = "x";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 83);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 34);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(55, 83);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 34);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(107, 83);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 34);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Location = new System.Drawing.Point(159, 83);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(48, 34);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 123);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 34);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(55, 123);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 34);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(107, 123);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 34);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Location = new System.Drawing.Point(159, 123);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(48, 34);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Location = new System.Drawing.Point(3, 163);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(46, 34);
            this.button16.TabIndex = 16;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(55, 163);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(46, 34);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Location = new System.Drawing.Point(107, 163);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(46, 34);
            this.button18.TabIndex = 18;
            this.button18.Text = ",";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.Location = new System.Drawing.Point(159, 163);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(48, 34);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 281);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.calcResultText);
            this.Controls.Add(this.UserInputText);
            this.MaximumSize = new System.Drawing.Size(500, 520);
            this.MinimumSize = new System.Drawing.Size(250, 320);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Basic Calc";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label calcResultText;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnEqual;
    }
}


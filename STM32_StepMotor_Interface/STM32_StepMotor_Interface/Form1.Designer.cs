namespace STM32_StepMotor_Interface
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
            leftBtn = new Button();
            inputBox = new TextBox();
            rightBtn = new Button();
            resultBox = new TextBox();
            portsBox = new ComboBox();
            connectBtn = new Button();
            disconnectBtn = new Button();
            SuspendLayout();
            // 
            // leftBtn
            // 
            leftBtn.Location = new Point(12, 12);
            leftBtn.Name = "leftBtn";
            leftBtn.Size = new Size(33, 29);
            leftBtn.TabIndex = 0;
            leftBtn.Text = "<";
            leftBtn.UseVisualStyleBackColor = true;
            leftBtn.Click += leftBtn_Click;
            // 
            // inputBox
            // 
            inputBox.Location = new Point(51, 12);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(125, 27);
            inputBox.TabIndex = 1;
            // 
            // rightBtn
            // 
            rightBtn.Location = new Point(182, 12);
            rightBtn.Name = "rightBtn";
            rightBtn.Size = new Size(33, 29);
            rightBtn.TabIndex = 2;
            rightBtn.Text = ">";
            rightBtn.UseVisualStyleBackColor = true;
            rightBtn.Click += rightBtn_Click;
            // 
            // resultBox
            // 
            resultBox.Enabled = false;
            resultBox.Location = new Point(12, 45);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(203, 27);
            resultBox.TabIndex = 3;
            // 
            // portsBox
            // 
            portsBox.FormattingEnabled = true;
            portsBox.Location = new Point(12, 78);
            portsBox.Name = "portsBox";
            portsBox.Size = new Size(203, 28);
            portsBox.TabIndex = 4;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(12, 112);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(203, 29);
            connectBtn.TabIndex = 5;
            connectBtn.Text = "Bağlan";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(12, 147);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(203, 29);
            disconnectBtn.TabIndex = 6;
            disconnectBtn.Text = "Bağlantıyı Kes";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 192);
            Controls.Add(disconnectBtn);
            Controls.Add(connectBtn);
            Controls.Add(portsBox);
            Controls.Add(resultBox);
            Controls.Add(rightBtn);
            Controls.Add(inputBox);
            Controls.Add(leftBtn);
            Name = "Form1";
            Text = ":D";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button leftBtn;
        private TextBox inputBox;
        private Button rightBtn;
        private TextBox resultBox;
        private ComboBox portsBox;
        private Button connectBtn;
        private Button disconnectBtn;
    }
}

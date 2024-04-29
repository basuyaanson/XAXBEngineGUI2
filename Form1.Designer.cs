namespace GUI
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
            PlayerInput = new MaskedTextBox();
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // PlayerInput
            // 
            PlayerInput.Location = new Point(313, 140);
            PlayerInput.Name = "PlayerInput";
            PlayerInput.Size = new Size(100, 23);
            PlayerInput.TabIndex = 0;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 94);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 1;
            label1.Text = "請輸入不重複的三個數字";
            // 
            // button1
            // 
            button1.Location = new Point(322, 179);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "送出";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(240, 229);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(265, 154);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(PlayerInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox PlayerInput;
        public Label label1;
        private Button button1;
        private ListBox listBox1;
    }
}
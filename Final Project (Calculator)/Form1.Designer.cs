namespace Final_Project__Calculator_
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
            Totalbox = new TextBox();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b0 = new Button();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            b6 = new Button();
            bClear = new Button();
            bDiv = new Button();
            bMul = new Button();
            bMin = new Button();
            bPlus = new Button();
            bEq = new Button();
            SuspendLayout();
            // 
            // Totalbox
            // 
            Totalbox.Location = new Point(12, 12);
            Totalbox.Multiline = true;
            Totalbox.Name = "Totalbox";
            Totalbox.Size = new Size(336, 44);
            Totalbox.TabIndex = 0;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b1.Location = new Point(28, 72);
            b1.Name = "b1";
            b1.Size = new Size(48, 40);
            b1.TabIndex = 1;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += button1_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b2.Location = new Point(91, 72);
            b2.Name = "b2";
            b2.Size = new Size(48, 40);
            b2.TabIndex = 2;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b3.Location = new Point(154, 72);
            b3.Name = "b3";
            b3.Size = new Size(48, 40);
            b3.TabIndex = 3;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b4.Location = new Point(217, 72);
            b4.Name = "b4";
            b4.Size = new Size(48, 40);
            b4.TabIndex = 4;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b5.Location = new Point(283, 72);
            b5.Name = "b5";
            b5.Size = new Size(48, 40);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b0
            // 
            b0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b0.Location = new Point(284, 137);
            b0.Name = "b0";
            b0.Size = new Size(48, 40);
            b0.TabIndex = 10;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b9.Location = new Point(218, 137);
            b9.Name = "b9";
            b9.Size = new Size(48, 40);
            b9.TabIndex = 9;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b8.Location = new Point(155, 137);
            b8.Name = "b8";
            b8.Size = new Size(48, 40);
            b8.TabIndex = 8;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b7
            // 
            b7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b7.Location = new Point(92, 137);
            b7.Name = "b7";
            b7.Size = new Size(48, 40);
            b7.TabIndex = 7;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b6.Location = new Point(29, 137);
            b6.Name = "b6";
            b6.Size = new Size(48, 40);
            b6.TabIndex = 6;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // bClear
            // 
            bClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bClear.Location = new Point(265, 200);
            bClear.Name = "bClear";
            bClear.Size = new Size(66, 40);
            bClear.TabIndex = 15;
            bClear.Text = "Clear";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // bDiv
            // 
            bDiv.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bDiv.Location = new Point(217, 200);
            bDiv.Name = "bDiv";
            bDiv.Size = new Size(48, 40);
            bDiv.TabIndex = 14;
            bDiv.Text = "/";
            bDiv.UseVisualStyleBackColor = true;
            bDiv.Click += bDiv_Click;
            // 
            // bMul
            // 
            bMul.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bMul.Location = new Point(154, 200);
            bMul.Name = "bMul";
            bMul.Size = new Size(48, 40);
            bMul.TabIndex = 13;
            bMul.Text = "*";
            bMul.UseVisualStyleBackColor = true;
            bMul.Click += bMul_Click;
            // 
            // bMin
            // 
            bMin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bMin.Location = new Point(91, 200);
            bMin.Name = "bMin";
            bMin.Size = new Size(48, 40);
            bMin.TabIndex = 12;
            bMin.Text = "-";
            bMin.UseVisualStyleBackColor = true;
            bMin.Click += bMin_Click;
            // 
            // bPlus
            // 
            bPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bPlus.Location = new Point(28, 200);
            bPlus.Name = "bPlus";
            bPlus.Size = new Size(48, 40);
            bPlus.TabIndex = 11;
            bPlus.Text = "+";
            bPlus.UseVisualStyleBackColor = true;
            bPlus.Click += bPlus_Click;
            // 
            // bEq
            // 
            bEq.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bEq.Location = new Point(28, 262);
            bEq.Name = "bEq";
            bEq.Size = new Size(303, 40);
            bEq.TabIndex = 16;
            bEq.Text = "=";
            bEq.UseVisualStyleBackColor = true;
            bEq.Click += bEq_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 314);
            Controls.Add(bEq);
            Controls.Add(bClear);
            Controls.Add(bDiv);
            Controls.Add(bMul);
            Controls.Add(bMin);
            Controls.Add(bPlus);
            Controls.Add(b0);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(Totalbox);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Totalbox;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b0;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button b6;
        private Button bClear;
        private Button bDiv;
        private Button bMul;
        private Button bMin;
        private Button bPlus;
        private Button bEq;
    }
}

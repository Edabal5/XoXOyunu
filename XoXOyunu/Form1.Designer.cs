namespace XoXOyunu
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
            lblXo = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblXo
            // 
            lblXo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblXo.Location = new Point(120, 20);
            lblXo.Name = "lblXo";
            lblXo.Size = new Size(74, 50);
            lblXo.TabIndex = 0;
            lblXo.Text = "X";
            lblXo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(31, 92);
            button1.Name = "button1";
            button1.Size = new Size(64, 64);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += XoxTiklama;
            // 
            // button2
            // 
            button2.Location = new Point(120, 92);
            button2.Name = "button2";
            button2.Size = new Size(64, 64);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += XoxTiklama;
            // 
            // button3
            // 
            button3.Location = new Point(204, 92);
            button3.Name = "button3";
            button3.Size = new Size(64, 64);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += XoxTiklama;
            // 
            // button4
            // 
            button4.Location = new Point(31, 175);
            button4.Name = "button4";
            button4.Size = new Size(64, 64);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += XoxTiklama;
            // 
            // button5
            // 
            button5.Location = new Point(120, 175);
            button5.Name = "button5";
            button5.Size = new Size(64, 64);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += XoxTiklama;
            // 
            // button6
            // 
            button6.Location = new Point(204, 175);
            button6.Name = "button6";
            button6.Size = new Size(64, 64);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += XoxTiklama;
            // 
            // button7
            // 
            button7.Location = new Point(31, 254);
            button7.Name = "button7";
            button7.Size = new Size(64, 64);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += XoxTiklama;
            // 
            // button8
            // 
            button8.Location = new Point(120, 254);
            button8.Name = "button8";
            button8.Size = new Size(64, 64);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += XoxTiklama;
            // 
            // button9
            // 
            button9.Location = new Point(204, 254);
            button9.Name = "button9";
            button9.Size = new Size(64, 64);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            button9.Click += XoxTiklama;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(67, 37);
            label1.TabIndex = 10;
            label1.Text = "Sıra:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 352);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblXo);
            Name = "Form1";
            Text = "XOX OYUNU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblXo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
    }
}

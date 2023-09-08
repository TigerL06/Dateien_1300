namespace Zufallszahl
{
    partial class Ratemodus
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
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(45, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(333, 41);
            label1.TabIndex = 0;
            label1.Text = "Geben sie eine Zahl ein:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(384, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(250, 47);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(64, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 41);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(64, 158);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 41);
            label3.TabIndex = 3;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(26, 292);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(188, 58);
            button1.TabIndex = 4;
            button1.Text = "Ja";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(725, 292);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(188, 58);
            button2.TabIndex = 5;
            button2.Text = "Nein";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(231, 181);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 41);
            label4.TabIndex = 6;
            label4.Text = "label4";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(231, 222);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(501, 41);
            label5.TabIndex = 7;
            label5.Text = "Wollen sie noch eine Runde spielen?";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(231, 140);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(452, 41);
            label6.TabIndex = 8;
            label6.Text = "Sie haben die Zufallszahl erraten.";
            label6.Visible = false;
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            button3.Location = new System.Drawing.Point(640, 70);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(188, 58);
            button3.TabIndex = 9;
            button3.Text = "Raten";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Ratemodus
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(943, 450);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Ratemodus";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}
namespace Zufallszahl
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(142, 238);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(188, 58);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(205, 131);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(379, 41);
            label1.TabIndex = 3;
            label1.Text = "Wollen sie das Spiel starten";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = System.Windows.Forms.Cursors.No;
            label2.Location = new System.Drawing.Point(276, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(258, 41);
            label2.TabIndex = 4;
            label2.Text = "Zufallszahl erraten";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(437, 238);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(188, 58);
            button2.TabIndex = 5;
            button2.Text = "Beenden";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(750, 475);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

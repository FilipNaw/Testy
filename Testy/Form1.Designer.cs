namespace Testy
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
            components = new System.ComponentModel.Container();
            AAA = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // AAA
            // 
            AAA.BackColor = SystemColors.MenuHighlight;
            AAA.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AAA.Location = new Point(304, 111);
            AAA.Name = "AAA";
            AAA.Size = new Size(189, 107);
            AAA.TabIndex = 0;
            AAA.Text = "button1";
            AAA.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 405);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";

            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(label1);
            Controls.Add(AAA);
            Name = "Form1";
            Text = "Form1";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Button;
        private Button AAA;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
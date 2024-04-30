namespace HESAP_MAKİNESİ
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
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            txtSonuc = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(214, 164);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(125, 27);
            txtSayi1.TabIndex = 0;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(391, 164);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(125, 27);
            txtSayi2.TabIndex = 1;
            // 
            // txtSonuc
            // 
            txtSonuc.Location = new Point(306, 274);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(125, 27);
            txtSonuc.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(320, 220);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtSonuc);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private TextBox txtSonuc;
        private Button button1;
    }
}

namespace PlayFairFix
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
            txtKey = new TextBox();
            btnEncrypt = new Button();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            txtTable = new Label();
            txtFiltered = new TextBox();
            btnDecrypt = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rbCzech = new RadioButton();
            rbEnglish = new RadioButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtKey
            // 
            txtKey.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKey.Location = new Point(12, 5);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(188, 27);
            txtKey.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(632, 362);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(75, 75);
            btnEncrypt.TabIndex = 2;
            btnEncrypt.Text = "ENCRYPT";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(12, 37);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(577, 29);
            txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOutput.Location = new Point(12, 102);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(577, 29);
            txtOutput.TabIndex = 4;
            // 
            // txtTable
            // 
            txtTable.AutoSize = true;
            txtTable.BackColor = Color.Black;
            txtTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTable.ForeColor = Color.White;
            txtTable.Location = new Point(12, 315);
            txtTable.Name = "txtTable";
            txtTable.Size = new Size(102, 21);
            txtTable.TabIndex = 5;
            txtTable.Text = "-TABULKOS-";
            // 
            // txtFiltered
            // 
            txtFiltered.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFiltered.Location = new Point(12, 70);
            txtFiltered.Name = "txtFiltered";
            txtFiltered.Size = new Size(577, 29);
            txtFiltered.TabIndex = 6;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(713, 362);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(75, 75);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "DECRYPT";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 8);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 8;
            label1.Text = "HESLO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(595, 45);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "INPUT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(595, 79);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 10;
            label3.Text = "FILTERED";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(595, 106);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 11;
            label4.Text = "OUTPUT";
            // 
            // rbCzech
            // 
            rbCzech.AutoSize = true;
            rbCzech.Location = new Point(713, 17);
            rbCzech.Name = "rbCzech";
            rbCzech.Size = new Size(56, 19);
            rbCzech.TabIndex = 12;
            rbCzech.TabStop = true;
            rbCzech.Text = "Česká";
            rbCzech.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            rbEnglish.AutoSize = true;
            rbEnglish.Location = new Point(713, 37);
            rbEnglish.Name = "rbEnglish";
            rbEnglish.Size = new Size(71, 19);
            rbEnglish.TabIndex = 13;
            rbEnglish.TabStop = true;
            rbEnglish.Text = "Anglická";
            rbEnglish.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.photo_1484387436194_cf7cb70800ce;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbEnglish);
            Controls.Add(rbCzech);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDecrypt);
            Controls.Add(txtFiltered);
            Controls.Add(txtTable);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnEncrypt);
            Controls.Add(txtKey);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtKey;
        private Button btnEncrypt;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Label txtTable;
        private TextBox txtFiltered;
        private Button btnDecrypt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rbCzech;
        private RadioButton rbEnglish;
        private PictureBox pictureBox1;
    }
}
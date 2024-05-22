namespace PLWinForm
{
    partial class HighscoreForm
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
            btnRevertForm = new Button();
            btnSaveForm = new Button();
            label2 = new Label();
            label1 = new Label();
            scoreInput = new NumericUpDown();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)scoreInput).BeginInit();
            SuspendLayout();
            // 
            // btnRevertForm
            // 
            btnRevertForm.Location = new Point(336, 265);
            btnRevertForm.Margin = new Padding(3, 2, 3, 2);
            btnRevertForm.Name = "btnRevertForm";
            btnRevertForm.Size = new Size(82, 22);
            btnRevertForm.TabIndex = 48;
            btnRevertForm.Text = "Abort";
            btnRevertForm.UseVisualStyleBackColor = true;
            btnRevertForm.Click += btnRevertForm_Click;
            // 
            // btnSaveForm
            // 
            btnSaveForm.Location = new Point(11, 265);
            btnSaveForm.Margin = new Padding(3, 2, 3, 2);
            btnSaveForm.Name = "btnSaveForm";
            btnSaveForm.Size = new Size(82, 22);
            btnSaveForm.TabIndex = 47;
            btnSaveForm.Text = "Save";
            btnSaveForm.UseVisualStyleBackColor = true;
            btnSaveForm.Click += addHighScoreButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 33);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 46;
            label2.Text = "lable2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 44;
            label1.Text = "lable1";
            // 
            // scoreInput
            // 
            scoreInput.Location = new Point(86, 33);
            scoreInput.Name = "scoreInput";
            scoreInput.Size = new Size(120, 23);
            scoreInput.TabIndex = 60;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(86, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(334, 23);
            comboBox1.TabIndex = 61;
            // 
            // HighscoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 298);
            Controls.Add(comboBox1);
            Controls.Add(scoreInput);
            Controls.Add(btnRevertForm);
            Controls.Add(btnSaveForm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HighscoreForm";
            Text = "HighscoreForm";
            ((System.ComponentModel.ISupportInitialize)scoreInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRevertForm;
        private Button btnSaveForm;
        private Label label2;
        private Label label1;
        private NumericUpDown scoreInput;
        private ComboBox comboBox1;
    }
}
namespace PLWinForm
{
    partial class PlayerForm
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
            components = new System.ComponentModel.Container();
            Field1 = new TextBox();
            playerDetailBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            Field2 = new TextBox();
            btnRevertForm = new Button();
            btnSaveForm = new Button();
            label4 = new Label();
            Field4 = new TextBox();
            label3 = new Label();
            Field3 = new TextBox();
            label5 = new Label();
            Field5 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)playerDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Field1
            // 
            Field1.Location = new Point(169, 25);
            Field1.Name = "Field1";
            Field1.Size = new Size(617, 39);
            Field1.TabIndex = 0;
            // 
            // playerDetailBindingSource
            // 
            playerDetailBindingSource.DataSource = typeof(DTO.PlayerDetail);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 1;
            label1.Text = "lable1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 73);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "lable2";
            // 
            // Field2
            // 
            Field2.Location = new Point(169, 70);
            Field2.Name = "Field2";
            Field2.Size = new Size(617, 39);
            Field2.TabIndex = 2;
            // 
            // btnRevertForm
            // 
            btnRevertForm.Location = new Point(633, 568);
            btnRevertForm.Margin = new Padding(5);
            btnRevertForm.Name = "btnRevertForm";
            btnRevertForm.Size = new Size(153, 46);
            btnRevertForm.TabIndex = 13;
            btnRevertForm.Text = "Abort";
            btnRevertForm.UseVisualStyleBackColor = true;
            btnRevertForm.Click += btnRevertForm_Click;
            // 
            // btnSaveForm
            // 
            btnSaveForm.Location = new Point(29, 568);
            btnSaveForm.Margin = new Padding(5);
            btnSaveForm.Name = "btnSaveForm";
            btnSaveForm.Size = new Size(153, 46);
            btnSaveForm.TabIndex = 12;
            btnSaveForm.Text = "Save";
            btnSaveForm.UseVisualStyleBackColor = true;
            btnSaveForm.Click += btnSaveForm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 163);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 17;
            label4.Text = "label4";
            // 
            // Field4
            // 
            Field4.Location = new Point(169, 160);
            Field4.Name = "Field4";
            Field4.Size = new Size(617, 39);
            Field4.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 118);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 15;
            label3.Text = "lable3";
            // 
            // Field3
            // 
            Field3.Location = new Point(169, 115);
            Field3.Name = "Field3";
            Field3.Size = new Size(617, 39);
            Field3.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 208);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // Field5
            // 
            Field5.Location = new Point(169, 205);
            Field5.Name = "Field5";
            Field5.Size = new Size(617, 39);
            Field5.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 266);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(757, 283);
            textBox1.TabIndex = 20;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 636);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(Field5);
            Controls.Add(label4);
            Controls.Add(Field4);
            Controls.Add(label3);
            Controls.Add(Field3);
            Controls.Add(btnRevertForm);
            Controls.Add(btnSaveForm);
            Controls.Add(label2);
            Controls.Add(Field2);
            Controls.Add(label1);
            Controls.Add(Field1);
            Name = "PlayerForm";
            Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)playerDetailBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Field1;
        private BindingSource playerDetailBindingSource;
        private Label label1;
        private Label label2;
        private TextBox Field2;
        private Button btnRevertForm;
        private Button btnSaveForm;
        private Label label4;
        private TextBox Field4;
        private Label label3;
        private TextBox Field3;
        private Label label5;
        private TextBox Field5;
        private TextBox textBox1;
    }
}
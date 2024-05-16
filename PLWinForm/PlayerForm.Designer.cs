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
            label3 = new Label();
            Field3 = new TextBox();
            label5 = new Label();
            Field5 = new TextBox();
            inpNotes = new TextBox();
            BirthDate = new DateTimePicker();
            Field4 = new TextBox();
            Exit = new DateTimePicker();
            Entry = new DateTimePicker();
            lbNotes = new Label();
            ((System.ComponentModel.ISupportInitialize)playerDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Field1
            // 
            Field1.Location = new Point(91, 12);
            Field1.Margin = new Padding(2, 1, 2, 1);
            Field1.Name = "Field1";
            Field1.Size = new Size(334, 23);
            Field1.TabIndex = 0;
            // 
            // playerDetailBindingSource
            // 
            playerDetailBindingSource.DataSource = typeof(DTO.PlayerDetail);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "lable1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "lable2";
            // 
            // Field2
            // 
            Field2.Location = new Point(91, 33);
            Field2.Margin = new Padding(2, 1, 2, 1);
            Field2.Name = "Field2";
            Field2.Size = new Size(334, 23);
            Field2.TabIndex = 2;
            // 
            // btnRevertForm
            // 
            btnRevertForm.Location = new Point(341, 266);
            btnRevertForm.Margin = new Padding(3, 2, 3, 2);
            btnRevertForm.Name = "btnRevertForm";
            btnRevertForm.Size = new Size(82, 22);
            btnRevertForm.TabIndex = 13;
            btnRevertForm.Text = "Abort";
            btnRevertForm.UseVisualStyleBackColor = true;
            btnRevertForm.Click += btnRevertForm_Click;
            // 
            // btnSaveForm
            // 
            btnSaveForm.Location = new Point(16, 266);
            btnSaveForm.Margin = new Padding(3, 2, 3, 2);
            btnSaveForm.Name = "btnSaveForm";
            btnSaveForm.Size = new Size(82, 22);
            btnSaveForm.TabIndex = 12;
            btnSaveForm.Text = "Save";
            btnSaveForm.UseVisualStyleBackColor = true;
            btnSaveForm.Click += btnSaveForm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 76);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 17;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 55);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 15;
            label3.Text = "lable3";
            // 
            // Field3
            // 
            Field3.Location = new Point(91, 52);
            Field3.Margin = new Padding(2, 1, 2, 1);
            Field3.Name = "Field3";
            Field3.Size = new Size(334, 23);
            Field3.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 98);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // Field5
            // 
            Field5.Location = new Point(91, 96);
            Field5.Margin = new Padding(2, 1, 2, 1);
            Field5.Name = "Field5";
            Field5.Size = new Size(334, 23);
            Field5.TabIndex = 18;
            // 
            // inpNotes
            // 
            inpNotes.Location = new Point(91, 125);
            inpNotes.Margin = new Padding(2, 1, 2, 1);
            inpNotes.Multiline = true;
            inpNotes.Name = "inpNotes";
            inpNotes.Size = new Size(334, 135);
            inpNotes.TabIndex = 20;
            // 
            // BirthDate
            // 
            BirthDate.Location = new Point(91, 53);
            BirthDate.Margin = new Padding(2, 1, 2, 1);
            BirthDate.Name = "BirthDate";
            BirthDate.Size = new Size(334, 23);
            BirthDate.TabIndex = 21;
            // 
            // Field4
            // 
            Field4.Location = new Point(91, 74);
            Field4.Margin = new Padding(2, 1, 2, 1);
            Field4.Name = "Field4";
            Field4.Size = new Size(334, 23);
            Field4.TabIndex = 22;
            // 
            // Exit
            // 
            Exit.Location = new Point(91, 94);
            Exit.Margin = new Padding(2, 1, 2, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(334, 23);
            Exit.TabIndex = 23;
            // 
            // Entry
            // 
            Entry.Location = new Point(91, 74);
            Entry.Margin = new Padding(2, 1, 2, 1);
            Entry.Name = "Entry";
            Entry.Size = new Size(334, 23);
            Entry.TabIndex = 24;
            // 
            // lbNotes
            // 
            lbNotes.AutoSize = true;
            lbNotes.Location = new Point(16, 125);
            lbNotes.Margin = new Padding(2, 0, 2, 0);
            lbNotes.Name = "lbNotes";
            lbNotes.Size = new Size(38, 15);
            lbNotes.TabIndex = 25;
            lbNotes.Text = "Notes";
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 298);
            Controls.Add(lbNotes);
            Controls.Add(Entry);
            Controls.Add(Exit);
            Controls.Add(Field4);
            Controls.Add(BirthDate);
            Controls.Add(inpNotes);
            Controls.Add(label5);
            Controls.Add(Field5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Field3);
            Controls.Add(btnRevertForm);
            Controls.Add(btnSaveForm);
            Controls.Add(label2);
            Controls.Add(Field2);
            Controls.Add(label1);
            Controls.Add(Field1);
            Margin = new Padding(2, 1, 2, 1);
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
        private Label label3;
        private TextBox Field3;
        private Label label5;
        private TextBox Field5;
        private TextBox inpNotes;
        private DateTimePicker BirthDate;
        private TextBox Field4;
        private DateTimePicker Exit;
        private DateTimePicker Entry;
        private Label lbNotes;
    }
}
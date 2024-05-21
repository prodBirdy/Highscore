namespace PLWinForm
{
    partial class GameForm
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
            lbNotes = new Label();
            Entry = new DateTimePicker();
            Exit = new DateTimePicker();
            Field4 = new TextBox();
            ReleaseDate = new DateTimePicker();
            inpNotes = new TextBox();
            label5 = new Label();
            Field5 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnRevertForm = new Button();
            btnSaveForm = new Button();
            label2 = new Label();
            Field2 = new TextBox();
            label1 = new Label();
            Field3 = new TextBox();
            Field1 = new TextBox();
            gameDetailBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)gameDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbNotes
            // 
            lbNotes.AutoSize = true;
            lbNotes.Location = new Point(11, 124);
            lbNotes.Margin = new Padding(2, 0, 2, 0);
            lbNotes.Name = "lbNotes";
            lbNotes.Size = new Size(38, 15);
            lbNotes.TabIndex = 42;
            lbNotes.Text = "Notes";
            // 
            // Entry
            // 
            Entry.Location = new Point(86, 73);
            Entry.Margin = new Padding(2, 1, 2, 1);
            Entry.Name = "Entry";
            Entry.Size = new Size(334, 23);
            Entry.TabIndex = 41;
            // 
            // Exit
            // 
            Exit.Location = new Point(86, 93);
            Exit.Margin = new Padding(2, 1, 2, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(334, 23);
            Exit.TabIndex = 40;
            // 
            // Field4
            // 
            Field4.Location = new Point(86, 73);
            Field4.Margin = new Padding(2, 1, 2, 1);
            Field4.Name = "Field4";
            Field4.Size = new Size(334, 23);
            Field4.TabIndex = 39;
            // 
            // ReleaseDate
            // 
            ReleaseDate.Location = new Point(86, 52);
            ReleaseDate.Margin = new Padding(2, 1, 2, 1);
            ReleaseDate.Name = "ReleaseDate";
            ReleaseDate.Size = new Size(334, 23);
            ReleaseDate.TabIndex = 38;
            // 
            // inpNotes
            // 
            inpNotes.Location = new Point(86, 124);
            inpNotes.Margin = new Padding(2, 1, 2, 1);
            inpNotes.Multiline = true;
            inpNotes.Name = "inpNotes";
            inpNotes.Size = new Size(334, 135);
            inpNotes.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 97);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 36;
            label5.Text = "label5";
            // 
            // Field5
            // 
            Field5.Location = new Point(86, 95);
            Field5.Margin = new Padding(2, 1, 2, 1);
            Field5.Name = "Field5";
            Field5.Size = new Size(334, 23);
            Field5.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 34;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 54);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 33;
            label3.Text = "lable3";
            // 
            // btnRevertForm
            // 
            btnRevertForm.Location = new Point(336, 265);
            btnRevertForm.Margin = new Padding(3, 2, 3, 2);
            btnRevertForm.Name = "btnRevertForm";
            btnRevertForm.Size = new Size(82, 22);
            btnRevertForm.TabIndex = 31;
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
            btnSaveForm.TabIndex = 30;
            btnSaveForm.Text = "Save";
            btnSaveForm.UseVisualStyleBackColor = true;
            btnSaveForm.Click += btnSaveForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 33);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 29;
            label2.Text = "lable2";
            // 
            // Field2
            // 
            Field2.Location = new Point(86, 32);
            Field2.Margin = new Padding(2, 1, 2, 1);
            Field2.Name = "Field2";
            Field2.Size = new Size(334, 23);
            Field2.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 27;
            label1.Text = "lable1";
            // 
            // Field3
            // 
            Field3.Location = new Point(86, 51);
            Field3.Margin = new Padding(2, 1, 2, 1);
            Field3.Name = "Field3";
            Field3.Size = new Size(334, 23);
            Field3.TabIndex = 32;
            // 
            // Field1
            // 
            Field1.Location = new Point(86, 11);
            Field1.Margin = new Padding(2, 1, 2, 1);
            Field1.Name = "Field1";
            Field1.Size = new Size(334, 23);
            Field1.TabIndex = 26;
            // 
            // gameDetailBindingSource
            // 
            gameDetailBindingSource.DataSource = typeof(DTO.GameDetail);
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 298);
            Controls.Add(lbNotes);
            Controls.Add(Entry);
            Controls.Add(Exit);
            Controls.Add(Field4);
            Controls.Add(ReleaseDate);
            Controls.Add(inpNotes);
            Controls.Add(label5);
            Controls.Add(Field5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRevertForm);
            Controls.Add(btnSaveForm);
            Controls.Add(label2);
            Controls.Add(Field2);
            Controls.Add(label1);
            Controls.Add(Field3);
            Controls.Add(Field1);
            Name = "GameForm";
            Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)gameDetailBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNotes;
        private DateTimePicker Entry;
        private DateTimePicker Exit;
        private TextBox Field4;
        private DateTimePicker ReleaseDate;
        private TextBox inpNotes;
        private Label label5;
        private TextBox Field5;
        private Label label4;
        private Label label3;
        private Button btnRevertForm;
        private Button btnSaveForm;
        private Label label2;
        private TextBox Field2;
        private Label label1;
        private TextBox Field3;
        private TextBox Field1;
        private BindingSource gameDetailBindingSource;
    }
}
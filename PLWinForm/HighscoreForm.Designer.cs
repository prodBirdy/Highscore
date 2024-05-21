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
            components = new System.ComponentModel.Container();
            PlayerIndexBindingSource = new BindingSource(components);
            lbNotes = new Label();
            Entry = new DateTimePicker();
            Exit = new DateTimePicker();
            Field4 = new TextBox();
            ReleaseDate = new DateTimePicker();
            inpNotes = new TextBox();
            GameIndexBindingSource = new BindingSource(components);
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
            SelectBindingSource = new BindingSource(components);
            scoreInput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PlayerIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GameIndexBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scoreInput).BeginInit();
            SuspendLayout();
            // 
            // PlayerIndexBindingSource
            // 
            PlayerIndexBindingSource.DataSource = typeof(DTO.PlayerIndex);
            // 
            // lbNotes
            // 
            lbNotes.AutoSize = true;
            lbNotes.Location = new Point(11, 124);
            lbNotes.Margin = new Padding(2, 0, 2, 0);
            lbNotes.Name = "lbNotes";
            lbNotes.Size = new Size(38, 15);
            lbNotes.TabIndex = 59;
            lbNotes.Text = "Notes";
            // 
            // Entry
            // 
            Entry.Location = new Point(86, 73);
            Entry.Margin = new Padding(2, 1, 2, 1);
            Entry.Name = "Entry";
            Entry.Size = new Size(334, 23);
            Entry.TabIndex = 58;
            // 
            // Exit
            // 
            Exit.Location = new Point(86, 93);
            Exit.Margin = new Padding(2, 1, 2, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(334, 23);
            Exit.TabIndex = 57;
            // 
            // Field4
            // 
            Field4.Location = new Point(86, 73);
            Field4.Margin = new Padding(2, 1, 2, 1);
            Field4.Name = "Field4";
            Field4.Size = new Size(334, 23);
            Field4.TabIndex = 56;
            // 
            // ReleaseDate
            // 
            ReleaseDate.Location = new Point(86, 52);
            ReleaseDate.Margin = new Padding(2, 1, 2, 1);
            ReleaseDate.Name = "ReleaseDate";
            ReleaseDate.Size = new Size(334, 23);
            ReleaseDate.TabIndex = 55;
            // 
            // inpNotes
            // 
            inpNotes.DataBindings.Add(new Binding("DataContext", GameIndexBindingSource, "PlayerId", true));
            inpNotes.Location = new Point(86, 124);
            inpNotes.Margin = new Padding(2, 1, 2, 1);
            inpNotes.Multiline = true;
            inpNotes.Name = "inpNotes";
            inpNotes.Size = new Size(334, 135);
            inpNotes.TabIndex = 54;
            // 
            // GameIndexBindingSource
            // 
            GameIndexBindingSource.DataSource = typeof(DTO.GameIndex);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 97);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 53;
            label5.Text = "label5";
            // 
            // Field5
            // 
            Field5.Location = new Point(86, 95);
            Field5.Margin = new Padding(2, 1, 2, 1);
            Field5.Name = "Field5";
            Field5.Size = new Size(334, 23);
            Field5.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 51;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 54);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 50;
            label3.Text = "lable3";
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
            // Field2
            // 
            Field2.Location = new Point(86, 32);
            Field2.Margin = new Padding(2, 1, 2, 1);
            Field2.Name = "Field2";
            Field2.Size = new Size(334, 23);
            Field2.TabIndex = 45;
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
            // Field3
            // 
            Field3.Location = new Point(86, 51);
            Field3.Margin = new Padding(2, 1, 2, 1);
            Field3.Name = "Field3";
            Field3.Size = new Size(334, 23);
            Field3.TabIndex = 49;
            // 
            // SelectBindingSource
            // 
            SelectBindingSource.DataSource = typeof(DTO.SelectItem);
            // 
            // scoreInput
            // 
            scoreInput.Location = new Point(86, 10);
            scoreInput.Name = "scoreInput";
            scoreInput.Size = new Size(120, 23);
            scoreInput.TabIndex = 60;
            // 
            // HighscoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 298);
            Controls.Add(scoreInput);
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
            Name = "HighscoreForm";
            Text = "HighscoreForm";
            ((System.ComponentModel.ISupportInitialize)PlayerIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)GameIndexBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)scoreInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource PlayerIndexBindingSource;
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
        private BindingSource GameIndexBindingSource;
        private BindingSource SelectBindingSource;
        private NumericUpDown scoreInput;
    }
}
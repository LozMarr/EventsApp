namespace EventsApp {
	partial class FormAddEvents {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			button1 = new Button();
			btnSave = new Button();
			numericUpDown1 = new NumericUpDown();
			textBox1 = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			lblHeader = new Label();
			dateTimePicker1 = new DateTimePicker();
			dateTimePicker2 = new DateTimePicker();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.Crimson;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			button1.Location = new Point(558, 12);
			button1.Name = "button1";
			button1.Size = new Size(30, 30);
			button1.TabIndex = 29;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.Indigo;
			btnSave.FlatAppearance.BorderSize = 0;
			btnSave.FlatStyle = FlatStyle.Flat;
			btnSave.Location = new Point(233, 535);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(135, 42);
			btnSave.TabIndex = 28;
			btnSave.Text = "Сохранить";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(201, 249);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(199, 33);
			numericUpDown1.TabIndex = 25;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(127, 151);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(346, 33);
			textBox1.TabIndex = 24;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(188, 119);
			label5.Name = "label5";
			label5.Size = new Size(225, 26);
			label5.TabIndex = 23;
			label5.Text = "Название мероприятия:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(220, 413);
			label4.Name = "label4";
			label4.Size = new Size(160, 26);
			label4.TabIndex = 22;
			label4.Text = "Дата окончания:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(237, 315);
			label3.Name = "label3";
			label3.Size = new Size(127, 26);
			label3.TabIndex = 21;
			label3.Text = "Дата начала:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(210, 217);
			label2.Name = "label2";
			label2.Size = new Size(181, 26);
			label2.TabIndex = 20;
			label2.Text = "Количество гостей:";
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			lblHeader.Location = new Point(61, 43);
			lblHeader.Margin = new Padding(4, 0, 4, 0);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(479, 42);
			lblHeader.TabIndex = 19;
			lblHeader.Text = "Создание нового мероприятия";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.Location = new Point(200, 344);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(200, 33);
			dateTimePicker1.TabIndex = 30;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
			dateTimePicker2.Format = DateTimePickerFormat.Custom;
			dateTimePicker2.Location = new Point(200, 442);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(200, 33);
			dateTimePicker2.TabIndex = 31;
			// 
			// FormAddEvents
			// 
			AutoScaleDimensions = new SizeF(11F, 26F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(600, 600);
			Controls.Add(dateTimePicker2);
			Controls.Add(dateTimePicker1);
			Controls.Add(button1);
			Controls.Add(btnSave);
			Controls.Add(numericUpDown1);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(lblHeader);
			Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(5);
			Name = "FormAddEvents";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormAddEvents";
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button btnSave;
		private NumericUpDown numericUpDown1;
		private TextBox textBox1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label lblHeader;
		private DateTimePicker dateTimePicker1;
		private DateTimePicker dateTimePicker2;
	}
}
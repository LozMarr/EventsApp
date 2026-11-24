namespace EventsApp {
	partial class FormAddHalls {
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
			lblHeader = new Label();
			btnClose = new Button();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			textBox1 = new TextBox();
			numericUpDown1 = new NumericUpDown();
			numericUpDown2 = new NumericUpDown();
			numericUpDown3 = new NumericUpDown();
			btnSave = new Button();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
			SuspendLayout();
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			lblHeader.Location = new Point(127, 43);
			lblHeader.Margin = new Padding(4, 0, 4, 0);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(347, 42);
			lblHeader.TabIndex = 0;
			lblHeader.Text = "Создание нового зала";
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.Crimson;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.Location = new Point(1308, 18);
			btnClose.Margin = new Padding(4, 5, 4, 5);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(45, 46);
			btnClose.TabIndex = 8;
			btnClose.Text = "X";
			btnClose.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(95, 217);
			label2.Name = "label2";
			label2.Size = new Size(410, 29);
			label2.TabIndex = 9;
			label2.Text = "Количество проходов между блоками:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(113, 315);
			label3.Name = "label3";
			label3.Size = new Size(374, 29);
			label3.TabIndex = 10;
			label3.Text = "Количество рядов в каждом блоке:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(127, 413);
			label4.Name = "label4";
			label4.Size = new Size(346, 29);
			label4.TabIndex = 11;
			label4.Text = "Количество мест в каждом ряду:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(174, 119);
			label5.Name = "label5";
			label5.Size = new Size(253, 29);
			label5.TabIndex = 12;
			label5.Text = "Местоположение зала:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(127, 151);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(346, 37);
			textBox1.TabIndex = 13;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(201, 249);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(199, 37);
			numericUpDown1.TabIndex = 14;
			// 
			// numericUpDown2
			// 
			numericUpDown2.Location = new Point(201, 347);
			numericUpDown2.Name = "numericUpDown2";
			numericUpDown2.Size = new Size(199, 37);
			numericUpDown2.TabIndex = 15;
			// 
			// numericUpDown3
			// 
			numericUpDown3.Location = new Point(201, 445);
			numericUpDown3.Name = "numericUpDown3";
			numericUpDown3.Size = new Size(199, 37);
			numericUpDown3.TabIndex = 16;
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.Indigo;
			btnSave.FlatAppearance.BorderSize = 0;
			btnSave.FlatStyle = FlatStyle.Flat;
			btnSave.Location = new Point(233, 535);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(135, 42);
			btnSave.TabIndex = 17;
			btnSave.Text = "Сохранить";
			btnSave.UseVisualStyleBackColor = false;
			btnSave.Click += btnSave_Click;
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
			button1.TabIndex = 18;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// FormAddHalls
			// 
			AutoScaleDimensions = new SizeF(12F, 29F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(600, 600);
			Controls.Add(button1);
			Controls.Add(btnSave);
			Controls.Add(numericUpDown3);
			Controls.Add(numericUpDown2);
			Controls.Add(numericUpDown1);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(btnClose);
			Controls.Add(lblHeader);
			Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 6, 4, 6);
			Name = "FormAddHalls";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormAddHalls";
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeader;
		private Button btnClose;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox textBox1;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown3;
		private Button btnSave;
		private Button button1;
	}
}
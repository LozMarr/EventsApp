namespace EventsApp {
	partial class FormMain {
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
			lblName = new Label();
			btnSeating = new Button();
			btnHalls = new Button();
			btnClose = new Button();
			SuspendLayout();
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(12, 18);
			lblName.Name = "lblName";
			lblName.Size = new Size(115, 19);
			lblName.TabIndex = 0;
			lblName.Text = "Сафронов В. М.";
			// 
			// btnSeating
			// 
			btnSeating.BackColor = Color.Indigo;
			btnSeating.FlatAppearance.BorderSize = 0;
			btnSeating.FlatStyle = FlatStyle.Flat;
			btnSeating.Location = new Point(50, 79);
			btnSeating.Name = "btnSeating";
			btnSeating.Size = new Size(200, 75);
			btnSeating.TabIndex = 1;
			btnSeating.Text = "Редактирование рассадок и мероприятий";
			btnSeating.UseVisualStyleBackColor = false;
			btnSeating.Click += btnSeating_Click;
			// 
			// btnHalls
			// 
			btnHalls.BackColor = Color.Indigo;
			btnHalls.FlatAppearance.BorderSize = 0;
			btnHalls.FlatStyle = FlatStyle.Flat;
			btnHalls.Location = new Point(50, 189);
			btnHalls.Name = "btnHalls";
			btnHalls.Size = new Size(200, 75);
			btnHalls.TabIndex = 2;
			btnHalls.Text = "Редактирование залов";
			btnHalls.UseVisualStyleBackColor = false;
			btnHalls.Click += btnHalls_Click;
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.Crimson;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.Location = new Point(258, 12);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(30, 30);
			btnClose.TabIndex = 7;
			btnClose.Text = "X";
			btnClose.UseVisualStyleBackColor = false;
			btnClose.Click += btnClose_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(300, 300);
			Controls.Add(btnClose);
			Controls.Add(btnHalls);
			Controls.Add(btnSeating);
			Controls.Add(lblName);
			Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Настройка рассадки";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblName;
		private Button btnSeating;
		private Button btnHalls;
		private Button btnClose;
	}
}
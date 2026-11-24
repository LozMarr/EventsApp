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
			btnHalls = new Button();
			btnClose = new Button();
			btnEvents = new Button();
			label1 = new Label();
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
			// btnHalls
			// 
			btnHalls.BackColor = Color.Indigo;
			btnHalls.FlatAppearance.BorderSize = 0;
			btnHalls.FlatStyle = FlatStyle.Flat;
			btnHalls.Location = new Point(50, 124);
			btnHalls.Name = "btnHalls";
			btnHalls.Size = new Size(200, 75);
			btnHalls.TabIndex = 2;
			btnHalls.Text = "Залы";
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
			// btnEvents
			// 
			btnEvents.BackColor = Color.Indigo;
			btnEvents.FlatAppearance.BorderSize = 0;
			btnEvents.FlatStyle = FlatStyle.Flat;
			btnEvents.Location = new Point(50, 230);
			btnEvents.Name = "btnEvents";
			btnEvents.Size = new Size(200, 75);
			btnEvents.TabIndex = 8;
			btnEvents.Text = "Мероприятия";
			btnEvents.UseVisualStyleBackColor = false;
			btnEvents.Click += btnEvents_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(71, 68);
			label1.Name = "label1";
			label1.Size = new Size(158, 33);
			label1.TabIndex = 9;
			label1.Text = "Управление:";
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(300, 350);
			Controls.Add(label1);
			Controls.Add(btnEvents);
			Controls.Add(btnClose);
			Controls.Add(btnHalls);
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
		private Button btnHalls;
		private Button btnClose;
		private Button btnEvents;
		private Label label1;
	}
}
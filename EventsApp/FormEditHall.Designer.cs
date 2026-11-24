namespace EventsApp {
	partial class FormEditHall {
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
			label1 = new Label();
			btnClose = new Button();
			btnEditHall = new Button();
			btnDeleteHall = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(30, 60);
			label1.Name = "label1";
			label1.Size = new Size(241, 78);
			label1.TabIndex = 0;
			label1.Text = "Редактирование\r\nзала";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.Crimson;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btnClose.Location = new Point(258, 12);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(30, 30);
			btnClose.TabIndex = 7;
			btnClose.Text = "X";
			btnClose.UseVisualStyleBackColor = false;
			// 
			// btnEditHall
			// 
			btnEditHall.BackColor = Color.Indigo;
			btnEditHall.FlatAppearance.BorderSize = 0;
			btnEditHall.FlatStyle = FlatStyle.Flat;
			btnEditHall.Location = new Point(71, 181);
			btnEditHall.Name = "btnEditHall";
			btnEditHall.Size = new Size(158, 49);
			btnEditHall.TabIndex = 8;
			btnEditHall.Text = "Редактировать";
			btnEditHall.UseVisualStyleBackColor = false;
			// 
			// btnDeleteHall
			// 
			btnDeleteHall.BackColor = Color.Crimson;
			btnDeleteHall.FlatAppearance.BorderSize = 0;
			btnDeleteHall.FlatStyle = FlatStyle.Flat;
			btnDeleteHall.Location = new Point(71, 253);
			btnDeleteHall.Name = "btnDeleteHall";
			btnDeleteHall.Size = new Size(158, 49);
			btnDeleteHall.TabIndex = 9;
			btnDeleteHall.Text = "Удалить";
			btnDeleteHall.UseVisualStyleBackColor = false;
			// 
			// FormEditHall
			// 
			AutoScaleDimensions = new SizeF(11F, 26F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(300, 344);
			Controls.Add(btnDeleteHall);
			Controls.Add(btnEditHall);
			Controls.Add(btnClose);
			Controls.Add(label1);
			Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(5, 5, 5, 5);
			Name = "FormEditHall";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormEditHall";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnClose;
		private Button btnEditHall;
		private Button btnDeleteHall;
	}
}
namespace EventsApp {
	partial class FormLogin {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			btnLogin = new Button();
			txtLogin = new TextBox();
			txtPassword = new TextBox();
			btnClose = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(84, 66);
			label1.Name = "label1";
			label1.Size = new Size(232, 78);
			label1.TabIndex = 0;
			label1.Text = "EVENTS";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(127, 190);
			label2.Name = "label2";
			label2.Size = new Size(146, 26);
			label2.TabIndex = 1;
			label2.Text = "Введите логин:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(121, 279);
			label3.Name = "label3";
			label3.Size = new Size(159, 26);
			label3.TabIndex = 2;
			label3.Text = "Введите пароль:";
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.Indigo;
			btnLogin.FlatAppearance.BorderSize = 0;
			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.Location = new Point(146, 382);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(109, 39);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Войти";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// txtLogin
			// 
			txtLogin.Location = new Point(107, 227);
			txtLogin.Name = "txtLogin";
			txtLogin.Size = new Size(187, 33);
			txtLogin.TabIndex = 4;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(107, 316);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(187, 33);
			txtPassword.TabIndex = 5;
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.Crimson;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.Location = new Point(358, 12);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(30, 30);
			btnClose.TabIndex = 6;
			btnClose.Text = "X";
			btnClose.UseVisualStyleBackColor = false;
			btnClose.Click += btnClose_Click;
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(11F, 26F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(400, 450);
			Controls.Add(btnClose);
			Controls.Add(txtPassword);
			Controls.Add(txtLogin);
			Controls.Add(btnLogin);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(5);
			Name = "FormLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Button btnLogin;
		private TextBox txtLogin;
		private TextBox txtPassword;
		private Button btnClose;
	}
}

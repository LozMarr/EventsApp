namespace EventsApp {
	partial class FormSeatings {
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
			FLPLeft = new FlowLayoutPanel();
			FLPRight = new FlowLayoutPanel();
			label1 = new Label();
			SuspendLayout();
			// 
			// FLPLeft
			// 
			FLPLeft.BackColor = Color.BlueViolet;
			FLPLeft.Location = new Point(12, 101);
			FLPLeft.Name = "FLPLeft";
			FLPLeft.Size = new Size(250, 250);
			FLPLeft.TabIndex = 0;
			// 
			// FLPRight
			// 
			FLPRight.BackColor = Color.BlueViolet;
			FLPRight.Location = new Point(322, 101);
			FLPRight.Name = "FLPRight";
			FLPRight.Size = new Size(250, 250);
			FLPRight.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(211, 14);
			label1.Name = "label1";
			label1.Size = new Size(163, 59);
			label1.TabIndex = 2;
			label1.Text = "СЦЕНА";
			// 
			// FormSeatings
			// 
			AutoScaleDimensions = new SizeF(11F, 26F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(584, 363);
			Controls.Add(label1);
			Controls.Add(FLPRight);
			Controls.Add(FLPLeft);
			Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(5);
			Name = "FormSeatings";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Рассадка";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel FLPLeft;
		private FlowLayoutPanel FLPRight;
		private Label label1;
	}
}
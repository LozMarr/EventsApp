namespace EventsApp {
	partial class FormEvents {
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
			FLP = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// FLP
			// 
			FLP.Dock = DockStyle.Fill;
			FLP.Location = new Point(0, 0);
			FLP.Name = "FLP";
			FLP.Size = new Size(914, 561);
			FLP.TabIndex = 0;
			// 
			// FormEvents
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.MediumPurple;
			ClientSize = new Size(914, 561);
			Controls.Add(FLP);
			Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormEvents";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Мероприятия";
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel FLP;
	}
}
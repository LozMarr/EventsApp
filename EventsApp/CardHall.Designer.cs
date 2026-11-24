namespace EventsApp {
	partial class CardHall {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			lblCapacity = new Label();
			lblName = new Label();
			lblLocation = new Label();
			SuspendLayout();
			// 
			// lblCapacity
			// 
			lblCapacity.BorderStyle = BorderStyle.FixedSingle;
			lblCapacity.Location = new Point(625, 0);
			lblCapacity.Name = "lblCapacity";
			lblCapacity.Size = new Size(275, 150);
			lblCapacity.TabIndex = 0;
			lblCapacity.Text = "label1";
			lblCapacity.TextAlign = ContentAlignment.MiddleCenter;
			lblCapacity.Click += lbl_Click;
			// 
			// lblName
			// 
			lblName.BorderStyle = BorderStyle.FixedSingle;
			lblName.Location = new Point(0, 0);
			lblName.Name = "lblName";
			lblName.Size = new Size(625, 50);
			lblName.TabIndex = 1;
			lblName.Text = "label1";
			lblName.TextAlign = ContentAlignment.MiddleCenter;
			lblName.Click += lbl_Click;
			// 
			// lblLocation
			// 
			lblLocation.BorderStyle = BorderStyle.FixedSingle;
			lblLocation.Location = new Point(0, 50);
			lblLocation.Name = "lblLocation";
			lblLocation.Padding = new Padding(5);
			lblLocation.Size = new Size(625, 100);
			lblLocation.TabIndex = 2;
			lblLocation.Text = "label2";
			lblLocation.Click += lbl_Click;
			// 
			// CardHall
			// 
			AutoScaleDimensions = new SizeF(14F, 33F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.BlueViolet;
			Controls.Add(lblLocation);
			Controls.Add(lblName);
			Controls.Add(lblCapacity);
			Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			Margin = new Padding(7);
			Name = "CardHall";
			Size = new Size(900, 150);
			ResumeLayout(false);
		}

		#endregion

		private Label lblCapacity;
		private Label lblName;
		private Label lblLocation;
	}
}

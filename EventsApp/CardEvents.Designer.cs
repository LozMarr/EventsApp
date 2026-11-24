namespace EventsApp {
	partial class CardEvents {
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
			lblStatus = new Label();
			lblHeader = new Label();
			lblCapacity = new Label();
			lblEndDate = new Label();
			lblStartDate = new Label();
			SuspendLayout();
			// 
			// lblStatus
			// 
			lblStatus.BorderStyle = BorderStyle.FixedSingle;
			lblStatus.Location = new Point(550, 0);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(350, 150);
			lblStatus.TabIndex = 0;
			lblStatus.Text = "label1";
			lblStatus.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblHeader
			// 
			lblHeader.BorderStyle = BorderStyle.FixedSingle;
			lblHeader.Location = new Point(0, 0);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(550, 50);
			lblHeader.TabIndex = 1;
			lblHeader.Text = "label2";
			lblHeader.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblCapacity
			// 
			lblCapacity.BorderStyle = BorderStyle.FixedSingle;
			lblCapacity.Location = new Point(0, 50);
			lblCapacity.Name = "lblCapacity";
			lblCapacity.Size = new Size(200, 100);
			lblCapacity.TabIndex = 2;
			lblCapacity.Text = "label1";
			lblCapacity.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblEndDate
			// 
			lblEndDate.BorderStyle = BorderStyle.FixedSingle;
			lblEndDate.Location = new Point(200, 100);
			lblEndDate.Name = "lblEndDate";
			lblEndDate.Size = new Size(350, 50);
			lblEndDate.TabIndex = 3;
			lblEndDate.Text = "label2";
			lblEndDate.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblStartDate
			// 
			lblStartDate.BorderStyle = BorderStyle.FixedSingle;
			lblStartDate.Location = new Point(200, 50);
			lblStartDate.Name = "lblStartDate";
			lblStartDate.Size = new Size(350, 50);
			lblStartDate.TabIndex = 4;
			lblStartDate.Text = "label2";
			lblStartDate.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// CardEvents
			// 
			AutoScaleDimensions = new SizeF(11F, 26F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.BlueViolet;
			Controls.Add(lblStartDate);
			Controls.Add(lblEndDate);
			Controls.Add(lblCapacity);
			Controls.Add(lblHeader);
			Controls.Add(lblStatus);
			Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ForeColor = Color.White;
			Margin = new Padding(7);
			Name = "CardEvents";
			Size = new Size(900, 150);
			ResumeLayout(false);
		}

		#endregion

		private Label lblStatus;
		private Label lblHeader;
		private Label lblCapacity;
		private Label lblEndDate;
		private Label lblStartDate;
	}
}

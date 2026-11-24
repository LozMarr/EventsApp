namespace EventsApp {
	public partial class FormSeatings : Form {
		public FormSeatings() {
			InitializeComponent();
			for (int i = 0; i < 25; i++) {
				var btnSeatLeft = new Button {
					BackColor = Color.Gray,
					Margin = new Padding(0),
					Size = new Size(50,50)
				};
				var btnSeatRight = new Button {
					BackColor = Color.Gray,
					Margin = new Padding(0),
					Size = new Size(50, 50)
				};
				if (i == 12 || i == 3) {
					btnSeatLeft.BackColor = Color.Red;
				}
				if(i == 22 || i == 8) {
					btnSeatRight.BackColor = Color.Red;
				}
				FLPLeft.Controls.Add(btnSeatLeft);
				FLPRight.Controls.Add(btnSeatRight);
			}
		}
	}
}

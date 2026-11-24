namespace EventsApp {
	public partial class CardEvents : UserControl {
		public CardEvents() {
			InitializeComponent();
		}

		public void Fill(int capacity, string name, string status, DateTime startTime, DateTime endTime, bool flag = false) {
			lblHeader.Text = name;
			lblStatus.Text = status;
			lblStartDate.Text = $"Начало: {startTime.ToString()}";
			lblEndDate.Text = $"Конец: {endTime.ToString()}";
			lblCapacity.Text = $"Гостей: {capacity}";
			if(flag == true) {
				lblCapacity.Click += LblCapacity_Click;
				lblEndDate.Click += LblCapacity_Click;
				lblHeader.Click += LblCapacity_Click;
				lblStartDate.Click += LblCapacity_Click;
				lblStatus.Click += LblCapacity_Click;
			}
		}

		private void LblCapacity_Click(object? sender, EventArgs e) {
			FormSeatings formSeatings = new FormSeatings();
			formSeatings.ShowDialog();
		}
	}
}

namespace EventsApp {
	public partial class CardHall : UserControl {
		public CardHall() {
			InitializeComponent();
		}

		public void Fill(int capacity, string name, string location) {
			lblCapacity.Text = $"Вместимость: {capacity}";
			lblLocation.Text = location;
			lblName.Text = name;
		}

		private void lbl_Click(object sender, EventArgs e) {
			FormAddHalls formAddHalls = new FormAddHalls(true);
			formAddHalls.ShowDialog();
		}
	}
}

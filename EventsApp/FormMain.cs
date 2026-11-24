namespace EventsApp {
	public partial class FormMain : Form {
		public FormMain() {
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e) => OnFormClosed();
		private void OnFormClosed() => Application.Exit();

		private void btnHalls_Click(object sender, EventArgs e) {
			FormHalls formHalls = new FormHalls();
			this.Hide();
			formHalls.ShowDialog();
			this.Show();
		}

		private void btnSeating_Click(object sender, EventArgs e) {

		}
	}
}

namespace EventsApp {
	public partial class FormAddEvents : Form {
		public FormAddEvents() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e) {
			MessageBox.Show("Мероприятие успешно добавлено!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}

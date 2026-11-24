//using EventsApp.Models;

namespace EventsApp {
	public partial class FormLogin : Form {
		public User CurrentUser {  get; private set; }
		public FormLogin() {
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e) {

		}
	}
}

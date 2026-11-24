namespace EventsApp {
	public partial class FormLogin : Form {
		public FormLogin() {
			InitializeComponent();
			txtLogin.Text = "LozHad";
			txtPassword.Text = "123";
		}

		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			if(txtLogin.Text != "LozHad" || txtPassword.Text != "123"){
				MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			FormMain formMain = new FormMain();
			formMain.Show();
			this.Hide();
		}
	}
}

namespace EventsApp {
	public partial class FormAddHalls : Form {
		public FormAddHalls(bool flag = false) {
			InitializeComponent();
			if (flag == true) {
				lblHeader.Text = "Редактирование зала";
				textBox1.Text = "УК 1, Ул. Ладыженского, д. 7";
				numericUpDown1.Value = 2;
				numericUpDown2.Value = 50;
				numericUpDown3.Value = 6;
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e) {
			MessageBox.Show("Зал успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}

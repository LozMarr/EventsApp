namespace EventsApp {
	public partial class FormHalls : Form {
		public FormHalls() {
			InitializeComponent();
			var panelAdd = new Panel {
				Dock = DockStyle.Top,
				Height = 50,
				Width = FLPHalls.Width - 17
			};
			var btnAdd = new Button {
				Dock = DockStyle.Fill,
				Text = "Создать новый зал"
			};
			btnAdd.Click += BtnAdd_Click;
			FLPHalls.Controls.Add(panelAdd);
			panelAdd.Controls.Add(btnAdd);
			CardHall card1 = new CardHall();
			CardHall card2 = new CardHall();
			card1.Fill(300, "Большой актовый зал", "УК 1, Ул. Ладыженского, д. 7");
			card2.Fill(50, "Малый актовый зал", "УК 2, Ул. Чапаева, д. 28");
			FLPHalls.Controls.Add(card1);
			FLPHalls.Controls.Add(card2);
		}

		private void BtnAdd_Click(object? sender, EventArgs e) {
			FormAddHalls formAddHalls = new FormAddHalls();
			this.Hide();
			formAddHalls.ShowDialog();
			this.Show(); ;
		}
	}
}

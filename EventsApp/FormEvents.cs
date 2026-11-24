namespace EventsApp {
	public partial class FormEvents : Form {
		public FormEvents() {
			InitializeComponent();
			var panelFilter = new FlowLayoutPanel {
				Height = 50,
				Width = FLP.Width - 10,
				BackColor = Color.BlueViolet,
				FlowDirection = FlowDirection.LeftToRight,
				WrapContents = false,
				Padding = new Padding(10, 12, 10, 10)
			};
			var lblFilter = new Label {
				Text = "Фильтрация:",
				AutoSize = true,
				ForeColor = Color.White,
				Margin = new Padding(0, 4, 15, 0)
			};
			panelFilter.Controls.Add(lblFilter);
			var cmbGroup = new ComboBox {
				Width = 150,
				DropDownStyle = ComboBoxStyle.DropDownList,
				Margin = new Padding(0, 0, 15, 0)
			};
			cmbGroup.Items.AddRange(new object[] { "Все группы", "ИС-23", "ИС-24", "ОДЛ-24", "ЭРО-26", "ИС-25" });
			cmbGroup.SelectedIndex = 0;
			panelFilter.Controls.Add(cmbGroup);
			var cmbDate = new ComboBox {
				Width = 150,
				DropDownStyle = ComboBoxStyle.DropDownList,
				Margin = new Padding(0, 0, 15, 0)
			};
			var btnAdd = new Button {
				Text = "Добавить мероприятие",
				Width = 300,
				Height = 30,
				FlatStyle = FlatStyle.Flat,
				ForeColor = Color.White,
				BackColor = Color.Indigo,
				Margin = new Padding(0)
			};
			btnAdd.FlatAppearance.BorderSize = 0;
			btnAdd.Click += BtnAdd_Click;
			cmbDate.Items.AddRange(new object[] { "Все даты", "Сегодня", "На этой неделе", "В этом месяце" });
			cmbDate.SelectedIndex = 0;
			panelFilter.Controls.Add(cmbDate);
			FLP.Controls.Add(panelFilter);
			panelFilter.Controls.Add(btnAdd);

			DateTime start = DateTime.Now;
			DateTime end = DateTime.Now;
			CardEvents card1 = new CardEvents();
			CardEvents card2 = new CardEvents();
			card1.Fill(243, "Стань звездой", "Рассадка завершена\nЗал: Большой актовый зал", new DateTime(2026, 11, 24, 13, 30, 0), new DateTime(2026, 11, 24, 15, 00, 0));
			card2.Fill(34, "Лекция о вреде наркотиков", "Рассадка не назначена", new DateTime(2026, 11, 26, 14, 30, 0), new DateTime(2026, 11, 24, 17, 00, 0), true);
			FLP.Controls.Add(card1);
			FLP.Controls.Add(card2);
		}

		private void BtnAdd_Click(object? sender, EventArgs e) {
			FormAddEvents formAddEvents = new FormAddEvents();
			this.Hide();
			formAddEvents.ShowDialog();
			this.Show();
		}
	}
}

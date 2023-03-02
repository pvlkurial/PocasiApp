namespace PocasiApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            getDataButton = new Button();
            label2 = new Label();
            comboCityName = new ComboBox();
            label3 = new Label();
            labelCurrentCity = new Label();
            labelTemperature = new Label();
            labelHumidity = new Label();
            label4 = new Label();
            labelFeelsLike = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // getDataButton
            // 
            getDataButton.Anchor = AnchorStyles.Top;
            getDataButton.BackColor = Color.Transparent;
            getDataButton.BackgroundImage = Properties.Resources.refresh_icon;
            getDataButton.BackgroundImageLayout = ImageLayout.Zoom;
            getDataButton.FlatStyle = FlatStyle.Flat;
            getDataButton.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            getDataButton.ForeColor = Color.Transparent;
            getDataButton.ImageAlign = ContentAlignment.TopRight;
            getDataButton.Location = new Point(431, 40);
            getDataButton.Margin = new Padding(4, 5, 4, 5);
            getDataButton.Name = "getDataButton";
            getDataButton.Size = new Size(86, 100);
            getDataButton.TabIndex = 0;
            getDataButton.UseVisualStyleBackColor = false;
            getDataButton.Click += getDataButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(336, 450);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "HUMIDITA";
            // 
            // comboCityName
            // 
            comboCityName.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboCityName.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboCityName.BackColor = Color.Azure;
            comboCityName.DropDownHeight = 200;
            comboCityName.FlatStyle = FlatStyle.Flat;
            comboCityName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboCityName.ForeColor = Color.Black;
            comboCityName.FormattingEnabled = true;
            comboCityName.IntegralHeight = false;
            comboCityName.Items.AddRange(new object[] { "Abidjan", "Abu Dhabi", "Abuja", "Accra", "Addis Ababa", "Ahmedabad", "Aleppo", "Alexandria", "Algiers", "Almaty", "Amman", "Amsterdam", "Andorra la Vella", "Anchorage", "Ankara", "Antananarivo", "Apia", "Arnold", "Ashgabat", "Asmara", "Asuncion", "Athens", "Auckland", "Avarua", "Baghdad", "Baku", "Bamako", "Banda Aceh", "Bandar Seri Begawan", "Bandung", "Bangkok", "Bangui", "Banjul", "Barcelona", "Barranquilla", "Basrah", "Basse-Terre", "Basseterre", "Beijing", "Beirut", "Bekasi", "Belem", "Belgrade", "Belmopan", "Belo Horizonte", "Bengaluru", "Berlin", "Bern", "Bishkek", "Bissau", "Bogota", "Brasilia", "Bratislava", "Brazzaville", "Bridgetown", "Brisbane", "Brussels", "Budapest", "Buenos Aires", "Bucharest", "Bujumbura", "Bursa", "Busan", "Cairo", "Cali", "Caloocan", "Camayenne", "Canberra", "Cape Town", "Caracas", "Casablanca", "Castries", "Cayenne", "Colombo", "Conakry", "Copenhagen", "Cordoba", "Curitiba", "Daegu", "Daejeon", "Dakar", "Dallas", "Damascus", "Dar es Salaam", "Delhi", "Denver", "Dhaka", "Dili", "Djibouti", "Dodoma", "Doha", "Dongguan", "Douala", "Douglas", "Dubai", "Dublin", "Durban", "Dushanbe", "Faisalabad", "Fort-de-France", "Fortaleza", "Freetown", "Fukuoka", "Funafuti", "Gaborone", "George Town", "Georgetown", "Gibraltar", "Gitega", "Giza", "Guadalajara", "Guangzhou", "Guatemala City", "Guayaquil", "Gujranwala", "Gustavia", "Gwangju", "Hamburg", "Hanoi", "Harare", "Havana", "Helsinki", "Ho Chi Minh City", "Hong Kong", "Honiara", "Honolulu", "Houston", "Hyderabad", "Hyderabad", "Charlotte Amalie", "Chengdu", "Chennai", "Chicago", "Chisinau", "Chittagong", "Chongqing", "Ibadan", "Incheon", "Isfahan", "Islamabad", "Istanbul", "Izmir", "Jaipur", "Jakarta", "Jeddah", "Jerusalem", "Johannesburg", "Juarez", "Juba", "Kabul", "Kaduna", "Kampala", "Kano", "Kanpur", "Kaohsiung", "Karachi", "Karaj", "Kathmandu", "Kawasaki", "Kharkiv", "Khartoum", "Khulna", "Kigali", "Kingsburg", "Kingston", "Kingstown", "Kinshasa", "Kobe", "Kolkata", "Kota Bharu", "Kowloon", "Kuala Lumpur", "Kumasi", "Kuwait", "Kyiv", "Kyoto", "La Paz", "Lagos", "Lahore", "Libreville", "Lilongwe", "Lima", "Lisbon", "Ljubljana", "Lome", "London", "Los Angeles", "Luanda", "Lubumbashi", "Lusaka", "Luxembourg", "Macau", "Madrid", "Majuro", "Makassar", "Malabo", "Male", "Mamoudzou", "Managua", "Manama", "Manaus", "Manila", "Maputo", "Maracaibo", "Maracay", "Mariehamn", "Marigot", "Maseru", "Mashhad", "Mbabane", "Mecca", "Medan", "Medellin", "Medina", "Melbourne", "Mexico City", "Miami", "Minsk", "Mogadishu", "Monaco", "Monrovia", "Montevideo", "Montreal", "Moroni", "Moscow", "Mosul", "Multan", "Mumbai", "Muscat", "N'Djamena", "Nagoya", "Nairobi", "Nanchong", "Nanjing", "Nassau", "Nay Pyi Taw", "New York", "Niamey", "Nicosia", "Nouakchott", "Noumea", "Novosibirsk", "Nuku'alofa", "Nur-Sultan", "Nuuk", "Oranjestad", "Osaka", "Oslo", "Ottawa", "Ouagadougou", "Pago Pago", "Palembang", "Palo Alto", "Panama", "Papeete", "Paramaribo", "Paris", "Perth", "Philadelphia", "Phnom Penh", "Phoenix", "Podgorica", "Port Louis", "Port Moresby", "Port of Spain", "Port-au-Prince", "Port-Vila", "Porto Alegre", "Porto-Novo", "Prague", "Praia", "Pretoria", "Pristina", "Puebla", "Pune", "Pyongyang", "Quezon City", "Quito", "Rabat", "Rawalpindi", "Recife", "Reykjavik", "Riga", "Rio de Janeiro", "Riyadh", "Road Town", "Rome", "Roseau", "Saint George's", "Saint Helier", "Saint John's", "Saint Peter Port", "Saint Petersburg", "Saint-Denis", "Saint-Pierre", "Saipan", "Salvador", "San Antonio", "San Diego", "San Francisco", "San Jose", "San Juan", "San Marino", "San Salvador", "Sanaa", "Santa Cruz de la Sierra", "Santiago", "Santo Domingo", "Sao Paulo", "Sao Tome", "Sapporo", "Sarajevo", "Seattle", "Semarang", "Seoul", "Shanghai", "Sharjah", "Shenzhen", "Singapore", "Skopje", "Sofia", "South Tangerang", "Soweto", "Stockholm", "Sucre", "Surabaya", "Surat", "Suva", "Sydney", "Tabriz", "Taipei", "Tallinn", "Tangerang", "Tarawa", "Tashkent", "Tbilisi", "Tegucigalpa", "Tehran", "Tel Aviv", "Thimphu", "Tianjin", "Tijuana", "Tirana", "Tokyo", "Toronto", "Torshavn", "Tripoli", "Tunis", "Ulan Bator", "Vaduz", "Valencia", "Valletta", "Vancouver", "Victoria", "Vienna", "Vientiane", "Vilnius", "Warsaw", "Washington", "Wellington", "Willemstad", "Windhoek", "Wuhan", "Xi'an", "Yamoussoukro", "Yangon", "Yaounde", "Yekaterinburg", "Yerevan", "Yokohama", "Zagreb" });
            comboCityName.Location = new Point(17, 40);
            comboCityName.Margin = new Padding(4, 5, 4, 5);
            comboCityName.Name = "comboCityName";
            comboCityName.RightToLeft = RightToLeft.No;
            comboCityName.Size = new Size(157, 30);
            comboCityName.Sorted = true;
            comboCityName.TabIndex = 5;
            comboCityName.SelectedIndexChanged += comboCityName_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 22);
            label3.TabIndex = 7;
            label3.Text = "CURRENT CITY:";
            // 
            // labelCurrentCity
            // 
            labelCurrentCity.AutoSize = true;
            labelCurrentCity.BackColor = Color.Transparent;
            labelCurrentCity.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrentCity.ForeColor = Color.White;
            labelCurrentCity.Location = new Point(201, 327);
            labelCurrentCity.Margin = new Padding(4, 0, 4, 0);
            labelCurrentCity.Name = "labelCurrentCity";
            labelCurrentCity.Size = new Size(93, 40);
            labelCurrentCity.TabIndex = 8;
            labelCurrentCity.Text = "NAN";
            labelCurrentCity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTemperature
            // 
            labelTemperature.BackColor = Color.Transparent;
            labelTemperature.FlatStyle = FlatStyle.Flat;
            labelTemperature.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelTemperature.ForeColor = Color.White;
            labelTemperature.Location = new Point(264, 180);
            labelTemperature.Margin = new Padding(4, 0, 4, 0);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(276, 142);
            labelTemperature.TabIndex = 9;
            labelTemperature.Text = "NAN";
            labelTemperature.TextAlign = ContentAlignment.TopCenter;
            labelTemperature.Click += labelTemperature_Click;
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.BackColor = Color.Transparent;
            labelHumidity.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHumidity.ForeColor = Color.White;
            labelHumidity.Location = new Point(336, 475);
            labelHumidity.Margin = new Padding(4, 0, 4, 0);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(90, 37);
            labelHumidity.TabIndex = 10;
            labelHumidity.Text = "NAN";
            labelHumidity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(97, 450);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 11;
            label4.Text = "POCITOVÁ TEPLOTA";
            // 
            // labelFeelsLike
            // 
            labelFeelsLike.AutoSize = true;
            labelFeelsLike.BackColor = Color.Transparent;
            labelFeelsLike.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelFeelsLike.ForeColor = Color.White;
            labelFeelsLike.Location = new Point(130, 475);
            labelFeelsLike.Margin = new Padding(4, 0, 4, 0);
            labelFeelsLike.Name = "labelFeelsLike";
            labelFeelsLike.Size = new Size(90, 37);
            labelFeelsLike.TabIndex = 12;
            labelFeelsLike.Text = "NAN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(60, 145);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 710);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(534, 680);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(labelFeelsLike);
            Controls.Add(label4);
            Controls.Add(labelHumidity);
            Controls.Add(labelTemperature);
            Controls.Add(labelCurrentCity);
            Controls.Add(label3);
            Controls.Add(comboCityName);
            Controls.Add(label2);
            Controls.Add(getDataButton);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox valueBox;
        private Label label2;
        private Label label3;
        private Label labelCurrentCity;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        public Label labelFeelsLike;
        private Label label5;
        public Button getDataButton;
        public ComboBox comboCityName;
        public Label labelTemperature;
        public Label labelHumidity;
        public PictureBox pictureBox1;
    }
}
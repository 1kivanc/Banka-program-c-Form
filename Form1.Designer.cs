namespace Banka
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxGiris = new System.Windows.Forms.GroupBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttons = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBoxKayit = new System.Windows.Forms.GroupBox();
            this.kayitYas = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.kayitEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.kayitTel = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.kayitAdres = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.kayitParolaOnay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.kayitTC = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.kayitAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.radioKadın = new System.Windows.Forms.RadioButton();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.kayitParola = new System.Windows.Forms.TextBox();
            this.kayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.koumadimOnayladım = new System.Windows.Forms.CheckBox();
            this.groupBoxGiris.SuspendLayout();
            this.buttons.SuspendLayout();
            this.groupBoxKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGiris
            // 
            this.groupBoxGiris.Controls.Add(this.btnGirisYap);
            this.groupBoxGiris.Controls.Add(this.linkLabel1);
            this.groupBoxGiris.Controls.Add(this.radioButton2);
            this.groupBoxGiris.Controls.Add(this.radioButton1);
            this.groupBoxGiris.Controls.Add(this.txtParola);
            this.groupBoxGiris.Controls.Add(this.txtKullaniciAdi);
            this.groupBoxGiris.Controls.Add(this.label3);
            this.groupBoxGiris.Controls.Add(this.label2);
            this.groupBoxGiris.Controls.Add(this.label1);
            this.groupBoxGiris.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBoxGiris.Location = new System.Drawing.Point(104, 69);
            this.groupBoxGiris.Name = "groupBoxGiris";
            this.groupBoxGiris.Size = new System.Drawing.Size(745, 513);
            this.groupBoxGiris.TabIndex = 0;
            this.groupBoxGiris.TabStop = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGirisYap.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnGirisYap.Location = new System.Drawing.Point(332, 299);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(198, 51);
            this.btnGirisYap.TabIndex = 8;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.linkLabel1.Location = new System.Drawing.Point(383, 380);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.radioButton2.Location = new System.Drawing.Point(464, 240);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Admin";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.radioButton1.Location = new System.Drawing.Point(332, 240);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 20);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Müşteri";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(306, 188);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(240, 22);
            this.txtParola.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(306, 149);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(240, 22);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label3.Location = new System.Drawing.Point(197, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label2.Location = new System.Drawing.Point(153, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label1.Location = new System.Drawing.Point(313, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Yap";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(90, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(232, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kayıt Ol";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttons
            // 
            this.buttons.Controls.Add(this.label6);
            this.buttons.Controls.Add(this.label5);
            this.buttons.Controls.Add(this.label4);
            this.buttons.Controls.Add(this.button1);
            this.buttons.Controls.Add(this.button2);
            this.buttons.Location = new System.Drawing.Point(255, 105);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(486, 326);
            this.buttons.TabIndex = 11;
            this.buttons.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(96, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Güvenilir Bankya Hoşgeldiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tek tıkla anında bütün bankacılık işlemlerini hallet";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(94, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Güvenilir  Banka";
            // 
            // btnKapat
            // 
            this.btnKapat.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnKapat.Image = global::Banka.Properties.Resources.kapat;
            this.btnKapat.Location = new System.Drawing.Point(914, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(41, 38);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Visible = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupBoxKayit
            // 
            this.groupBoxKayit.Controls.Add(this.koumadimOnayladım);
            this.groupBoxKayit.Controls.Add(this.kayitYas);
            this.groupBoxKayit.Controls.Add(this.label17);
            this.groupBoxKayit.Controls.Add(this.kayitEmail);
            this.groupBoxKayit.Controls.Add(this.label16);
            this.groupBoxKayit.Controls.Add(this.kayitTel);
            this.groupBoxKayit.Controls.Add(this.label15);
            this.groupBoxKayit.Controls.Add(this.kayitAdres);
            this.groupBoxKayit.Controls.Add(this.label14);
            this.groupBoxKayit.Controls.Add(this.label13);
            this.groupBoxKayit.Controls.Add(this.kayitParolaOnay);
            this.groupBoxKayit.Controls.Add(this.label12);
            this.groupBoxKayit.Controls.Add(this.kayitTC);
            this.groupBoxKayit.Controls.Add(this.label11);
            this.groupBoxKayit.Controls.Add(this.kayitAdSoyad);
            this.groupBoxKayit.Controls.Add(this.label10);
            this.groupBoxKayit.Controls.Add(this.btnKayitOl);
            this.groupBoxKayit.Controls.Add(this.radioKadın);
            this.groupBoxKayit.Controls.Add(this.radioErkek);
            this.groupBoxKayit.Controls.Add(this.kayitParola);
            this.groupBoxKayit.Controls.Add(this.kayitKullaniciAdi);
            this.groupBoxKayit.Controls.Add(this.label7);
            this.groupBoxKayit.Controls.Add(this.label8);
            this.groupBoxKayit.Controls.Add(this.label9);
            this.groupBoxKayit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBoxKayit.Location = new System.Drawing.Point(98, 53);
            this.groupBoxKayit.Name = "groupBoxKayit";
            this.groupBoxKayit.Size = new System.Drawing.Size(745, 513);
            this.groupBoxKayit.TabIndex = 9;
            this.groupBoxKayit.TabStop = false;
            // 
            // kayitYas
            // 
            this.kayitYas.Location = new System.Drawing.Point(306, 183);
            this.kayitYas.Mask = "00";
            this.kayitYas.Name = "kayitYas";
            this.kayitYas.Size = new System.Drawing.Size(240, 22);
            this.kayitYas.TabIndex = 23;
            this.kayitYas.ValidatingType = typeof(int);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label17.Location = new System.Drawing.Point(194, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 22;
            this.label17.Text = "Yaş : ";
            // 
            // kayitEmail
            // 
            this.kayitEmail.Location = new System.Drawing.Point(307, 390);
            this.kayitEmail.Name = "kayitEmail";
            this.kayitEmail.Size = new System.Drawing.Size(239, 22);
            this.kayitEmail.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label16.Location = new System.Drawing.Point(201, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Email : ";
            // 
            // kayitTel
            // 
            this.kayitTel.Location = new System.Drawing.Point(307, 354);
            this.kayitTel.Mask = "(999) 000-0000";
            this.kayitTel.Name = "kayitTel";
            this.kayitTel.Size = new System.Drawing.Size(239, 22);
            this.kayitTel.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label15.Location = new System.Drawing.Point(196, 354);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Telefon :";
            // 
            // kayitAdres
            // 
            this.kayitAdres.Location = new System.Drawing.Point(306, 316);
            this.kayitAdres.Name = "kayitAdres";
            this.kayitAdres.Size = new System.Drawing.Size(240, 22);
            this.kayitAdres.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label14.Location = new System.Drawing.Point(196, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Adres :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label13.Location = new System.Drawing.Point(180, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Cinsiyet :";
            // 
            // kayitParolaOnay
            // 
            this.kayitParolaOnay.Location = new System.Drawing.Point(307, 254);
            this.kayitParolaOnay.Name = "kayitParolaOnay";
            this.kayitParolaOnay.PasswordChar = '*';
            this.kayitParolaOnay.Size = new System.Drawing.Size(240, 22);
            this.kayitParolaOnay.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label12.Location = new System.Drawing.Point(149, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Parola Onay :";
            // 
            // kayitTC
            // 
            this.kayitTC.Location = new System.Drawing.Point(306, 148);
            this.kayitTC.Mask = "00000000000";
            this.kayitTC.Name = "kayitTC";
            this.kayitTC.Size = new System.Drawing.Size(240, 22);
            this.kayitTC.TabIndex = 12;
            this.kayitTC.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label11.Location = new System.Drawing.Point(192, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "TC NO :";
            // 
            // kayitAdSoyad
            // 
            this.kayitAdSoyad.Location = new System.Drawing.Point(306, 106);
            this.kayitAdSoyad.Name = "kayitAdSoyad";
            this.kayitAdSoyad.Size = new System.Drawing.Size(240, 22);
            this.kayitAdSoyad.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label10.Location = new System.Drawing.Point(175, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ad Soyad :";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnKayitOl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnKayitOl.Location = new System.Drawing.Point(302, 462);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(136, 45);
            this.btnKayitOl.TabIndex = 8;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // radioKadın
            // 
            this.radioKadın.AutoSize = true;
            this.radioKadın.ImeMode = System.Windows.Forms.ImeMode.On;
            this.radioKadın.Location = new System.Drawing.Point(447, 286);
            this.radioKadın.Name = "radioKadın";
            this.radioKadın.Size = new System.Drawing.Size(62, 20);
            this.radioKadın.TabIndex = 6;
            this.radioKadın.TabStop = true;
            this.radioKadın.Text = "Kadın";
            this.radioKadın.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.ImeMode = System.Windows.Forms.ImeMode.On;
            this.radioErkek.Location = new System.Drawing.Point(315, 286);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(63, 20);
            this.radioErkek.TabIndex = 5;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // kayitParola
            // 
            this.kayitParola.Location = new System.Drawing.Point(307, 217);
            this.kayitParola.Name = "kayitParola";
            this.kayitParola.PasswordChar = '*';
            this.kayitParola.Size = new System.Drawing.Size(240, 22);
            this.kayitParola.TabIndex = 4;
            // 
            // kayitKullaniciAdi
            // 
            this.kayitKullaniciAdi.Location = new System.Drawing.Point(306, 69);
            this.kayitKullaniciAdi.Name = "kayitKullaniciAdi";
            this.kayitKullaniciAdi.Size = new System.Drawing.Size(240, 22);
            this.kayitKullaniciAdi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label7.Location = new System.Drawing.Point(197, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Parola :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label8.Location = new System.Drawing.Point(153, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Kullanıcı Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label9.Location = new System.Drawing.Point(313, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kayıt Ol";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // koumadimOnayladım
            // 
            this.koumadimOnayladım.AutoSize = true;
            this.koumadimOnayladım.Location = new System.Drawing.Point(288, 436);
            this.koumadimOnayladım.Name = "koumadimOnayladım";
            this.koumadimOnayladım.Size = new System.Drawing.Size(166, 20);
            this.koumadimOnayladım.TabIndex = 25;
            this.koumadimOnayladım.Text = "Okumadım , onayladım";
            this.koumadimOnayladım.UseVisualStyleBackColor = true;
            this.koumadimOnayladım.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 671);
            this.Controls.Add(this.groupBoxKayit);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.groupBoxGiris);
            this.Controls.Add(this.buttons);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxGiris.ResumeLayout(false);
            this.groupBoxGiris.PerformLayout();
            this.buttons.ResumeLayout(false);
            this.buttons.PerformLayout();
            this.groupBoxKayit.ResumeLayout(false);
            this.groupBoxKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGiris;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox buttons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox groupBoxKayit;
        private System.Windows.Forms.MaskedTextBox kayitTel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox kayitAdres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox kayitParolaOnay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox kayitTC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox kayitAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.RadioButton radioKadın;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.TextBox kayitParola;
        private System.Windows.Forms.TextBox kayitKullaniciAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox kayitYas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox kayitEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox koumadimOnayladım;
    }
}


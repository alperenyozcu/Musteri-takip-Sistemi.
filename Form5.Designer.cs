namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaMediumRadioButton1 = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.gunaMediumRadioButton2 = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(9, 44);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(255, 32);
            this.gunaTextBox1.TabIndex = 0;
            this.gunaTextBox1.Text = "gunaTextBox1";
            this.gunaTextBox1.Click += new System.EventHandler(this.GunaTextBox1_Click);
            this.gunaTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GunaTextBox1_MouseClick);
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(9, 104);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(255, 32);
            this.gunaTextBox2.TabIndex = 1;
            this.gunaTextBox2.Text = "gunaTextBox2";
            this.gunaTextBox2.Click += new System.EventHandler(this.GunaTextBox2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(95, 370);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(255, 42);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "gunaButton1";
            this.gunaButton1.Click += new System.EventHandler(this.GunaButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gunaLabel1.Location = new System.Drawing.Point(68, 83);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(282, 67);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "gunaLabel1";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gunaLabel2.Location = new System.Drawing.Point(12, 610);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(86, 20);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "gunaLabel2";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaCheckBox1);
            this.gunaPanel1.Controls.Add(this.gunaTextBox2);
            this.gunaPanel1.Controls.Add(this.gunaTextBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(87, 173);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(285, 191);
            this.gunaPanel1.TabIndex = 5;
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Location = new System.Drawing.Point(9, 165);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(129, 20);
            this.gunaCheckBox1.TabIndex = 2;
            this.gunaCheckBox1.Text = "gunaCheckBox1";
            this.gunaCheckBox1.CheckedChanged += new System.EventHandler(this.GunaCheckBox1_CheckedChanged);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(95, 455);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(255, 42);
            this.gunaButton2.TabIndex = 6;
            this.gunaButton2.Text = "gunaButton2";
            this.gunaButton2.Click += new System.EventHandler(this.GunaButton2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gunaLabel3.Location = new System.Drawing.Point(95, 429);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(86, 20);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "gunaLabel3";
            // 
            // gunaMediumRadioButton1
            // 
            this.gunaMediumRadioButton1.BaseColor = System.Drawing.Color.White;
            this.gunaMediumRadioButton1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaMediumRadioButton1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaMediumRadioButton1.FillColor = System.Drawing.Color.White;
            this.gunaMediumRadioButton1.Location = new System.Drawing.Point(427, 12);
            this.gunaMediumRadioButton1.Name = "gunaMediumRadioButton1";
            this.gunaMediumRadioButton1.Size = new System.Drawing.Size(20, 20);
            this.gunaMediumRadioButton1.TabIndex = 8;
            this.gunaMediumRadioButton1.Click += new System.EventHandler(this.GunaMediumRadioButton1_Click);
            this.gunaMediumRadioButton1.MouseLeave += new System.EventHandler(this.GunaMediumRadioButton1_MouseLeave);
            this.gunaMediumRadioButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GunaMediumRadioButton1_MouseMove);
            // 
            // gunaMediumRadioButton2
            // 
            this.gunaMediumRadioButton2.BaseColor = System.Drawing.Color.White;
            this.gunaMediumRadioButton2.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaMediumRadioButton2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaMediumRadioButton2.FillColor = System.Drawing.Color.White;
            this.gunaMediumRadioButton2.Location = new System.Drawing.Point(398, 12);
            this.gunaMediumRadioButton2.Name = "gunaMediumRadioButton2";
            this.gunaMediumRadioButton2.Size = new System.Drawing.Size(20, 20);
            this.gunaMediumRadioButton2.TabIndex = 9;
            this.gunaMediumRadioButton2.Click += new System.EventHandler(this.GunaMediumRadioButton2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 639);
            this.Controls.Add(this.gunaMediumRadioButton2);
            this.Controls.Add(this.gunaMediumRadioButton1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form5_KeyPress);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaMediumRadioButton gunaMediumRadioButton1;
        private Guna.UI.WinForms.GunaMediumRadioButton gunaMediumRadioButton2;
    }
}


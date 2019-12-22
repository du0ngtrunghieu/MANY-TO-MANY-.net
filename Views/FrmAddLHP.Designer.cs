namespace ONTAP_Finaly.Views
{
    partial class FrmAddLHP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtma = new MetroFramework.Controls.MetroTextBox();
            this.lopHocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtten = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtmin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtmax = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtgv = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã Lớp Học Phần";
            // 
            // txtma
            // 
            // 
            // 
            // 
            this.txtma.CustomButton.Image = null;
            this.txtma.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtma.CustomButton.Name = "";
            this.txtma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtma.CustomButton.TabIndex = 1;
            this.txtma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtma.CustomButton.UseSelectable = true;
            this.txtma.CustomButton.Visible = false;
            this.txtma.Lines = new string[0];
            this.txtma.Location = new System.Drawing.Point(211, 94);
            this.txtma.MaxLength = 32767;
            this.txtma.Name = "txtma";
            this.txtma.PasswordChar = '\0';
            this.txtma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtma.SelectedText = "";
            this.txtma.SelectionLength = 0;
            this.txtma.SelectionStart = 0;
            this.txtma.ShortcutsEnabled = true;
            this.txtma.Size = new System.Drawing.Size(244, 23);
            this.txtma.TabIndex = 1;
            this.txtma.UseSelectable = true;
            this.txtma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lopHocPhanBindingSource
            // 
            this.lopHocPhanBindingSource.DataSource = typeof(ONTAP_Finaly.Models.LopHocPhan);
            // 
            // txtten
            // 
            // 
            // 
            // 
            this.txtten.CustomButton.Image = null;
            this.txtten.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtten.CustomButton.Name = "";
            this.txtten.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtten.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtten.CustomButton.TabIndex = 1;
            this.txtten.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtten.CustomButton.UseSelectable = true;
            this.txtten.CustomButton.Visible = false;
            this.txtten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocPhanBindingSource, "Tenlhp", true));
            this.txtten.Lines = new string[0];
            this.txtten.Location = new System.Drawing.Point(211, 161);
            this.txtten.MaxLength = 32767;
            this.txtten.Name = "txtten";
            this.txtten.PasswordChar = '\0';
            this.txtten.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtten.SelectedText = "";
            this.txtten.SelectionLength = 0;
            this.txtten.SelectionStart = 0;
            this.txtten.ShortcutsEnabled = true;
            this.txtten.Size = new System.Drawing.Size(244, 23);
            this.txtten.TabIndex = 3;
            this.txtten.UseSelectable = true;
            this.txtten.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtten.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 165);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Tên Lớp Học Phần";
            // 
            // txtmin
            // 
            // 
            // 
            // 
            this.txtmin.CustomButton.Image = null;
            this.txtmin.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtmin.CustomButton.Name = "";
            this.txtmin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtmin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmin.CustomButton.TabIndex = 1;
            this.txtmin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmin.CustomButton.UseSelectable = true;
            this.txtmin.CustomButton.Visible = false;
            this.txtmin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocPhanBindingSource, "Min_Sv", true));
            this.txtmin.Lines = new string[0];
            this.txtmin.Location = new System.Drawing.Point(211, 231);
            this.txtmin.MaxLength = 32767;
            this.txtmin.Name = "txtmin";
            this.txtmin.PasswordChar = '\0';
            this.txtmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmin.SelectedText = "";
            this.txtmin.SelectionLength = 0;
            this.txtmin.SelectionStart = 0;
            this.txtmin.ShortcutsEnabled = true;
            this.txtmin.Size = new System.Drawing.Size(244, 23);
            this.txtmin.TabIndex = 5;
            this.txtmin.UseSelectable = true;
            this.txtmin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 235);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(138, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Số Sinh Viên Tối Thiểu";
            // 
            // txtmax
            // 
            // 
            // 
            // 
            this.txtmax.CustomButton.Image = null;
            this.txtmax.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtmax.CustomButton.Name = "";
            this.txtmax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtmax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmax.CustomButton.TabIndex = 1;
            this.txtmax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmax.CustomButton.UseSelectable = true;
            this.txtmax.CustomButton.Visible = false;
            this.txtmax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocPhanBindingSource, "Max_Sv", true));
            this.txtmax.Lines = new string[0];
            this.txtmax.Location = new System.Drawing.Point(211, 305);
            this.txtmax.MaxLength = 32767;
            this.txtmax.Name = "txtmax";
            this.txtmax.PasswordChar = '\0';
            this.txtmax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmax.SelectedText = "";
            this.txtmax.SelectionLength = 0;
            this.txtmax.SelectionStart = 0;
            this.txtmax.ShortcutsEnabled = true;
            this.txtmax.Size = new System.Drawing.Size(244, 23);
            this.txtmax.TabIndex = 7;
            this.txtmax.UseSelectable = true;
            this.txtmax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(52, 309);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(123, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Số Sinh Viên Tối Đa";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(605, 334);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(158, 49);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Thêm";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // txtgv
            // 
            // 
            // 
            // 
            this.txtgv.CustomButton.Image = null;
            this.txtgv.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtgv.CustomButton.Name = "";
            this.txtgv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtgv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtgv.CustomButton.TabIndex = 1;
            this.txtgv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtgv.CustomButton.UseSelectable = true;
            this.txtgv.CustomButton.Visible = false;
            this.txtgv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocPhanBindingSource, "GiaoVien", true));
            this.txtgv.Lines = new string[0];
            this.txtgv.Location = new System.Drawing.Point(211, 372);
            this.txtgv.MaxLength = 32767;
            this.txtgv.Name = "txtgv";
            this.txtgv.PasswordChar = '\0';
            this.txtgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtgv.SelectedText = "";
            this.txtgv.SelectionLength = 0;
            this.txtgv.SelectionStart = 0;
            this.txtgv.ShortcutsEnabled = true;
            this.txtgv.Size = new System.Drawing.Size(244, 23);
            this.txtgv.TabIndex = 10;
            this.txtgv.UseSelectable = true;
            this.txtgv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtgv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(52, 376);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Giáo Viên";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.monHocBindingSource;
            this.metroComboBox1.DisplayMember = "TenMonHoc";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(605, 98);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(185, 29);
            this.metroComboBox1.TabIndex = 11;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "id";
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataSource = typeof(ONTAP_Finaly.Models.MonHoc);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(605, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Chọn môn học";
            // 
            // FrmAddLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.txtgv);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmAddLHP";
            this.Text = "Thêm Lớp Học Phần";
            this.Load += new System.EventHandler(this.FrmAddLHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lopHocPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtma;
        private MetroFramework.Controls.MetroTextBox txtten;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtmin;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtmax;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtgv;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.BindingSource lopHocPhanBindingSource;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.BindingSource monHocBindingSource;
    }
}
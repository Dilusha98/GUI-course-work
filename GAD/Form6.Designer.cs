namespace GAD
{
    partial class supervisoracc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsvunit = new MetroFramework.Controls.MetroButton();
            this.date = new MetroFramework.Controls.MetroDateTime();
            this.cmbunit = new MetroFramework.Controls.MetroComboBox();
            this.damage = new MetroFramework.Controls.MetroTextBox();
            this.totalpro = new MetroFramework.Controls.MetroTextBox();
            this.absenceemp = new MetroFramework.Controls.MetroTextBox();
            this.prsntemp = new MetroFramework.Controls.MetroTextBox();
            this.unitempid = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnview = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenceemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalproductioncountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagecountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kARL111DataSet = new GAD.KARL111DataSet();
            this.btndltunit = new MetroFramework.Controls.MetroButton();
            this.dltdate = new MetroFramework.Controls.MetroDateTime();
            this.cmbdlunit = new MetroFramework.Controls.MetroComboBox();
            this.productionTableAdapter = new GAD.KARL111DataSetTableAdapters.productionTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kARL111DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = global::GAD.Properties.Resources.icons8_user_40;
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.Location = new System.Drawing.Point(822, 27);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(63, 57);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.BackgroundImage = global::GAD.Properties.Resources.icons8_back_128;
            this.metroLink2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink2.Location = new System.Drawing.Point(11, 16);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(26, 26);
            this.metroLink2.TabIndex = 1;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsvunit);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.cmbunit);
            this.groupBox1.Controls.Add(this.damage);
            this.groupBox1.Controls.Add(this.totalpro);
            this.groupBox1.Controls.Add(this.absenceemp);
            this.groupBox1.Controls.Add(this.prsntemp);
            this.groupBox1.Controls.Add(this.unitempid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 424);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Damage Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Production";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Absence Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Present Employee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // btnupdate
            // 
            this.btnupdate.BackgroundImage = global::GAD.Properties.Resources.fwwf;
            this.btnupdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnupdate.Location = new System.Drawing.Point(191, 371);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(123, 38);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseSelectable = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unit ";
            // 
            // btnsvunit
            // 
            this.btnsvunit.BackgroundImage = global::GAD.Properties.Resources.fwwf;
            this.btnsvunit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnsvunit.Location = new System.Drawing.Point(41, 372);
            this.btnsvunit.Name = "btnsvunit";
            this.btnsvunit.Size = new System.Drawing.Size(123, 38);
            this.btnsvunit.TabIndex = 14;
            this.btnsvunit.Text = "SAVE";
            this.btnsvunit.UseSelectable = true;
            this.btnsvunit.Click += new System.EventHandler(this.btnsvunit_Click);
            // 
            // date
            // 
            this.date.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.date.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.date.Location = new System.Drawing.Point(180, 75);
            this.date.MinimumSize = new System.Drawing.Size(0, 25);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(181, 25);
            this.date.TabIndex = 13;
            // 
            // cmbunit
            // 
            this.cmbunit.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbunit.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cmbunit.FormattingEnabled = true;
            this.cmbunit.ItemHeight = 19;
            this.cmbunit.Items.AddRange(new object[] {
            "Print Unit",
            "Handle Unit",
            "Cutting Unit",
            "Bordering Unit",
            "Tailoring Unit",
            "Complete Unit"});
            this.cmbunit.Location = new System.Drawing.Point(180, 25);
            this.cmbunit.Name = "cmbunit";
            this.cmbunit.Size = new System.Drawing.Size(181, 25);
            this.cmbunit.TabIndex = 12;
            this.cmbunit.UseSelectable = true;
            // 
            // damage
            // 
            // 
            // 
            // 
            this.damage.CustomButton.Image = null;
            this.damage.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.damage.CustomButton.Name = "";
            this.damage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.damage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.damage.CustomButton.TabIndex = 1;
            this.damage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.damage.CustomButton.UseSelectable = true;
            this.damage.CustomButton.Visible = false;
            this.damage.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.damage.Lines = new string[0];
            this.damage.Location = new System.Drawing.Point(180, 329);
            this.damage.MaxLength = 32767;
            this.damage.Name = "damage";
            this.damage.PasswordChar = '\0';
            this.damage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.damage.SelectedText = "";
            this.damage.SelectionLength = 0;
            this.damage.SelectionStart = 0;
            this.damage.ShortcutsEnabled = true;
            this.damage.Size = new System.Drawing.Size(181, 23);
            this.damage.TabIndex = 11;
            this.damage.UseSelectable = true;
            this.damage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.damage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // totalpro
            // 
            // 
            // 
            // 
            this.totalpro.CustomButton.Image = null;
            this.totalpro.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.totalpro.CustomButton.Name = "";
            this.totalpro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalpro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalpro.CustomButton.TabIndex = 1;
            this.totalpro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalpro.CustomButton.UseSelectable = true;
            this.totalpro.CustomButton.Visible = false;
            this.totalpro.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.totalpro.Lines = new string[0];
            this.totalpro.Location = new System.Drawing.Point(180, 284);
            this.totalpro.MaxLength = 32767;
            this.totalpro.Name = "totalpro";
            this.totalpro.PasswordChar = '\0';
            this.totalpro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalpro.SelectedText = "";
            this.totalpro.SelectionLength = 0;
            this.totalpro.SelectionStart = 0;
            this.totalpro.ShortcutsEnabled = true;
            this.totalpro.Size = new System.Drawing.Size(181, 23);
            this.totalpro.TabIndex = 10;
            this.totalpro.UseSelectable = true;
            this.totalpro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalpro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // absenceemp
            // 
            // 
            // 
            // 
            this.absenceemp.CustomButton.Image = null;
            this.absenceemp.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.absenceemp.CustomButton.Name = "";
            this.absenceemp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.absenceemp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.absenceemp.CustomButton.TabIndex = 1;
            this.absenceemp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.absenceemp.CustomButton.UseSelectable = true;
            this.absenceemp.CustomButton.Visible = false;
            this.absenceemp.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.absenceemp.Lines = new string[0];
            this.absenceemp.Location = new System.Drawing.Point(180, 235);
            this.absenceemp.MaxLength = 32767;
            this.absenceemp.Name = "absenceemp";
            this.absenceemp.PasswordChar = '\0';
            this.absenceemp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.absenceemp.SelectedText = "";
            this.absenceemp.SelectionLength = 0;
            this.absenceemp.SelectionStart = 0;
            this.absenceemp.ShortcutsEnabled = true;
            this.absenceemp.Size = new System.Drawing.Size(181, 23);
            this.absenceemp.TabIndex = 9;
            this.absenceemp.UseSelectable = true;
            this.absenceemp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.absenceemp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // prsntemp
            // 
            // 
            // 
            // 
            this.prsntemp.CustomButton.Image = null;
            this.prsntemp.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.prsntemp.CustomButton.Name = "";
            this.prsntemp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prsntemp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prsntemp.CustomButton.TabIndex = 1;
            this.prsntemp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prsntemp.CustomButton.UseSelectable = true;
            this.prsntemp.CustomButton.Visible = false;
            this.prsntemp.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.prsntemp.Icon = global::GAD.Properties.Resources.IMG_E7654;
            this.prsntemp.Lines = new string[0];
            this.prsntemp.Location = new System.Drawing.Point(180, 182);
            this.prsntemp.MaxLength = 32767;
            this.prsntemp.Name = "prsntemp";
            this.prsntemp.PasswordChar = '\0';
            this.prsntemp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prsntemp.SelectedText = "";
            this.prsntemp.SelectionLength = 0;
            this.prsntemp.SelectionStart = 0;
            this.prsntemp.ShortcutsEnabled = true;
            this.prsntemp.Size = new System.Drawing.Size(181, 23);
            this.prsntemp.TabIndex = 8;
            this.prsntemp.UseSelectable = true;
            this.prsntemp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prsntemp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // unitempid
            // 
            // 
            // 
            // 
            this.unitempid.CustomButton.Image = null;
            this.unitempid.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.unitempid.CustomButton.Name = "";
            this.unitempid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.unitempid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unitempid.CustomButton.TabIndex = 1;
            this.unitempid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unitempid.CustomButton.UseSelectable = true;
            this.unitempid.CustomButton.Visible = false;
            this.unitempid.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.unitempid.Lines = new string[0];
            this.unitempid.Location = new System.Drawing.Point(180, 132);
            this.unitempid.MaxLength = 32767;
            this.unitempid.Name = "unitempid";
            this.unitempid.PasswordChar = '\0';
            this.unitempid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unitempid.SelectedText = "";
            this.unitempid.SelectionLength = 0;
            this.unitempid.SelectionStart = 0;
            this.unitempid.ShortcutsEnabled = true;
            this.unitempid.Size = new System.Drawing.Size(181, 23);
            this.unitempid.TabIndex = 7;
            this.unitempid.UseSelectable = true;
            this.unitempid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unitempid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnview);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.metroGrid1);
            this.groupBox2.Controls.Add(this.btndltunit);
            this.groupBox2.Controls.Add(this.dltdate);
            this.groupBox2.Controls.Add(this.cmbdlunit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(388, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 424);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete and View Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // btnview
            // 
            this.btnview.BackgroundImage = global::GAD.Properties.Resources.fwwf;
            this.btnview.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnview.Location = new System.Drawing.Point(217, 350);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(99, 53);
            this.btnview.TabIndex = 17;
            this.btnview.Text = "REFRESH";
            this.btnview.UseSelectable = true;
            this.btnview.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unit ";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.supervisoridDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.presentemployeeDataGridViewTextBoxColumn,
            this.absenceemployeeDataGridViewTextBoxColumn,
            this.totalproductioncountDataGridViewTextBoxColumn,
            this.damagecountDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.productionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(6, 121);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(485, 209);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGrid1.TabIndex = 16;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // supervisoridDataGridViewTextBoxColumn
            // 
            this.supervisoridDataGridViewTextBoxColumn.DataPropertyName = "supervisor_id";
            this.supervisoridDataGridViewTextBoxColumn.HeaderText = "supervisor_id";
            this.supervisoridDataGridViewTextBoxColumn.Name = "supervisoridDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // presentemployeeDataGridViewTextBoxColumn
            // 
            this.presentemployeeDataGridViewTextBoxColumn.DataPropertyName = "present_employee";
            this.presentemployeeDataGridViewTextBoxColumn.HeaderText = "present_employee";
            this.presentemployeeDataGridViewTextBoxColumn.Name = "presentemployeeDataGridViewTextBoxColumn";
            // 
            // absenceemployeeDataGridViewTextBoxColumn
            // 
            this.absenceemployeeDataGridViewTextBoxColumn.DataPropertyName = "absence_employee";
            this.absenceemployeeDataGridViewTextBoxColumn.HeaderText = "absence_employee";
            this.absenceemployeeDataGridViewTextBoxColumn.Name = "absenceemployeeDataGridViewTextBoxColumn";
            // 
            // totalproductioncountDataGridViewTextBoxColumn
            // 
            this.totalproductioncountDataGridViewTextBoxColumn.DataPropertyName = "total_production_count";
            this.totalproductioncountDataGridViewTextBoxColumn.HeaderText = "total_production_count";
            this.totalproductioncountDataGridViewTextBoxColumn.Name = "totalproductioncountDataGridViewTextBoxColumn";
            // 
            // damagecountDataGridViewTextBoxColumn
            // 
            this.damagecountDataGridViewTextBoxColumn.DataPropertyName = "damage_count";
            this.damagecountDataGridViewTextBoxColumn.HeaderText = "damage_count";
            this.damagecountDataGridViewTextBoxColumn.Name = "damagecountDataGridViewTextBoxColumn";
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "production";
            this.productionBindingSource.DataSource = this.kARL111DataSet;
            // 
            // kARL111DataSet
            // 
            this.kARL111DataSet.DataSetName = "KARL111DataSet";
            this.kARL111DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndltunit
            // 
            this.btndltunit.BackgroundImage = global::GAD.Properties.Resources.fwwf;
            this.btndltunit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btndltunit.Location = new System.Drawing.Point(361, 40);
            this.btndltunit.Name = "btndltunit";
            this.btndltunit.Size = new System.Drawing.Size(96, 46);
            this.btndltunit.TabIndex = 15;
            this.btndltunit.Text = "DELETE";
            this.btndltunit.UseSelectable = true;
            this.btndltunit.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dltdate
            // 
            this.dltdate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dltdate.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dltdate.Location = new System.Drawing.Point(127, 75);
            this.dltdate.MinimumSize = new System.Drawing.Size(0, 25);
            this.dltdate.Name = "dltdate";
            this.dltdate.Size = new System.Drawing.Size(190, 25);
            this.dltdate.TabIndex = 15;
            // 
            // cmbdlunit
            // 
            this.cmbdlunit.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbdlunit.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cmbdlunit.FormattingEnabled = true;
            this.cmbdlunit.ItemHeight = 19;
            this.cmbdlunit.Items.AddRange(new object[] {
            "Print Unit",
            "Handle Unit",
            "Cutting Unit",
            "Bordering Unit",
            "Tailoring Unit",
            "Complete Unit"});
            this.cmbdlunit.Location = new System.Drawing.Point(127, 23);
            this.cmbdlunit.Name = "cmbdlunit";
            this.cmbdlunit.Size = new System.Drawing.Size(190, 25);
            this.cmbdlunit.TabIndex = 15;
            this.cmbdlunit.UseSelectable = true;
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // supervisoracc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Name = "supervisoracc";
            this.Load += new System.EventHandler(this.supervisoracc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kARL111DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnsvunit;
        private MetroFramework.Controls.MetroDateTime date;
        private MetroFramework.Controls.MetroComboBox cmbunit;
        private MetroFramework.Controls.MetroTextBox damage;
        private MetroFramework.Controls.MetroTextBox totalpro;
        private MetroFramework.Controls.MetroTextBox absenceemp;
        private MetroFramework.Controls.MetroTextBox prsntemp;
        private MetroFramework.Controls.MetroTextBox unitempid;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btndltunit;
        private MetroFramework.Controls.MetroDateTime dltdate;
        private MetroFramework.Controls.MetroComboBox cmbdlunit;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnview;
        private MetroFramework.Controls.MetroButton btnupdate;
        private KARL111DataSet kARL111DataSet;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private KARL111DataSetTableAdapters.productionTableAdapter productionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenceemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalproductioncountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagecountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
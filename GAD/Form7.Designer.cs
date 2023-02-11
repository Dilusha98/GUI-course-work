namespace GAD
{
    partial class cooacc
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
            this.coodate = new MetroFramework.Controls.MetroDateTime();
            this.coounit = new MetroFramework.Controls.MetroComboBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenceemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalproductioncountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagecountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kARL111DataSet1 = new GAD.KARL111DataSet1();
            this.txt35 = new MetroFramework.Controls.MetroTextBox();
            this.txt_34 = new MetroFramework.Controls.MetroTextBox();
            this.txt33 = new MetroFramework.Controls.MetroTextBox();
            this.txt32 = new MetroFramework.Controls.MetroTextBox();
            this.lbl_final_analystic_ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.coomeal = new System.Windows.Forms.Label();
            this.coodamage = new System.Windows.Forms.Label();
            this.cooefficiency = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLink5 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.productionTableAdapter = new GAD.KARL111DataSet1TableAdapters.productionTableAdapter();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kARL111DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // coodate
            // 
            this.coodate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.coodate.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.coodate.Location = new System.Drawing.Point(113, 93);
            this.coodate.MinimumSize = new System.Drawing.Size(0, 25);
            this.coodate.Name = "coodate";
            this.coodate.Size = new System.Drawing.Size(209, 25);
            this.coodate.TabIndex = 3;
            // 
            // coounit
            // 
            this.coounit.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.coounit.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.coounit.FormattingEnabled = true;
            this.coounit.ItemHeight = 19;
            this.coounit.Items.AddRange(new object[] {
            "Print Unit",
            "Handle Unit",
            "Cutting Unit",
            "Bordering Unit",
            "Tailoring Unit",
            "Complete Unit"});
            this.coounit.Location = new System.Drawing.Point(113, 28);
            this.coounit.Name = "coounit";
            this.coounit.Size = new System.Drawing.Size(209, 25);
            this.coounit.TabIndex = 4;
            this.coounit.UseSelectable = true;
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Silver;
            this.gb1.Controls.Add(this.metroGrid1);
            this.gb1.Controls.Add(this.txt35);
            this.gb1.Controls.Add(this.txt_34);
            this.gb1.Controls.Add(this.txt33);
            this.gb1.Controls.Add(this.txt32);
            this.gb1.Controls.Add(this.lbl_final_analystic_);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.coomeal);
            this.gb1.Controls.Add(this.coodamage);
            this.gb1.Controls.Add(this.cooefficiency);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.metroButton1);
            this.gb1.Controls.Add(this.coounit);
            this.gb1.Controls.Add(this.coodate);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(27, 94);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(820, 392);
            this.gb1.TabIndex = 5;
            this.gb1.TabStop = false;
            this.gb1.Text = "Analystics Details of each unit";
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
            this.metroGrid1.Location = new System.Drawing.Point(362, 18);
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
            this.metroGrid1.Size = new System.Drawing.Size(444, 359);
            this.metroGrid1.TabIndex = 29;
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
            this.productionBindingSource.DataSource = this.kARL111DataSet1;
            // 
            // kARL111DataSet1
            // 
            this.kARL111DataSet1.DataSetName = "KARL111DataSet1";
            this.kARL111DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt35
            // 
            // 
            // 
            // 
            this.txt35.CustomButton.Image = null;
            this.txt35.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.txt35.CustomButton.Name = "";
            this.txt35.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt35.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt35.CustomButton.TabIndex = 1;
            this.txt35.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt35.CustomButton.UseSelectable = true;
            this.txt35.CustomButton.Visible = false;
            this.txt35.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt35.Lines = new string[0];
            this.txt35.Location = new System.Drawing.Point(568, 286);
            this.txt35.MaxLength = 32767;
            this.txt35.Name = "txt35";
            this.txt35.PasswordChar = '\0';
            this.txt35.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt35.SelectedText = "";
            this.txt35.SelectionLength = 0;
            this.txt35.SelectionStart = 0;
            this.txt35.ShortcutsEnabled = true;
            this.txt35.Size = new System.Drawing.Size(50, 23);
            this.txt35.TabIndex = 27;
            this.txt35.UseSelectable = true;
            this.txt35.Visible = false;
            this.txt35.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt35.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_34
            // 
            // 
            // 
            // 
            this.txt_34.CustomButton.Image = null;
            this.txt_34.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.txt_34.CustomButton.Name = "";
            this.txt_34.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_34.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_34.CustomButton.TabIndex = 1;
            this.txt_34.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_34.CustomButton.UseSelectable = true;
            this.txt_34.CustomButton.Visible = false;
            this.txt_34.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_34.Lines = new string[0];
            this.txt_34.Location = new System.Drawing.Point(646, 331);
            this.txt_34.MaxLength = 32767;
            this.txt_34.Name = "txt_34";
            this.txt_34.PasswordChar = '\0';
            this.txt_34.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_34.SelectedText = "";
            this.txt_34.SelectionLength = 0;
            this.txt_34.SelectionStart = 0;
            this.txt_34.ShortcutsEnabled = true;
            this.txt_34.Size = new System.Drawing.Size(50, 23);
            this.txt_34.TabIndex = 26;
            this.txt_34.UseSelectable = true;
            this.txt_34.Visible = false;
            this.txt_34.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_34.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt33
            // 
            // 
            // 
            // 
            this.txt33.CustomButton.Image = null;
            this.txt33.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.txt33.CustomButton.Name = "";
            this.txt33.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt33.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt33.CustomButton.TabIndex = 1;
            this.txt33.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt33.CustomButton.UseSelectable = true;
            this.txt33.CustomButton.Visible = false;
            this.txt33.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt33.Lines = new string[0];
            this.txt33.Location = new System.Drawing.Point(646, 286);
            this.txt33.MaxLength = 32767;
            this.txt33.Name = "txt33";
            this.txt33.PasswordChar = '\0';
            this.txt33.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt33.SelectedText = "";
            this.txt33.SelectionLength = 0;
            this.txt33.SelectionStart = 0;
            this.txt33.ShortcutsEnabled = true;
            this.txt33.Size = new System.Drawing.Size(50, 23);
            this.txt33.TabIndex = 25;
            this.txt33.UseSelectable = true;
            this.txt33.Visible = false;
            this.txt33.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt33.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt32
            // 
            // 
            // 
            // 
            this.txt32.CustomButton.Image = null;
            this.txt32.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.txt32.CustomButton.Name = "";
            this.txt32.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt32.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt32.CustomButton.TabIndex = 1;
            this.txt32.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt32.CustomButton.UseSelectable = true;
            this.txt32.CustomButton.Visible = false;
            this.txt32.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt32.Lines = new string[0];
            this.txt32.Location = new System.Drawing.Point(646, 241);
            this.txt32.MaxLength = 32767;
            this.txt32.Name = "txt32";
            this.txt32.PasswordChar = '\0';
            this.txt32.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt32.SelectedText = "";
            this.txt32.SelectionLength = 0;
            this.txt32.SelectionStart = 0;
            this.txt32.ShortcutsEnabled = true;
            this.txt32.Size = new System.Drawing.Size(50, 23);
            this.txt32.TabIndex = 24;
            this.txt32.UseSelectable = true;
            this.txt32.Visible = false;
            this.txt32.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt32.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_final_analystic_
            // 
            this.lbl_final_analystic_.AutoSize = true;
            this.lbl_final_analystic_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_final_analystic_.Location = new System.Drawing.Point(209, 283);
            this.lbl_final_analystic_.Name = "lbl_final_analystic_";
            this.lbl_final_analystic_.Size = new System.Drawing.Size(0, 16);
            this.lbl_final_analystic_.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Final Status :";
            // 
            // coomeal
            // 
            this.coomeal.AutoSize = true;
            this.coomeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coomeal.Location = new System.Drawing.Point(209, 151);
            this.coomeal.Name = "coomeal";
            this.coomeal.Size = new System.Drawing.Size(0, 16);
            this.coomeal.TabIndex = 21;
            // 
            // coodamage
            // 
            this.coodamage.AutoSize = true;
            this.coodamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coodamage.Location = new System.Drawing.Point(209, 248);
            this.coodamage.Name = "coodamage";
            this.coodamage.Size = new System.Drawing.Size(0, 16);
            this.coodamage.TabIndex = 20;
            // 
            // cooefficiency
            // 
            this.cooefficiency.AutoSize = true;
            this.cooefficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cooefficiency.Location = new System.Drawing.Point(209, 197);
            this.cooefficiency.Name = "cooefficiency";
            this.cooefficiency.Size = new System.Drawing.Size(0, 16);
            this.cooefficiency.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Damage percentag :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Production Efficiency  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Meal Expences :         RS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unit";
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::GAD.Properties.Resources.fwwf;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(23, 330);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(299, 47);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "SHOW";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLink5
            // 
            this.metroLink5.BackgroundImage = global::GAD.Properties.Resources.icons8_administrator_male_96;
            this.metroLink5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink5.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink5.Location = new System.Drawing.Point(779, 21);
            this.metroLink5.Name = "metroLink5";
            this.metroLink5.Size = new System.Drawing.Size(74, 73);
            this.metroLink5.TabIndex = 6;
            this.metroLink5.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = global::GAD.Properties.Resources.icons8_back_128;
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.Location = new System.Drawing.Point(9, 12);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(30, 26);
            this.metroLink1.TabIndex = 1;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // cooacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 497);
            this.Controls.Add(this.metroLink5);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.metroLink1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "cooacc";
            this.Load += new System.EventHandler(this.cooacc_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kARL111DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroDateTime coodate;
        private MetroFramework.Controls.MetroComboBox coounit;
        private System.Windows.Forms.GroupBox gb1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coomeal;
        private System.Windows.Forms.Label coodamage;
        private System.Windows.Forms.Label cooefficiency;
        private MetroFramework.Controls.MetroLink metroLink5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_final_analystic_;
        private MetroFramework.Controls.MetroTextBox txt35;
        private MetroFramework.Controls.MetroTextBox txt_34;
        private MetroFramework.Controls.MetroTextBox txt33;
        private MetroFramework.Controls.MetroTextBox txt32;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private KARL111DataSet1 kARL111DataSet1;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private KARL111DataSet1TableAdapters.productionTableAdapter productionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenceemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalproductioncountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagecountDataGridViewTextBoxColumn;
    }
}
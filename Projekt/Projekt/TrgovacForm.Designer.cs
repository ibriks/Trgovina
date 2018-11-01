namespace Projekt
{
    partial class TrgovacForm
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
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new Projekt.shopDataSet();
            this.artiklTableAdapter = new Projekt.shopDataSetTableAdapters.ArtiklTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.izdajRacun = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artiklIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.KodTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Proizvod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Popust = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Porez = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Količina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cijena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokTrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.količinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Projekt.Properties.Resources.back;
            this.tabPage2.Controls.Add(this.izdajRacun);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.KodTextBox);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 337);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Izdavanje racuna";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // izdajRacun
            // 
            this.izdajRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.izdajRacun.BackColor = System.Drawing.Color.MidnightBlue;
            this.izdajRacun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.izdajRacun.Location = new System.Drawing.Point(597, 283);
            this.izdajRacun.Name = "izdajRacun";
            this.izdajRacun.Size = new System.Drawing.Size(75, 23);
            this.izdajRacun.TabIndex = 11;
            this.izdajRacun.Text = "Izdaj račun";
            this.izdajRacun.UseVisualStyleBackColor = false;
            this.izdajRacun.Click += new System.EventHandler(this.izdajRacun_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gotovina",
            "Kartice",
            "Čekovi",
            "Bonovi"});
            this.comboBox1.Location = new System.Drawing.Point(108, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(20, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Način plaćanja:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(505, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(369, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ukupan iznos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(72, 207);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Količina";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(10, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artiklIdDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.artiklBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(299, 156);
            this.dataGridView1.TabIndex = 3;
            // 
            // artiklIdDataGridViewTextBoxColumn
            // 
            this.artiklIdDataGridViewTextBoxColumn.DataPropertyName = "Artikl_Id";
            this.artiklIdDataGridViewTextBoxColumn.HeaderText = "Artikl_Id";
            this.artiklIdDataGridViewTextBoxColumn.Name = "artiklIdDataGridViewTextBoxColumn";
            this.artiklIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.artiklIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDataGridViewTextBoxColumn.Width = 50;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kod proizvoda";
            // 
            // KodTextBox
            // 
            this.KodTextBox.Location = new System.Drawing.Point(113, 7);
            this.KodTextBox.Name = "KodTextBox";
            this.KodTextBox.Size = new System.Drawing.Size(100, 20);
            this.KodTextBox.TabIndex = 1;
            this.KodTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Proizvod,
            this.Kod,
            this.Popust,
            this.Porez,
            this.Količina,
            this.Cijena});
            this.listView1.Location = new System.Drawing.Point(337, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(337, 263);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Proizvod
            // 
            this.Proizvod.Text = "Proizvod";
            // 
            // Kod
            // 
            this.Kod.Text = "Kod";
            // 
            // Popust
            // 
            this.Popust.Text = "Popust";
            // 
            // Porez
            // 
            this.Porez.Text = "Porez";
            this.Porez.Width = 58;
            // 
            // Količina
            // 
            this.Količina.Text = "Količina";
            // 
            // Cijena
            // 
            this.Cijena.Text = "Cijena";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 363);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackgroundImage = global::Projekt.Properties.Resources.back;
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.TextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 337);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Traženje artikla";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(211, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Traženje artikla po nazivu";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(6, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Traženje artikla po kodu";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.rokTrajanjaDataGridViewTextBoxColumn,
            this.količinaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.artiklBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(697, 252);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Artikl_Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Artikl_Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn8.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Kod";
            this.dataGridViewTextBoxColumn9.HeaderText = "Kod";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cijena";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cijena";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // rokTrajanjaDataGridViewTextBoxColumn
            // 
            this.rokTrajanjaDataGridViewTextBoxColumn.DataPropertyName = "Rok_Trajanja";
            this.rokTrajanjaDataGridViewTextBoxColumn.HeaderText = "Rok_Trajanja";
            this.rokTrajanjaDataGridViewTextBoxColumn.Name = "rokTrajanjaDataGridViewTextBoxColumn";
            this.rokTrajanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // količinaDataGridViewTextBoxColumn
            // 
            this.količinaDataGridViewTextBoxColumn.DataPropertyName = "Količina";
            this.količinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.količinaDataGridViewTextBoxColumn.Name = "količinaDataGridViewTextBoxColumn";
            this.količinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(6, 39);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(522, 20);
            this.TextBox1.TabIndex = 6;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Projekt.Properties.Resources.back;
            this.tabPage3.Controls.Add(this.radioButton3);
            this.tabPage3.Controls.Add(this.radioButton4);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(709, 337);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Provjera roka trajanja i količine";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(211, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(139, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Prozvodi kojih je manjak";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton4.Location = new System.Drawing.Point(6, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(183, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "Proizvodi kojima ističe rok trajanja";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.DataSource = this.artiklBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 52);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(697, 190);
            this.dataGridView3.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Artikl_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Artikl_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kod";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kod";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cijena";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cijena";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Rok_Trajanja";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rok_Trajanja";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Količina";
            this.dataGridViewTextBoxColumn6.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // TrgovacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 387);
            this.Controls.Add(this.tabControl1);
            this.Name = "TrgovacForm";
            this.Text = "TrgovacForm";
            this.Load += new System.EventHandler(this.TrgovacForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private shopDataSetTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button izdajRacun;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KodTextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Proizvod;
        private System.Windows.Forms.ColumnHeader Kod;
        private System.Windows.Forms.ColumnHeader Popust;
        private System.Windows.Forms.ColumnHeader Porez;
        private System.Windows.Forms.ColumnHeader Količina;
        private System.Windows.Forms.ColumnHeader Cijena;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokTrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn količinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TextBox1;
    }
}
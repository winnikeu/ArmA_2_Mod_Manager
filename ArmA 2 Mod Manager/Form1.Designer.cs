namespace ArmA_2_Mod_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bttDelete = new System.Windows.Forms.Button();
            this.lvConfigurations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbSkipIntro = new System.Windows.Forms.CheckBox();
            this.chbWorldEmpty = new System.Windows.Forms.CheckBox();
            this.chbNoSplash = new System.Windows.Forms.CheckBox();
            this.chbBetaPatch = new System.Windows.Forms.CheckBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.bttRun = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.chbPort = new System.Windows.Forms.CheckBox();
            this.chbServer = new System.Windows.Forms.CheckBox();
            this.chbWindowed = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lbMods = new System.Windows.Forms.ListBox();
            this.lblInstalled = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAdditional = new System.Windows.Forms.TextBox();
            this.lblAdditional = new System.Windows.Forms.Label();
            this.lblParam = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblWinXp = new System.Windows.Forms.Label();
            this.chbWinXp = new System.Windows.Forms.CheckBox();
            this.cbExThreads = new System.Windows.Forms.ComboBox();
            this.chbExThreads = new System.Windows.Forms.CheckBox();
            this.lblExThreads = new System.Windows.Forms.Label();
            this.cbMaxVRAM = new System.Windows.Forms.ComboBox();
            this.chbMaxVRAM = new System.Windows.Forms.CheckBox();
            this.lblMaxVRAM = new System.Windows.Forms.Label();
            this.cbMaxMem = new System.Windows.Forms.ComboBox();
            this.chbMaxMem = new System.Windows.Forms.CheckBox();
            this.lblMaxMem = new System.Windows.Forms.Label();
            this.lblCpuCount = new System.Windows.Forms.Label();
            this.cbCpuCount = new System.Windows.Forms.ComboBox();
            this.chbCpuCount = new System.Windows.Forms.CheckBox();
            this.bttSave = new System.Windows.Forms.Button();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.bttPath = new System.Windows.Forms.Button();
            this.lblPath2OA = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.threadIp = new System.ComponentModel.BackgroundWorker();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(276, 315);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.bttDelete);
            this.tabPage1.Controls.Add(this.lvConfigurations);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pbStart);
            this.tabPage1.Controls.Add(this.bttRun);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pobieram";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pobrano: 0 z 14.";
            this.label1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 33);
            this.progressBar1.Maximum = 14;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 27);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(199, 217);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(63, 25);
            this.bttDelete.TabIndex = 6;
            this.bttDelete.Text = "Usuń";
            this.toolTip1.SetToolTip(this.bttDelete, "Usuwa wybraną konfigurację.");
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.button5_Click);
            // 
            // lvConfigurations
            // 
            this.lvConfigurations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvConfigurations.FullRowSelect = true;
            this.lvConfigurations.Location = new System.Drawing.Point(6, 66);
            this.lvConfigurations.MultiSelect = false;
            this.lvConfigurations.Name = "lvConfigurations";
            this.lvConfigurations.Size = new System.Drawing.Size(256, 145);
            this.lvConfigurations.TabIndex = 5;
            this.toolTip1.SetToolTip(this.lvConfigurations, "Lista zapisanych konfiguracji. Kliknij by uruchomić.");
            this.lvConfigurations.UseCompatibleStateImageBehavior = false;
            this.lvConfigurations.View = System.Windows.Forms.View.Details;
            this.lvConfigurations.DoubleClick += new System.EventHandler(this.lvConfigurations_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Parametry";
            this.columnHeader2.Width = 404;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbSkipIntro);
            this.groupBox1.Controls.Add(this.chbWorldEmpty);
            this.groupBox1.Controls.Add(this.chbNoSplash);
            this.groupBox1.Controls.Add(this.chbBetaPatch);
            this.groupBox1.Location = new System.Drawing.Point(6, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry:";
            // 
            // chbSkipIntro
            // 
            this.chbSkipIntro.AutoSize = true;
            this.chbSkipIntro.Checked = true;
            this.chbSkipIntro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSkipIntro.Location = new System.Drawing.Point(100, 19);
            this.chbSkipIntro.Name = "chbSkipIntro";
            this.chbSkipIntro.Size = new System.Drawing.Size(69, 17);
            this.chbSkipIntro.TabIndex = 5;
            this.chbSkipIntro.Text = "-skipIntro";
            this.toolTip1.SetToolTip(this.chbSkipIntro, "Pomija intro gry.");
            this.chbSkipIntro.UseVisualStyleBackColor = true;
            // 
            // chbWorldEmpty
            // 
            this.chbWorldEmpty.AutoSize = true;
            this.chbWorldEmpty.Checked = true;
            this.chbWorldEmpty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbWorldEmpty.Location = new System.Drawing.Point(6, 42);
            this.chbWorldEmpty.Name = "chbWorldEmpty";
            this.chbWorldEmpty.Size = new System.Drawing.Size(88, 17);
            this.chbWorldEmpty.TabIndex = 4;
            this.chbWorldEmpty.Text = "-world=empty";
            this.toolTip1.SetToolTip(this.chbWorldEmpty, "Wczytuje grę z pustym światem.");
            this.chbWorldEmpty.UseVisualStyleBackColor = true;
            // 
            // chbNoSplash
            // 
            this.chbNoSplash.AutoSize = true;
            this.chbNoSplash.Checked = true;
            this.chbNoSplash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNoSplash.Location = new System.Drawing.Point(6, 19);
            this.chbNoSplash.Name = "chbNoSplash";
            this.chbNoSplash.Size = new System.Drawing.Size(73, 17);
            this.chbNoSplash.TabIndex = 3;
            this.chbNoSplash.Text = "-noSplash";
            this.toolTip1.SetToolTip(this.chbNoSplash, "Wyłącza splash screeny?");
            this.chbNoSplash.UseVisualStyleBackColor = true;
            // 
            // chbBetaPatch
            // 
            this.chbBetaPatch.AutoSize = true;
            this.chbBetaPatch.Checked = true;
            this.chbBetaPatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBetaPatch.Location = new System.Drawing.Point(100, 42);
            this.chbBetaPatch.Name = "chbBetaPatch";
            this.chbBetaPatch.Size = new System.Drawing.Size(79, 17);
            this.chbBetaPatch.TabIndex = 2;
            this.chbBetaPatch.Text = "Beta Patch";
            this.toolTip1.SetToolTip(this.chbBetaPatch, "Uruchamia grę z Beta Patchem (jeśli zainstalowany).");
            this.chbBetaPatch.UseVisualStyleBackColor = true;
            // 
            // pbStart
            // 
            this.pbStart.Location = new System.Drawing.Point(6, 6);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(256, 54);
            this.pbStart.TabIndex = 4;
            this.pbStart.TabStop = false;
            this.toolTip1.SetToolTip(this.pbStart, "DayZ Info - www.dayzinfo.pl");
            // 
            // bttRun
            // 
            this.bttRun.Location = new System.Drawing.Point(199, 248);
            this.bttRun.Name = "bttRun";
            this.bttRun.Size = new System.Drawing.Size(63, 35);
            this.bttRun.TabIndex = 1;
            this.bttRun.Text = "Uruchom!";
            this.toolTip1.SetToolTip(this.bttRun, "Uruchamia grę z daną konfiguracją.");
            this.bttRun.UseVisualStyleBackColor = true;
            this.bttRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPort);
            this.tabPage2.Controls.Add(this.txtServer);
            this.tabPage2.Controls.Add(this.chbPort);
            this.tabPage2.Controls.Add(this.chbServer);
            this.tabPage2.Controls.Add(this.chbWindowed);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.lbMods);
            this.tabPage2.Controls.Add(this.lblInstalled);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtAdditional);
            this.tabPage2.Controls.Add(this.lblAdditional);
            this.tabPage2.Controls.Add(this.lblParam);
            this.tabPage2.Controls.Add(this.txtParam);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(268, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mody";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(118, 199);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 18;
            // 
            // txtServer
            // 
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(118, 150);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 17;
            // 
            // chbPort
            // 
            this.chbPort.AutoSize = true;
            this.chbPort.Location = new System.Drawing.Point(118, 176);
            this.chbPort.Name = "chbPort";
            this.chbPort.Size = new System.Drawing.Size(45, 17);
            this.chbPort.TabIndex = 16;
            this.chbPort.Text = "Port";
            this.chbPort.UseVisualStyleBackColor = true;
            this.chbPort.CheckedChanged += new System.EventHandler(this.chbPort_CheckedChanged);
            // 
            // chbServer
            // 
            this.chbServer.AutoSize = true;
            this.chbServer.Location = new System.Drawing.Point(118, 127);
            this.chbServer.Name = "chbServer";
            this.chbServer.Size = new System.Drawing.Size(75, 17);
            this.chbServer.TabIndex = 15;
            this.chbServer.Text = "Serwer IP:";
            this.chbServer.UseVisualStyleBackColor = true;
            this.chbServer.CheckedChanged += new System.EventHandler(this.chbServer_CheckedChanged);
            // 
            // chbWindowed
            // 
            this.chbWindowed.AutoSize = true;
            this.chbWindowed.Location = new System.Drawing.Point(118, 104);
            this.chbWindowed.Name = "chbWindowed";
            this.chbWindowed.Size = new System.Drawing.Size(109, 17);
            this.chbWindowed.TabIndex = 14;
            this.chbWindowed.Text = "Uruchom w oknie";
            this.chbWindowed.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Odznacz";
            this.toolTip1.SetToolTip(this.button4, "Odznacza aktualnie zaznaczone mody.");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbMods
            // 
            this.lbMods.FormattingEnabled = true;
            this.lbMods.Location = new System.Drawing.Point(3, 29);
            this.lbMods.Name = "lbMods";
            this.lbMods.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMods.Size = new System.Drawing.Size(109, 212);
            this.lbMods.TabIndex = 12;
            this.toolTip1.SetToolTip(this.lbMods, "Okno wyboru zainstalowanych modów.");
            this.lbMods.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // lblInstalled
            // 
            this.lblInstalled.AutoSize = true;
            this.lblInstalled.Location = new System.Drawing.Point(6, 11);
            this.lblInstalled.Name = "lblInstalled";
            this.lblInstalled.Size = new System.Drawing.Size(79, 13);
            this.lblInstalled.TabIndex = 11;
            this.lblInstalled.Text = "Zainstalowane:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Zapisz";
            this.toolTip1.SetToolTip(this.button2, "Zapisuje konfigurację by później z niej skorzystać.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAdditional
            // 
            this.txtAdditional.Location = new System.Drawing.Point(118, 66);
            this.txtAdditional.Multiline = true;
            this.txtAdditional.Name = "txtAdditional";
            this.txtAdditional.Size = new System.Drawing.Size(144, 32);
            this.txtAdditional.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtAdditional, "Twoje dodatkowe polecenia bądź mody, których nie widać w okienku po lewej.");
            // 
            // lblAdditional
            // 
            this.lblAdditional.AutoSize = true;
            this.lblAdditional.Location = new System.Drawing.Point(115, 50);
            this.lblAdditional.Name = "lblAdditional";
            this.lblAdditional.Size = new System.Drawing.Size(65, 13);
            this.lblAdditional.TabIndex = 7;
            this.lblAdditional.Text = "Dodatkowe:";
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(3, 244);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(57, 13);
            this.lblParam.TabIndex = 4;
            this.lblParam.Text = "Parametry:";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(3, 263);
            this.txtParam.Name = "txtParam";
            this.txtParam.ReadOnly = true;
            this.txtParam.Size = new System.Drawing.Size(259, 20);
            this.txtParam.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtParam, "Wyświetla aktualną linię modów.");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(115, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nazwa:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtName, "Nazwa jaką będziesz widział w oknie Start.");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblWinXp);
            this.tabPage3.Controls.Add(this.chbWinXp);
            this.tabPage3.Controls.Add(this.cbExThreads);
            this.tabPage3.Controls.Add(this.chbExThreads);
            this.tabPage3.Controls.Add(this.lblExThreads);
            this.tabPage3.Controls.Add(this.cbMaxVRAM);
            this.tabPage3.Controls.Add(this.chbMaxVRAM);
            this.tabPage3.Controls.Add(this.lblMaxVRAM);
            this.tabPage3.Controls.Add(this.cbMaxMem);
            this.tabPage3.Controls.Add(this.chbMaxMem);
            this.tabPage3.Controls.Add(this.lblMaxMem);
            this.tabPage3.Controls.Add(this.lblCpuCount);
            this.tabPage3.Controls.Add(this.cbCpuCount);
            this.tabPage3.Controls.Add(this.chbCpuCount);
            this.tabPage3.Controls.Add(this.bttSave);
            this.tabPage3.Controls.Add(this.pbSettings);
            this.tabPage3.Controls.Add(this.bttPath);
            this.tabPage3.Controls.Add(this.lblPath2OA);
            this.tabPage3.Controls.Add(this.txtPath);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(268, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ustawienia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblWinXp
            // 
            this.lblWinXp.AutoSize = true;
            this.lblWinXp.Location = new System.Drawing.Point(6, 185);
            this.lblWinXp.Name = "lblWinXp";
            this.lblWinXp.Size = new System.Drawing.Size(48, 13);
            this.lblWinXp.TabIndex = 20;
            this.lblWinXp.Text = "Tryb XP:";
            // 
            // chbWinXp
            // 
            this.chbWinXp.AutoSize = true;
            this.chbWinXp.Location = new System.Drawing.Point(91, 184);
            this.chbWinXp.Name = "chbWinXp";
            this.chbWinXp.Size = new System.Drawing.Size(76, 17);
            this.chbWinXp.TabIndex = 19;
            this.chbWinXp.Text = "Włączone";
            this.chbWinXp.UseVisualStyleBackColor = true;
            // 
            // cbExThreads
            // 
            this.cbExThreads.Enabled = false;
            this.cbExThreads.FormattingEnabled = true;
            this.cbExThreads.Items.AddRange(new object[] {
            "0",
            "1",
            "3",
            "5",
            "7"});
            this.cbExThreads.Location = new System.Drawing.Point(173, 147);
            this.cbExThreads.Name = "cbExThreads";
            this.cbExThreads.Size = new System.Drawing.Size(49, 21);
            this.cbExThreads.TabIndex = 18;
            this.cbExThreads.Text = "0";
            this.cbExThreads.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbExThreads_KeyPress);
            // 
            // chbExThreads
            // 
            this.chbExThreads.AutoSize = true;
            this.chbExThreads.Location = new System.Drawing.Point(91, 149);
            this.chbExThreads.Name = "chbExThreads";
            this.chbExThreads.Size = new System.Drawing.Size(76, 17);
            this.chbExThreads.TabIndex = 17;
            this.chbExThreads.Text = "Włączone";
            this.chbExThreads.UseVisualStyleBackColor = true;
            this.chbExThreads.CheckedChanged += new System.EventHandler(this.chbExThreads_CheckedChanged);
            // 
            // lblExThreads
            // 
            this.lblExThreads.AutoSize = true;
            this.lblExThreads.Location = new System.Drawing.Point(6, 150);
            this.lblExThreads.Name = "lblExThreads";
            this.lblExThreads.Size = new System.Drawing.Size(61, 13);
            this.lblExThreads.TabIndex = 16;
            this.lblExThreads.Text = "ExThreads:";
            // 
            // cbMaxVRAM
            // 
            this.cbMaxVRAM.Enabled = false;
            this.cbMaxVRAM.FormattingEnabled = true;
            this.cbMaxVRAM.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "768",
            "1024",
            "1536",
            "2047"});
            this.cbMaxVRAM.Location = new System.Drawing.Point(173, 112);
            this.cbMaxVRAM.Name = "cbMaxVRAM";
            this.cbMaxVRAM.Size = new System.Drawing.Size(49, 21);
            this.cbMaxVRAM.TabIndex = 15;
            this.cbMaxVRAM.Text = "0";
            // 
            // chbMaxVRAM
            // 
            this.chbMaxVRAM.AutoSize = true;
            this.chbMaxVRAM.Location = new System.Drawing.Point(91, 114);
            this.chbMaxVRAM.Name = "chbMaxVRAM";
            this.chbMaxVRAM.Size = new System.Drawing.Size(76, 17);
            this.chbMaxVRAM.TabIndex = 14;
            this.chbMaxVRAM.Text = "Włączone";
            this.chbMaxVRAM.UseVisualStyleBackColor = true;
            this.chbMaxVRAM.CheckedChanged += new System.EventHandler(this.chbMaxVRAM_CheckedChanged);
            // 
            // lblMaxVRAM
            // 
            this.lblMaxVRAM.AutoSize = true;
            this.lblMaxVRAM.Location = new System.Drawing.Point(6, 115);
            this.lblMaxVRAM.Name = "lblMaxVRAM";
            this.lblMaxVRAM.Size = new System.Drawing.Size(79, 13);
            this.lblMaxVRAM.TabIndex = 13;
            this.lblMaxVRAM.Text = "Pamięć VRAM:";
            // 
            // cbMaxMem
            // 
            this.cbMaxMem.Enabled = false;
            this.cbMaxMem.FormattingEnabled = true;
            this.cbMaxMem.Items.AddRange(new object[] {
            "256",
            "512",
            "768",
            "1024",
            "1536",
            "2047"});
            this.cbMaxMem.Location = new System.Drawing.Point(173, 77);
            this.cbMaxMem.Name = "cbMaxMem";
            this.cbMaxMem.Size = new System.Drawing.Size(49, 21);
            this.cbMaxMem.TabIndex = 12;
            this.cbMaxMem.Text = "0";
            // 
            // chbMaxMem
            // 
            this.chbMaxMem.AutoSize = true;
            this.chbMaxMem.Location = new System.Drawing.Point(91, 79);
            this.chbMaxMem.Name = "chbMaxMem";
            this.chbMaxMem.Size = new System.Drawing.Size(76, 17);
            this.chbMaxMem.TabIndex = 11;
            this.chbMaxMem.Text = "Włączone";
            this.chbMaxMem.UseVisualStyleBackColor = true;
            this.chbMaxMem.CheckedChanged += new System.EventHandler(this.chbMaxMem_CheckedChanged);
            // 
            // lblMaxMem
            // 
            this.lblMaxMem.AutoSize = true;
            this.lblMaxMem.Location = new System.Drawing.Point(6, 80);
            this.lblMaxMem.Name = "lblMaxMem";
            this.lblMaxMem.Size = new System.Drawing.Size(72, 13);
            this.lblMaxMem.TabIndex = 10;
            this.lblMaxMem.Text = "Pamięć RAM:";
            // 
            // lblCpuCount
            // 
            this.lblCpuCount.AutoSize = true;
            this.lblCpuCount.Location = new System.Drawing.Point(6, 45);
            this.lblCpuCount.Name = "lblCpuCount";
            this.lblCpuCount.Size = new System.Drawing.Size(63, 13);
            this.lblCpuCount.TabIndex = 9;
            this.lblCpuCount.Text = "Ilość rdzeni:";
            // 
            // cbCpuCount
            // 
            this.cbCpuCount.Enabled = false;
            this.cbCpuCount.FormattingEnabled = true;
            this.cbCpuCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbCpuCount.Location = new System.Drawing.Point(173, 42);
            this.cbCpuCount.Name = "cbCpuCount";
            this.cbCpuCount.Size = new System.Drawing.Size(49, 21);
            this.cbCpuCount.TabIndex = 8;
            this.cbCpuCount.Text = "0";
            this.cbCpuCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCpuCount_KeyPress);
            // 
            // chbCpuCount
            // 
            this.chbCpuCount.AutoSize = true;
            this.chbCpuCount.Location = new System.Drawing.Point(91, 44);
            this.chbCpuCount.Name = "chbCpuCount";
            this.chbCpuCount.Size = new System.Drawing.Size(76, 17);
            this.chbCpuCount.TabIndex = 7;
            this.chbCpuCount.Text = "Włączone";
            this.chbCpuCount.UseVisualStyleBackColor = true;
            this.chbCpuCount.CheckedChanged += new System.EventHandler(this.chbCpuCount_CheckedChanged);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(190, 200);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 6;
            this.bttSave.Text = "Zapisz";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // pbSettings
            // 
            this.pbSettings.Location = new System.Drawing.Point(6, 229);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(256, 54);
            this.pbSettings.TabIndex = 5;
            this.pbSettings.TabStop = false;
            this.toolTip1.SetToolTip(this.pbSettings, "DayZ Info - www.dayzinfo.pl");
            // 
            // bttPath
            // 
            this.bttPath.Location = new System.Drawing.Point(237, 4);
            this.bttPath.Name = "bttPath";
            this.bttPath.Size = new System.Drawing.Size(25, 23);
            this.bttPath.TabIndex = 2;
            this.bttPath.Text = "...";
            this.toolTip1.SetToolTip(this.bttPath, "Pokazuje okienko wyboru ścieżki do gry.");
            this.bttPath.UseVisualStyleBackColor = true;
            this.bttPath.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // lblPath2OA
            // 
            this.lblPath2OA.AutoSize = true;
            this.lblPath2OA.Location = new System.Drawing.Point(6, 9);
            this.lblPath2OA.Name = "lblPath2OA";
            this.lblPath2OA.Size = new System.Drawing.Size(62, 13);
            this.lblPath2OA.TabIndex = 1;
            this.lblPath2OA.Text = "ArmA 2 OA:";
            this.toolTip1.SetToolTip(this.lblPath2OA, "Ścieżka FOLDERU z grą ArmA 2: Operation Arrowhead");
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(91, 6);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(140, 20);
            this.txtPath.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtPath, "Podaj ścieżkę do folderu ze swoja grą ArmA 2 Operation Arrowhead -->");
            // 
            // threadIp
            // 
            this.threadIp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadIp_DoWork);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(156, 8);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(57, 13);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "UPDATE?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 321);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblPath2OA;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chbBetaPatch;
        private System.Windows.Forms.Button bttRun;
        private System.Windows.Forms.TextBox txtAdditional;
        private System.Windows.Forms.Label lblAdditional;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbSkipIntro;
        private System.Windows.Forms.CheckBox chbWorldEmpty;
        private System.Windows.Forms.CheckBox chbNoSplash;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.Button bttPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.ListView lvConfigurations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblInstalled;
        private System.Windows.Forms.ListBox lbMods;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chbWindowed;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.ComboBox cbCpuCount;
        private System.Windows.Forms.CheckBox chbCpuCount;
        private System.Windows.Forms.Label lblCpuCount;
        private System.Windows.Forms.ComboBox cbMaxMem;
        private System.Windows.Forms.CheckBox chbMaxMem;
        private System.Windows.Forms.Label lblMaxMem;
        private System.Windows.Forms.ComboBox cbMaxVRAM;
        private System.Windows.Forms.CheckBox chbMaxVRAM;
        private System.Windows.Forms.Label lblMaxVRAM;
        private System.Windows.Forms.ComboBox cbExThreads;
        private System.Windows.Forms.CheckBox chbExThreads;
        private System.Windows.Forms.Label lblExThreads;
        private System.Windows.Forms.Label lblWinXp;
        private System.Windows.Forms.CheckBox chbWinXp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.CheckBox chbPort;
        private System.Windows.Forms.CheckBox chbServer;
        private System.ComponentModel.BackgroundWorker threadIp;
        private System.Windows.Forms.Label lblUpdate;
    }
}


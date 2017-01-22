namespace MangaTool
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
            this.tabManga = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddSetting = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtTagCon = new System.Windows.Forms.TextBox();
            this.txtTagCha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbInfomation = new System.Windows.Forms.ComboBox();
            this.Imfomation = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkCheck2 = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddSetting2 = new System.Windows.Forms.Button();
            this.txtIndex2 = new System.Windows.Forms.TextBox();
            this.txtTagCon2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTagCha2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbInfomation2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infomationMangaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterMangaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabManga.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infomationMangaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterMangaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManga
            // 
            this.tabManga.Controls.Add(this.tabPage1);
            this.tabManga.Controls.Add(this.tabPage2);
            this.tabManga.Controls.Add(this.tabPage3);
            this.tabManga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManga.Location = new System.Drawing.Point(0, 0);
            this.tabManga.Name = "tabManga";
            this.tabManga.SelectedIndex = 0;
            this.tabManga.Size = new System.Drawing.Size(711, 435);
            this.tabManga.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnAddSetting);
            this.tabPage1.Controls.Add(this.txtIndex);
            this.tabPage1.Controls.Add(this.txtTagCon);
            this.tabPage1.Controls.Add(this.txtTagCha);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbbInfomation);
            this.tabPage1.Controls.Add(this.Imfomation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Step 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAction,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView1.DataSource = this.infomationMangaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 284);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.Text = "Delete";
            this.colAction.UseColumnTextForButtonValue = true;
            // 
            // btnAddSetting
            // 
            this.btnAddSetting.Location = new System.Drawing.Point(72, 90);
            this.btnAddSetting.Name = "btnAddSetting";
            this.btnAddSetting.Size = new System.Drawing.Size(268, 23);
            this.btnAddSetting.TabIndex = 6;
            this.btnAddSetting.Text = "Add Setting";
            this.btnAddSetting.UseVisualStyleBackColor = true;
            this.btnAddSetting.Click += new System.EventHandler(this.btnAddSetting_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(294, 64);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(74, 20);
            this.txtIndex.TabIndex = 5;
            this.txtIndex.Text = "0";
            // 
            // txtTagCon
            // 
            this.txtTagCon.Location = new System.Drawing.Point(157, 64);
            this.txtTagCon.Name = "txtTagCon";
            this.txtTagCon.Size = new System.Drawing.Size(92, 20);
            this.txtTagCon.TabIndex = 4;
            this.txtTagCon.Text = "li";
            // 
            // txtTagCha
            // 
            this.txtTagCha.Location = new System.Drawing.Point(100, 38);
            this.txtTagCha.Name = "txtTagCha";
            this.txtTagCha.Size = new System.Drawing.Size(268, 20);
            this.txtTagCha.TabIndex = 3;
            this.txtTagCha.Text = "div.manga-info-top";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vị Trí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tag Con";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "jQueryID Class";
            // 
            // cbbInfomation
            // 
            this.cbbInfomation.FormattingEnabled = true;
            this.cbbInfomation.Items.AddRange(new object[] {
            "manga_name",
            "manga_auth",
            "manga_type",
            "manga_img",
            "manga_des"});
            this.cbbInfomation.Location = new System.Drawing.Point(100, 11);
            this.cbbInfomation.Name = "cbbInfomation";
            this.cbbInfomation.Size = new System.Drawing.Size(268, 21);
            this.cbbInfomation.TabIndex = 1;
            // 
            // Imfomation
            // 
            this.Imfomation.AutoSize = true;
            this.Imfomation.Location = new System.Drawing.Point(8, 14);
            this.Imfomation.Name = "Imfomation";
            this.Imfomation.Size = new System.Drawing.Size(58, 13);
            this.Imfomation.TabIndex = 0;
            this.Imfomation.Text = "Imfomation";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkCheck2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnAddSetting2);
            this.tabPage2.Controls.Add(this.txtIndex2);
            this.tabPage2.Controls.Add(this.txtTagCon2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtTagCha2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbbInfomation2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Step 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkCheck2
            // 
            this.chkCheck2.AutoSize = true;
            this.chkCheck2.Location = new System.Drawing.Point(467, 39);
            this.chkCheck2.Name = "chkCheck2";
            this.chkCheck2.Size = new System.Drawing.Size(15, 14);
            this.chkCheck2.TabIndex = 6;
            this.chkCheck2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn17});
            this.dataGridView2.DataSource = this.chapterMangaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(689, 284);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Action";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // btnAddSetting2
            // 
            this.btnAddSetting2.Location = new System.Drawing.Point(112, 88);
            this.btnAddSetting2.Name = "btnAddSetting2";
            this.btnAddSetting2.Size = new System.Drawing.Size(230, 23);
            this.btnAddSetting2.TabIndex = 4;
            this.btnAddSetting2.Text = "Add Setting";
            this.btnAddSetting2.UseVisualStyleBackColor = true;
            this.btnAddSetting2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIndex2
            // 
            this.txtIndex2.Location = new System.Drawing.Point(290, 62);
            this.txtIndex2.Name = "txtIndex2";
            this.txtIndex2.Size = new System.Drawing.Size(52, 20);
            this.txtIndex2.TabIndex = 3;
            this.txtIndex2.Text = "0";
            // 
            // txtTagCon2
            // 
            this.txtTagCon2.Location = new System.Drawing.Point(112, 62);
            this.txtTagCon2.Name = "txtTagCon2";
            this.txtTagCon2.Size = new System.Drawing.Size(118, 20);
            this.txtTagCon2.TabIndex = 3;
            this.txtTagCon2.Text = "span";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Index";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "TagName";
            // 
            // txtTagCha2
            // 
            this.txtTagCha2.Location = new System.Drawing.Point(112, 36);
            this.txtTagCha2.Name = "txtTagCha2";
            this.txtTagCha2.Size = new System.Drawing.Size(349, 20);
            this.txtTagCha2.TabIndex = 3;
            this.txtTagCha2.Text = "div#chapter > div.manga-info-chapter >  div.chapter-list  > div.row";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "jQueryID Class";
            // 
            // cbbInfomation2
            // 
            this.cbbInfomation2.FormattingEnabled = true;
            this.cbbInfomation2.Items.AddRange(new object[] {
            "chap_name",
            "chap_create",
            "chap_link"});
            this.cbbInfomation2.Location = new System.Drawing.Point(112, 9);
            this.cbbInfomation2.Name = "cbbInfomation2";
            this.cbbInfomation2.Size = new System.Drawing.Size(370, 21);
            this.cbbInfomation2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ImformationChapter";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel1);
            this.tabPage3.Controls.Add(this.geckoWebBrowser1);
            this.tabPage3.Controls.Add(this.txtUrl);
            this.tabPage3.Controls.Add(this.btnGet);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(703, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Step 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(455, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 340);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Location = new System.Drawing.Point(8, 61);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(441, 340);
            this.geckoWebBrowser1.TabIndex = 3;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(6, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(400, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(8, 32);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(104, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Manga_property";
            this.dataGridViewTextBoxColumn9.HeaderText = "Manga_property";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Manga_tagcha";
            this.dataGridViewTextBoxColumn10.HeaderText = "Manga_tagcha";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Manga_tagcon";
            this.dataGridViewTextBoxColumn11.HeaderText = "Manga_tagcon";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Manga_removehtml";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Manga_removehtml";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Manga_index";
            this.dataGridViewTextBoxColumn12.HeaderText = "Manga_index";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Mana_value";
            this.dataGridViewTextBoxColumn13.HeaderText = "Mana_value";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // infomationMangaBindingSource
            // 
            this.infomationMangaBindingSource.DataSource = typeof(MangaTool.InfomationManga);
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Index";
            this.dataGridViewTextBoxColumn14.HeaderText = "Index";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Property_name";
            this.dataGridViewTextBoxColumn15.HeaderText = "Property_name";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Tag_name_info";
            this.dataGridViewTextBoxColumn16.HeaderText = "Tag_name_info";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Tag_link";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Tag_link";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Manga_value";
            this.dataGridViewTextBoxColumn17.HeaderText = "Manga_value";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // chapterMangaBindingSource
            // 
            this.chapterMangaBindingSource.DataSource = typeof(MangaTool.ChapterManga);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 435);
            this.Controls.Add(this.tabManga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabManga.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infomationMangaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterMangaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManga;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddSetting;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtTagCon;
        private System.Windows.Forms.TextBox txtTagCha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbInfomation;
        private System.Windows.Forms.Label Imfomation;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource infomationMangaBindingSource;
        private System.Windows.Forms.Button btnAddSetting2;
        private System.Windows.Forms.TextBox txtIndex2;
        private System.Windows.Forms.TextBox txtTagCon2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTagCha2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbInfomation2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource chapterMangaBindingSource;
        private System.Windows.Forms.CheckBox chkCheck2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGet;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagnameinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagnameparentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn taglinkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangavalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangapropertyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangatagchaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangatagconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mangaremovehtmlDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangaindexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manavalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}


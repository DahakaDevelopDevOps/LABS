namespace OOP_Lab02
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PublishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLast = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPanelShow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPanelHide = new System.Windows.Forms.ToolStripStatusLabel();
            this.objectsLoadedIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результаты";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поле ввода";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolStripMenuItem,
            this.SortToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.backwardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PublishToolStripMenuItem,
            this.YearToolStripMenuItem,
            this.PagesToolStripMenuItem});
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.SearchToolStripMenuItem.Text = "Поиск";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // PublishToolStripMenuItem
            // 
            this.PublishToolStripMenuItem.Name = "PublishToolStripMenuItem";
            this.PublishToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.PublishToolStripMenuItem.Text = "по издательству";
            this.PublishToolStripMenuItem.Click += new System.EventHandler(this.PublishToolStripMenuItem_Click);
            // 
            // YearToolStripMenuItem
            // 
            this.YearToolStripMenuItem.Name = "YearToolStripMenuItem";
            this.YearToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.YearToolStripMenuItem.Text = "по году издания";
            this.YearToolStripMenuItem.Click += new System.EventHandler(this.YearToolStripMenuItem_Click);
            // 
            // PagesToolStripMenuItem
            // 
            this.PagesToolStripMenuItem.Name = "PagesToolStripMenuItem";
            this.PagesToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.PagesToolStripMenuItem.Text = "по диапазону страниц";
            this.PagesToolStripMenuItem.Click += new System.EventHandler(this.PagesToolStripMenuItem_Click);
            // 
            // SortToolStripMenuItem
            // 
            this.SortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameToolStripMenuItem,
            this.DateToolStripMenuItem});
            this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            this.SortToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.SortToolStripMenuItem.Text = "Сортировка по ";
            this.SortToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // NameToolStripMenuItem
            // 
            this.NameToolStripMenuItem.Name = "NameToolStripMenuItem";
            this.NameToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.NameToolStripMenuItem.Text = "названию";
            this.NameToolStripMenuItem.Click += new System.EventHandler(this.NameToolStripMenuItem_Click);
            // 
            // DateToolStripMenuItem
            // 
            this.DateToolStripMenuItem.Name = "DateToolStripMenuItem";
            this.DateToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.DateToolStripMenuItem.Text = "дате издания";
            this.DateToolStripMenuItem.Click += new System.EventHandler(this.DateToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.forwardToolStripMenuItem.Text = "Вперед";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // backwardToolStripMenuItem
            // 
            this.backwardToolStripMenuItem.Name = "backwardToolStripMenuItem";
            this.backwardToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.backwardToolStripMenuItem.Text = "Назад";
            this.backwardToolStripMenuItem.Click += new System.EventHandler(this.backwardToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelLast,
            this.toolStripStatusLabelPanel,
            this.toolStripStatusLabelPanelShow,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabelPanelHide,
            this.objectsLoadedIndicator,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(956, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabel.Text = "Дата и время:";
            this.toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            // 
            // toolStripStatusLabelLast
            // 
            this.toolStripStatusLabelLast.Name = "toolStripStatusLabelLast";
            this.toolStripStatusLabelLast.Size = new System.Drawing.Size(257, 20);
            this.toolStripStatusLabelLast.Text = "Последнее выполненое действие: -";
            this.toolStripStatusLabelLast.Click += new System.EventHandler(this.toolStripStatusLabelLast_Click);
            // 
            // toolStripStatusLabelPanel
            // 
            this.toolStripStatusLabelPanel.Name = "toolStripStatusLabelPanel";
            this.toolStripStatusLabelPanel.Size = new System.Drawing.Size(166, 20);
            this.toolStripStatusLabelPanel.Text = "Панель инструментов:";
            // 
            // toolStripStatusLabelPanelShow
            // 
            this.toolStripStatusLabelPanelShow.Name = "toolStripStatusLabelPanelShow";
            this.toolStripStatusLabelPanelShow.Size = new System.Drawing.Size(89, 20);
            this.toolStripStatusLabelPanelShow.Text = "отобразить";
            this.toolStripStatusLabelPanelShow.Click += new System.EventHandler(this.toolStripStatusLabelPanelShow_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(15, 20);
            this.toolStripStatusLabel5.Text = "/";
            // 
            // toolStripStatusLabelPanelHide
            // 
            this.toolStripStatusLabelPanelHide.Name = "toolStripStatusLabelPanelHide";
            this.toolStripStatusLabelPanelHide.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabelPanelHide.Text = "cкрыть";
            this.toolStripStatusLabelPanelHide.Click += new System.EventHandler(this.toolStripStatusLabelPanelHide_Click);
            // 
            // objectsLoadedIndicator
            // 
            this.objectsLoadedIndicator.Name = "objectsLoadedIndicator";
            this.objectsLoadedIndicator.Size = new System.Drawing.Size(160, 20);
            this.objectsLoadedIndicator.Text = "Обьектов загружено: ";
            this.objectsLoadedIndicator.Click += new System.EventHandler(this.objectsLoadedIndicator_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 20);
            this.toolStripStatusLabel1.Text = "Обьектов загружено: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(510, 307);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 514);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem SearchToolStripMenuItem;
        private ToolStripMenuItem PublishToolStripMenuItem;
        private ToolStripMenuItem YearToolStripMenuItem;
        private ToolStripMenuItem PagesToolStripMenuItem;
        private ToolStripMenuItem SortToolStripMenuItem;
        private ToolStripMenuItem NameToolStripMenuItem;
        private ToolStripMenuItem DateToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem forwardToolStripMenuItem;
        private ToolStripMenuItem backwardToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripStatusLabel toolStripStatusLabelLast;
        private ToolStripStatusLabel toolStripStatusLabelPanel;
        private ToolStripStatusLabel toolStripStatusLabelPanelShow;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel toolStripStatusLabelPanelHide;
        private ToolStripStatusLabel objectsLoadedIndicator;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox textBox2;
    }
}
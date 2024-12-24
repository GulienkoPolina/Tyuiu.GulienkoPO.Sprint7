
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using AxWMPLib;

namespace Tyuiu.GulienkoPO.Sprint7.Project.V9
{
    partial class FormMain
{
    // <summary>
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

        private AxWMPLib.AxWindowsMediaPlayer GetAxWindowsMediaPlayer1()
        {
            return axWindowsMediaPlayer1;
        }

        private AxWMPLib.AxWindowsMediaPlayer GetAxWindowsMediaPlayer11()
        {
            return axWindowsMediaPlayer11;
        }

        private void InitializeComponent(AxWindowsMediaPlayer axWindowsMediaPlayer1, AxWindowsMediaPlayer axWindowsMediaPlayer11, AxWindowsMediaPlayer axWindowsMediaPlayer11, AxWindowsMediaPlayer axWindowsMediaPlayer11)
        {
            InitializeComponent(axWindowsMediaPlayer1, axWindowsMediaPlayer11, axWindowsMediaPlayer11, axWindowsMediaPlayer11, axWindowsMediaPlayer);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1, AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer11, AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer11, AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer11, AxWindowsMediaPlayer axWindowsMediaPlayer)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelWMP = new Panel();
            panelInfo = new Panel();
            textBoxDesc = new TextBox();
            labelDesc = new Label();
            labelS = new Label();
            textBoxS = new TextBox();
            labelM = new Label();
            textBoxM = new TextBox();
            labelH = new Label();
            textBoxH = new TextBox();
            labelDuration = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxFilePath = new TextBox();
            labelFilePath = new Label();
            panelCntrl = new Panel();
            buttonDeleteFile = new Button();
            buttonAddFile = new Button();
            buttonHelp = new Button();
            panelPlaylist = new Panel();
            dataGridViewPlaylist = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer = axWindowsMediaPlayer1;
            axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            panelWMP.SuspendLayout();
            panelInfo.SuspendLayout();
            panelCntrl.SuspendLayout();
            panelPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaylist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // panelWMP
            // 
            panelWMP.Controls.Add(axWindowsMediaPlayer1);
            panelWMP.Location = new Point(1, 0);
            panelWMP.Margin = new Padding(3, 4, 3, 4);
            panelWMP.Name = "panelWMP";
            panelWMP.Size = new Size(765, 524);
            panelWMP.TabIndex = 0;
            panelWMP.Paint += panelWMP_Paint;
            // 
            // panelInfo
            // 
            panelInfo.BorderStyle = BorderStyle.Fixed3D;
            panelInfo.Controls.Add(textBoxDesc);
            panelInfo.Controls.Add(labelDesc);
            panelInfo.Controls.Add(labelS);
            panelInfo.Controls.Add(textBoxS);
            panelInfo.Controls.Add(labelM);
            panelInfo.Controls.Add(textBoxM);
            panelInfo.Controls.Add(labelH);
            panelInfo.Controls.Add(textBoxH);
            panelInfo.Controls.Add(labelDuration);
            panelInfo.Controls.Add(textBoxName);
            panelInfo.Controls.Add(labelName);
            panelInfo.Controls.Add(textBoxFilePath);
            panelInfo.Controls.Add(labelFilePath);
            panelInfo.Location = new Point(1, 532);
            panelInfo.Margin = new Padding(3, 4, 3, 4);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(764, 235);
            panelInfo.TabIndex = 2;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(181, 121);
            textBoxDesc.Margin = new Padding(3, 4, 3, 4);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.ReadOnly = true;
            textBoxDesc.Size = new Size(483, 112);
            textBoxDesc.TabIndex = 25;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Location = new Point(99, 121);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(82, 20);
            labelDesc.TabIndex = 24;
            labelDesc.Text = "Описание:";
            // 
            // labelS
            // 
            labelS.AutoSize = true;
            labelS.Location = new Point(373, 83);
            labelS.Name = "labelS";
            labelS.Size = new Size(60, 20);
            labelS.TabIndex = 23;
            labelS.Text = "Секунд:";
            // 
            // textBoxS
            // 
            textBoxS.Location = new Point(435, 79);
            textBoxS.Margin = new Padding(3, 4, 3, 4);
            textBoxS.Name = "textBoxS";
            textBoxS.ReadOnly = true;
            textBoxS.Size = new Size(28, 27);
            textBoxS.TabIndex = 22;
            // 
            // labelM
            // 
            labelM.AutoSize = true;
            labelM.Location = new Point(287, 83);
            labelM.Name = "labelM";
            labelM.Size = new Size(56, 20);
            labelM.TabIndex = 21;
            labelM.Text = "Минут:";
            // 
            // textBoxM
            // 
            textBoxM.Location = new Point(337, 79);
            textBoxM.Margin = new Padding(3, 4, 3, 4);
            textBoxM.Name = "textBoxM";
            textBoxM.ReadOnly = true;
            textBoxM.Size = new Size(28, 27);
            textBoxM.TabIndex = 20;
            // 
            // labelH
            // 
            labelH.AutoSize = true;
            labelH.Location = new Point(201, 83);
            labelH.Name = "labelH";
            labelH.Size = new Size(54, 20);
            labelH.TabIndex = 19;
            labelH.Text = "Часов:";
            // 
            // textBoxH
            // 
            textBoxH.Location = new Point(251, 79);
            textBoxH.Margin = new Padding(3, 4, 3, 4);
            textBoxH.Name = "textBoxH";
            textBoxH.ReadOnly = true;
            textBoxH.Size = new Size(28, 27);
            textBoxH.TabIndex = 18;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(99, 83);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(108, 20);
            labelDuration.TabIndex = 17;
            labelDuration.Text = "Длительность:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(177, 45);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(449, 27);
            textBoxName.TabIndex = 16;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(99, 51);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 20);
            labelName.TabIndex = 15;
            labelName.Text = "Название:";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(201, 7);
            textBoxFilePath.Margin = new Padding(3, 4, 3, 4);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.ReadOnly = true;
            textBoxFilePath.Size = new Size(425, 27);
            textBoxFilePath.TabIndex = 14;
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Location = new Point(99, 11);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(101, 20);
            labelFilePath.TabIndex = 13;
            labelFilePath.Text = "Путь к файлу:";
            // 
            // panelCntrl
            // 
            panelCntrl.BorderStyle = BorderStyle.Fixed3D;
            panelCntrl.Controls.Add(buttonDeleteFile);
            panelCntrl.Controls.Add(buttonAddFile);
            panelCntrl.Controls.Add(buttonHelp);
            panelCntrl.Location = new Point(773, 672);
            panelCntrl.Margin = new Padding(3, 4, 3, 4);
            panelCntrl.Name = "panelCntrl";
            panelCntrl.Size = new Size(374, 95);
            panelCntrl.TabIndex = 3;
            // 
            // buttonDeleteFile
            // 
            buttonDeleteFile.Location = new Point(141, 4);
            buttonDeleteFile.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteFile.Name = "buttonDeleteFile";
            buttonDeleteFile.Size = new Size(117, 83);
            buttonDeleteFile.TabIndex = 2;
            buttonDeleteFile.Text = "Удалить видеофайл";
            buttonDeleteFile.UseVisualStyleBackColor = true;
            buttonDeleteFile.Click += buttonDeleteFile_Click;
            // 
            // buttonAddFile
            // 
            buttonAddFile.Location = new Point(3, 4);
            buttonAddFile.Margin = new Padding(3, 4, 3, 4);
            buttonAddFile.Name = "buttonAddFile";
            buttonAddFile.Size = new Size(130, 83);
            buttonAddFile.TabIndex = 1;
            buttonAddFile.Text = "Добавить видеофайл";
            buttonAddFile.UseVisualStyleBackColor = true;
            buttonAddFile.Click += buttonAddFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(266, 4);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(101, 83);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelPlaylist
            // 
            panelPlaylist.BorderStyle = BorderStyle.Fixed3D;
            panelPlaylist.Controls.Add(dataGridViewPlaylist);
            panelPlaylist.Location = new Point(773, 0);
            panelPlaylist.Margin = new Padding(3, 4, 3, 4);
            panelPlaylist.Name = "panelPlaylist";
            panelPlaylist.Size = new Size(374, 663);
            panelPlaylist.TabIndex = 1;
            // 
            // dataGridViewPlaylist
            // 
            dataGridViewPlaylist.AllowUserToAddRows = false;
            dataGridViewPlaylist.AllowUserToDeleteRows = false;
            dataGridViewPlaylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlaylist.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewPlaylist.Dock = DockStyle.Fill;
            dataGridViewPlaylist.Location = new Point(0, 0);
            dataGridViewPlaylist.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPlaylist.Name = "dataGridViewPlaylist";
            dataGridViewPlaylist.ReadOnly = true;
            dataGridViewPlaylist.RowHeadersWidth = 51;
            dataGridViewPlaylist.Size = new Size(370, 659);
            dataGridViewPlaylist.TabIndex = 0;
            dataGridViewPlaylist.CellContentClick += dataGridViewPlaylist_CellContentClick;
            dataGridViewPlaylist.CellContentDoubleClick += dataGridViewPlaylist_CellContentDoubleClick;
            dataGridViewPlaylist.CellDoubleClick += dataGridViewPlaylist_CellContentDoubleClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Видеотека:";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 113;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(3, 3);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(765, 518);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 768);
            Controls.Add(panelCntrl);
            Controls.Add(panelInfo);
            Controls.Add(panelPlaylist);
            Controls.Add(panelWMP);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Видеотека";
            Activated += FormMain_Activated;
            panelWMP.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelCntrl.ResumeLayout(false);
            panelPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlaylist).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelWMP;
    private AxWMPLib.AxWindowsMediaPlayer WMP;
    private Panel panelInfo;
    private Panel panelCntrl;
    private Panel panelPlaylist;
    private DataGridView dataGridViewPlaylist;
    private Button buttonAddFile;
    private Button buttonHelp;
    private DataGridViewTextBoxColumn Column1;
    private TextBox textBoxDesc;
    private Label labelDesc;
    private Label labelS;
    private TextBox textBoxS;
    private Label labelM;
    private TextBox textBoxM;
    private Label labelH;
    private TextBox textBoxH;
    private Label labelDuration;
    private TextBox textBoxName;
    private Label labelName;
    private TextBox textBoxFilePath;
    private Label labelFilePath;
    private Button buttonDeleteFile;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWindowsMediaPlayer axWindowsMediaPlayer11;
    }
}
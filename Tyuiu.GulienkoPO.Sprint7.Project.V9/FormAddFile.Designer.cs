namespace Tyuiu.GulienkoPO.Sprint7.Project.V9
{
    partial class FormAddFile
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
            openFileDialog1 = new OpenFileDialog();
            panelAddFileInfo = new Panel();
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
            buttonOpenFile = new Button();
            buttonSaveInfo = new Button();
            panelAddFileInfo.SuspendLayout();
            panelCntrl.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelAddFileInfo
            // 
            panelAddFileInfo.BorderStyle = BorderStyle.Fixed3D;
            panelAddFileInfo.Controls.Add(textBoxDesc);
            panelAddFileInfo.Controls.Add(labelDesc);
            panelAddFileInfo.Controls.Add(labelS);
            panelAddFileInfo.Controls.Add(textBoxS);
            panelAddFileInfo.Controls.Add(labelM);
            panelAddFileInfo.Controls.Add(textBoxM);
            panelAddFileInfo.Controls.Add(labelH);
            panelAddFileInfo.Controls.Add(textBoxH);
            panelAddFileInfo.Controls.Add(labelDuration);
            panelAddFileInfo.Controls.Add(textBoxName);
            panelAddFileInfo.Controls.Add(labelName);
            panelAddFileInfo.Controls.Add(textBoxFilePath);
            panelAddFileInfo.Controls.Add(labelFilePath);
            panelAddFileInfo.Dock = DockStyle.Top;
            panelAddFileInfo.Location = new Point(0, 0);
            panelAddFileInfo.Margin = new Padding(3, 4, 3, 4);
            panelAddFileInfo.Name = "panelAddFileInfo";
            panelAddFileInfo.Size = new Size(582, 247);
            panelAddFileInfo.TabIndex = 0;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(85, 129);
            textBoxDesc.Margin = new Padding(3, 4, 3, 4);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(483, 27);
            textBoxDesc.TabIndex = 12;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Location = new Point(3, 129);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(82, 20);
            labelDesc.TabIndex = 11;
            labelDesc.Text = "Описание:";
            // 
            // labelS
            // 
            labelS.AutoSize = true;
            labelS.Location = new Point(277, 91);
            labelS.Name = "labelS";
            labelS.Size = new Size(60, 20);
            labelS.TabIndex = 10;
            labelS.Text = "Секунд:";
            // 
            // textBoxS
            // 
            textBoxS.Location = new Point(339, 87);
            textBoxS.Margin = new Padding(3, 4, 3, 4);
            textBoxS.Name = "textBoxS";
            textBoxS.Size = new Size(28, 27);
            textBoxS.TabIndex = 9;
            // 
            // labelM
            // 
            labelM.AutoSize = true;
            labelM.Location = new Point(191, 91);
            labelM.Name = "labelM";
            labelM.Size = new Size(56, 20);
            labelM.TabIndex = 8;
            labelM.Text = "Минут:";
            // 
            // textBoxM
            // 
            textBoxM.Location = new Point(241, 87);
            textBoxM.Margin = new Padding(3, 4, 3, 4);
            textBoxM.Name = "textBoxM";
            textBoxM.Size = new Size(28, 27);
            textBoxM.TabIndex = 7;
            // 
            // labelH
            // 
            labelH.AutoSize = true;
            labelH.Location = new Point(105, 91);
            labelH.Name = "labelH";
            labelH.Size = new Size(54, 20);
            labelH.TabIndex = 6;
            labelH.Text = "Часов:";
            // 
            // textBoxH
            // 
            textBoxH.Location = new Point(155, 87);
            textBoxH.Margin = new Padding(3, 4, 3, 4);
            textBoxH.Name = "textBoxH";
            textBoxH.Size = new Size(28, 27);
            textBoxH.TabIndex = 5;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(3, 91);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(108, 20);
            labelDuration.TabIndex = 4;
            labelDuration.Text = "Длительность:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(81, 48);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(449, 27);
            textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(3, 52);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Название:";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(105, 8);
            textBoxFilePath.Margin = new Padding(3, 4, 3, 4);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.ReadOnly = true;
            textBoxFilePath.Size = new Size(425, 27);
            textBoxFilePath.TabIndex = 1;
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Location = new Point(3, 12);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(101, 20);
            labelFilePath.TabIndex = 0;
            labelFilePath.Text = "Путь к файлу:";
            // 
            // panelCntrl
            // 
            panelCntrl.BorderStyle = BorderStyle.Fixed3D;
            panelCntrl.Controls.Add(buttonOpenFile);
            panelCntrl.Controls.Add(buttonSaveInfo);
            panelCntrl.Dock = DockStyle.Bottom;
            panelCntrl.Location = new Point(0, 252);
            panelCntrl.Margin = new Padding(3, 4, 3, 4);
            panelCntrl.Name = "panelCntrl";
            panelCntrl.Size = new Size(582, 60);
            panelCntrl.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(303, 4);
            buttonOpenFile.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(145, 52);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.Text = "Выбрать файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonSaveInfo
            // 
            buttonSaveInfo.Location = new Point(455, 4);
            buttonSaveInfo.Margin = new Padding(3, 4, 3, 4);
            buttonSaveInfo.Name = "buttonSaveInfo";
            buttonSaveInfo.Size = new Size(123, 52);
            buttonSaveInfo.TabIndex = 0;
            buttonSaveInfo.Text = "Сохранить";
            buttonSaveInfo.UseVisualStyleBackColor = true;
            buttonSaveInfo.Click += buttonSaveInfo_Click;
            // 
            // FormAddFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 312);
            Controls.Add(panelCntrl);
            Controls.Add(panelAddFileInfo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddFile";
            Text = "Добавление видео";
            panelAddFileInfo.ResumeLayout(false);
            panelAddFileInfo.PerformLayout();
            panelCntrl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Panel panelAddFileInfo;
        private Panel panelCntrl;
        private Button buttonOpenFile;
        private Button buttonSaveInfo;
        private TextBox textBoxFilePath;
        private Label labelFilePath;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelDuration;
        private TextBox textBoxH;
        private Label labelS;
        private TextBox textBoxS;
        private Label labelM;
        private TextBox textBoxM;
        private Label labelH;
        private TextBox textBoxDesc;
        private Label labelDesc;
    }
}
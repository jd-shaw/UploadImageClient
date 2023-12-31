﻿
using System.Windows.Forms;

namespace GeekoUploadImage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.uploadImagePage = new System.Windows.Forms.TabPage();
            this.foldPathTextBox2 = new System.Windows.Forms.TextBox();
            this.typecomboBox = new System.Windows.Forms.ComboBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.imageDataGridView = new System.Windows.Forms.DataGridView();
            this.CheckBoxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageFoldPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDateGridViewUploadBtn = new System.Windows.Forms.Button();
            this.cleanImageDateGridViewBtn = new System.Windows.Forms.Button();
            this.imageDgvCount = new System.Windows.Forms.Label();
            this.imageUploadProgressBar = new System.Windows.Forms.ProgressBar();
            this.browseFoldPath = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.isPc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainbtnminimizar = new System.Windows.Forms.PictureBox();
            this.mainbtncerrar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.otherMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explanationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filllPanel = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uploadImagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGridView)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbtnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbtncerrar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.filllPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.SkyBlue;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1404, 4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(22, 21);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 7;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(1368, 4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(22, 21);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 8;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.uploadImagePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1432, 855);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // uploadImagePage
            // 
            this.uploadImagePage.Controls.Add(this.foldPathTextBox2);
            this.uploadImagePage.Controls.Add(this.typecomboBox);
            this.uploadImagePage.Controls.Add(this.RemoveBtn);
            this.uploadImagePage.Controls.Add(this.imageDataGridView);
            this.uploadImagePage.Controls.Add(this.imageDateGridViewUploadBtn);
            this.uploadImagePage.Controls.Add(this.cleanImageDateGridViewBtn);
            this.uploadImagePage.Controls.Add(this.imageDgvCount);
            this.uploadImagePage.Controls.Add(this.imageUploadProgressBar);
            this.uploadImagePage.Controls.Add(this.browseFoldPath);
            this.uploadImagePage.Location = new System.Drawing.Point(4, 28);
            this.uploadImagePage.Name = "uploadImagePage";
            this.uploadImagePage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.uploadImagePage.Size = new System.Drawing.Size(1424, 823);
            this.uploadImagePage.TabIndex = 0;
            this.uploadImagePage.Text = "图片库图片上传";
            this.uploadImagePage.UseVisualStyleBackColor = true;
            // 
            // foldPathTextBox2
            // 
            this.foldPathTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foldPathTextBox2.Enabled = false;
            this.foldPathTextBox2.Font = new System.Drawing.Font("宋体", 13.5F);
            this.foldPathTextBox2.Location = new System.Drawing.Point(240, 8);
            this.foldPathTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foldPathTextBox2.Name = "foldPathTextBox2";
            this.foldPathTextBox2.Size = new System.Drawing.Size(662, 28);
            this.foldPathTextBox2.TabIndex = 16;
            // 
            // typecomboBox
            // 
            this.typecomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typecomboBox.Font = new System.Drawing.Font("宋体", 13.5F);
            this.typecomboBox.FormattingEnabled = true;
            this.typecomboBox.ItemHeight = 18;
            this.typecomboBox.Location = new System.Drawing.Point(1072, 8);
            this.typecomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typecomboBox.Name = "typecomboBox";
            this.typecomboBox.Size = new System.Drawing.Size(180, 26);
            this.typecomboBox.TabIndex = 25;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(12, 8);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(108, 42);
            this.RemoveBtn.TabIndex = 21;
            this.RemoveBtn.Text = "删除行";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // imageDataGridView
            // 
            this.imageDataGridView.AllowUserToAddRows = false;
            this.imageDataGridView.AllowUserToDeleteRows = false;
            this.imageDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imageDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.imageDataGridView.ColumnHeadersHeight = 30;
            this.imageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxSelect,
            this.gridIndex,
            this.showImage,
            this.sku,
            this.imageFoldPath,
            this.fileName,
            this.imageWidth,
            this.imageHeight,
            this.fileSize,
            this.uploadStatus});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imageDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.imageDataGridView.GridColor = System.Drawing.Color.AliceBlue;
            this.imageDataGridView.Location = new System.Drawing.Point(0, 58);
            this.imageDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageDataGridView.Name = "imageDataGridView";
            this.imageDataGridView.RowHeadersVisible = false;
            this.imageDataGridView.RowTemplate.Height = 120;
            this.imageDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imageDataGridView.Size = new System.Drawing.Size(1418, 716);
            this.imageDataGridView.TabIndex = 24;
            // 
            // CheckBoxSelect
            // 
            this.CheckBoxSelect.FillWeight = 35F;
            this.CheckBoxSelect.HeaderText = "";
            this.CheckBoxSelect.Name = "CheckBoxSelect";
            // 
            // gridIndex
            // 
            this.gridIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gridIndex.FillWeight = 35F;
            this.gridIndex.HeaderText = "";
            this.gridIndex.Name = "gridIndex";
            this.gridIndex.Width = 40;
            // 
            // showImage
            // 
            this.showImage.FillWeight = 85.81362F;
            this.showImage.HeaderText = "图片";
            this.showImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.showImage.Name = "showImage";
            this.showImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sku
            // 
            this.sku.FillWeight = 60F;
            this.sku.HeaderText = "SKU";
            this.sku.Name = "sku";
            // 
            // imageFoldPath
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imageFoldPath.DefaultCellStyle = dataGridViewCellStyle2;
            this.imageFoldPath.HeaderText = "图片路径";
            this.imageFoldPath.Name = "imageFoldPath";
            // 
            // fileName
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fileName.DefaultCellStyle = dataGridViewCellStyle3;
            this.fileName.FillWeight = 75F;
            this.fileName.HeaderText = "图片名称";
            this.fileName.Name = "fileName";
            // 
            // imageWidth
            // 
            this.imageWidth.FillWeight = 50F;
            this.imageWidth.HeaderText = "宽度";
            this.imageWidth.Name = "imageWidth";
            // 
            // imageHeight
            // 
            this.imageHeight.FillWeight = 50F;
            this.imageHeight.HeaderText = "高度";
            this.imageHeight.Name = "imageHeight";
            // 
            // fileSize
            // 
            this.fileSize.FillWeight = 70F;
            this.fileSize.HeaderText = "文件大小";
            this.fileSize.Name = "fileSize";
            // 
            // uploadStatus
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.uploadStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.uploadStatus.FillWeight = 73.56156F;
            this.uploadStatus.HeaderText = "上传状态";
            this.uploadStatus.Name = "uploadStatus";
            // 
            // imageDateGridViewUploadBtn
            // 
            this.imageDateGridViewUploadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageDateGridViewUploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.imageDateGridViewUploadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.imageDateGridViewUploadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.imageDateGridViewUploadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.imageDateGridViewUploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageDateGridViewUploadBtn.ForeColor = System.Drawing.Color.LightGray;
            this.imageDateGridViewUploadBtn.Location = new System.Drawing.Point(1263, 8);
            this.imageDateGridViewUploadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageDateGridViewUploadBtn.Name = "imageDateGridViewUploadBtn";
            this.imageDateGridViewUploadBtn.Size = new System.Drawing.Size(150, 42);
            this.imageDateGridViewUploadBtn.TabIndex = 20;
            this.imageDateGridViewUploadBtn.Text = "确认上传";
            this.imageDateGridViewUploadBtn.UseVisualStyleBackColor = true;
            this.imageDateGridViewUploadBtn.Click += new System.EventHandler(this.imageDateGridViewUploadBtn_Click);
            // 
            // cleanImageDateGridViewBtn
            // 
            this.cleanImageDateGridViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanImageDateGridViewBtn.Location = new System.Drawing.Point(1304, 778);
            this.cleanImageDateGridViewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cleanImageDateGridViewBtn.Name = "cleanImageDateGridViewBtn";
            this.cleanImageDateGridViewBtn.Size = new System.Drawing.Size(112, 34);
            this.cleanImageDateGridViewBtn.TabIndex = 19;
            this.cleanImageDateGridViewBtn.Text = "清除列表";
            this.cleanImageDateGridViewBtn.UseVisualStyleBackColor = true;
            this.cleanImageDateGridViewBtn.Click += new System.EventHandler(this.cleanImageDateGridViewBtn_Click);
            // 
            // imageDgvCount
            // 
            this.imageDgvCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imageDgvCount.AutoSize = true;
            this.imageDgvCount.Location = new System.Drawing.Point(1224, 788);
            this.imageDgvCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageDgvCount.Name = "imageDgvCount";
            this.imageDgvCount.Size = new System.Drawing.Size(0, 18);
            this.imageDgvCount.TabIndex = 18;
            // 
            // imageUploadProgressBar
            // 
            this.imageUploadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageUploadProgressBar.Location = new System.Drawing.Point(8, 777);
            this.imageUploadProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageUploadProgressBar.Name = "imageUploadProgressBar";
            this.imageUploadProgressBar.Size = new System.Drawing.Size(1204, 34);
            this.imageUploadProgressBar.TabIndex = 17;
            this.imageUploadProgressBar.Visible = false;
            // 
            // browseFoldPath
            // 
            this.browseFoldPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFoldPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.browseFoldPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.browseFoldPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.browseFoldPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.browseFoldPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseFoldPath.ForeColor = System.Drawing.Color.LightGray;
            this.browseFoldPath.Location = new System.Drawing.Point(914, 8);
            this.browseFoldPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseFoldPath.Name = "browseFoldPath";
            this.browseFoldPath.Size = new System.Drawing.Size(150, 42);
            this.browseFoldPath.TabIndex = 0;
            this.browseFoldPath.Text = "浏览文件";
            this.browseFoldPath.UseVisualStyleBackColor = true;
            this.browseFoldPath.Click += new System.EventHandler(this.browseFoldPath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 15;
            // 
            // isPc
            // 
            this.isPc.FillWeight = 60F;
            this.isPc.HeaderText = "PC/APP";
            this.isPc.Name = "isPc";
            this.isPc.Width = 101;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.username);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.mainbtnminimizar);
            this.topPanel.Controls.Add(this.mainbtncerrar);
            this.topPanel.Controls.Add(this.menuStrip1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1432, 51);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(1242, 14);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 18);
            this.username.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1113, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "当前用户:";
            // 
            // mainbtnminimizar
            // 
            this.mainbtnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainbtnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainbtnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("mainbtnminimizar.Image")));
            this.mainbtnminimizar.Location = new System.Drawing.Point(1360, 14);
            this.mainbtnminimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainbtnminimizar.Name = "mainbtnminimizar";
            this.mainbtnminimizar.Size = new System.Drawing.Size(22, 21);
            this.mainbtnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainbtnminimizar.TabIndex = 10;
            this.mainbtnminimizar.TabStop = false;
            this.mainbtnminimizar.Click += new System.EventHandler(this.mainbtnminimizar_Click);
            // 
            // mainbtncerrar
            // 
            this.mainbtncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainbtncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainbtncerrar.Image = ((System.Drawing.Image)(resources.GetObject("mainbtncerrar.Image")));
            this.mainbtncerrar.Location = new System.Drawing.Point(1396, 14);
            this.mainbtncerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainbtncerrar.Name = "mainbtncerrar";
            this.mainbtncerrar.Size = new System.Drawing.Size(22, 21);
            this.mainbtncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainbtncerrar.TabIndex = 9;
            this.mainbtncerrar.TabStop = false;
            this.mainbtncerrar.Click += new System.EventHandler(this.mainbtncerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(152, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(55, 27);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // otherMenuItem
            // 
            this.otherMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.otherMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explanationMenuItem});
            this.otherMenuItem.Name = "otherMenuItem";
            this.otherMenuItem.Size = new System.Drawing.Size(44, 21);
            this.otherMenuItem.Text = "帮助";
            // 
            // explanationMenuItem
            // 
            this.explanationMenuItem.Name = "explanationMenuItem";
            this.explanationMenuItem.Size = new System.Drawing.Size(100, 22);
            this.explanationMenuItem.Text = "说明";
            this.explanationMenuItem.Click += new System.EventHandler(this.explanationMenuItem_Click);
            // 
            // filllPanel
            // 
            this.filllPanel.Controls.Add(this.tabControl1);
            this.filllPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filllPanel.Location = new System.Drawing.Point(0, 51);
            this.filllPanel.Name = "filllPanel";
            this.filllPanel.Size = new System.Drawing.Size(1432, 855);
            this.filllPanel.TabIndex = 12;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(1270, 430);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 906);
            this.Controls.Add(this.filllPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnminimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uploadImagePage.ResumeLayout(false);
            this.uploadImagePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGridView)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbtnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainbtncerrar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.filllPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private TabControl tabControl1;
        private TabPage uploadImagePage;
        private Button RemoveBtn;
        private Button imageDateGridViewUploadBtn;
        private Button cleanImageDateGridViewBtn;
        private Label imageDgvCount;
        private ProgressBar imageUploadProgressBar;
        private TextBox foldPathTextBox2;
        private Label label8;
        private Button browseFoldPath;
        private DataGridViewTextBoxColumn uploadStatus;
        private DataGridViewTextBoxColumn fileSize;
        private DataGridViewTextBoxColumn imageHeight;
        private DataGridViewTextBoxColumn imageWidth;
        private DataGridViewTextBoxColumn isPc;
        private DataGridViewTextBoxColumn fileName;
        private DataGridViewTextBoxColumn imageFoldPath;
        private DataGridViewTextBoxColumn sku;
        private DataGridViewImageColumn showImage;
        private DataGridViewTextBoxColumn gridIndex;
        private DataGridViewCheckBoxColumn CheckBoxSelect;
        private DataGridView imageDataGridView;
        private Panel topPanel;
        private Panel filllPanel;
        private PictureBox mainbtnminimizar;
        private PictureBox mainbtncerrar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private ComboBox typecomboBox;
        private Label username;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem otherMenuItem;
        private ToolStripMenuItem explanationMenuItem;
        private PictureBox pictureBox1;
    }
}
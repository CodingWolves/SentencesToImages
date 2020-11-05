﻿namespace SentencesToImages
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
            if(disposing && (components != null))
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
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sentencesListBox = new System.Windows.Forms.ListBox();
            this.addSensFileButton = new System.Windows.Forms.Button();
            this.saveImagesButton = new System.Windows.Forms.Button();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.chooseOutputFolderButton = new System.Windows.Forms.Button();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.currentBackColorBox = new System.Windows.Forms.PictureBox();
            this.defaultBackColorBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.defaultFontSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.defaultImageSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.currentImageSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.currentFontSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBackColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBackColorBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultFontSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultImageSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentImageSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentFontSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPictureBox.Location = new System.Drawing.Point(8, 23);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(511, 402);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            this.previewPictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseWheel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preview";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.previewPictureBox);
            this.panel1.Location = new System.Drawing.Point(259, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(529, 435);
            this.panel1.TabIndex = 2;
            // 
            // sentencesListBox
            // 
            this.sentencesListBox.FormattingEnabled = true;
            this.sentencesListBox.Location = new System.Drawing.Point(12, 206);
            this.sentencesListBox.Name = "sentencesListBox";
            this.sentencesListBox.Size = new System.Drawing.Size(241, 134);
            this.sentencesListBox.TabIndex = 3;
            this.sentencesListBox.SelectedIndexChanged += new System.EventHandler(this.sentencesListBox_SelectedIndexChanged);
            this.sentencesListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sentencesListBox_KeyDown);
            // 
            // addSensFileButton
            // 
            this.addSensFileButton.Location = new System.Drawing.Point(12, 6);
            this.addSensFileButton.Name = "addSensFileButton";
            this.addSensFileButton.Size = new System.Drawing.Size(241, 53);
            this.addSensFileButton.TabIndex = 4;
            this.addSensFileButton.Text = "Add Sentences File";
            this.addSensFileButton.UseVisualStyleBackColor = true;
            this.addSensFileButton.Click += new System.EventHandler(this.addSensFileButton_Click);
            // 
            // saveImagesButton
            // 
            this.saveImagesButton.Location = new System.Drawing.Point(12, 385);
            this.saveImagesButton.Name = "saveImagesButton";
            this.saveImagesButton.Size = new System.Drawing.Size(241, 53);
            this.saveImagesButton.TabIndex = 5;
            this.saveImagesButton.Text = "Save Images";
            this.saveImagesButton.UseVisualStyleBackColor = true;
            this.saveImagesButton.Click += new System.EventHandler(this.saveImagesButton_Click);
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Location = new System.Drawing.Point(12, 359);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(201, 20);
            this.outputFolderTextBox.TabIndex = 6;
            // 
            // chooseOutputFolderButton
            // 
            this.chooseOutputFolderButton.Location = new System.Drawing.Point(219, 358);
            this.chooseOutputFolderButton.Name = "chooseOutputFolderButton";
            this.chooseOutputFolderButton.Size = new System.Drawing.Size(34, 23);
            this.chooseOutputFolderButton.TabIndex = 7;
            this.chooseOutputFolderButton.Text = "...";
            this.chooseOutputFolderButton.UseVisualStyleBackColor = true;
            this.chooseOutputFolderButton.Click += new System.EventHandler(this.chooseOutputFolderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sentences";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // currentBackColorBox
            // 
            this.currentBackColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentBackColorBox.Location = new System.Drawing.Point(104, 6);
            this.currentBackColorBox.Name = "currentBackColorBox";
            this.currentBackColorBox.Size = new System.Drawing.Size(30, 30);
            this.currentBackColorBox.TabIndex = 11;
            this.currentBackColorBox.TabStop = false;
            this.currentBackColorBox.DoubleClick += new System.EventHandler(this.sentenceBackColorBox_DoubleClick);
            // 
            // defaultBackColorBox
            // 
            this.defaultBackColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultBackColorBox.Location = new System.Drawing.Point(104, 6);
            this.defaultBackColorBox.Name = "defaultBackColorBox";
            this.defaultBackColorBox.Size = new System.Drawing.Size(30, 30);
            this.defaultBackColorBox.TabIndex = 12;
            this.defaultBackColorBox.TabStop = false;
            this.defaultBackColorBox.DoubleClick += new System.EventHandler(this.defaultBackColorBox_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(241, 108);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.defaultImageSizeTrackBar);
            this.tabPage1.Controls.Add(this.defaultFontSizeTrackBar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.defaultBackColorBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(233, 82);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Default";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.currentBackColorBox);
            this.tabPage2.Controls.Add(this.currentImageSizeTrackBar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.currentFontSizeTrackBar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(233, 82);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Background Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Background Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Font Size";
            // 
            // defaultFontSizeTrackBar
            // 
            this.defaultFontSizeTrackBar.AutoSize = false;
            this.defaultFontSizeTrackBar.LargeChange = 10;
            this.defaultFontSizeTrackBar.Location = new System.Drawing.Point(6, 55);
            this.defaultFontSizeTrackBar.Maximum = 128;
            this.defaultFontSizeTrackBar.Minimum = 6;
            this.defaultFontSizeTrackBar.Name = "defaultFontSizeTrackBar";
            this.defaultFontSizeTrackBar.Size = new System.Drawing.Size(111, 21);
            this.defaultFontSizeTrackBar.SmallChange = 2;
            this.defaultFontSizeTrackBar.TabIndex = 18;
            this.defaultFontSizeTrackBar.TickFrequency = 6;
            this.defaultFontSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.defaultFontSizeTrackBar.Value = 20;
            this.defaultFontSizeTrackBar.Scroll += new System.EventHandler(this.defaultFontSizeTrackBar_Scroll);
            // 
            // defaultImageSizeTrackBar
            // 
            this.defaultImageSizeTrackBar.AutoSize = false;
            this.defaultImageSizeTrackBar.LargeChange = 10;
            this.defaultImageSizeTrackBar.Location = new System.Drawing.Point(123, 55);
            this.defaultImageSizeTrackBar.Maximum = 2000;
            this.defaultImageSizeTrackBar.Minimum = 200;
            this.defaultImageSizeTrackBar.Name = "defaultImageSizeTrackBar";
            this.defaultImageSizeTrackBar.Size = new System.Drawing.Size(104, 21);
            this.defaultImageSizeTrackBar.SmallChange = 20;
            this.defaultImageSizeTrackBar.TabIndex = 19;
            this.defaultImageSizeTrackBar.TickFrequency = 6;
            this.defaultImageSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.defaultImageSizeTrackBar.Value = 400;
            this.defaultImageSizeTrackBar.Scroll += new System.EventHandler(this.defaultImageSizeTrackBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Image Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Image Size";
            // 
            // currentImageSizeTrackBar
            // 
            this.currentImageSizeTrackBar.AutoSize = false;
            this.currentImageSizeTrackBar.LargeChange = 10;
            this.currentImageSizeTrackBar.Location = new System.Drawing.Point(123, 55);
            this.currentImageSizeTrackBar.Maximum = 2000;
            this.currentImageSizeTrackBar.Minimum = 200;
            this.currentImageSizeTrackBar.Name = "currentImageSizeTrackBar";
            this.currentImageSizeTrackBar.Size = new System.Drawing.Size(104, 21);
            this.currentImageSizeTrackBar.SmallChange = 20;
            this.currentImageSizeTrackBar.TabIndex = 23;
            this.currentImageSizeTrackBar.TickFrequency = 6;
            this.currentImageSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.currentImageSizeTrackBar.Value = 400;
            this.currentImageSizeTrackBar.Scroll += new System.EventHandler(this.currentImageSizeTrackBar_Scroll);
            // 
            // currentFontSizeTrackBar
            // 
            this.currentFontSizeTrackBar.AutoSize = false;
            this.currentFontSizeTrackBar.LargeChange = 10;
            this.currentFontSizeTrackBar.Location = new System.Drawing.Point(6, 55);
            this.currentFontSizeTrackBar.Maximum = 72;
            this.currentFontSizeTrackBar.Minimum = 6;
            this.currentFontSizeTrackBar.Name = "currentFontSizeTrackBar";
            this.currentFontSizeTrackBar.Size = new System.Drawing.Size(111, 21);
            this.currentFontSizeTrackBar.SmallChange = 2;
            this.currentFontSizeTrackBar.TabIndex = 22;
            this.currentFontSizeTrackBar.TickFrequency = 6;
            this.currentFontSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.currentFontSizeTrackBar.Value = 20;
            this.currentFontSizeTrackBar.Scroll += new System.EventHandler(this.currentFontSizeTrackBar_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Font Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseOutputFolderButton);
            this.Controls.Add(this.outputFolderTextBox);
            this.Controls.Add(this.saveImagesButton);
            this.Controls.Add(this.addSensFileButton);
            this.Controls.Add(this.sentencesListBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBackColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBackColorBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultFontSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultImageSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentImageSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentFontSizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox sentencesListBox;
        private System.Windows.Forms.Button addSensFileButton;
        private System.Windows.Forms.Button saveImagesButton;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.Button chooseOutputFolderButton;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox currentBackColorBox;
        private System.Windows.Forms.PictureBox defaultBackColorBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar defaultImageSizeTrackBar;
        private System.Windows.Forms.TrackBar defaultFontSizeTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar currentImageSizeTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar currentFontSizeTrackBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
    }
}

﻿
namespace AddonUpdater.Forms
{
    partial class FormAddons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddons));
            this.button_Dowload = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.buttonLauncher = new System.Windows.Forms.Button();
            this.PanelDescription = new System.Windows.Forms.Panel();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.panelAddon = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDeleteSettings = new System.Windows.Forms.Button();
            this.buttonGitHub = new System.Windows.Forms.Button();
            this.buttonForum = new System.Windows.Forms.Button();
            this.buttonReportBug = new System.Windows.Forms.Button();
            this.buttonIgnore = new System.Windows.Forms.Button();
            this.buttonReinstall = new System.Windows.Forms.Button();
            this.panelDeleteSettings = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.labelAddonName = new System.Windows.Forms.Label();
            this.comboBoxRealm = new System.Windows.Forms.ComboBox();
            this.comboBoxPersons = new System.Windows.Forms.ComboBox();
            this.comboBoxSettings = new System.Windows.Forms.ComboBox();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.buttonpanelDeleteSettings = new System.Windows.Forms.Button();
            this.panelAddonsViewTitle = new System.Windows.Forms.Panel();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelAddonsView = new System.Windows.Forms.Panel();
            this.PanelDescription.SuspendLayout();
            this.panelAddon.SuspendLayout();
            this.panelDeleteSettings.SuspendLayout();
            this.panelAddonsViewTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Dowload
            // 
            this.button_Dowload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.button_Dowload.FlatAppearance.BorderSize = 0;
            this.button_Dowload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Dowload.ForeColor = System.Drawing.Color.White;
            this.button_Dowload.Location = new System.Drawing.Point(740, 535);
            this.button_Dowload.Name = "button_Dowload";
            this.button_Dowload.Size = new System.Drawing.Size(150, 40);
            this.button_Dowload.TabIndex = 12;
            this.button_Dowload.TabStop = false;
            this.button_Dowload.Text = "Обновить все";
            this.button_Dowload.UseVisualStyleBackColor = false;
            this.button_Dowload.Click += new System.EventHandler(this.Button_Dowload_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.button_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_update.BackgroundImage")));
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(680, 535);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(50, 40);
            this.button_update.TabIndex = 20;
            this.button_update.TabStop = false;
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // buttonLauncher
            // 
            this.buttonLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.buttonLauncher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLauncher.BackgroundImage")));
            this.buttonLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLauncher.FlatAppearance.BorderSize = 0;
            this.buttonLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLauncher.ForeColor = System.Drawing.Color.White;
            this.buttonLauncher.Location = new System.Drawing.Point(620, 535);
            this.buttonLauncher.Name = "buttonLauncher";
            this.buttonLauncher.Size = new System.Drawing.Size(50, 40);
            this.buttonLauncher.TabIndex = 21;
            this.buttonLauncher.TabStop = false;
            this.buttonLauncher.UseVisualStyleBackColor = false;
            this.buttonLauncher.Click += new System.EventHandler(this.ButtonLauncher_Click);
            // 
            // PanelDescription
            // 
            this.PanelDescription.Controls.Add(this.LabelDescription);
            this.PanelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelDescription.Location = new System.Drawing.Point(262, 300);
            this.PanelDescription.MaximumSize = new System.Drawing.Size(800, 300);
            this.PanelDescription.Name = "PanelDescription";
            this.PanelDescription.Size = new System.Drawing.Size(800, 15);
            this.PanelDescription.TabIndex = 22;
            this.PanelDescription.Visible = false;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoEllipsis = true;
            this.LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelDescription.Location = new System.Drawing.Point(0, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(800, 15);
            this.LabelDescription.TabIndex = 1;
            // 
            // panelAddon
            // 
            this.panelAddon.Controls.Add(this.buttonUpdate);
            this.panelAddon.Controls.Add(this.buttonDelete);
            this.panelAddon.Controls.Add(this.buttonDeleteSettings);
            this.panelAddon.Controls.Add(this.buttonGitHub);
            this.panelAddon.Controls.Add(this.buttonForum);
            this.panelAddon.Controls.Add(this.buttonReportBug);
            this.panelAddon.Controls.Add(this.buttonIgnore);
            this.panelAddon.Controls.Add(this.buttonReinstall);
            this.panelAddon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelAddon.Location = new System.Drawing.Point(101, 100);
            this.panelAddon.MaximumSize = new System.Drawing.Size(800, 500);
            this.panelAddon.Name = "panelAddon";
            this.panelAddon.Size = new System.Drawing.Size(140, 300);
            this.panelAddon.TabIndex = 23;
            this.panelAddon.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(0, 75);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 40);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Text = "Cледить за обновлением";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(0, 258);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 40);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonDeleteSettings
            // 
            this.buttonDeleteSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonDeleteSettings.FlatAppearance.BorderSize = 0;
            this.buttonDeleteSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteSettings.Location = new System.Drawing.Point(0, 226);
            this.buttonDeleteSettings.Name = "buttonDeleteSettings";
            this.buttonDeleteSettings.Size = new System.Drawing.Size(140, 40);
            this.buttonDeleteSettings.TabIndex = 8;
            this.buttonDeleteSettings.TabStop = false;
            this.buttonDeleteSettings.Text = "Удалить настройки";
            this.buttonDeleteSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteSettings.UseVisualStyleBackColor = false;
            this.buttonDeleteSettings.Click += new System.EventHandler(this.ButtonDeleteSettings_Click);
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonGitHub.FlatAppearance.BorderSize = 0;
            this.buttonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGitHub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGitHub.Location = new System.Drawing.Point(0, 190);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(140, 40);
            this.buttonGitHub.TabIndex = 7;
            this.buttonGitHub.TabStop = false;
            this.buttonGitHub.Text = "GitHub";
            this.buttonGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGitHub.UseVisualStyleBackColor = false;
            this.buttonGitHub.Click += new System.EventHandler(this.ButtonGitHub_Click);
            // 
            // buttonForum
            // 
            this.buttonForum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonForum.FlatAppearance.BorderSize = 0;
            this.buttonForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForum.Location = new System.Drawing.Point(0, 154);
            this.buttonForum.Name = "buttonForum";
            this.buttonForum.Size = new System.Drawing.Size(140, 40);
            this.buttonForum.TabIndex = 6;
            this.buttonForum.TabStop = false;
            this.buttonForum.Text = "Форум";
            this.buttonForum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonForum.UseVisualStyleBackColor = false;
            this.buttonForum.Click += new System.EventHandler(this.ButtonForum_Click);
            // 
            // buttonReportBug
            // 
            this.buttonReportBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonReportBug.FlatAppearance.BorderSize = 0;
            this.buttonReportBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReportBug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReportBug.Location = new System.Drawing.Point(0, 115);
            this.buttonReportBug.Name = "buttonReportBug";
            this.buttonReportBug.Size = new System.Drawing.Size(140, 40);
            this.buttonReportBug.TabIndex = 5;
            this.buttonReportBug.TabStop = false;
            this.buttonReportBug.Text = "Сообщить о баге";
            this.buttonReportBug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportBug.UseVisualStyleBackColor = false;
            this.buttonReportBug.Click += new System.EventHandler(this.ButtonReportBug_Click);
            // 
            // buttonIgnore
            // 
            this.buttonIgnore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonIgnore.FlatAppearance.BorderSize = 0;
            this.buttonIgnore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIgnore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIgnore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIgnore.Location = new System.Drawing.Point(0, 40);
            this.buttonIgnore.Name = "buttonIgnore";
            this.buttonIgnore.Size = new System.Drawing.Size(140, 40);
            this.buttonIgnore.TabIndex = 4;
            this.buttonIgnore.TabStop = false;
            this.buttonIgnore.Text = "Игнорировать";
            this.buttonIgnore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIgnore.UseVisualStyleBackColor = false;
            this.buttonIgnore.Click += new System.EventHandler(this.ButtonIgnore_Click);
            // 
            // buttonReinstall
            // 
            this.buttonReinstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonReinstall.FlatAppearance.BorderSize = 0;
            this.buttonReinstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReinstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReinstall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReinstall.Location = new System.Drawing.Point(0, 0);
            this.buttonReinstall.Name = "buttonReinstall";
            this.buttonReinstall.Size = new System.Drawing.Size(140, 40);
            this.buttonReinstall.TabIndex = 3;
            this.buttonReinstall.TabStop = false;
            this.buttonReinstall.Text = "Переустановить";
            this.buttonReinstall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReinstall.UseVisualStyleBackColor = false;
            this.buttonReinstall.Click += new System.EventHandler(this.ButtonReinstall_Click);
            // 
            // panelDeleteSettings
            // 
            this.panelDeleteSettings.Controls.Add(this.button_Close);
            this.panelDeleteSettings.Controls.Add(this.labelAddonName);
            this.panelDeleteSettings.Controls.Add(this.comboBoxRealm);
            this.panelDeleteSettings.Controls.Add(this.comboBoxPersons);
            this.panelDeleteSettings.Controls.Add(this.comboBoxSettings);
            this.panelDeleteSettings.Controls.Add(this.comboBoxAccount);
            this.panelDeleteSettings.Controls.Add(this.buttonpanelDeleteSettings);
            this.panelDeleteSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDeleteSettings.Location = new System.Drawing.Point(390, 150);
            this.panelDeleteSettings.MaximumSize = new System.Drawing.Size(800, 400);
            this.panelDeleteSettings.Name = "panelDeleteSettings";
            this.panelDeleteSettings.Size = new System.Drawing.Size(357, 171);
            this.panelDeleteSettings.TabIndex = 24;
            this.panelDeleteSettings.Visible = false;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.button_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Close.BackgroundImage")));
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_Close.Location = new System.Drawing.Point(327, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 26;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // labelAddonName
            // 
            this.labelAddonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddonName.ForeColor = System.Drawing.Color.White;
            this.labelAddonName.Location = new System.Drawing.Point(85, 10);
            this.labelAddonName.Name = "labelAddonName";
            this.labelAddonName.Size = new System.Drawing.Size(168, 30);
            this.labelAddonName.TabIndex = 25;
            this.labelAddonName.Text = "Название";
            this.labelAddonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxRealm
            // 
            this.comboBoxRealm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRealm.FormattingEnabled = true;
            this.comboBoxRealm.Location = new System.Drawing.Point(179, 44);
            this.comboBoxRealm.Name = "comboBoxRealm";
            this.comboBoxRealm.Size = new System.Drawing.Size(160, 21);
            this.comboBoxRealm.TabIndex = 24;
            this.comboBoxRealm.TextChanged += new System.EventHandler(this.ComboBoxRealm_TextChanged);
            // 
            // comboBoxPersons
            // 
            this.comboBoxPersons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersons.FormattingEnabled = true;
            this.comboBoxPersons.Location = new System.Drawing.Point(13, 80);
            this.comboBoxPersons.Name = "comboBoxPersons";
            this.comboBoxPersons.Size = new System.Drawing.Size(160, 21);
            this.comboBoxPersons.TabIndex = 23;
            this.comboBoxPersons.TextChanged += new System.EventHandler(this.ComboBoxPersons_TextChanged);
            // 
            // comboBoxSettings
            // 
            this.comboBoxSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSettings.FormattingEnabled = true;
            this.comboBoxSettings.Location = new System.Drawing.Point(179, 80);
            this.comboBoxSettings.Name = "comboBoxSettings";
            this.comboBoxSettings.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSettings.TabIndex = 22;
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(13, 45);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(160, 21);
            this.comboBoxAccount.TabIndex = 21;
            this.comboBoxAccount.TextChanged += new System.EventHandler(this.ComboBoxAccount_TextChanged);
            // 
            // buttonpanelDeleteSettings
            // 
            this.buttonpanelDeleteSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonpanelDeleteSettings.FlatAppearance.BorderSize = 0;
            this.buttonpanelDeleteSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpanelDeleteSettings.ForeColor = System.Drawing.Color.White;
            this.buttonpanelDeleteSettings.Location = new System.Drawing.Point(99, 119);
            this.buttonpanelDeleteSettings.Name = "buttonpanelDeleteSettings";
            this.buttonpanelDeleteSettings.Size = new System.Drawing.Size(150, 35);
            this.buttonpanelDeleteSettings.TabIndex = 20;
            this.buttonpanelDeleteSettings.TabStop = false;
            this.buttonpanelDeleteSettings.Text = "Удалить";
            this.buttonpanelDeleteSettings.UseVisualStyleBackColor = false;
            this.buttonpanelDeleteSettings.Click += new System.EventHandler(this.ButtonpanelDeleteSettings_Click);
            // 
            // panelAddonsViewTitle
            // 
            this.panelAddonsViewTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(159)))));
            this.panelAddonsViewTitle.Controls.Add(this.labelAuthor);
            this.panelAddonsViewTitle.Controls.Add(this.labelCategory);
            this.panelAddonsViewTitle.Controls.Add(this.labelVersion);
            this.panelAddonsViewTitle.Controls.Add(this.labelName);
            this.panelAddonsViewTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddonsViewTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAddonsViewTitle.Name = "panelAddonsViewTitle";
            this.panelAddonsViewTitle.Size = new System.Drawing.Size(900, 40);
            this.panelAddonsViewTitle.TabIndex = 25;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(670, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(180, 40);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Автор";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.ForeColor = System.Drawing.Color.White;
            this.labelCategory.Location = new System.Drawing.Point(470, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(190, 40);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Категория";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(300, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(170, 40);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Версия";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(300, 40);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddonsView
            // 
            this.panelAddonsView.BackColor = System.Drawing.Color.LightGray;
            this.panelAddonsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddonsView.Location = new System.Drawing.Point(0, 40);
            this.panelAddonsView.Margin = new System.Windows.Forms.Padding(0);
            this.panelAddonsView.Name = "panelAddonsView";
            this.panelAddonsView.Size = new System.Drawing.Size(900, 485);
            this.panelAddonsView.TabIndex = 26;
            // 
            // FormAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.panelAddon);
            this.Controls.Add(this.PanelDescription);
            this.Controls.Add(this.panelDeleteSettings);
            this.Controls.Add(this.panelAddonsView);
            this.Controls.Add(this.panelAddonsViewTitle);
            this.Controls.Add(this.buttonLauncher);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_Dowload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddons";
            this.Text = "Установленные аддоны";
            this.Load += new System.EventHandler(this.FormAddons_Load);
            this.PanelDescription.ResumeLayout(false);
            this.panelAddon.ResumeLayout(false);
            this.panelDeleteSettings.ResumeLayout(false);
            this.panelAddonsViewTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Dowload;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button buttonLauncher;
        private System.Windows.Forms.Panel PanelDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Panel panelAddon;
        public System.Windows.Forms.Button buttonIgnore;
        public System.Windows.Forms.Button buttonReinstall;
        public System.Windows.Forms.Button buttonDeleteSettings;
        public System.Windows.Forms.Button buttonGitHub;
        public System.Windows.Forms.Button buttonForum;
        public System.Windows.Forms.Button buttonReportBug;
        public System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelDeleteSettings;
        private System.Windows.Forms.ComboBox comboBoxPersons;
        private System.Windows.Forms.ComboBox comboBoxSettings;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.Button buttonpanelDeleteSettings;
        private System.Windows.Forms.ComboBox comboBoxRealm;
        private System.Windows.Forms.Label labelAddonName;
        public System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Panel panelAddonsViewTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelAddonsView;
        public System.Windows.Forms.Button buttonUpdate;
    }
}
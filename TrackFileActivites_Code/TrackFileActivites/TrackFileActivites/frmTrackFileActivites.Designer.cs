namespace TrackFileActivites
{
    partial class frmTrackFileActivites
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrackFileActivites));
            this.txtSetPath = new System.Windows.Forms.TextBox();
            this.txtWorkPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.btnWorkPath = new System.Windows.Forms.Button();
            this.btnStartTracking = new System.Windows.Forms.Button();
            this.btnStopTracking = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.chkIncludeSubdirectories = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.gbNotifyFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSetPath
            // 
            this.txtSetPath.Location = new System.Drawing.Point(58, 20);
            this.txtSetPath.Name = "txtSetPath";
            this.txtSetPath.Size = new System.Drawing.Size(301, 20);
            this.txtSetPath.TabIndex = 0;
            // 
            // txtWorkPath
            // 
            this.txtWorkPath.Location = new System.Drawing.Point(58, 68);
            this.txtWorkPath.Name = "txtWorkPath";
            this.txtWorkPath.Size = new System.Drawing.Size(301, 20);
            this.txtWorkPath.TabIndex = 1;
            // 
            // btnSetPath
            // 
            this.btnSetPath.Location = new System.Drawing.Point(365, 18);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(30, 23);
            this.btnSetPath.TabIndex = 2;
            this.btnSetPath.Text = "...";
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // btnWorkPath
            // 
            this.btnWorkPath.Location = new System.Drawing.Point(365, 65);
            this.btnWorkPath.Name = "btnWorkPath";
            this.btnWorkPath.Size = new System.Drawing.Size(30, 23);
            this.btnWorkPath.TabIndex = 3;
            this.btnWorkPath.Text = "...";
            this.btnWorkPath.UseVisualStyleBackColor = true;
            this.btnWorkPath.Click += new System.EventHandler(this.btnWorkPath_Click);
            // 
            // btnStartTracking
            // 
            this.btnStartTracking.Location = new System.Drawing.Point(17, 13);
            this.btnStartTracking.Name = "btnStartTracking";
            this.btnStartTracking.Size = new System.Drawing.Size(120, 23);
            this.btnStartTracking.TabIndex = 4;
            this.btnStartTracking.Text = "Start Tracking";
            this.btnStartTracking.UseVisualStyleBackColor = true;
            this.btnStartTracking.Click += new System.EventHandler(this.btnStartTracking_Click);
            // 
            // btnStopTracking
            // 
            this.btnStopTracking.Location = new System.Drawing.Point(157, 13);
            this.btnStopTracking.Name = "btnStopTracking";
            this.btnStopTracking.Size = new System.Drawing.Size(120, 23);
            this.btnStopTracking.TabIndex = 5;
            this.btnStopTracking.Text = "Stop Tracking";
            this.btnStopTracking.UseVisualStyleBackColor = true;
            this.btnStopTracking.Click += new System.EventHandler(this.btnStopTracking_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // cmbFilters
            // 
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Location = new System.Drawing.Point(58, 118);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(105, 21);
            this.cmbFilters.TabIndex = 6;
            this.cmbFilters.Text = "*.*";
            // 
            // chkIncludeSubdirectories
            // 
            this.chkIncludeSubdirectories.AutoSize = true;
            this.chkIncludeSubdirectories.Location = new System.Drawing.Point(223, 118);
            this.chkIncludeSubdirectories.Name = "chkIncludeSubdirectories";
            this.chkIncludeSubdirectories.Size = new System.Drawing.Size(131, 17);
            this.chkIncludeSubdirectories.TabIndex = 7;
            this.chkIncludeSubdirectories.Text = "Include Subdirectories";
            this.chkIncludeSubdirectories.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            // 
            // gbNotifyFilter
            // 
            this.gbNotifyFilter.BackColor = System.Drawing.SystemColors.Window;
            this.gbNotifyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotifyFilter.Location = new System.Drawing.Point(51, 160);
            this.gbNotifyFilter.Name = "gbNotifyFilter";
            this.gbNotifyFilter.Size = new System.Drawing.Size(308, 95);
            this.gbNotifyFilter.TabIndex = 8;
            this.gbNotifyFilter.TabStop = false;
            this.gbNotifyFilter.Text = "Notify Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Log";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnStartTracking);
            this.panel1.Controls.Add(this.btnStopTracking);
            this.panel1.Location = new System.Drawing.Point(51, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 53);
            this.panel1.TabIndex = 12;
            // 
            // frmTrackFileActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(426, 358);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbNotifyFilter);
            this.Controls.Add(this.chkIncludeSubdirectories);
            this.Controls.Add(this.cmbFilters);
            this.Controls.Add(this.btnWorkPath);
            this.Controls.Add(this.btnSetPath);
            this.Controls.Add(this.txtWorkPath);
            this.Controls.Add(this.txtSetPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTrackFileActivites";
            this.Text = "Track File Activites";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSetPath;
        private System.Windows.Forms.TextBox txtWorkPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.Button btnWorkPath;
        private System.Windows.Forms.Button btnStartTracking;
        private System.Windows.Forms.Button btnStopTracking;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.CheckBox chkIncludeSubdirectories;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.GroupBox gbNotifyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}


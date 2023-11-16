
namespace AutoCopy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.fsw = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trigFolderLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.targetFoldersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceFoldersList = new System.Windows.Forms.ListBox();
            this.editTargetFolderButton = new System.Windows.Forms.Button();
            this.toggleListeningButton = new System.Windows.Forms.Button();
            this.removeTargetFolderButton = new System.Windows.Forms.Button();
            this.editSourceFolderButton = new System.Windows.Forms.Button();
            this.addTargetFolderButton = new System.Windows.Forms.Button();
            this.removeSourceFolderButton = new System.Windows.Forms.Button();
            this.selectTriggerButton = new System.Windows.Forms.Button();
            this.addSourceFolderButton = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyFiredRadio = new System.Windows.Forms.RadioButton();
            this.copyAllRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.createCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteCheckbox = new System.Windows.Forms.CheckBox();
            this.changeCheckbox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.IncludeSubdirectories = true;
            this.fsw.NotifyFilter = ((System.IO.NotifyFilters)((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.LastWrite) 
            | System.IO.NotifyFilters.CreationTime)));
            this.fsw.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trigFolderLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.targetFoldersList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sourceFoldersList);
            this.groupBox1.Controls.Add(this.editTargetFolderButton);
            this.groupBox1.Controls.Add(this.toggleListeningButton);
            this.groupBox1.Controls.Add(this.removeTargetFolderButton);
            this.groupBox1.Controls.Add(this.editSourceFolderButton);
            this.groupBox1.Controls.Add(this.addTargetFolderButton);
            this.groupBox1.Controls.Add(this.removeSourceFolderButton);
            this.groupBox1.Controls.Add(this.selectTriggerButton);
            this.groupBox1.Controls.Add(this.addSourceFolderButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders";
            // 
            // trigFolderLabel
            // 
            this.trigFolderLabel.AutoSize = true;
            this.trigFolderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trigFolderLabel.Location = new System.Drawing.Point(290, 255);
            this.trigFolderLabel.Name = "trigFolderLabel";
            this.trigFolderLabel.Size = new System.Drawing.Size(97, 20);
            this.trigFolderLabel.TabIndex = 6;
            this.trigFolderLabel.Text = "Not selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target folders:";
            // 
            // targetFoldersList
            // 
            this.targetFoldersList.FormattingEnabled = true;
            this.targetFoldersList.ItemHeight = 20;
            this.targetFoldersList.Location = new System.Drawing.Point(328, 45);
            this.targetFoldersList.Name = "targetFoldersList";
            this.targetFoldersList.Size = new System.Drawing.Size(297, 144);
            this.targetFoldersList.TabIndex = 4;
            this.targetFoldersList.SelectedIndexChanged += new System.EventHandler(this.targetFoldersList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source folders:";
            // 
            // sourceFoldersList
            // 
            this.sourceFoldersList.FormattingEnabled = true;
            this.sourceFoldersList.ItemHeight = 20;
            this.sourceFoldersList.Location = new System.Drawing.Point(10, 45);
            this.sourceFoldersList.Name = "sourceFoldersList";
            this.sourceFoldersList.Size = new System.Drawing.Size(297, 144);
            this.sourceFoldersList.TabIndex = 4;
            this.sourceFoldersList.SelectedIndexChanged += new System.EventHandler(this.sourceFoldersList_SelectedIndexChanged);
            // 
            // editTargetFolderButton
            // 
            this.editTargetFolderButton.Location = new System.Drawing.Point(429, 194);
            this.editTargetFolderButton.Name = "editTargetFolderButton";
            this.editTargetFolderButton.Size = new System.Drawing.Size(95, 30);
            this.editTargetFolderButton.TabIndex = 2;
            this.editTargetFolderButton.Text = "Edit";
            this.editTargetFolderButton.UseVisualStyleBackColor = true;
            this.editTargetFolderButton.Click += new System.EventHandler(this.editTargetFolderButton_Click);
            // 
            // toggleListeningButton
            // 
            this.toggleListeningButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toggleListeningButton.Location = new System.Drawing.Point(555, 251);
            this.toggleListeningButton.Name = "toggleListeningButton";
            this.toggleListeningButton.Size = new System.Drawing.Size(94, 29);
            this.toggleListeningButton.TabIndex = 3;
            this.toggleListeningButton.Text = "Start";
            this.toggleListeningButton.UseVisualStyleBackColor = true;
            this.toggleListeningButton.Click += new System.EventHandler(this.startListeningButton_Click);
            // 
            // removeTargetFolderButton
            // 
            this.removeTargetFolderButton.Location = new System.Drawing.Point(530, 194);
            this.removeTargetFolderButton.Name = "removeTargetFolderButton";
            this.removeTargetFolderButton.Size = new System.Drawing.Size(95, 30);
            this.removeTargetFolderButton.TabIndex = 2;
            this.removeTargetFolderButton.Text = "Remove";
            this.removeTargetFolderButton.UseVisualStyleBackColor = true;
            this.removeTargetFolderButton.Click += new System.EventHandler(this.removeTargetFolderButton_Click);
            // 
            // editSourceFolderButton
            // 
            this.editSourceFolderButton.Location = new System.Drawing.Point(111, 194);
            this.editSourceFolderButton.Name = "editSourceFolderButton";
            this.editSourceFolderButton.Size = new System.Drawing.Size(95, 30);
            this.editSourceFolderButton.TabIndex = 2;
            this.editSourceFolderButton.Text = "Edit";
            this.editSourceFolderButton.UseVisualStyleBackColor = true;
            this.editSourceFolderButton.Click += new System.EventHandler(this.editSourceFolderButton_Click);
            // 
            // addTargetFolderButton
            // 
            this.addTargetFolderButton.Location = new System.Drawing.Point(328, 194);
            this.addTargetFolderButton.Name = "addTargetFolderButton";
            this.addTargetFolderButton.Size = new System.Drawing.Size(95, 30);
            this.addTargetFolderButton.TabIndex = 2;
            this.addTargetFolderButton.Text = "Add";
            this.addTargetFolderButton.UseVisualStyleBackColor = true;
            this.addTargetFolderButton.Click += new System.EventHandler(this.addTargetFolderButton_Click);
            // 
            // removeSourceFolderButton
            // 
            this.removeSourceFolderButton.Location = new System.Drawing.Point(212, 194);
            this.removeSourceFolderButton.Name = "removeSourceFolderButton";
            this.removeSourceFolderButton.Size = new System.Drawing.Size(95, 30);
            this.removeSourceFolderButton.TabIndex = 2;
            this.removeSourceFolderButton.Text = "Remove";
            this.removeSourceFolderButton.UseVisualStyleBackColor = true;
            this.removeSourceFolderButton.Click += new System.EventHandler(this.removeSourceFolderButton_Click);
            // 
            // selectTriggerButton
            // 
            this.selectTriggerButton.Location = new System.Drawing.Point(10, 250);
            this.selectTriggerButton.Name = "selectTriggerButton";
            this.selectTriggerButton.Size = new System.Drawing.Size(165, 30);
            this.selectTriggerButton.TabIndex = 2;
            this.selectTriggerButton.Text = "Select trigger folder";
            this.toolTip1.SetToolTip(this.selectTriggerButton, "Folder that\'ll be checked for updates");
            this.selectTriggerButton.UseVisualStyleBackColor = true;
            this.selectTriggerButton.Click += new System.EventHandler(this.selectTriggerButton_Click);
            // 
            // addSourceFolderButton
            // 
            this.addSourceFolderButton.Location = new System.Drawing.Point(10, 194);
            this.addSourceFolderButton.Name = "addSourceFolderButton";
            this.addSourceFolderButton.Size = new System.Drawing.Size(95, 30);
            this.addSourceFolderButton.TabIndex = 2;
            this.addSourceFolderButton.Text = "Add";
            this.addSourceFolderButton.UseVisualStyleBackColor = true;
            this.addSourceFolderButton.Click += new System.EventHandler(this.addSourceFolderButton_Click);
            // 
            // fbd
            // 
            this.fbd.RootFolder = System.Environment.SpecialFolder.Recent;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copyFiredRadio);
            this.groupBox2.Controls.Add(this.copyAllRadio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.createCheckbox);
            this.groupBox2.Controls.Add(this.deleteCheckbox);
            this.groupBox2.Controls.Add(this.changeCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(10, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 94);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // copyFiredRadio
            // 
            this.copyFiredRadio.AutoSize = true;
            this.copyFiredRadio.Location = new System.Drawing.Point(221, 49);
            this.copyFiredRadio.Name = "copyFiredRadio";
            this.copyFiredRadio.Size = new System.Drawing.Size(122, 24);
            this.copyFiredRadio.TabIndex = 2;
            this.copyFiredRadio.Text = "Copy trig files";
            this.copyFiredRadio.UseVisualStyleBackColor = true;
            // 
            // copyAllRadio
            // 
            this.copyAllRadio.AutoSize = true;
            this.copyAllRadio.Checked = true;
            this.copyAllRadio.Location = new System.Drawing.Point(101, 49);
            this.copyAllRadio.Name = "copyAllRadio";
            this.copyAllRadio.Size = new System.Drawing.Size(115, 24);
            this.copyAllRadio.TabIndex = 2;
            this.copyAllRadio.TabStop = true;
            this.copyAllRadio.Text = "Copy all files";
            this.copyAllRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Operations:";
            // 
            // createCheckbox
            // 
            this.createCheckbox.AutoSize = true;
            this.createCheckbox.Location = new System.Drawing.Point(101, 19);
            this.createCheckbox.Name = "createCheckbox";
            this.createCheckbox.Size = new System.Drawing.Size(74, 24);
            this.createCheckbox.TabIndex = 0;
            this.createCheckbox.Text = "Create";
            this.createCheckbox.UseVisualStyleBackColor = true;
            // 
            // deleteCheckbox
            // 
            this.deleteCheckbox.AutoSize = true;
            this.deleteCheckbox.Location = new System.Drawing.Point(268, 19);
            this.deleteCheckbox.Name = "deleteCheckbox";
            this.deleteCheckbox.Size = new System.Drawing.Size(75, 24);
            this.deleteCheckbox.TabIndex = 0;
            this.deleteCheckbox.Text = "Delete";
            this.deleteCheckbox.UseVisualStyleBackColor = true;
            // 
            // changeCheckbox
            // 
            this.changeCheckbox.AutoSize = true;
            this.changeCheckbox.Location = new System.Drawing.Point(181, 19);
            this.changeCheckbox.Name = "changeCheckbox";
            this.changeCheckbox.Size = new System.Drawing.Size(81, 24);
            this.changeCheckbox.TabIndex = 0;
            this.changeCheckbox.Text = "Change";
            this.changeCheckbox.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trigger folder:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AutoCopy";
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button toggleListeningButton;
        private System.Windows.Forms.Button addSourceFolderButton;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox sourceFoldersList;
        private System.Windows.Forms.Button removeSourceFolderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox targetFoldersList;
        private System.Windows.Forms.Button editTargetFolderButton;
        private System.Windows.Forms.Button removeTargetFolderButton;
        private System.Windows.Forms.Button editSourceFolderButton;
        private System.Windows.Forms.Button addTargetFolderButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox createCheckbox;
        private System.Windows.Forms.CheckBox deleteCheckbox;
        private System.Windows.Forms.CheckBox changeCheckbox;
        private System.Windows.Forms.RadioButton copyFiredRadio;
        private System.Windows.Forms.RadioButton copyAllRadio;
        private System.Windows.Forms.Button selectTriggerButton;
        private System.Windows.Forms.Label trigFolderLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
    }
}


namespace SardezExer1a.Forms
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
            this.btnAddKitchenware = new System.Windows.Forms.Button();
            this.btnWashKitchenware = new System.Windows.Forms.Button();
            this.btnTopKitchenware = new System.Windows.Forms.Button();
            this.btnWashAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentIDText = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.stStackStatus = new System.Windows.Forms.StatusStrip();
            this.tsStackMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTop = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblArrayItems = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.txtArrayItems = new System.Windows.Forms.TextBox();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.stStackStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddKitchenware
            // 
            this.btnAddKitchenware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKitchenware.Location = new System.Drawing.Point(41, 108);
            this.btnAddKitchenware.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddKitchenware.Name = "btnAddKitchenware";
            this.btnAddKitchenware.Size = new System.Drawing.Size(211, 48);
            this.btnAddKitchenware.TabIndex = 0;
            this.btnAddKitchenware.Text = "[&1] Add Kitchenware";
            this.btnAddKitchenware.UseVisualStyleBackColor = true;
            this.btnAddKitchenware.Click += new System.EventHandler(this.btnAddKitchenware_Click);
            // 
            // btnWashKitchenware
            // 
            this.btnWashKitchenware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWashKitchenware.Location = new System.Drawing.Point(41, 163);
            this.btnWashKitchenware.Name = "btnWashKitchenware";
            this.btnWashKitchenware.Size = new System.Drawing.Size(211, 48);
            this.btnWashKitchenware.TabIndex = 1;
            this.btnWashKitchenware.Text = "[&2] Wash Kitchenware";
            this.btnWashKitchenware.UseVisualStyleBackColor = true;
            this.btnWashKitchenware.Click += new System.EventHandler(this.btnWashKitchenware_Click);
            // 
            // btnTopKitchenware
            // 
            this.btnTopKitchenware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopKitchenware.Location = new System.Drawing.Point(41, 217);
            this.btnTopKitchenware.Name = "btnTopKitchenware";
            this.btnTopKitchenware.Size = new System.Drawing.Size(211, 48);
            this.btnTopKitchenware.TabIndex = 2;
            this.btnTopKitchenware.Text = "[&3] Top Kitchenware";
            this.btnTopKitchenware.UseVisualStyleBackColor = true;
            this.btnTopKitchenware.Click += new System.EventHandler(this.btnTopKitchenware_Click);
            // 
            // btnWashAll
            // 
            this.btnWashAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWashAll.Location = new System.Drawing.Point(41, 274);
            this.btnWashAll.Name = "btnWashAll";
            this.btnWashAll.Size = new System.Drawing.Size(211, 48);
            this.btnWashAll.TabIndex = 3;
            this.btnWashAll.Text = "[&4] Wash All";
            this.btnWashAll.UseVisualStyleBackColor = true;
            this.btnWashAll.Click += new System.EventHandler(this.btnWashAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(41, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(211, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "[&5] Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblNameText);
            this.pnlHeader.Controls.Add(this.lblName);
            this.pnlHeader.Controls.Add(this.lblStudentIDText);
            this.pnlHeader.Controls.Add(this.lblStudentID);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(754, 85);
            this.pnlHeader.TabIndex = 5;
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Location = new System.Drawing.Point(219, 54);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(152, 16);
            this.lblNameText.TabIndex = 6;
            this.lblNameText.Text = "Sardez, Angelito Jr. Ortiz";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(130, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblStudentIDText
            // 
            this.lblStudentIDText.AutoSize = true;
            this.lblStudentIDText.Location = new System.Drawing.Point(219, 34);
            this.lblStudentIDText.Name = "lblStudentIDText";
            this.lblStudentIDText.Size = new System.Drawing.Size(75, 16);
            this.lblStudentIDText.TabIndex = 4;
            this.lblStudentIDText.Text = "2016-30105";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(130, 34);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(83, 16);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(130, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(591, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SardezExer1a – STACKS: A Stack + Array Implementation for CMSC 204: EXERCISE 1";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::SardezExer1a.Properties.Resources.Logo_small;
            this.picLogo.Location = new System.Drawing.Point(3, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(119, 73);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // stStackStatus
            // 
            this.stStackStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStackMessage,
            this.tsSize,
            this.tsTop,
            this.tsLastAction});
            this.stStackStatus.Location = new System.Drawing.Point(0, 399);
            this.stStackStatus.Name = "stStackStatus";
            this.stStackStatus.Size = new System.Drawing.Size(754, 22);
            this.stStackStatus.TabIndex = 6;
            // 
            // tsStackMessage
            // 
            this.tsStackMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsStackMessage.Name = "tsStackMessage";
            this.tsStackMessage.Size = new System.Drawing.Size(84, 17);
            this.tsStackMessage.Text = "Stack\'s Status";
            // 
            // tsSize
            // 
            this.tsSize.Name = "tsSize";
            this.tsSize.Size = new System.Drawing.Size(35, 17);
            this.tsSize.Text = "[Size]";
            // 
            // tsTop
            // 
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(36, 17);
            this.tsTop.Text = "[Top]";
            // 
            // tsLastAction
            // 
            this.tsLastAction.Name = "tsLastAction";
            this.tsLastAction.Size = new System.Drawing.Size(71, 17);
            this.tsLastAction.Text = "[LastAction]";
            // 
            // lblArrayItems
            // 
            this.lblArrayItems.AutoSize = true;
            this.lblArrayItems.Location = new System.Drawing.Point(291, 94);
            this.lblArrayItems.Name = "lblArrayItems";
            this.lblArrayItems.Size = new System.Drawing.Size(125, 16);
            this.lblArrayItems.TabIndex = 1;
            this.lblArrayItems.Text = "Stack\'s Array Items:";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(291, 262);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(52, 16);
            this.lblEvents.TabIndex = 2;
            this.lblEvents.Text = "Events:";
            // 
            // txtArrayItems
            // 
            this.txtArrayItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArrayItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrayItems.Location = new System.Drawing.Point(294, 114);
            this.txtArrayItems.Multiline = true;
            this.txtArrayItems.Name = "txtArrayItems";
            this.txtArrayItems.ReadOnly = true;
            this.txtArrayItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArrayItems.ShortcutsEnabled = false;
            this.txtArrayItems.Size = new System.Drawing.Size(448, 145);
            this.txtArrayItems.TabIndex = 7;
            this.txtArrayItems.TabStop = false;
            // 
            // txtEvents
            // 
            this.txtEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvents.Location = new System.Drawing.Point(294, 281);
            this.txtEvents.Multiline = true;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.ReadOnly = true;
            this.txtEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEvents.ShortcutsEnabled = false;
            this.txtEvents.Size = new System.Drawing.Size(448, 104);
            this.txtEvents.TabIndex = 8;
            this.txtEvents.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 421);
            this.Controls.Add(this.txtEvents);
            this.Controls.Add(this.txtArrayItems);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblArrayItems);
            this.Controls.Add(this.stStackStatus);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWashAll);
            this.Controls.Add(this.btnTopKitchenware);
            this.Controls.Add(this.btnWashKitchenware);
            this.Controls.Add(this.btnAddKitchenware);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(770, 460);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SardezExer1a – STACKS";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.stStackStatus.ResumeLayout(false);
            this.stStackStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddKitchenware;
        private System.Windows.Forms.Button btnWashKitchenware;
        private System.Windows.Forms.Button btnTopKitchenware;
        private System.Windows.Forms.Button btnWashAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.StatusStrip stStackStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsStackMessage;
        private System.Windows.Forms.ToolStripStatusLabel tsSize;
        private System.Windows.Forms.ToolStripStatusLabel tsTop;
        private System.Windows.Forms.ToolStripStatusLabel tsLastAction;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblArrayItems;
        private System.Windows.Forms.TextBox txtArrayItems;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentIDText;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblTitle;
    }
}


namespace SardezExer1b.Forms
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
            this.btnFallInLine = new System.Windows.Forms.Button();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.btnGetName = new System.Windows.Forms.Button();
            this.btnClosingTime = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentIDText = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.stQueueStatus = new System.Windows.Forms.StatusStrip();
            this.tsStackMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHead = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTail = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblArrayItems = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.txtQueueItems = new System.Windows.Forms.TextBox();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.stQueueStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFallInLine
            // 
            this.btnFallInLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFallInLine.Location = new System.Drawing.Point(41, 108);
            this.btnFallInLine.Margin = new System.Windows.Forms.Padding(4);
            this.btnFallInLine.Name = "btnFallInLine";
            this.btnFallInLine.Size = new System.Drawing.Size(211, 48);
            this.btnFallInLine.TabIndex = 0;
            this.btnFallInLine.Text = "[&1] Fall in line";
            this.btnFallInLine.UseVisualStyleBackColor = true;
            this.btnFallInLine.Click += new System.EventHandler(this.btnFallInLine_Click);
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetOrder.Location = new System.Drawing.Point(41, 163);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(211, 48);
            this.btnGetOrder.TabIndex = 1;
            this.btnGetOrder.Text = "[&2] Get order";
            this.btnGetOrder.UseVisualStyleBackColor = true;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // btnGetName
            // 
            this.btnGetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetName.Location = new System.Drawing.Point(41, 217);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(211, 48);
            this.btnGetName.TabIndex = 2;
            this.btnGetName.Text = "[&3] Get name";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // btnClosingTime
            // 
            this.btnClosingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosingTime.Location = new System.Drawing.Point(41, 274);
            this.btnClosingTime.Name = "btnClosingTime";
            this.btnClosingTime.Size = new System.Drawing.Size(211, 48);
            this.btnClosingTime.TabIndex = 3;
            this.btnClosingTime.Text = "[&4] Closing time";
            this.btnClosingTime.UseVisualStyleBackColor = true;
            this.btnClosingTime.Click += new System.EventHandler(this.btnClosingTime_Click);
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
            this.pnlHeader.Size = new System.Drawing.Size(784, 85);
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
            this.lblTitle.Size = new System.Drawing.Size(637, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SardezExer1b - QUEUES: A Queue + Linked List Implementation for CMSC 204: EXERCIS" +
    "E 1";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::SardezExer1b.Properties.Resources.Logo_small;
            this.picLogo.Location = new System.Drawing.Point(3, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(119, 73);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // stQueueStatus
            // 
            this.stQueueStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStackMessage,
            this.tsSize,
            this.tsHead,
            this.tsTail,
            this.tsLastAction});
            this.stQueueStatus.Location = new System.Drawing.Point(0, 399);
            this.stQueueStatus.Name = "stQueueStatus";
            this.stQueueStatus.Size = new System.Drawing.Size(784, 22);
            this.stQueueStatus.TabIndex = 6;
            // 
            // tsStackMessage
            // 
            this.tsStackMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsStackMessage.Name = "tsStackMessage";
            this.tsStackMessage.Size = new System.Drawing.Size(89, 17);
            this.tsStackMessage.Text = "Queue\'s Status";
            // 
            // tsSize
            // 
            this.tsSize.Name = "tsSize";
            this.tsSize.Size = new System.Drawing.Size(35, 17);
            this.tsSize.Text = "[Size]";
            // 
            // tsHead
            // 
            this.tsHead.Name = "tsHead";
            this.tsHead.Size = new System.Drawing.Size(43, 17);
            this.tsHead.Text = "[Head]";
            // 
            // tsTail
            // 
            this.tsTail.Name = "tsTail";
            this.tsTail.Size = new System.Drawing.Size(34, 17);
            this.tsTail.Text = "[Tail]";
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
            this.lblArrayItems.Size = new System.Drawing.Size(165, 16);
            this.lblArrayItems.TabIndex = 1;
            this.lblArrayItems.Text = "Queue\'s Node Data Items:";
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
            // txtQueueItems
            // 
            this.txtQueueItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueueItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueueItems.Location = new System.Drawing.Point(294, 114);
            this.txtQueueItems.Multiline = true;
            this.txtQueueItems.Name = "txtQueueItems";
            this.txtQueueItems.ReadOnly = true;
            this.txtQueueItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueueItems.ShortcutsEnabled = false;
            this.txtQueueItems.Size = new System.Drawing.Size(478, 145);
            this.txtQueueItems.TabIndex = 7;
            this.txtQueueItems.TabStop = false;
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
            this.txtEvents.Size = new System.Drawing.Size(478, 104);
            this.txtEvents.TabIndex = 8;
            this.txtEvents.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.txtEvents);
            this.Controls.Add(this.txtQueueItems);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblArrayItems);
            this.Controls.Add(this.stQueueStatus);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClosingTime);
            this.Controls.Add(this.btnGetName);
            this.Controls.Add(this.btnGetOrder);
            this.Controls.Add(this.btnFallInLine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 460);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SardezExer1b – QUEUES";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.stQueueStatus.ResumeLayout(false);
            this.stQueueStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFallInLine;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.Button btnGetName;
        private System.Windows.Forms.Button btnClosingTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.StatusStrip stQueueStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsStackMessage;
        private System.Windows.Forms.ToolStripStatusLabel tsSize;
        private System.Windows.Forms.ToolStripStatusLabel tsHead;
        private System.Windows.Forms.ToolStripStatusLabel tsLastAction;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblArrayItems;
        private System.Windows.Forms.TextBox txtQueueItems;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentIDText;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripStatusLabel tsTail;
    }
}


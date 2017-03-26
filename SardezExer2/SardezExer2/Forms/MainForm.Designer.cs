namespace SardezExer2.Forms
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMinimum = new System.Windows.Forms.Button();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.btnSuccessor = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentIDText = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.stBSTStatus = new System.Windows.Forms.StatusStrip();
            this.tsStackMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRoot = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblArrayItems = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.txtBSTItems = new System.Windows.Forms.TextBox();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.btnPredecessor = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.stBSTStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(19, 107);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 48);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "[&1] Insert node to binary tree";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(19, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 48);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "[&2] Delete node from binary tree";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMinimum
            // 
            this.btnMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimum.Location = new System.Drawing.Point(19, 216);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(157, 48);
            this.btnMinimum.TabIndex = 2;
            this.btnMinimum.Text = "[&3] Minimum";
            this.btnMinimum.UseVisualStyleBackColor = true;
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimum_Click);
            // 
            // btnMaximum
            // 
            this.btnMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximum.Location = new System.Drawing.Point(19, 270);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(157, 48);
            this.btnMaximum.TabIndex = 3;
            this.btnMaximum.Text = "[&4] Maximum";
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // btnSuccessor
            // 
            this.btnSuccessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccessor.Location = new System.Drawing.Point(19, 325);
            this.btnSuccessor.Name = "btnSuccessor";
            this.btnSuccessor.Size = new System.Drawing.Size(157, 48);
            this.btnSuccessor.TabIndex = 4;
            this.btnSuccessor.Text = "[&5] Successor";
            this.btnSuccessor.UseVisualStyleBackColor = true;
            this.btnSuccessor.Click += new System.EventHandler(this.btnSuccessor_Click);
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
            this.lblTitle.Size = new System.Drawing.Size(594, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SardezExer2 - BST: A Binary Search Tree Implementation for CMSC 204: EXERCISE 2";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::SardezExer2.Properties.Resources.Logo_small;
            this.picLogo.Location = new System.Drawing.Point(3, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(119, 73);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // stBSTStatus
            // 
            this.stBSTStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStackMessage,
            this.tsCount,
            this.tsRoot,
            this.tsLastAction});
            this.stBSTStatus.Location = new System.Drawing.Point(0, 399);
            this.stBSTStatus.Name = "stBSTStatus";
            this.stBSTStatus.Size = new System.Drawing.Size(784, 22);
            this.stBSTStatus.TabIndex = 6;
            // 
            // tsStackMessage
            // 
            this.tsStackMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsStackMessage.Name = "tsStackMessage";
            this.tsStackMessage.Size = new System.Drawing.Size(75, 17);
            this.tsStackMessage.Text = "BST\'s Status";
            // 
            // tsCount
            // 
            this.tsCount.Name = "tsCount";
            this.tsCount.Size = new System.Drawing.Size(48, 17);
            this.tsCount.Text = "[Count]";
            // 
            // tsRoot
            // 
            this.tsRoot.Name = "tsRoot";
            this.tsRoot.Size = new System.Drawing.Size(40, 17);
            this.tsRoot.Text = "[Root]";
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
            this.lblArrayItems.Location = new System.Drawing.Point(359, 95);
            this.lblArrayItems.Name = "lblArrayItems";
            this.lblArrayItems.Size = new System.Drawing.Size(152, 16);
            this.lblArrayItems.TabIndex = 1;
            this.lblArrayItems.Text = "BST\'s Node Data Items:";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(359, 212);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(52, 16);
            this.lblEvents.TabIndex = 2;
            this.lblEvents.Text = "Events:";
            // 
            // txtBSTItems
            // 
            this.txtBSTItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBSTItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBSTItems.Location = new System.Drawing.Point(362, 114);
            this.txtBSTItems.Multiline = true;
            this.txtBSTItems.Name = "txtBSTItems";
            this.txtBSTItems.ReadOnly = true;
            this.txtBSTItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBSTItems.ShortcutsEnabled = false;
            this.txtBSTItems.Size = new System.Drawing.Size(410, 97);
            this.txtBSTItems.TabIndex = 7;
            this.txtBSTItems.TabStop = false;
            // 
            // txtEvents
            // 
            this.txtEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvents.Location = new System.Drawing.Point(362, 231);
            this.txtEvents.Multiline = true;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.ReadOnly = true;
            this.txtEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEvents.ShortcutsEnabled = false;
            this.txtEvents.Size = new System.Drawing.Size(410, 165);
            this.txtEvents.TabIndex = 8;
            this.txtEvents.TabStop = false;
            // 
            // btnPredecessor
            // 
            this.btnPredecessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredecessor.Location = new System.Drawing.Point(188, 107);
            this.btnPredecessor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPredecessor.Name = "btnPredecessor";
            this.btnPredecessor.Size = new System.Drawing.Size(157, 48);
            this.btnPredecessor.TabIndex = 5;
            this.btnPredecessor.Text = "[&6] Predecessor";
            this.btnPredecessor.UseVisualStyleBackColor = true;
            this.btnPredecessor.Click += new System.EventHandler(this.btnPredecessor_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(188, 163);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 48);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "[&7] Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(188, 216);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(157, 48);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "[&8] Print BST";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(188, 270);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 48);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "[&9] Clear BST";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(188, 325);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 48);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "[1&0] Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPredecessor);
            this.Controls.Add(this.txtEvents);
            this.Controls.Add(this.txtBSTItems);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblArrayItems);
            this.Controls.Add(this.stBSTStatus);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnSuccessor);
            this.Controls.Add(this.btnMaximum);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 460);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SardezExer2 – BST";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.stBSTStatus.ResumeLayout(false);
            this.stBSTStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMinimum;
        private System.Windows.Forms.Button btnMaximum;
        private System.Windows.Forms.Button btnSuccessor;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.StatusStrip stBSTStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsStackMessage;
        private System.Windows.Forms.ToolStripStatusLabel tsCount;
        private System.Windows.Forms.ToolStripStatusLabel tsRoot;
        private System.Windows.Forms.ToolStripStatusLabel tsLastAction;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblArrayItems;
        private System.Windows.Forms.TextBox txtBSTItems;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentIDText;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPredecessor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}


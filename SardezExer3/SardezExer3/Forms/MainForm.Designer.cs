namespace SardezExer3.Forms
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
            this.btnDFSTraversal = new System.Windows.Forms.Button();
            this.btnBFSTraversal = new System.Windows.Forms.Button();
            this.btnSearchG1DFS = new System.Windows.Forms.Button();
            this.btnSeachG2BFS = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentIDText = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.stStackStatus = new System.Windows.Forms.StatusStrip();
            this.tsGraphMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAdjacencyList = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.txtAdjacencyList = new System.Windows.Forms.TextBox();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.btnRecurDFSTraversal = new System.Windows.Forms.Button();
            this.btnSearchG1BFS = new System.Windows.Forms.Button();
            this.btnSearchG2DFS = new System.Windows.Forms.Button();
            this.btnSearchG1RecDFS = new System.Windows.Forms.Button();
            this.btnSearchG2RecDFS = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.stStackStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDFSTraversal
            // 
            this.btnDFSTraversal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFSTraversal.Location = new System.Drawing.Point(9, 108);
            this.btnDFSTraversal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDFSTraversal.Name = "btnDFSTraversal";
            this.btnDFSTraversal.Size = new System.Drawing.Size(158, 48);
            this.btnDFSTraversal.TabIndex = 0;
            this.btnDFSTraversal.Text = "[&1] Perform Depth First Traversal";
            this.btnDFSTraversal.UseVisualStyleBackColor = true;
            this.btnDFSTraversal.Click += new System.EventHandler(this.btnDFSTraversal_Click);
            // 
            // btnBFSTraversal
            // 
            this.btnBFSTraversal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFSTraversal.Location = new System.Drawing.Point(9, 163);
            this.btnBFSTraversal.Name = "btnBFSTraversal";
            this.btnBFSTraversal.Size = new System.Drawing.Size(158, 48);
            this.btnBFSTraversal.TabIndex = 1;
            this.btnBFSTraversal.Text = "[&2] Perform Breadth Fist Traversal";
            this.btnBFSTraversal.UseVisualStyleBackColor = true;
            this.btnBFSTraversal.Click += new System.EventHandler(this.btnBFSTraversal_Click);
            // 
            // btnSearchG1DFS
            // 
            this.btnSearchG1DFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchG1DFS.Location = new System.Drawing.Point(9, 217);
            this.btnSearchG1DFS.Name = "btnSearchG1DFS";
            this.btnSearchG1DFS.Size = new System.Drawing.Size(158, 48);
            this.btnSearchG1DFS.TabIndex = 2;
            this.btnSearchG1DFS.Text = "[&3] Search Graph 1 (DFS)";
            this.btnSearchG1DFS.UseVisualStyleBackColor = true;
            this.btnSearchG1DFS.Click += new System.EventHandler(this.btnSearchG1DFS_Click);
            // 
            // btnSeachG2BFS
            // 
            this.btnSeachG2BFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeachG2BFS.Location = new System.Drawing.Point(9, 274);
            this.btnSeachG2BFS.Name = "btnSeachG2BFS";
            this.btnSeachG2BFS.Size = new System.Drawing.Size(158, 48);
            this.btnSeachG2BFS.TabIndex = 3;
            this.btnSeachG2BFS.Text = "[&4] Search Graph 2 (BFS)";
            this.btnSeachG2BFS.UseVisualStyleBackColor = true;
            this.btnSeachG2BFS.Click += new System.EventHandler(this.btnSeachG2BFS_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(9, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 48);
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
            this.pnlHeader.Size = new System.Drawing.Size(774, 85);
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
            this.lblTitle.Size = new System.Drawing.Size(535, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SardezExer3 - GRAPHS: A Graph Implementation for CMSC 204: EXERCISE 3";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::SardezExer3.Properties.Resources.Logo_small;
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
            this.tsGraphMessage,
            this.tsLastAction});
            this.stStackStatus.Location = new System.Drawing.Point(0, 409);
            this.stStackStatus.Name = "stStackStatus";
            this.stStackStatus.Size = new System.Drawing.Size(774, 22);
            this.stStackStatus.TabIndex = 6;
            // 
            // tsGraphMessage
            // 
            this.tsGraphMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsGraphMessage.Name = "tsGraphMessage";
            this.tsGraphMessage.Size = new System.Drawing.Size(88, 17);
            this.tsGraphMessage.Text = "Graphs\' Status";
            // 
            // tsLastAction
            // 
            this.tsLastAction.Name = "tsLastAction";
            this.tsLastAction.Size = new System.Drawing.Size(71, 17);
            this.tsLastAction.Text = "[LastAction]";
            // 
            // lblAdjacencyList
            // 
            this.lblAdjacencyList.AutoSize = true;
            this.lblAdjacencyList.Location = new System.Drawing.Point(341, 95);
            this.lblAdjacencyList.Name = "lblAdjacencyList";
            this.lblAdjacencyList.Size = new System.Drawing.Size(155, 16);
            this.lblAdjacencyList.TabIndex = 1;
            this.lblAdjacencyList.Text = "Graphs\' Adjacency Lists:";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(341, 300);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(52, 16);
            this.lblEvents.TabIndex = 2;
            this.lblEvents.Text = "Events:";
            // 
            // txtAdjacencyList
            // 
            this.txtAdjacencyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdjacencyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjacencyList.Location = new System.Drawing.Point(344, 114);
            this.txtAdjacencyList.Multiline = true;
            this.txtAdjacencyList.Name = "txtAdjacencyList";
            this.txtAdjacencyList.ReadOnly = true;
            this.txtAdjacencyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdjacencyList.ShortcutsEnabled = false;
            this.txtAdjacencyList.Size = new System.Drawing.Size(418, 183);
            this.txtAdjacencyList.TabIndex = 10;
            this.txtAdjacencyList.TabStop = false;
            // 
            // txtEvents
            // 
            this.txtEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvents.Location = new System.Drawing.Point(344, 319);
            this.txtEvents.Multiline = true;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.ReadOnly = true;
            this.txtEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEvents.ShortcutsEnabled = false;
            this.txtEvents.Size = new System.Drawing.Size(418, 76);
            this.txtEvents.TabIndex = 11;
            this.txtEvents.TabStop = false;
            // 
            // btnRecurDFSTraversal
            // 
            this.btnRecurDFSTraversal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecurDFSTraversal.Location = new System.Drawing.Point(175, 108);
            this.btnRecurDFSTraversal.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecurDFSTraversal.Name = "btnRecurDFSTraversal";
            this.btnRecurDFSTraversal.Size = new System.Drawing.Size(158, 48);
            this.btnRecurDFSTraversal.TabIndex = 5;
            this.btnRecurDFSTraversal.Text = "[&6] Perform Recr. Depth 1st Traversal";
            this.btnRecurDFSTraversal.UseVisualStyleBackColor = true;
            this.btnRecurDFSTraversal.Click += new System.EventHandler(this.btnRecurDFSTraversal_Click);
            // 
            // btnSearchG1BFS
            // 
            this.btnSearchG1BFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchG1BFS.Location = new System.Drawing.Point(176, 163);
            this.btnSearchG1BFS.Name = "btnSearchG1BFS";
            this.btnSearchG1BFS.Size = new System.Drawing.Size(158, 48);
            this.btnSearchG1BFS.TabIndex = 6;
            this.btnSearchG1BFS.Text = "[&7] Search Graph 1 (BFS)";
            this.btnSearchG1BFS.UseVisualStyleBackColor = true;
            this.btnSearchG1BFS.Click += new System.EventHandler(this.btnSearchG1BFS_Click);
            // 
            // btnSearchG2DFS
            // 
            this.btnSearchG2DFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchG2DFS.Location = new System.Drawing.Point(176, 217);
            this.btnSearchG2DFS.Name = "btnSearchG2DFS";
            this.btnSearchG2DFS.Size = new System.Drawing.Size(158, 48);
            this.btnSearchG2DFS.TabIndex = 7;
            this.btnSearchG2DFS.Text = "[&8] Search Graph 2 (DFS)";
            this.btnSearchG2DFS.UseVisualStyleBackColor = true;
            this.btnSearchG2DFS.Click += new System.EventHandler(this.btnSearchG2DFS_Click);
            // 
            // btnSearchG1RecDFS
            // 
            this.btnSearchG1RecDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchG1RecDFS.Location = new System.Drawing.Point(176, 274);
            this.btnSearchG1RecDFS.Name = "btnSearchG1RecDFS";
            this.btnSearchG1RecDFS.Size = new System.Drawing.Size(158, 48);
            this.btnSearchG1RecDFS.TabIndex = 8;
            this.btnSearchG1RecDFS.Text = "[&9] Search Graph 1 (Recursice DFS)";
            this.btnSearchG1RecDFS.UseVisualStyleBackColor = true;
            this.btnSearchG1RecDFS.Click += new System.EventHandler(this.btnSearchG1RecDFS_Click);
            // 
            // btnSearchG2RecDFS
            // 
            this.btnSearchG2RecDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchG2RecDFS.Location = new System.Drawing.Point(176, 328);
            this.btnSearchG2RecDFS.Name = "btnSearchG2RecDFS";
            this.btnSearchG2RecDFS.Size = new System.Drawing.Size(158, 48);
            this.btnSearchG2RecDFS.TabIndex = 9;
            this.btnSearchG2RecDFS.Text = "[&0] Search Graph 2 (Recursice DFS)";
            this.btnSearchG2RecDFS.UseVisualStyleBackColor = true;
            this.btnSearchG2RecDFS.Click += new System.EventHandler(this.btnSearchG2RecDFS_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 431);
            this.Controls.Add(this.btnSearchG2RecDFS);
            this.Controls.Add(this.btnSearchG1RecDFS);
            this.Controls.Add(this.btnSearchG2DFS);
            this.Controls.Add(this.btnSearchG1BFS);
            this.Controls.Add(this.btnRecurDFSTraversal);
            this.Controls.Add(this.txtEvents);
            this.Controls.Add(this.txtAdjacencyList);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblAdjacencyList);
            this.Controls.Add(this.stStackStatus);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSeachG2BFS);
            this.Controls.Add(this.btnSearchG1DFS);
            this.Controls.Add(this.btnBFSTraversal);
            this.Controls.Add(this.btnDFSTraversal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(790, 470);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SardezExer3 – GRAPHS";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.stStackStatus.ResumeLayout(false);
            this.stStackStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDFSTraversal;
        private System.Windows.Forms.Button btnBFSTraversal;
        private System.Windows.Forms.Button btnSearchG1DFS;
        private System.Windows.Forms.Button btnSeachG2BFS;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.StatusStrip stStackStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsGraphMessage;
        private System.Windows.Forms.ToolStripStatusLabel tsLastAction;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblAdjacencyList;
        private System.Windows.Forms.TextBox txtAdjacencyList;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentIDText;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRecurDFSTraversal;
        private System.Windows.Forms.Button btnSearchG1BFS;
        private System.Windows.Forms.Button btnSearchG2DFS;
        private System.Windows.Forms.Button btnSearchG1RecDFS;
        private System.Windows.Forms.Button btnSearchG2RecDFS;
    }
}


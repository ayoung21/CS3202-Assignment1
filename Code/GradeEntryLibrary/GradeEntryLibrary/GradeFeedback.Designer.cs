namespace GradeEntryLibrary
{
    partial class GradeFeedback
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gradeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonUnsatisfactory = new System.Windows.Forms.RadioButton();
            this.radioButtonAmateur = new System.Windows.Forms.RadioButton();
            this.radioButtonAcceptable = new System.Windows.Forms.RadioButton();
            this.radioButtonExceptional = new System.Windows.Forms.RadioButton();
            this.dataGridViewFeedback = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuDataViewGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedback)).BeginInit();
            this.contextMenuDataViewGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradeGroupBox
            // 
            this.gradeGroupBox.Controls.Add(this.radioButtonUnsatisfactory);
            this.gradeGroupBox.Controls.Add(this.radioButtonAmateur);
            this.gradeGroupBox.Controls.Add(this.radioButtonAcceptable);
            this.gradeGroupBox.Controls.Add(this.radioButtonExceptional);
            this.gradeGroupBox.Location = new System.Drawing.Point(15, 16);
            this.gradeGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gradeGroupBox.Name = "gradeGroupBox";
            this.gradeGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gradeGroupBox.Size = new System.Drawing.Size(150, 104);
            this.gradeGroupBox.TabIndex = 0;
            this.gradeGroupBox.TabStop = false;
            this.gradeGroupBox.Text = "Title";
            // 
            // radioButtonUnsatisfactory
            // 
            this.radioButtonUnsatisfactory.AutoSize = true;
            this.radioButtonUnsatisfactory.Location = new System.Drawing.Point(4, 81);
            this.radioButtonUnsatisfactory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonUnsatisfactory.Name = "radioButtonUnsatisfactory";
            this.radioButtonUnsatisfactory.Size = new System.Drawing.Size(67, 17);
            this.radioButtonUnsatisfactory.TabIndex = 4;
            this.radioButtonUnsatisfactory.TabStop = true;
            this.radioButtonUnsatisfactory.Text = "Option D";
            this.radioButtonUnsatisfactory.UseVisualStyleBackColor = true;
            this.radioButtonUnsatisfactory.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButtonAmateur
            // 
            this.radioButtonAmateur.AutoSize = true;
            this.radioButtonAmateur.Location = new System.Drawing.Point(4, 59);
            this.radioButtonAmateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAmateur.Name = "radioButtonAmateur";
            this.radioButtonAmateur.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAmateur.TabIndex = 3;
            this.radioButtonAmateur.TabStop = true;
            this.radioButtonAmateur.Text = "Option C";
            this.radioButtonAmateur.UseVisualStyleBackColor = true;
            this.radioButtonAmateur.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButtonAcceptable
            // 
            this.radioButtonAcceptable.AutoSize = true;
            this.radioButtonAcceptable.Location = new System.Drawing.Point(4, 39);
            this.radioButtonAcceptable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAcceptable.Name = "radioButtonAcceptable";
            this.radioButtonAcceptable.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAcceptable.TabIndex = 2;
            this.radioButtonAcceptable.TabStop = true;
            this.radioButtonAcceptable.Text = "Option B";
            this.radioButtonAcceptable.UseVisualStyleBackColor = true;
            this.radioButtonAcceptable.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButtonExceptional
            // 
            this.radioButtonExceptional.AutoSize = true;
            this.radioButtonExceptional.Location = new System.Drawing.Point(4, 17);
            this.radioButtonExceptional.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonExceptional.Name = "radioButtonExceptional";
            this.radioButtonExceptional.Size = new System.Drawing.Size(66, 17);
            this.radioButtonExceptional.TabIndex = 1;
            this.radioButtonExceptional.TabStop = true;
            this.radioButtonExceptional.Text = "Option A";
            this.radioButtonExceptional.UseVisualStyleBackColor = true;
            this.radioButtonExceptional.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // dataGridViewFeedback
            // 
            this.dataGridViewFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add,
            this.Comment});
            this.dataGridViewFeedback.ContextMenuStrip = this.contextMenuDataViewGrid;
            this.dataGridViewFeedback.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridViewFeedback.Location = new System.Drawing.Point(172, 16);
            this.dataGridViewFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFeedback.Name = "dataGridViewFeedback";
            this.dataGridViewFeedback.RowHeadersVisible = false;
            this.dataGridViewFeedback.RowHeadersWidth = 51;
            this.dataGridViewFeedback.RowTemplate.Height = 24;
            this.dataGridViewFeedback.Size = new System.Drawing.Size(375, 203);
            this.dataGridViewFeedback.TabIndex = 1;
            this.dataGridViewFeedback.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFeedback_CellClick);
            this.dataGridViewFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFeedback_CellContentClick);
            this.dataGridViewFeedback.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFeedback_CellEndEdit);
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.MinimumWidth = 25;
            this.Add.Name = "Add";
            this.Add.Width = 50;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 25;
            this.Comment.Name = "Comment";
            this.Comment.Width = 450;
            // 
            // contextMenuDataViewGrid
            // 
            this.contextMenuDataViewGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem});
            this.contextMenuDataViewGrid.Name = "contextMenuDataViewGrid";
            this.contextMenuDataViewGrid.Size = new System.Drawing.Size(136, 48);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.deselectAllToolStripMenuItem.Text = "Deselect All";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // GradeFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFeedback);
            this.Controls.Add(this.gradeGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GradeFeedback";
            this.Size = new System.Drawing.Size(562, 244);
            this.gradeGroupBox.ResumeLayout(false);
            this.gradeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedback)).EndInit();
            this.contextMenuDataViewGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gradeGroupBox;
        private System.Windows.Forms.RadioButton radioButtonUnsatisfactory;
        private System.Windows.Forms.RadioButton radioButtonAmateur;
        private System.Windows.Forms.RadioButton radioButtonAcceptable;
        private System.Windows.Forms.RadioButton radioButtonExceptional;
        private System.Windows.Forms.DataGridView dataGridViewFeedback;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.ContextMenuStrip contextMenuDataViewGrid;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
    }
}

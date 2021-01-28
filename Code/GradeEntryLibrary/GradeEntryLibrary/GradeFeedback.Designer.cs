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
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.radioButtonUnsatisfactory = new System.Windows.Forms.RadioButton();
            this.radioButtonAmateur = new System.Windows.Forms.RadioButton();
            this.radioButtonAcceptable = new System.Windows.Forms.RadioButton();
            this.radioButtonExceptional = new System.Windows.Forms.RadioButton();
            this.dataGridViewFeedback = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.Controls.Add(this.radioButtonUnsatisfactory);
            this.groupBoxTitle.Controls.Add(this.radioButtonAmateur);
            this.groupBoxTitle.Controls.Add(this.radioButtonAcceptable);
            this.groupBoxTitle.Controls.Add(this.radioButtonExceptional);
            this.groupBoxTitle.Location = new System.Drawing.Point(20, 20);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(200, 128);
            this.groupBoxTitle.TabIndex = 0;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "Title";
            // 
            // radioButtonUnsatisfactory
            // 
            this.radioButtonUnsatisfactory.AutoSize = true;
            this.radioButtonUnsatisfactory.Location = new System.Drawing.Point(6, 100);
            this.radioButtonUnsatisfactory.Name = "radioButtonUnsatisfactory";
            this.radioButtonUnsatisfactory.Size = new System.Drawing.Size(85, 21);
            this.radioButtonUnsatisfactory.TabIndex = 4;
            this.radioButtonUnsatisfactory.TabStop = true;
            this.radioButtonUnsatisfactory.Text = "Option D";
            this.radioButtonUnsatisfactory.UseVisualStyleBackColor = true;
            // 
            // radioButtonAmateur
            // 
            this.radioButtonAmateur.AutoSize = true;
            this.radioButtonAmateur.Location = new System.Drawing.Point(6, 73);
            this.radioButtonAmateur.Name = "radioButtonAmateur";
            this.radioButtonAmateur.Size = new System.Drawing.Size(84, 21);
            this.radioButtonAmateur.TabIndex = 3;
            this.radioButtonAmateur.TabStop = true;
            this.radioButtonAmateur.Text = "Option C";
            this.radioButtonAmateur.UseVisualStyleBackColor = true;
            // 
            // radioButtonAcceptable
            // 
            this.radioButtonAcceptable.AutoSize = true;
            this.radioButtonAcceptable.Location = new System.Drawing.Point(6, 48);
            this.radioButtonAcceptable.Name = "radioButtonAcceptable";
            this.radioButtonAcceptable.Size = new System.Drawing.Size(84, 21);
            this.radioButtonAcceptable.TabIndex = 2;
            this.radioButtonAcceptable.TabStop = true;
            this.radioButtonAcceptable.Text = "Option B";
            this.radioButtonAcceptable.UseVisualStyleBackColor = true;
            // 
            // radioButtonExceptional
            // 
            this.radioButtonExceptional.AutoSize = true;
            this.radioButtonExceptional.Location = new System.Drawing.Point(6, 21);
            this.radioButtonExceptional.Name = "radioButtonExceptional";
            this.radioButtonExceptional.Size = new System.Drawing.Size(84, 21);
            this.radioButtonExceptional.TabIndex = 1;
            this.radioButtonExceptional.TabStop = true;
            this.radioButtonExceptional.Text = "Option A";
            this.radioButtonExceptional.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFeedback
            // 
            this.dataGridViewFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add,
            this.Comment});
            this.dataGridViewFeedback.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridViewFeedback.Location = new System.Drawing.Point(230, 20);
            this.dataGridViewFeedback.Name = "dataGridViewFeedback";
            this.dataGridViewFeedback.RowHeadersVisible = false;
            this.dataGridViewFeedback.RowHeadersWidth = 51;
            this.dataGridViewFeedback.RowTemplate.Height = 24;
            this.dataGridViewFeedback.Size = new System.Drawing.Size(500, 250);
            this.dataGridViewFeedback.TabIndex = 1;
            this.dataGridViewFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFeedback_CellContentClick);
            this.dataGridViewFeedback.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFeedback_CellLeave);
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
            // GradeFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFeedback);
            this.Controls.Add(this.groupBoxTitle);
            this.Name = "GradeFeedback";
            this.Size = new System.Drawing.Size(750, 300);
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTitle;
        private System.Windows.Forms.RadioButton radioButtonUnsatisfactory;
        private System.Windows.Forms.RadioButton radioButtonAmateur;
        private System.Windows.Forms.RadioButton radioButtonAcceptable;
        private System.Windows.Forms.RadioButton radioButtonExceptional;
        private System.Windows.Forms.DataGridView dataGridViewFeedback;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}

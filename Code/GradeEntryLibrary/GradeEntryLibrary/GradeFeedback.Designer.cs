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
            this.radioButtonOptionD = new System.Windows.Forms.RadioButton();
            this.radioButtonOptionC = new System.Windows.Forms.RadioButton();
            this.radioButtonOptionB = new System.Windows.Forms.RadioButton();
            this.radioButtonOptionA = new System.Windows.Forms.RadioButton();
            this.dataGridViewFeedback = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.Controls.Add(this.radioButtonOptionD);
            this.groupBoxTitle.Controls.Add(this.radioButtonOptionC);
            this.groupBoxTitle.Controls.Add(this.radioButtonOptionB);
            this.groupBoxTitle.Controls.Add(this.radioButtonOptionA);
            this.groupBoxTitle.Location = new System.Drawing.Point(20, 20);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(200, 128);
            this.groupBoxTitle.TabIndex = 0;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "Title";
            // 
            // radioButtonOptionD
            // 
            this.radioButtonOptionD.AutoSize = true;
            this.radioButtonOptionD.Location = new System.Drawing.Point(6, 100);
            this.radioButtonOptionD.Name = "radioButtonOptionD";
            this.radioButtonOptionD.Size = new System.Drawing.Size(85, 21);
            this.radioButtonOptionD.TabIndex = 4;
            this.radioButtonOptionD.TabStop = true;
            this.radioButtonOptionD.Text = "Option D";
            this.radioButtonOptionD.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptionC
            // 
            this.radioButtonOptionC.AutoSize = true;
            this.radioButtonOptionC.Location = new System.Drawing.Point(6, 73);
            this.radioButtonOptionC.Name = "radioButtonOptionC";
            this.radioButtonOptionC.Size = new System.Drawing.Size(84, 21);
            this.radioButtonOptionC.TabIndex = 3;
            this.radioButtonOptionC.TabStop = true;
            this.radioButtonOptionC.Text = "Option C";
            this.radioButtonOptionC.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptionB
            // 
            this.radioButtonOptionB.AutoSize = true;
            this.radioButtonOptionB.Location = new System.Drawing.Point(6, 48);
            this.radioButtonOptionB.Name = "radioButtonOptionB";
            this.radioButtonOptionB.Size = new System.Drawing.Size(84, 21);
            this.radioButtonOptionB.TabIndex = 2;
            this.radioButtonOptionB.TabStop = true;
            this.radioButtonOptionB.Text = "Option B";
            this.radioButtonOptionB.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptionA
            // 
            this.radioButtonOptionA.AutoSize = true;
            this.radioButtonOptionA.Location = new System.Drawing.Point(6, 21);
            this.radioButtonOptionA.Name = "radioButtonOptionA";
            this.radioButtonOptionA.Size = new System.Drawing.Size(84, 21);
            this.radioButtonOptionA.TabIndex = 1;
            this.radioButtonOptionA.TabStop = true;
            this.radioButtonOptionA.Text = "Option A";
            this.radioButtonOptionA.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.RadioButton radioButtonOptionD;
        private System.Windows.Forms.RadioButton radioButtonOptionC;
        private System.Windows.Forms.RadioButton radioButtonOptionB;
        private System.Windows.Forms.RadioButton radioButtonOptionA;
        private System.Windows.Forms.DataGridView dataGridViewFeedback;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}

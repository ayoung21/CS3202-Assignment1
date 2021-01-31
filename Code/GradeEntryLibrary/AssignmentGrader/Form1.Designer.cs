
namespace AssignmentGrader
{
    partial class FormAssignmentGrader
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
            this.tabControlAssignmentFeedback = new System.Windows.Forms.TabControl();
            this.tabPageFunctionality = new System.Windows.Forms.TabPage();
            this.gradeFeedbackFunctionality = new GradeEntryLibrary.GradeFeedback();
            this.tabPageImplementation = new System.Windows.Forms.TabPage();
            this.gradeFeedbackImplementation = new GradeEntryLibrary.GradeFeedback();
            this.tabPageDocumentation = new System.Windows.Forms.TabPage();
            this.gradeFeedbackDocumentation = new GradeEntryLibrary.GradeFeedback();
            this.textBoxGradeSummary = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelGradeSummary = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlAssignmentFeedback.SuspendLayout();
            this.tabPageFunctionality.SuspendLayout();
            this.tabPageImplementation.SuspendLayout();
            this.tabPageDocumentation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAssignmentFeedback
            // 
            this.tabControlAssignmentFeedback.Controls.Add(this.tabPageFunctionality);
            this.tabControlAssignmentFeedback.Controls.Add(this.tabPageImplementation);
            this.tabControlAssignmentFeedback.Controls.Add(this.tabPageDocumentation);
            this.tabControlAssignmentFeedback.Location = new System.Drawing.Point(9, 39);
            this.tabControlAssignmentFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlAssignmentFeedback.Name = "tabControlAssignmentFeedback";
            this.tabControlAssignmentFeedback.SelectedIndex = 0;
            this.tabControlAssignmentFeedback.Size = new System.Drawing.Size(582, 285);
            this.tabControlAssignmentFeedback.TabIndex = 0;
            // 
            // tabPageFunctionality
            // 
            this.tabPageFunctionality.Controls.Add(this.gradeFeedbackFunctionality);
            this.tabPageFunctionality.Location = new System.Drawing.Point(4, 22);
            this.tabPageFunctionality.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageFunctionality.Name = "tabPageFunctionality";
            this.tabPageFunctionality.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageFunctionality.Size = new System.Drawing.Size(574, 259);
            this.tabPageFunctionality.TabIndex = 0;
            this.tabPageFunctionality.Text = "Functionality";
            this.tabPageFunctionality.UseVisualStyleBackColor = true;
            // 
            // gradeFeedbackFunctionality
            // 
            this.gradeFeedbackFunctionality.Location = new System.Drawing.Point(9, 5);
            this.gradeFeedbackFunctionality.Margin = new System.Windows.Forms.Padding(2);
            this.gradeFeedbackFunctionality.Name = "gradeFeedbackFunctionality";
            this.gradeFeedbackFunctionality.RadioButtonAcceptableValue = 2;
            this.gradeFeedbackFunctionality.RadioButtonAmateurValue = 1;
            this.gradeFeedbackFunctionality.RadioButtonExceptionalValue = 3;
            this.gradeFeedbackFunctionality.RadioButtonUnsatisfactoryValue = 0;
            this.gradeFeedbackFunctionality.Size = new System.Drawing.Size(562, 244);
            this.gradeFeedbackFunctionality.TabIndex = 0;
            // 
            // tabPageImplementation
            // 
            this.tabPageImplementation.Controls.Add(this.gradeFeedbackImplementation);
            this.tabPageImplementation.Location = new System.Drawing.Point(4, 22);
            this.tabPageImplementation.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageImplementation.Name = "tabPageImplementation";
            this.tabPageImplementation.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageImplementation.Size = new System.Drawing.Size(574, 259);
            this.tabPageImplementation.TabIndex = 1;
            this.tabPageImplementation.Text = "Implementation";
            this.tabPageImplementation.UseVisualStyleBackColor = true;
            // 
            // gradeFeedbackImplementation
            // 
            this.gradeFeedbackImplementation.Location = new System.Drawing.Point(9, 5);
            this.gradeFeedbackImplementation.Margin = new System.Windows.Forms.Padding(2);
            this.gradeFeedbackImplementation.Name = "gradeFeedbackImplementation";
            this.gradeFeedbackImplementation.RadioButtonAcceptableValue = 2;
            this.gradeFeedbackImplementation.RadioButtonAmateurValue = 1;
            this.gradeFeedbackImplementation.RadioButtonExceptionalValue = 3;
            this.gradeFeedbackImplementation.RadioButtonUnsatisfactoryValue = 0;
            this.gradeFeedbackImplementation.Size = new System.Drawing.Size(562, 244);
            this.gradeFeedbackImplementation.TabIndex = 0;
            // 
            // tabPageDocumentation
            // 
            this.tabPageDocumentation.Controls.Add(this.gradeFeedbackDocumentation);
            this.tabPageDocumentation.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocumentation.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDocumentation.Name = "tabPageDocumentation";
            this.tabPageDocumentation.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDocumentation.Size = new System.Drawing.Size(574, 259);
            this.tabPageDocumentation.TabIndex = 2;
            this.tabPageDocumentation.Text = "Documentation";
            this.tabPageDocumentation.UseVisualStyleBackColor = true;
            // 
            // gradeFeedbackDocumentation
            // 
            this.gradeFeedbackDocumentation.Location = new System.Drawing.Point(9, 5);
            this.gradeFeedbackDocumentation.Margin = new System.Windows.Forms.Padding(2);
            this.gradeFeedbackDocumentation.Name = "gradeFeedbackDocumentation";
            this.gradeFeedbackDocumentation.RadioButtonAcceptableValue = 2;
            this.gradeFeedbackDocumentation.RadioButtonAmateurValue = 1;
            this.gradeFeedbackDocumentation.RadioButtonExceptionalValue = 3;
            this.gradeFeedbackDocumentation.RadioButtonUnsatisfactoryValue = 0;
            this.gradeFeedbackDocumentation.Size = new System.Drawing.Size(562, 244);
            this.gradeFeedbackDocumentation.TabIndex = 0;
            // 
            // textBoxGradeSummary
            // 
            this.textBoxGradeSummary.Location = new System.Drawing.Point(9, 382);
            this.textBoxGradeSummary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGradeSummary.Multiline = true;
            this.textBoxGradeSummary.Name = "textBoxGradeSummary";
            this.textBoxGradeSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGradeSummary.Size = new System.Drawing.Size(580, 110);
            this.textBoxGradeSummary.TabIndex = 1;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(178, 514);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 32);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(311, 514);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 32);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelGradeSummary
            // 
            this.labelGradeSummary.AutoSize = true;
            this.labelGradeSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradeSummary.Location = new System.Drawing.Point(9, 359);
            this.labelGradeSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGradeSummary.Name = "labelGradeSummary";
            this.labelGradeSummary.Size = new System.Drawing.Size(111, 17);
            this.labelGradeSummary.TabIndex = 4;
            this.labelGradeSummary.Text = "Grade Summary";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // FormAssignmentGrader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 557);
            this.Controls.Add(this.labelGradeSummary);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxGradeSummary);
            this.Controls.Add(this.tabControlAssignmentFeedback);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAssignmentGrader";
            this.Text = "Assignment Grader by Andrew Young";
            this.tabControlAssignmentFeedback.ResumeLayout(false);
            this.tabPageFunctionality.ResumeLayout(false);
            this.tabPageImplementation.ResumeLayout(false);
            this.tabPageDocumentation.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAssignmentFeedback;
        private System.Windows.Forms.TabPage tabPageFunctionality;
        private GradeEntryLibrary.GradeFeedback gradeFeedbackFunctionality;
        private System.Windows.Forms.TabPage tabPageImplementation;
        private System.Windows.Forms.TabPage tabPageDocumentation;
        private GradeEntryLibrary.GradeFeedback gradeFeedbackImplementation;
        private GradeEntryLibrary.GradeFeedback gradeFeedbackDocumentation;
        private System.Windows.Forms.TextBox textBoxGradeSummary;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelGradeSummary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}


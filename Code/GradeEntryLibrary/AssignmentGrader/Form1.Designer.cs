
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
            this.tabPageImplementation = new System.Windows.Forms.TabPage();
            this.tabPageDocumentation = new System.Windows.Forms.TabPage();
            this.textBoxGradeSummary = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelGradeSummary = new System.Windows.Forms.Label();
            this.gradeFeedbackFunctionality = new GradeEntryLibrary.GradeFeedback();
            this.gradeFeedbackImplementation = new GradeEntryLibrary.GradeFeedback();
            this.gradeFeedbackDocumentation = new GradeEntryLibrary.GradeFeedback();
            this.tabControlAssignmentFeedback.SuspendLayout();
            this.tabPageFunctionality.SuspendLayout();
            this.tabPageImplementation.SuspendLayout();
            this.tabPageDocumentation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAssignmentFeedback
            // 
            this.tabControlAssignmentFeedback.Controls.Add(this.tabPageFunctionality);
            this.tabControlAssignmentFeedback.Controls.Add(this.tabPageImplementation);
            this.tabControlAssignmentFeedback.Controls.Add(this.tabPageDocumentation);
            this.tabControlAssignmentFeedback.Location = new System.Drawing.Point(12, 12);
            this.tabControlAssignmentFeedback.Name = "tabControlAssignmentFeedback";
            this.tabControlAssignmentFeedback.SelectedIndex = 0;
            this.tabControlAssignmentFeedback.Size = new System.Drawing.Size(776, 351);
            this.tabControlAssignmentFeedback.TabIndex = 0;
            // 
            // tabPageFunctionality
            // 
            this.tabPageFunctionality.Controls.Add(this.gradeFeedbackFunctionality);
            this.tabPageFunctionality.Location = new System.Drawing.Point(4, 25);
            this.tabPageFunctionality.Name = "tabPageFunctionality";
            this.tabPageFunctionality.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFunctionality.Size = new System.Drawing.Size(768, 322);
            this.tabPageFunctionality.TabIndex = 0;
            this.tabPageFunctionality.Text = "Functionality";
            this.tabPageFunctionality.UseVisualStyleBackColor = true;
            // 
            // tabPageImplementation
            // 
            this.tabPageImplementation.Controls.Add(this.gradeFeedbackImplementation);
            this.tabPageImplementation.Location = new System.Drawing.Point(4, 25);
            this.tabPageImplementation.Name = "tabPageImplementation";
            this.tabPageImplementation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImplementation.Size = new System.Drawing.Size(768, 322);
            this.tabPageImplementation.TabIndex = 1;
            this.tabPageImplementation.Text = "Implementation";
            this.tabPageImplementation.UseVisualStyleBackColor = true;
            // 
            // tabPageDocumentation
            // 
            this.tabPageDocumentation.Controls.Add(this.gradeFeedbackDocumentation);
            this.tabPageDocumentation.Location = new System.Drawing.Point(4, 25);
            this.tabPageDocumentation.Name = "tabPageDocumentation";
            this.tabPageDocumentation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocumentation.Size = new System.Drawing.Size(768, 322);
            this.tabPageDocumentation.TabIndex = 2;
            this.tabPageDocumentation.Text = "Documentation";
            this.tabPageDocumentation.UseVisualStyleBackColor = true;
            // 
            // textBoxGradeSummary
            // 
            this.textBoxGradeSummary.Location = new System.Drawing.Point(12, 416);
            this.textBoxGradeSummary.Multiline = true;
            this.textBoxGradeSummary.Name = "textBoxGradeSummary";
            this.textBoxGradeSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGradeSummary.Size = new System.Drawing.Size(772, 135);
            this.textBoxGradeSummary.TabIndex = 1;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(238, 578);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(100, 40);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(415, 578);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 40);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelGradeSummary
            // 
            this.labelGradeSummary.AutoSize = true;
            this.labelGradeSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradeSummary.Location = new System.Drawing.Point(12, 388);
            this.labelGradeSummary.Name = "labelGradeSummary";
            this.labelGradeSummary.Size = new System.Drawing.Size(131, 20);
            this.labelGradeSummary.TabIndex = 4;
            this.labelGradeSummary.Text = "Grade Summary";
            // 
            // gradeFeedbackFunctionality
            // 
            this.gradeFeedbackFunctionality.Location = new System.Drawing.Point(12, 6);
            this.gradeFeedbackFunctionality.Name = "gradeFeedbackFunctionality";
            this.gradeFeedbackFunctionality.RadioButtonAcceptableValue = 2;
            this.gradeFeedbackFunctionality.RadioButtonAmateurValue = 1;
            this.gradeFeedbackFunctionality.RadioButtonExceptionalValue = 3;
            this.gradeFeedbackFunctionality.RadioButtonUnsatisfactoryValue = 0;
            this.gradeFeedbackFunctionality.Size = new System.Drawing.Size(750, 300);
            this.gradeFeedbackFunctionality.TabIndex = 0;
            // 
            // gradeFeedbackImplementation
            // 
            this.gradeFeedbackImplementation.Location = new System.Drawing.Point(12, 6);
            this.gradeFeedbackImplementation.Name = "gradeFeedbackImplementation";
            this.gradeFeedbackImplementation.RadioButtonAcceptableValue = 2;
            this.gradeFeedbackImplementation.RadioButtonAmateurValue = 1;
            this.gradeFeedbackImplementation.RadioButtonExceptionalValue = 3;
            this.gradeFeedbackImplementation.RadioButtonUnsatisfactoryValue = 0;
            this.gradeFeedbackImplementation.Size = new System.Drawing.Size(750, 300);
            this.gradeFeedbackImplementation.TabIndex = 0;
            // 
            // gradeFeedbackDocumentation
            // 
            this.gradeFeedbackDocumentation.Location = new System.Drawing.Point(12, 6);
            this.gradeFeedbackDocumentation.Name = "gradeFeedbackDocumentation";
            this.gradeFeedbackDocumentation.RadioButtonAcceptableValue = 2;
            this.gradeFeedbackDocumentation.RadioButtonAmateurValue = 1;
            this.gradeFeedbackDocumentation.RadioButtonExceptionalValue = 3;
            this.gradeFeedbackDocumentation.RadioButtonUnsatisfactoryValue = 0;
            this.gradeFeedbackDocumentation.Size = new System.Drawing.Size(750, 300);
            this.gradeFeedbackDocumentation.TabIndex = 0;
            // 
            // FormAssignmentGrader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.labelGradeSummary);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxGradeSummary);
            this.Controls.Add(this.tabControlAssignmentFeedback);
            this.Name = "FormAssignmentGrader";
            this.Text = "Assignment Grader by Andrew Young";
            this.tabControlAssignmentFeedback.ResumeLayout(false);
            this.tabPageFunctionality.ResumeLayout(false);
            this.tabPageImplementation.ResumeLayout(false);
            this.tabPageDocumentation.ResumeLayout(false);
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
    }
}


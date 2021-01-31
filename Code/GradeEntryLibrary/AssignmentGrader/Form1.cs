using AssignmentGrader.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentGrader
{
    public partial class FormAssignmentGrader : Form
    {
        private FeedbackOutputBuilder outputBuilder;
        public FormAssignmentGrader()
        {
            InitializeComponent();
            this.initializeFunctionalityControl();
            this.initializeImplementationControl();
            this.initializeDocumentationControl();

            this.outputBuilder = new FeedbackOutputBuilder(this.tabControlAssignmentFeedback.TabPages);
            this.textBoxGradeSummary.Text = outputBuilder.GetSummary();

            this.gradeFeedbackFunctionality.FeedbackChanged += this.OnFeedbackChanged; 
            this.gradeFeedbackImplementation.FeedbackChanged += this.OnFeedbackChanged; 
            this.gradeFeedbackDocumentation.FeedbackChanged += this.OnFeedbackChanged; 
        }

        private void initializeFunctionalityControl()
        {
            this.gradeFeedbackFunctionality.AddComment("Good job.");
            this.gradeFeedbackFunctionality.AddComment("No issues were discovered.");
            this.gradeFeedbackFunctionality.RadioButtonExceptionalValue = 10;
            this.gradeFeedbackFunctionality.RadioButtonAcceptableValue = 7;
            this.gradeFeedbackFunctionality.RadioButtonAmateurValue = 3;
            this.gradeFeedbackFunctionality.RadioButtonUnsatisfactoryValue = 0;
        }

        private void initializeImplementationControl()
        {
            this.gradeFeedbackImplementation.AddComment("Well done on design and implementation.");
            this.gradeFeedbackImplementation.AddComment("Violations of SRP.");
            this.gradeFeedbackImplementation.AddComment("Violations of DRY");
            this.gradeFeedbackImplementation.RadioButtonExceptionalValue = 7;
            this.gradeFeedbackImplementation.RadioButtonAcceptableValue = 5;
            this.gradeFeedbackImplementation.RadioButtonAmateurValue = 3;
            this.gradeFeedbackImplementation.RadioButtonUnsatisfactoryValue = 1;
        }

        private void initializeDocumentationControl()
        {
            this.gradeFeedbackDocumentation.AddComment("Well done.");
            this.gradeFeedbackDocumentation.AddComment("Missing lots of required documentation.");
        }

        private void OnFeedbackChanged(object sender, EventArgs e)
        {
            this.textBoxGradeSummary.Text = outputBuilder.GetSummary();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBoxGradeSummary.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxGradeSummary.Text = "";
        }
    }
}

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
        public FormAssignmentGrader()
        {
            InitializeComponent();
            this.initializeFunctionalityControl();
            this.initializeImplementationControl();
            this.initializeDocumentationControl();

            this.gradeFeedbackFunctionality.FeedbackChanged += this.OnFeedbackChanged; 
            this.gradeFeedbackImplementation.FeedbackChanged += this.OnFeedbackChanged; 
            this.gradeFeedbackDocumentation.FeedbackChanged += this.OnFeedbackChanged; 
        }

        private void OnFeedbackChanged(object sender, EventArgs e)
        {
            var output = "";
            var list = this.gradeFeedbackImplementation.GetSelectedComments();

            foreach (TabPage currentPage in this.tabControlAssignmentFeedback.TabPages)
            {
                var control =
                    currentPage.Controls.Cast<GradeEntryLibrary.GradeFeedback>().FirstOrDefault(
                    x => x is GradeEntryLibrary.GradeFeedback);

                var selectedButton = control.GetSelectedRadioButton();

                output += $"{currentPage.Text} [{selectedButton.Tag} / {control.MaxPoints}] {Environment.NewLine}";



                //foreach (var currentFeedback in control.GetSelectedComments())
                //{
                //    list.Add(currentFeedback);
                //}

                foreach (var currentFeedback in control.GetSelectedComments())
                {
                    output += currentFeedback + Environment.NewLine;
                }

                output += Environment.NewLine;
            }



            //var comments = "";
            //foreach(var feedback in list)
            //{
            //    comments += feedback + Environment.NewLine;
            //}

            this.textBoxGradeSummary.Text = output;
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
    }
}

using AssignmentGrader.IO;
using GradeEntryLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AssignmentGrader
{
    public partial class FormAssignmentGrader : Form
    {
        private FeedbackOutputBuilder outputBuilder;
        private IList<Control> gradeEntryControls;
        public FormAssignmentGrader()
        {
            InitializeComponent();
            this.initializeFunctionalityControl();
            this.initializeImplementationControl();
            this.initializeDocumentationControl();
            this.initializeEvents();

            this.gradeEntryControls = new List<Control>();
            this.outputBuilder = new FeedbackOutputBuilder(this.tabControlAssignmentFeedback.TabPages);
            this.textBoxGradeSummary.Text = outputBuilder.GetSummary();
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

        private void initializeEvents()
        {
            this.gradeFeedbackFunctionality.FeedbackChanged += this.OnFeedbackChanged;
            this.gradeFeedbackImplementation.FeedbackChanged += this.OnFeedbackChanged;
            this.gradeFeedbackDocumentation.FeedbackChanged += this.OnFeedbackChanged;
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

            foreach (TabPage currentPage in this.tabControlAssignmentFeedback.TabPages)
            {
                var control = currentPage.Controls.Cast<GradeFeedback>()
                    .FirstOrDefault(x => x is GradeFeedback);

                control.ResetCheckboxes();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var content = string.Empty;
            foreach (TabPage currentPage in this.tabControlAssignmentFeedback.TabPages)
            {
                var control = currentPage.Controls.Cast<GradeFeedback>()
                    .FirstOrDefault(x => x is GradeFeedback);

                var comments = control.GetAllComments();
                foreach (var comment in comments)
                {
                    content += comment + ",";
                }

                content += Environment.NewLine;
            }

            File.WriteAllText(@".\\feedback.csv", content);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.clearAllCommentsFromControls();

            IList<string> comments = new List<string>();
            using (var reader = new StreamReader(@".\\feedback.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    // var values = line.Split(',');
                    comments.Add(line);
                }
            }

            int tabIndex = 0;
            foreach (TabPage currentPage in this.tabControlAssignmentFeedback.TabPages)
            {
                var control = currentPage.Controls.Cast<GradeFeedback>()
                    .FirstOrDefault(x => x is GradeFeedback);

                control.LoadComments(comments[tabIndex].Split(','));

                tabIndex++;
            }


        }

        private void clearAllCommentsFromControls()
        {
            this.gradeFeedbackImplementation.DeleteAllComments();
            this.gradeFeedbackFunctionality.DeleteAllComments();
            this.gradeFeedbackDocumentation.DeleteAllComments();
        }
    }
}

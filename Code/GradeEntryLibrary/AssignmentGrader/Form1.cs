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
            this.gradeFeedbackDocumentation.AddComment("Well done on design and implementation.");
            this.gradeFeedbackDocumentation.AddComment("Violations of SRP.");
            this.gradeFeedbackDocumentation.AddComment("Violations of DRY");
        }
    }
}

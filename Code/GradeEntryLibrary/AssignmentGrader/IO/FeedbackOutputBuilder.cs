using GradeEntryLibrary;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.TabControl;

namespace AssignmentGrader.IO
{
    class FeedbackOutputBuilder
    {
        private TabPageCollection tabCollection;

        public FeedbackOutputBuilder(TabPageCollection tabCollection)
        {
            this.tabCollection = tabCollection;
        }

        public string GetSummary()
        {
            var summary = "";

            foreach (TabPage currentPage in this.tabCollection)
            {
                var control = currentPage.Controls.Cast<GradeFeedback>()
                                         .FirstOrDefault(x => x is GradeFeedback);
                if (control != null)
                {
                    var selectedButton = control.GetSelectedRadioButton();

                    summary += $"{currentPage.Text} [{selectedButton.Tag} / {control.MaxPoints}] {Environment.NewLine}";
                    summary += this.buildComments(control);
                    summary += Environment.NewLine;
                }
            }

            return summary;
        }

        private string buildComments(GradeFeedback control)
        {
            var comments = "";
            foreach (var currentFeedback in control.GetSelectedComments())
            {
                comments += currentFeedback + Environment.NewLine;
            }

            return comments;
        }
    }
}

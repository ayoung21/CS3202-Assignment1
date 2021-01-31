using System;
using System.Linq;
using System.Windows.Forms;
using GradeEntryLibrary;
using static System.Windows.Forms.TabControl;

namespace AssignmentGrader.IO
{
    /// <summary>
    ///     Feedback Output Builder class
    /// </summary>
    public class FeedbackOutputBuilder
    {
        #region Data members

        private readonly TabPageCollection tabCollection;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="FeedbackOutputBuilder" /> class.</summary>
        /// <param name="tabCollection">The tab collection.</param>
        public FeedbackOutputBuilder(TabPageCollection tabCollection)
        {
            this.tabCollection = tabCollection;
        }

        #endregion

        #region Methods

        /// <summary>Gets the summary.</summary>
        /// <returns>
        ///     Summary of all values selected
        /// </returns>
        public string GetSummary()
        {
            var totalPoints = 0;
            var currentPoints = 0;
            var summary = string.Empty;

            foreach (TabPage currentPage in this.tabCollection)
            {
                var control = currentPage.Controls.Cast<GradeFeedback>()
                                         .FirstOrDefault(x => x != null);

                if (control != null)
                {
                    var selectedButton = control.GetSelectedRadioButton();
                    totalPoints += control.MaxPoints;
                    currentPoints += (int) selectedButton.Tag;

                    summary += $"{currentPage.Text} [{selectedButton.Tag} / {control.MaxPoints}] {Environment.NewLine}";
                    summary += this.buildComments(control);
                    summary += Environment.NewLine;
                }
            }

            var header = $"Total: [{currentPoints} / {totalPoints}] {Environment.NewLine}";
            return $"{header}{Environment.NewLine}{summary}";
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

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GradeEntryLibrary
{

    /// <summary>
    ///   GradeFeedback class
    /// </summary>
    public partial class GradeFeedback : UserControl
    {
        #region Data members
        private int radioButtonExceptionalValue;
        private int radioButtonAcceptableValue;
        private int radioButtonAmateurValue;
        private int radioButtonUnsatisfactoryValue;
        #endregion

        #region Properties
        /// <summary>Gets the maximum points.</summary>
        /// <value>The maximum points.</value>
        public int MaxPoints { get; private set; }

        /// <summary>Gets or sets the RadioButton exceptional value.</summary>
        /// <value>The RadioButton exceptional value.</value>
        public int RadioButtonExceptionalValue
        {
            get => this.radioButtonExceptionalValue;
            set
            {
                this.MaxPoints = value;
                this.radioButtonExceptionalValue = value;
                this.radioButtonExceptional.Tag = value;
                this.radioButtonExceptional.Text = $@"({value}) {Constants.Constants.TextExceptional}";
            }
        }

        /// <summary>Gets or sets the RadioButton acceptable value.</summary>
        /// <value>The RadioButton acceptable value.</value>
        public int RadioButtonAcceptableValue
        {
            get => this.radioButtonAcceptableValue;
            set
            {
                this.radioButtonAcceptableValue = value;
                this.radioButtonAcceptable.Tag = value;
                this.radioButtonAcceptable.Text = $@"({value}) {Constants.Constants.TextAcceptable}";
            }
        }

        /// <summary>Gets or sets the RadioButton amateur value.</summary>
        /// <value>The RadioButton amateur value.</value>
        public int RadioButtonAmateurValue
        {
            get => this.radioButtonAmateurValue;
            set
            {
                this.radioButtonAmateurValue = value;
                this.radioButtonAmateur.Tag = value;
                this.radioButtonAmateur.Text = $@"({value}) {Constants.Constants.TextAmateur}";
            }
        }

        /// <summary>Gets or sets the RadioButton unsatisfactory value.</summary>
        /// <value>The RadioButton unsatisfactory value.</value>
        public int RadioButtonUnsatisfactoryValue
        {
            get => this.radioButtonUnsatisfactoryValue;
            set
            {
                this.radioButtonUnsatisfactoryValue = value;
                this.radioButtonUnsatisfactory.Tag = value;
                this.radioButtonUnsatisfactory.Text = $@"({value}) {Constants.Constants.TextUnsatisfactory}";
            }
        }
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="GradeFeedback" /> class.</summary>
        public GradeFeedback()
        {
            this.InitializeComponent();
            this.gradeGroupBox.Text = Constants.Constants.DefaultTitle;

            this.radioButtonExceptional.Checked = true;
            this.setDefaultTagsForRadioButtons();
        }

        #endregion

        #region Methods
        /// <summary>Occurs when [feedback changed].</summary>
        public event EventHandler<EventArgs> FeedbackChanged;

        private void onFeedbackChanged()
        {
            this.FeedbackChanged?.Invoke(this, new EventArgs());
        }


        /// <summary>Gets the selected comments.</summary>
        /// <returns>
        ///   List of currently selected comments
        /// </returns>
        public List<string> GetSelectedComments()
        {
            var comments = new List<string>();
            foreach (DataGridViewRow row in this.dataGridViewFeedback.Rows)
            {
                var cell = (DataGridViewCheckBoxCell) row.Cells[0];
                if (Convert.ToBoolean(cell.EditedFormattedValue))
                {
                    var textCell = (DataGridViewTextBoxCell) row.Cells[1];
                    comments.Add(this.GetValueFromCell(textCell));
                }
            }

            return comments;
        }


        /// <summary>Gets all comments.</summary>
        /// <returns>
        ///   List of ALL comments
        /// </returns>
        public List<string> GetAllComments()
        {
            var comments = new List<string>();
            foreach (DataGridViewRow row in this.dataGridViewFeedback.Rows)
            {
                var textCell = (DataGridViewTextBoxCell) row.Cells[1];
                comments.Add(this.GetValueFromCell(textCell));
            }

            return comments;
        }


        /// <summary>Deletes all comments.</summary>
        public void DeleteAllComments()
        {
            this.dataGridViewFeedback.Rows.Clear();
            this.dataGridViewFeedback.Refresh();
        }

        /// <summary>Loads the comments.</summary>
        /// <param name="comments">The comments.</param>
        public void LoadComments(IList<string> comments)
        {
            foreach (var comment in comments)
            {
                this.AddComment(comment);
            }
        }

        /// <summary>Gets the selected RadioButton.</summary>
        /// <returns>
        ///   Selected Radio Button
        /// </returns>
        public RadioButton GetSelectedRadioButton()
        {
            var checkedButton = this.gradeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            return checkedButton;
        }

        /// <summary>Adds the comment.</summary>
        /// <param name="comment">The comment.</param>
        public void AddComment(string comment)
        {
            var newRowIndex = this.dataGridViewFeedback.Rows.Add();
            this.dataGridViewFeedback.Rows[newRowIndex].Cells[Constants.Constants.CommentCellIndex].Value = comment;
        }

        /// <summary>Selects all checkboxes.</summary>
        public void SelectAllCheckboxes()
        {
            foreach (DataGridViewRow row in this.dataGridViewFeedback.Rows)
            {
                ((DataGridViewCheckBoxCell) row.Cells[0]).Value = true;
            }
        }

        /// <summary>Resets the checkboxes.</summary>
        public void ResetCheckboxes()
        {
            foreach (DataGridViewRow row in this.dataGridViewFeedback.Rows)
            {
                ((DataGridViewCheckBoxCell) row.Cells[0]).Value = false;
            }
        }

        /// <summary>Gets the value from cell.</summary>
        /// <param name="cell">The cell.</param>
        /// <returns>
        ///   Current value from cell
        /// </returns>
        private string GetValueFromCell(DataGridViewTextBoxCell cell)
        {
            var cellValue = "";
            if (cell.Value != null)
            {
                cellValue = cell.Value.ToString();
            }

            return cellValue;
        }

        private void setDefaultTagsForRadioButtons()
        {
            this.RadioButtonExceptionalValue = Constants.Constants.DefaultExceptionalValue;
            this.RadioButtonAcceptableValue = Constants.Constants.DefaultAcceptableValue;
            this.RadioButtonAmateurValue = Constants.Constants.DefaultAmateurValue;
            this.RadioButtonUnsatisfactoryValue = Constants.Constants.DefaultUnsatisfactoryValue;
        }

        private void dataGridViewFeedback_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.onFeedbackChanged();
        }

        private void dataGridViewFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.onFeedbackChanged();
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            this.onFeedbackChanged();
        }

        private void dataGridViewFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.onFeedbackChanged();
        }

        #endregion

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SelectAllCheckboxes();
            this.onFeedbackChanged();
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ResetCheckboxes();
            this.onFeedbackChanged();
        }
    }
}
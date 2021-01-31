using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace GradeEntryLibrary
{
    public partial class GradeFeedback: UserControl
    {
        const string DEFUALT_TITLE = "Grade";
        const string TEXT_EXCEPTIONAL = "Exceptional";
        const string TEXT_ACCEPTABLE  = "Acceptable";
        const string TEXT_AMATEUR = "Amateur";
        const string TEXT_UNSATISFACTORY = "Unsatisfactory";
        const int DEFAULT_EXCEPTIONAL_VALUE = 3;
        const int DEFAULT_ACCEPTABLE_VALUE = 2;
        const int DEFAULT_AMATEUR_VALUE = 1;
        const int DEFAULT_UNSATISFACTORY_VALUE = 0;
        const int NUMBER_OF_DEFAULT_COMMENT_ROWS = 3;

        private int _radioButtonExceptionalValue;
        private int _radioButtonAcceptableValue;
        private int _radioButtonAmateurValue;
        private int _radioButtonUnsatisfactoryValue;

        public event EventHandler<EventArgs> FeedbackChanged;

        private void onFeedbackChanged()
        {
            this.FeedbackChanged?.Invoke(this, new EventArgs());
        }

        public List<string> GetSelectedComments()
        {
            var comments = new List<string>();
            foreach (DataGridViewRow row in this.dataGridViewFeedback.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];
                if (Convert.ToBoolean(cell.EditedFormattedValue))
                {
                    DataGridViewTextBoxCell textCell = (DataGridViewTextBoxCell)row.Cells[1];
                    comments.Add(this.GetValueFromCell(textCell));
                }
            }

            return comments;
        }

        public List<string> GetAllComments()
        {
            var comments = new List<string>();
            foreach (DataGridViewRow row in this.dataGridViewFeedback.Rows)
            {
                DataGridViewTextBoxCell textCell = (DataGridViewTextBoxCell)row.Cells[1];
                comments.Add(this.GetValueFromCell(textCell));
            }

            return comments;
        }

        public void DeleteAllComments()
        {
            this.dataGridViewFeedback.Rows.Clear();
            this.dataGridViewFeedback.Refresh();
        }

        public void LoadComments(IList<string> comments)
        {
            var COMMENT_CELL = 1;
            this.DefaultComments.Clear();
            this.dataGridViewFeedback.Rows.Clear();
            this.dataGridViewFeedback.Rows.Add(comments.Count() + 1);

            for (int i = 0; i < comments.Count(); i++)
            {
                this.dataGridViewFeedback.Rows[i].Cells[COMMENT_CELL].Value = comments[i];
            }
        }

        private string GetValueFromCell(DataGridViewTextBoxCell cell)
        {
            var cellValue = "";
            if (cell.Value != null)
            {
                cellValue =  cell.Value.ToString();
            }

            return cellValue;
        }

        public RadioButton GetSelectedRadioButton()
        {
            var checkedButton = this.gradeGroupBox.Controls.OfType<RadioButton>().
                FirstOrDefault(r => r.Checked);

            return checkedButton;
        }

        #region Properties
        public int MaxPoints { get; private set; }
        public int RadioButtonExceptionalValue
        {
            get => _radioButtonExceptionalValue;
            set
            {
                this.MaxPoints = value;
                this._radioButtonExceptionalValue = value;
                this.radioButtonExceptional.Tag = value;
                this.radioButtonExceptional.Text = $"({value}) {TEXT_EXCEPTIONAL}";
            }
        }

        public int RadioButtonAcceptableValue
        {
            get => _radioButtonAcceptableValue;
            set
            {
                this._radioButtonAcceptableValue = value;
                this.radioButtonAcceptable.Tag = value;
                this.radioButtonAcceptable.Text = $"({value}) {TEXT_ACCEPTABLE}";
            }
        }

        public int RadioButtonAmateurValue
        {
            get => _radioButtonAmateurValue;
            set
            {
                this._radioButtonAmateurValue = value;
                this.radioButtonAmateur.Tag = value;
                this.radioButtonAmateur.Text = $"({value}) {TEXT_AMATEUR}";
            }
        }

        public int RadioButtonUnsatisfactoryValue
        {
            get => _radioButtonUnsatisfactoryValue;
            set
            {
                this._radioButtonUnsatisfactoryValue = value;
                this.radioButtonUnsatisfactory.Tag = value;
                this.radioButtonUnsatisfactory.Text = $"({value}) {TEXT_UNSATISFACTORY}";
            }
        }

        private IList<string> DefaultComments { get; set; }
        #endregion

        public GradeFeedback()
        {
            InitializeComponent();
            this.gradeGroupBox.Text = DEFUALT_TITLE;
            this.DefaultComments = new List<string>();
            // this.dataGridViewFeedback.Rows.Add(NUMBER_OF_DEFAULT_COMMENT_ROWS);

            this.radioButtonExceptional.Checked = true;
            this.setDefaultTagsForRadioButtons();
        }

        public void AddComment(string comment)
        {
            const int COMMENT_CELL = 1;
            // this.DefaultComments.Add(comment);

            var newRowIndex = this.dataGridViewFeedback.Rows.Add();
            this.dataGridViewFeedback.Rows[newRowIndex].Cells[COMMENT_CELL].Value = comment;
            //for (int i = 0; i < this.DefaultComments.Count(); i++)
            //{
            //    this.dataGridViewFeedback.Rows[i].Cells[COMMENT_CELL].Value = this.DefaultComments[i];
            //}
        }

        public void SelectAllCheckboxes()
        {
            foreach (DataGridViewRow row in this.dataGridViewFeedback.Rows)
            {
                ((DataGridViewCheckBoxCell)row.Cells[0]).Value = true;
            }
        }

        public void ResetCheckboxes()
        {
            foreach (DataGridViewRow row in this.dataGridViewFeedback.Rows)
            {
                ((DataGridViewCheckBoxCell)row.Cells[0]).Value = false;
            }
        }

        private void setDefaultTagsForRadioButtons()
        {
            this.RadioButtonExceptionalValue = DEFAULT_EXCEPTIONAL_VALUE;
            this.RadioButtonAcceptableValue = DEFAULT_ACCEPTABLE_VALUE; 
            this.RadioButtonAmateurValue = DEFAULT_AMATEUR_VALUE;
            this.RadioButtonUnsatisfactoryValue = DEFAULT_UNSATISFACTORY_VALUE;
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
    }

    public class MessageSentEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}

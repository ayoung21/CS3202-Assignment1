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

        #region Properties
        public int RadioButtonExceptionalValue
        {
            get => _radioButtonExceptionalValue;
            set
            {
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
            this.groupBoxTitle.Text = DEFUALT_TITLE;
            this.DefaultComments = new List<string>();
            this.dataGridViewFeedback.Rows.Add(NUMBER_OF_DEFAULT_COMMENT_ROWS);

            this.setDefaultTagsForRadioButtons();
        }

        public void AddComment(string comment)
        {
            const int COMMENT_CELL = 1;
            this.DefaultComments.Add(comment);
            for (int i = 0; i < this.DefaultComments.Count(); i++)
            {
                this.dataGridViewFeedback.Rows[i].Cells[COMMENT_CELL].Value = this.DefaultComments[i];
            }
        }

        private void setDefaultTagsForRadioButtons()
        {
            this.RadioButtonExceptionalValue = DEFAULT_EXCEPTIONAL_VALUE;
            this.RadioButtonAcceptableValue = DEFAULT_ACCEPTABLE_VALUE; 
            this.RadioButtonAmateurValue = DEFAULT_AMATEUR_VALUE;
            this.RadioButtonUnsatisfactoryValue = DEFAULT_UNSATISFACTORY_VALUE;
        }

        private void dataGridViewFeedback_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: 
        }
    }

    public class FeedbackEventArgs : EventArgs
    {
        public string Feedback { get; set; }
    }
}

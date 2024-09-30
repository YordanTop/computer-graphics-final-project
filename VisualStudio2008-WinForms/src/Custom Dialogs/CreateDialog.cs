using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Draw.src.Custom_Dialogs
{
    public partial class CreateDialog : Form
    {
        public CreateDialog()
        {
            InitializeComponent();
            
        }
        private GroupModel _listOfGroups;
        /// <summary>
        /// Избраната група.
        /// </summary>
        public GroupModel ListOfElements
        {
            get { return _listOfGroups; }
            set { _listOfGroups = value; }
        }

        public object ListOfGroups { get; internal set; }

        /// <summary>
        /// Създаване и въвеждане на параметрите.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ListOfElements = new GroupModel();
            ListOfElements.GroupName = SelectText.Text;
            ListOfElements.GroupList = new List<Shape>();
            Close();
        }
    }
}

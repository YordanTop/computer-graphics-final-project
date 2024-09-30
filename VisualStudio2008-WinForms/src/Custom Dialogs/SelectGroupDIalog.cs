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
    public partial class SelectGroupDIalog : Form
    {
        public SelectGroupDIalog(List<GroupModel> listOfGroups)
        {
            InitializeComponent();
            // Създаване на нови полета с имената на на групите.
            foreach (GroupModel group in listOfGroups)
            {
                SelectCombo.Items.Add(group.GroupName);
            }
            _listOfGroups = listOfGroups;

        }

        private List<GroupModel> _listOfGroups;
        
        /// <summary>
        /// Имената на групите.
        /// </summary>
        private string selected;
        public string SelectedGroupName
        {
            get { return selected; }
            set { selected = value; } 
        }
        /// <summary>
        /// Избраната група.
        /// </summary>
        private GroupModel selectedList;
        public GroupModel SelectedList
        {
            get { return selectedList; }
            set { selectedList = value; }
        }
        /// <summary>
        /// При натискане на бутона се търси сътветната група по име.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectButton_Click(object sender, EventArgs e)
        {
            if(SelectCombo.SelectedIndex != -1)
            {
                SelectedGroupName = SelectCombo.Text;

                foreach (GroupModel group in _listOfGroups)
                {
                    if(group.GroupName.Equals(SelectedGroupName))
                    {
                        SelectedList = group;
                        break;
                    }
                }
            }
            Close();

        }


    }
}

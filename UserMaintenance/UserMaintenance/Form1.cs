using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        #region Variables
        BindingList<User> users = new BindingList<User>();
        #endregion

        public Form1()
        {
            InitializeComponent();
            lbl_LastName.Text = Localization.FullName;
            btn_Add.Text = Localization.Add;
            btn_Remove.Text = Localization.Remove;
            btn_SaveToFile.Text = Localization.SaveToFile;

            lst_Users.DataSource = users;
            lst_Users.ValueMember = "ID";
            lst_Users.DisplayMember = "FullName";

            btn_Add.Click += Btn_Add_Click;
            btn_Remove.Click += Btn_Remove_Click;
            btn_SaveToFile.Click += Btn_SaveToFile_Click;
        }


        #region EventHandlers
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddUserToList();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            DeleteUserFromList((User)lst_Users.SelectedItem);
        }

        private void Btn_SaveToFile_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
        #endregion

        #region Functions
        private void AddUserToList()
        {
            User u = new User { FullName = txt_LastName.Text };
            users.Add(u);
        }

        private void DeleteUserFromList(User seletedUser)
        {
            if (lst_Users.SelectedItem != null) users.Remove(seletedUser);
        }

        private void SaveToFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Text files | *.txt", DefaultExt = "txt" })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    foreach (User u in lst_Users.Items)
                    {
                        sw.WriteLine(u.ID + "," + u.FullName);
                    }
                    sw.Close();
                }
            }
        }

        
        #endregion
    }
}

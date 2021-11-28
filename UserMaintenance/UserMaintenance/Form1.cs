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
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lbl_LastName.Text = Localization.FullName;
            btn_Add.Text = Localization.Add;
            btn_SaveToFile.Text = Localization.SaveToFile;

            lst_Users.DataSource = users;
            lst_Users.ValueMember = "ID";
            lst_Users.DisplayMember = "FullName";

            btn_Add.Click += Btn_Add_Click;
            btn_SaveToFile.Click += Btn_SaveToFile_Click;
        }

        private void Btn_SaveToFile_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddUserToList();
        }



        private void AddUserToList()
        {
            User u = new User { FullName = txt_LastName.Text };
            users.Add(u);
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
    }
}

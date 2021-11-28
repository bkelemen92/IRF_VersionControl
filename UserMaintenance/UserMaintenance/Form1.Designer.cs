
namespace UserMaintenance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_Users = new System.Windows.Forms.ListBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Users
            // 
            this.lst_Users.FormattingEnabled = true;
            this.lst_Users.Location = new System.Drawing.Point(12, 12);
            this.lst_Users.Name = "lst_Users";
            this.lst_Users.Size = new System.Drawing.Size(170, 238);
            this.lst_Users.TabIndex = 0;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(188, 24);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(35, 13);
            this.lbl_LastName.TabIndex = 1;
            this.lbl_LastName.Text = "label1";
            this.lbl_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(258, 21);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(138, 20);
            this.txt_LastName.TabIndex = 3;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(191, 56);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 23);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "button1";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.Location = new System.Drawing.Point(192, 85);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(204, 23);
            this.btn_SaveToFile.TabIndex = 6;
            this.btn_SaveToFile.Text = "button1";
            this.btn_SaveToFile.UseVisualStyleBackColor = true;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(297, 56);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(99, 23);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.Text = "button1";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_SaveToFile);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lst_Users);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Users;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_SaveToFile;
        private System.Windows.Forms.Button btn_Remove;
    }
}


namespace Assignment_2
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
            this.txtBx_Name = new System.Windows.Forms.TextBox();
            this.txtBx_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBx_EmailAddress = new System.Windows.Forms.TextBox();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.txtBx_PostalAddress = new System.Windows.Forms.TextBox();
            this.txtBx_Birthday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_AddContact = new System.Windows.Forms.Button();
            this.button_RemoveContact = new System.Windows.Forms.Button();
            this.button_EditContact = new System.Windows.Forms.Button();
            this.button_SearchContact = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBxRowsTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxRowsCurrent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBx_Name
            // 
            this.txtBx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_Name.Location = new System.Drawing.Point(370, 89);
            this.txtBx_Name.Name = "txtBx_Name";
            this.txtBx_Name.Size = new System.Drawing.Size(195, 22);
            this.txtBx_Name.TabIndex = 0;
            // 
            // txtBx_PhoneNumber
            // 
            this.txtBx_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_PhoneNumber.Location = new System.Drawing.Point(370, 149);
            this.txtBx_PhoneNumber.Name = "txtBx_PhoneNumber";
            this.txtBx_PhoneNumber.Size = new System.Drawing.Size(195, 22);
            this.txtBx_PhoneNumber.TabIndex = 1;
            // 
            // txtBx_EmailAddress
            // 
            this.txtBx_EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_EmailAddress.Location = new System.Drawing.Point(370, 209);
            this.txtBx_EmailAddress.Name = "txtBx_EmailAddress";
            this.txtBx_EmailAddress.Size = new System.Drawing.Size(195, 22);
            this.txtBx_EmailAddress.TabIndex = 2;
            // 
            // listBoxContent
            // 
            this.listBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.ItemHeight = 16;
            this.listBoxContent.Location = new System.Drawing.Point(10, 68);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(351, 324);
            this.listBoxContent.TabIndex = 17;
            this.listBoxContent.TabStop = false;
            this.listBoxContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxContent_MouseClick);
            this.listBoxContent.SelectedIndexChanged += new System.EventHandler(this.listBoxContent_SelectedIndexChanged);
            this.listBoxContent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxContent_MouseDoubleClick);
            // 
            // txtBx_PostalAddress
            // 
            this.txtBx_PostalAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_PostalAddress.Location = new System.Drawing.Point(370, 269);
            this.txtBx_PostalAddress.Name = "txtBx_PostalAddress";
            this.txtBx_PostalAddress.Size = new System.Drawing.Size(195, 22);
            this.txtBx_PostalAddress.TabIndex = 3;
            // 
            // txtBx_Birthday
            // 
            this.txtBx_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_Birthday.Location = new System.Drawing.Point(370, 329);
            this.txtBx_Birthday.Name = "txtBx_Birthday";
            this.txtBx_Birthday.Size = new System.Drawing.Size(195, 22);
            this.txtBx_Birthday.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contacts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Postal Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birthday";
            // 
            // button_AddContact
            // 
            this.button_AddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddContact.Location = new System.Drawing.Point(10, 416);
            this.button_AddContact.Name = "button_AddContact";
            this.button_AddContact.Size = new System.Drawing.Size(75, 45);
            this.button_AddContact.TabIndex = 6;
            this.button_AddContact.Text = "&Add";
            this.button_AddContact.UseVisualStyleBackColor = true;
            this.button_AddContact.Click += new System.EventHandler(this.button_AddContact_Click);
            // 
            // button_RemoveContact
            // 
            this.button_RemoveContact.Enabled = false;
            this.button_RemoveContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveContact.Location = new System.Drawing.Point(130, 416);
            this.button_RemoveContact.Name = "button_RemoveContact";
            this.button_RemoveContact.Size = new System.Drawing.Size(75, 45);
            this.button_RemoveContact.TabIndex = 7;
            this.button_RemoveContact.Text = "&Remove";
            this.button_RemoveContact.UseVisualStyleBackColor = true;
            this.button_RemoveContact.Click += new System.EventHandler(this.button_RemoveContact_Click);
            // 
            // button_EditContact
            // 
            this.button_EditContact.Enabled = false;
            this.button_EditContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditContact.Location = new System.Drawing.Point(250, 416);
            this.button_EditContact.Name = "button_EditContact";
            this.button_EditContact.Size = new System.Drawing.Size(75, 45);
            this.button_EditContact.TabIndex = 8;
            this.button_EditContact.Text = "&Edit / Update";
            this.button_EditContact.UseVisualStyleBackColor = true;
            this.button_EditContact.Click += new System.EventHandler(this.button_EditContact_Click);
            // 
            // button_SearchContact
            // 
            this.button_SearchContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchContact.Location = new System.Drawing.Point(370, 416);
            this.button_SearchContact.Name = "button_SearchContact";
            this.button_SearchContact.Size = new System.Drawing.Size(75, 45);
            this.button_SearchContact.TabIndex = 9;
            this.button_SearchContact.Text = "&Search";
            this.button_SearchContact.UseVisualStyleBackColor = true;
            this.button_SearchContact.Click += new System.EventHandler(this.button_SearchContact_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quit.Location = new System.Drawing.Point(490, 416);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(75, 45);
            this.button_Quit.TabIndex = 10;
            this.button_Quit.Text = "E&xit";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(429, 369);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "&Clear Fields";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 17;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // txtBxRowsTotal
            // 
            this.txtBxRowsTotal.Location = new System.Drawing.Point(198, 43);
            this.txtBxRowsTotal.Name = "txtBxRowsTotal";
            this.txtBxRowsTotal.Size = new System.Drawing.Size(40, 20);
            this.txtBxRowsTotal.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Records Total";
            // 
            // txtBxRowsCurrent
            // 
            this.txtBxRowsCurrent.Location = new System.Drawing.Point(247, 43);
            this.txtBxRowsCurrent.Name = "txtBxRowsCurrent";
            this.txtBxRowsCurrent.Size = new System.Drawing.Size(40, 20);
            this.txtBxRowsCurrent.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Last Selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 475);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBxRowsCurrent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxRowsTotal);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_SearchContact);
            this.Controls.Add(this.button_EditContact);
            this.Controls.Add(this.button_RemoveContact);
            this.Controls.Add(this.button_AddContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_Birthday);
            this.Controls.Add(this.txtBx_PostalAddress);
            this.Controls.Add(this.listBoxContent);
            this.Controls.Add(this.txtBx_EmailAddress);
            this.Controls.Add(this.txtBx_PhoneNumber);
            this.Controls.Add(this.txtBx_Name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Assignment 2 - Contacts Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_Name;
        private System.Windows.Forms.TextBox txtBx_PhoneNumber;
        private System.Windows.Forms.TextBox txtBx_EmailAddress;
        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.TextBox txtBx_PostalAddress;
        private System.Windows.Forms.TextBox txtBx_Birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_AddContact;
        private System.Windows.Forms.Button button_RemoveContact;
        private System.Windows.Forms.Button button_EditContact;
        private System.Windows.Forms.Button button_SearchContact;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBxRowsTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxRowsCurrent;
        private System.Windows.Forms.Label label8;
    }
}


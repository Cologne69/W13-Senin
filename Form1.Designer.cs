namespace W13___Senin
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_PrevAll = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_NextAll = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.txt_playerID = new System.Windows.Forms.TextBox();
            this.lbl_playerID = new System.Windows.Forms.Label();
            this.num_TeamNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_teamNumber = new System.Windows.Forms.Label();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Team = new System.Windows.Forms.ComboBox();
            this.lbl_Available = new System.Windows.Forms.Label();
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.cb_Nationality = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_TeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(462, 481);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(252, 38);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(147, 481);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(252, 38);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_PrevAll
            // 
            this.btn_PrevAll.Location = new System.Drawing.Point(165, 31);
            this.btn_PrevAll.Name = "btn_PrevAll";
            this.btn_PrevAll.Size = new System.Drawing.Size(120, 72);
            this.btn_PrevAll.TabIndex = 2;
            this.btn_PrevAll.Text = "<<";
            this.btn_PrevAll.UseVisualStyleBackColor = true;
            this.btn_PrevAll.Click += new System.EventHandler(this.btn_PrevAll_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(307, 31);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(114, 72);
            this.btn_Prev.TabIndex = 3;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_NextAll
            // 
            this.btn_NextAll.Location = new System.Drawing.Point(583, 31);
            this.btn_NextAll.Name = "btn_NextAll";
            this.btn_NextAll.Size = new System.Drawing.Size(112, 72);
            this.btn_NextAll.TabIndex = 4;
            this.btn_NextAll.Text = ">>";
            this.btn_NextAll.UseVisualStyleBackColor = true;
            this.btn_NextAll.Click += new System.EventHandler(this.btn_NextAll_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(448, 31);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(112, 72);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // txt_playerID
            // 
            this.txt_playerID.Location = new System.Drawing.Point(263, 128);
            this.txt_playerID.Name = "txt_playerID";
            this.txt_playerID.Size = new System.Drawing.Size(200, 26);
            this.txt_playerID.TabIndex = 6;
            // 
            // lbl_playerID
            // 
            this.lbl_playerID.AutoSize = true;
            this.lbl_playerID.Location = new System.Drawing.Point(143, 134);
            this.lbl_playerID.Name = "lbl_playerID";
            this.lbl_playerID.Size = new System.Drawing.Size(73, 20);
            this.lbl_playerID.TabIndex = 7;
            this.lbl_playerID.Text = "Player ID";
            // 
            // num_TeamNumber
            // 
            this.num_TeamNumber.Location = new System.Drawing.Point(263, 401);
            this.num_TeamNumber.Name = "num_TeamNumber";
            this.num_TeamNumber.Size = new System.Drawing.Size(233, 26);
            this.num_TeamNumber.TabIndex = 8;
            this.num_TeamNumber.ValueChanged += new System.EventHandler(this.num_TeamNumber_ValueChanged);
            // 
            // lbl_teamNumber
            // 
            this.lbl_teamNumber.AutoSize = true;
            this.lbl_teamNumber.Location = new System.Drawing.Point(143, 403);
            this.lbl_teamNumber.Name = "lbl_teamNumber";
            this.lbl_teamNumber.Size = new System.Drawing.Size(109, 20);
            this.lbl_teamNumber.TabIndex = 9;
            this.lbl_teamNumber.Text = "Team Number";
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.Location = new System.Drawing.Point(143, 191);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(98, 20);
            this.lbl_playerName.TabIndex = 10;
            this.lbl_playerName.Text = "Player Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Birth Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Team";
            // 
            // cb_Team
            // 
            this.cb_Team.FormattingEnabled = true;
            this.cb_Team.Location = new System.Drawing.Point(263, 339);
            this.cb_Team.Name = "cb_Team";
            this.cb_Team.Size = new System.Drawing.Size(442, 28);
            this.cb_Team.TabIndex = 14;
            this.cb_Team.SelectedIndexChanged += new System.EventHandler(this.cb_Team_SelectedIndexChanged);
            // 
            // lbl_Available
            // 
            this.lbl_Available.AutoSize = true;
            this.lbl_Available.Location = new System.Drawing.Point(552, 403);
            this.lbl_Available.Name = "lbl_Available";
            this.lbl_Available.Size = new System.Drawing.Size(101, 20);
            this.lbl_Available.TabIndex = 15;
            this.lbl_Available.Text = "Not Available";
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Location = new System.Drawing.Point(263, 185);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.Size = new System.Drawing.Size(442, 26);
            this.txt_PlayerName.TabIndex = 16;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Location = new System.Drawing.Point(263, 241);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(442, 26);
            this.dtp_BirthDate.TabIndex = 17;
            // 
            // cb_Nationality
            // 
            this.cb_Nationality.FormattingEnabled = true;
            this.cb_Nationality.Location = new System.Drawing.Point(263, 289);
            this.cb_Nationality.Name = "cb_Nationality";
            this.cb_Nationality.Size = new System.Drawing.Size(442, 28);
            this.cb_Nationality.TabIndex = 19;
            this.cb_Nationality.SelectedIndexChanged += new System.EventHandler(this.cb_Nationality_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 576);
            this.Controls.Add(this.cb_Nationality);
            this.Controls.Add(this.dtp_BirthDate);
            this.Controls.Add(this.txt_PlayerName);
            this.Controls.Add(this.lbl_Available);
            this.Controls.Add(this.cb_Team);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_playerName);
            this.Controls.Add(this.lbl_teamNumber);
            this.Controls.Add(this.num_TeamNumber);
            this.Controls.Add(this.lbl_playerID);
            this.Controls.Add(this.txt_playerID);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_NextAll);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_PrevAll);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_TeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_PrevAll;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_NextAll;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TextBox txt_playerID;
        private System.Windows.Forms.Label lbl_playerID;
        private System.Windows.Forms.NumericUpDown num_TeamNumber;
        private System.Windows.Forms.Label lbl_teamNumber;
        private System.Windows.Forms.Label lbl_playerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Team;
        private System.Windows.Forms.Label lbl_Available;
        private System.Windows.Forms.TextBox txt_PlayerName;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.ComboBox cb_Nationality;
    }
}


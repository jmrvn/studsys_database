namespace databaseprog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtMN = new System.Windows.Forms.TextBox();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.cbCOURSE = new System.Windows.Forms.ComboBox();
            this.lvList = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNEW = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.cbYEAR = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LAST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "FIRST NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "MIDDLE NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ADDRESS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "COURSE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "YEAR";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(213, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(213, 104);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(176, 20);
            this.txtLN.TabIndex = 8;
            this.txtLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLN_KeyPress);
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(213, 145);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(176, 20);
            this.txtFN.TabIndex = 9;
            this.txtFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFN_KeyPress);
            // 
            // txtMN
            // 
            this.txtMN.Location = new System.Drawing.Point(213, 181);
            this.txtMN.Name = "txtMN";
            this.txtMN.Size = new System.Drawing.Size(176, 20);
            this.txtMN.TabIndex = 10;
            this.txtMN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMN_KeyPress);
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.Location = new System.Drawing.Point(213, 218);
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.Size = new System.Drawing.Size(176, 20);
            this.txtADDRESS.TabIndex = 11;
            // 
            // cbCOURSE
            // 
            this.cbCOURSE.FormattingEnabled = true;
            this.cbCOURSE.Location = new System.Drawing.Point(213, 250);
            this.cbCOURSE.Name = "cbCOURSE";
            this.cbCOURSE.Size = new System.Drawing.Size(176, 21);
            this.cbCOURSE.TabIndex = 12;
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmLN,
            this.clmFN,
            this.clm,
            this.clmnAddress,
            this.clmnCourse,
            this.clmYear});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(435, 66);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(562, 358);
            this.lvList.TabIndex = 14;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvList_ColumnWidthChanged);
            this.lvList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvList_ColumnWidthChanging);
            this.lvList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvList_ItemDrag);
            this.lvList.SelectedIndexChanged += new System.EventHandler(this.lvList_SelectedIndexChanged);
            this.lvList.Click += new System.EventHandler(this.lvList_Click);
            this.lvList.DoubleClick += new System.EventHandler(this.lvList_DoubleClick);
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            // 
            // clmLN
            // 
            this.clmLN.Text = "LAST NAME";
            this.clmLN.Width = 84;
            // 
            // clmFN
            // 
            this.clmFN.Text = "FIRST NAME";
            this.clmFN.Width = 94;
            // 
            // clm
            // 
            this.clm.Text = "MIDDLE NAME";
            this.clm.Width = 103;
            // 
            // clmnAddress
            // 
            this.clmnAddress.Text = "ADDRESS";
            this.clmnAddress.Width = 72;
            // 
            // clmnCourse
            // 
            this.clmnCourse.Text = "COURSE";
            // 
            // clmYear
            // 
            this.clmYear.Text = "YEAR";
            // 
            // btnNEW
            // 
            this.btnNEW.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNEW.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNEW.Location = new System.Drawing.Point(37, 346);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(104, 45);
            this.btnNEW.TabIndex = 15;
            this.btnNEW.Text = "NEW";
            this.btnNEW.UseVisualStyleBackColor = false;
            this.btnNEW.EnabledChanged += new System.EventHandler(this.btnNEW_EnabledChanged);
            this.btnNEW.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSAVE.Enabled = false;
            this.btnSAVE.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.Location = new System.Drawing.Point(161, 346);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(104, 45);
            this.btnSAVE.TabIndex = 16;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.EnabledChanged += new System.EventHandler(this.btnSAVE_EnabledChanged);
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEDIT.Enabled = false;
            this.btnEDIT.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Location = new System.Drawing.Point(285, 346);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(104, 45);
            this.btnEDIT.TabIndex = 17;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.EnabledChanged += new System.EventHandler(this.btnEDIT_EnabledChanged);
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUPDATE.Enabled = false;
            this.btnUPDATE.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Location = new System.Drawing.Point(37, 405);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(104, 45);
            this.btnUPDATE.TabIndex = 18;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = false;
            this.btnUPDATE.EnabledChanged += new System.EventHandler(this.btnUPDATE_EnabledChanged);
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDELETE.Enabled = false;
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(161, 405);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(104, 45);
            this.btnDELETE.TabIndex = 19;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.EnabledChanged += new System.EventHandler(this.btnDELETE_EnabledChanged);
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCANCEL.Enabled = false;
            this.btnCANCEL.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.Location = new System.Drawing.Point(285, 405);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(104, 45);
            this.btnCANCEL.TabIndex = 20;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.EnabledChanged += new System.EventHandler(this.btnCANCEL_EnabledChanged);
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // cbYEAR
            // 
            this.cbYEAR.FormattingEnabled = true;
            this.cbYEAR.Location = new System.Drawing.Point(213, 287);
            this.cbYEAR.Name = "cbYEAR";
            this.cbYEAR.Size = new System.Drawing.Size(176, 21);
            this.cbYEAR.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1066, 489);
            this.Controls.Add(this.cbYEAR);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnNEW);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.cbCOURSE);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.txtMN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT SYSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtMN;
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.ComboBox cbCOURSE;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.Button btnNEW;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmLN;
        private System.Windows.Forms.ColumnHeader clmFN;
        private System.Windows.Forms.ColumnHeader clm;
        private System.Windows.Forms.ColumnHeader clmnAddress;
        private System.Windows.Forms.ColumnHeader clmnCourse;
        private System.Windows.Forms.ColumnHeader clmYear;
        private System.Windows.Forms.ComboBox cbYEAR;
    }
}


using System.Drawing;
using System.Windows.Forms;

namespace CalculateProgram
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.IdCustLbl = new System.Windows.Forms.Label();
            this.IdCusTxtb = new System.Windows.Forms.TextBox();
            this.TypeOfCustomeLabel = new System.Windows.Forms.Label();
            this.TypeOfCustomerTxtb = new System.Windows.Forms.ComboBox();
            this.LMonthTxtb = new System.Windows.Forms.TextBox();
            this.LMonthMainLbl = new System.Windows.Forms.Label();
            this.ThisMonthtxtb = new System.Windows.Forms.TextBox();
            this.TMonthMainLbl = new System.Windows.Forms.Label();
            this.HeadingProgramLbl = new System.Windows.Forms.Label();
            this.CalculateBtt = new System.Windows.Forms.Button();
            this.ClearBtt = new System.Windows.Forms.Button();
            this.lvResult = new System.Windows.Forms.ListView();
            this.InforCusLbl = new System.Windows.Forms.Label();
            this.NameCusTxtb = new System.Windows.Forms.TextBox();
            this.NameCusTxtbLbl = new System.Windows.Forms.Label();
            this.numberPeoplerTxtb = new System.Windows.Forms.TextBox();
            this.NumberOfPeopleLbl = new System.Windows.Forms.Label();
            this.findInforLabel = new System.Windows.Forms.Label();
            this.SearchTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBtt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // IdCustLbl
            // 
            this.IdCustLbl.AutoSize = true;
            this.IdCustLbl.BackColor = System.Drawing.Color.Transparent;
            this.IdCustLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCustLbl.Location = new System.Drawing.Point(12, 95);
            this.IdCustLbl.Name = "IdCustLbl";
            this.IdCustLbl.Size = new System.Drawing.Size(66, 13);
            this.IdCustLbl.TabIndex = 1;
            this.IdCustLbl.Text = "Id Customer:";
            // 
            // IdCusTxtb
            // 
            this.IdCusTxtb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.IdCusTxtb.Location = new System.Drawing.Point(12, 111);
            this.IdCusTxtb.Name = "IdCusTxtb";
            this.IdCusTxtb.Size = new System.Drawing.Size(194, 20);
            this.IdCusTxtb.TabIndex = 2;
            // 
            // TypeOfCustomeLabel
            // 
            this.TypeOfCustomeLabel.AutoSize = true;
            this.TypeOfCustomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeOfCustomeLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfCustomeLabel.Location = new System.Drawing.Point(12, 296);
            this.TypeOfCustomeLabel.Name = "TypeOfCustomeLabel";
            this.TypeOfCustomeLabel.Size = new System.Drawing.Size(89, 13);
            this.TypeOfCustomeLabel.TabIndex = 4;
            this.TypeOfCustomeLabel.Text = "Type of customer:";
            // 
            // TypeOfCustomerTxtb
            // 
            this.TypeOfCustomerTxtb.DisplayMember = "aaaa";
            this.TypeOfCustomerTxtb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TypeOfCustomerTxtb.FormattingEnabled = true;
            this.TypeOfCustomerTxtb.Items.AddRange(new object[] {
            "Household customer",
            "Administrative agency, public service",
            "Production units",
            "Business services"});
            this.TypeOfCustomerTxtb.Location = new System.Drawing.Point(12, 312);
            this.TypeOfCustomerTxtb.Name = "TypeOfCustomerTxtb";
            this.TypeOfCustomerTxtb.Size = new System.Drawing.Size(194, 21);
            this.TypeOfCustomerTxtb.TabIndex = 13;
            // 
            // LMonthTxtb
            // 
            this.LMonthTxtb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LMonthTxtb.Location = new System.Drawing.Point(12, 209);
            this.LMonthTxtb.Name = "LMonthTxtb";
            this.LMonthTxtb.Size = new System.Drawing.Size(194, 20);
            this.LMonthTxtb.TabIndex = 15;
            // 
            // LMonthMainLbl
            // 
            this.LMonthMainLbl.AutoSize = true;
            this.LMonthMainLbl.BackColor = System.Drawing.Color.Transparent;
            this.LMonthMainLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMonthMainLbl.Location = new System.Drawing.Point(12, 191);
            this.LMonthMainLbl.Name = "LMonthMainLbl";
            this.LMonthMainLbl.Size = new System.Drawing.Size(97, 13);
            this.LMonthMainLbl.TabIndex = 14;
            this.LMonthMainLbl.Text = "Last month’s water:";
            // 
            // ThisMonthtxtb
            // 
            this.ThisMonthtxtb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ThisMonthtxtb.Location = new System.Drawing.Point(12, 260);
            this.ThisMonthtxtb.Name = "ThisMonthtxtb";
            this.ThisMonthtxtb.Size = new System.Drawing.Size(194, 20);
            this.ThisMonthtxtb.TabIndex = 17;
            // 
            // TMonthMainLbl
            // 
            this.TMonthMainLbl.AutoSize = true;
            this.TMonthMainLbl.BackColor = System.Drawing.Color.Transparent;
            this.TMonthMainLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMonthMainLbl.Location = new System.Drawing.Point(12, 244);
            this.TMonthMainLbl.Name = "TMonthMainLbl";
            this.TMonthMainLbl.Size = new System.Drawing.Size(97, 13);
            this.TMonthMainLbl.TabIndex = 16;
            this.TMonthMainLbl.Text = "This month’s water:";
            // 
            // HeadingProgramLbl
            // 
            this.HeadingProgramLbl.AutoSize = true;
            this.HeadingProgramLbl.BackColor = System.Drawing.Color.Transparent;
            this.HeadingProgramLbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingProgramLbl.Location = new System.Drawing.Point(238, 9);
            this.HeadingProgramLbl.Name = "HeadingProgramLbl";
            this.HeadingProgramLbl.Size = new System.Drawing.Size(268, 24);
            this.HeadingProgramLbl.TabIndex = 18;
            this.HeadingProgramLbl.Text = "CALCULATE WATER BILL";
            // 
            // CalculateBtt
            // 
            this.CalculateBtt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CalculateBtt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CalculateBtt.BackgroundImage")));
            this.CalculateBtt.Location = new System.Drawing.Point(11, 413);
            this.CalculateBtt.Name = "CalculateBtt";
            this.CalculateBtt.Size = new System.Drawing.Size(75, 26);
            this.CalculateBtt.TabIndex = 19;
            this.CalculateBtt.Text = "Show Bill";
            this.CalculateBtt.UseVisualStyleBackColor = false;
            this.CalculateBtt.Click += new System.EventHandler(this.CalculateBtt_Click);
            // 
            // ClearBtt
            // 
            this.ClearBtt.BackColor = System.Drawing.Color.SkyBlue;
            this.ClearBtt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearBtt.BackgroundImage")));
            this.ClearBtt.Location = new System.Drawing.Point(134, 413);
            this.ClearBtt.Name = "ClearBtt";
            this.ClearBtt.Size = new System.Drawing.Size(75, 26);
            this.ClearBtt.TabIndex = 20;
            this.ClearBtt.Text = "Clear ";
            this.ClearBtt.UseVisualStyleBackColor = false;
            this.ClearBtt.Click += new System.EventHandler(this.ClearBtt_Click);
            // 
            // lvResult
            // 
            this.lvResult.FullRowSelect = true;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(249, 111);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(540, 327);
            this.lvResult.TabIndex = 21;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvResult_MouseClick);
            // 
            // InforCusLbl
            // 
            this.InforCusLbl.AutoSize = true;
            this.InforCusLbl.BackColor = System.Drawing.Color.Transparent;
            this.InforCusLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InforCusLbl.Location = new System.Drawing.Point(12, 52);
            this.InforCusLbl.Name = "InforCusLbl";
            this.InforCusLbl.Size = new System.Drawing.Size(129, 15);
            this.InforCusLbl.TabIndex = 22;
            this.InforCusLbl.Text = "Information Customer\r\n";
            // 
            // NameCusTxtb
            // 
            this.NameCusTxtb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.NameCusTxtb.Location = new System.Drawing.Point(12, 162);
            this.NameCusTxtb.Name = "NameCusTxtb";
            this.NameCusTxtb.Size = new System.Drawing.Size(194, 20);
            this.NameCusTxtb.TabIndex = 24;
            // 
            // NameCusTxtbLbl
            // 
            this.NameCusTxtbLbl.AutoSize = true;
            this.NameCusTxtbLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameCusTxtbLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameCusTxtbLbl.Location = new System.Drawing.Point(12, 146);
            this.NameCusTxtbLbl.Name = "NameCusTxtbLbl";
            this.NameCusTxtbLbl.Size = new System.Drawing.Size(86, 13);
            this.NameCusTxtbLbl.TabIndex = 23;
            this.NameCusTxtbLbl.Text = "Name Customer: ";
            // 
            // numberPeoplerTxtb
            // 
            this.numberPeoplerTxtb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numberPeoplerTxtb.Location = new System.Drawing.Point(12, 365);
            this.numberPeoplerTxtb.Name = "numberPeoplerTxtb";
            this.numberPeoplerTxtb.Size = new System.Drawing.Size(194, 20);
            this.numberPeoplerTxtb.TabIndex = 26;
            // 
            // NumberOfPeopleLbl
            // 
            this.NumberOfPeopleLbl.AutoSize = true;
            this.NumberOfPeopleLbl.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfPeopleLbl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPeopleLbl.Location = new System.Drawing.Point(12, 349);
            this.NumberOfPeopleLbl.Name = "NumberOfPeopleLbl";
            this.NumberOfPeopleLbl.Size = new System.Drawing.Size(85, 13);
            this.NumberOfPeopleLbl.TabIndex = 25;
            this.NumberOfPeopleLbl.Text = "Number People: ";
            // 
            // findInforLabel
            // 
            this.findInforLabel.AutoSize = true;
            this.findInforLabel.BackColor = System.Drawing.Color.Transparent;
            this.findInforLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findInforLabel.Location = new System.Drawing.Point(245, 52);
            this.findInforLabel.Name = "findInforLabel";
            this.findInforLabel.Size = new System.Drawing.Size(101, 15);
            this.findInforLabel.TabIndex = 27;
            this.findInforLabel.Text = "Find Information ";
            // 
            // SearchTxtbox
            // 
            this.SearchTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxtbox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchTxtbox.Location = new System.Drawing.Point(248, 79);
            this.SearchTxtbox.Name = "SearchTxtbox";
            this.SearchTxtbox.Size = new System.Drawing.Size(194, 20);
            this.SearchTxtbox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(239, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 28;
            // 
            // searchBtt
            // 
            this.searchBtt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.searchBtt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtt.BackgroundImage")));
            this.searchBtt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchBtt.Location = new System.Drawing.Point(437, 78);
            this.searchBtt.Name = "searchBtt";
            this.searchBtt.Size = new System.Drawing.Size(55, 22);
            this.searchBtt.TabIndex = 30;
            this.searchBtt.Text = "Search ";
            this.searchBtt.UseVisualStyleBackColor = false;
            this.searchBtt.Click += new System.EventHandler(this.searchBtt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(763, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(421, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(117)))), ((int)(((byte)(34)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchBtt);
            this.Controls.Add(this.SearchTxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.findInforLabel);
            this.Controls.Add(this.numberPeoplerTxtb);
            this.Controls.Add(this.NumberOfPeopleLbl);
            this.Controls.Add(this.NameCusTxtb);
            this.Controls.Add(this.NameCusTxtbLbl);
            this.Controls.Add(this.InforCusLbl);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.ClearBtt);
            this.Controls.Add(this.CalculateBtt);
            this.Controls.Add(this.HeadingProgramLbl);
            this.Controls.Add(this.ThisMonthtxtb);
            this.Controls.Add(this.TMonthMainLbl);
            this.Controls.Add(this.LMonthTxtb);
            this.Controls.Add(this.LMonthMainLbl);
            this.Controls.Add(this.TypeOfCustomerTxtb);
            this.Controls.Add(this.TypeOfCustomeLabel);
            this.Controls.Add(this.IdCusTxtb);
            this.Controls.Add(this.IdCustLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "ABC Company";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IdCustLbl;
        private System.Windows.Forms.TextBox IdCusTxtb;
        private System.Windows.Forms.Label TypeOfCustomeLabel;
        private System.Windows.Forms.ComboBox TypeOfCustomerTxtb;
        private System.Windows.Forms.TextBox LMonthTxtb;
        private System.Windows.Forms.Label LMonthMainLbl;
        private System.Windows.Forms.TextBox ThisMonthtxtb;
        private System.Windows.Forms.Label TMonthMainLbl;
        private System.Windows.Forms.Label HeadingProgramLbl;
        private System.Windows.Forms.Button CalculateBtt;
        private System.Windows.Forms.Button ClearBtt;
        private System.Windows.Forms.ListView lvResult;
        private Label InforCusLbl;
        private TextBox NameCusTxtb;
        private Label NameCusTxtbLbl;
        private TextBox numberPeoplerTxtb;
        private Label NumberOfPeopleLbl;
        private Label findInforLabel;
        private TextBox SearchTxtbox;
        private Label label5;
        private Button searchBtt;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox2;
    }
}




namespace TrabajoFinalVisualComp
{
	partial class ManageEmployeesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeesForm));
			this.dtgEmp = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmpNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEmpName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmpUserN = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmpPW = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxIsAdmin = new System.Windows.Forms.ComboBox();
			this.txtSrchName = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dtgEmp)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtgEmp
			// 
			this.dtgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgEmp.Location = new System.Drawing.Point(128, 57);
			this.dtgEmp.Name = "dtgEmp";
			this.dtgEmp.Size = new System.Drawing.Size(548, 174);
			this.dtgEmp.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(271, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(268, 31);
			this.label5.TabIndex = 19;
			this.label5.Text = "Manage Employees";
			// 
			// txtEmpNo
			// 
			this.txtEmpNo.Location = new System.Drawing.Point(219, 265);
			this.txtEmpNo.Name = "txtEmpNo";
			this.txtEmpNo.Size = new System.Drawing.Size(100, 20);
			this.txtEmpNo.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 300);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "Employee Name";
			// 
			// txtEmpName
			// 
			this.txtEmpName.Location = new System.Drawing.Point(219, 300);
			this.txtEmpName.Name = "txtEmpName";
			this.txtEmpName.Size = new System.Drawing.Size(100, 20);
			this.txtEmpName.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 265);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 20);
			this.label2.TabIndex = 23;
			this.label2.Text = "Employee Number";
			// 
			// txtEmpUserN
			// 
			this.txtEmpUserN.Location = new System.Drawing.Point(219, 338);
			this.txtEmpUserN.Name = "txtEmpUserN";
			this.txtEmpUserN.Size = new System.Drawing.Size(100, 20);
			this.txtEmpUserN.TabIndex = 26;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(60, 337);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 20);
			this.label3.TabIndex = 25;
			this.label3.Text = "E-Username";
			// 
			// txtEmpPW
			// 
			this.txtEmpPW.Location = new System.Drawing.Point(219, 373);
			this.txtEmpPW.Name = "txtEmpPW";
			this.txtEmpPW.Size = new System.Drawing.Size(100, 20);
			this.txtEmpPW.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(60, 373);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 20);
			this.label4.TabIndex = 27;
			this.label4.Text = "E-Password";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(388, 276);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(84, 43);
			this.btnAdd.TabIndex = 29;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(388, 335);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(84, 41);
			this.btnDelete.TabIndex = 30;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(388, 393);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(84, 38);
			this.btnEdit.TabIndex = 31;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(64, 412);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 20);
			this.label6.TabIndex = 33;
			this.label6.Text = "Is Admin:";
			// 
			// cbxIsAdmin
			// 
			this.cbxIsAdmin.FormattingEnabled = true;
			this.cbxIsAdmin.Location = new System.Drawing.Point(219, 412);
			this.cbxIsAdmin.Name = "cbxIsAdmin";
			this.cbxIsAdmin.Size = new System.Drawing.Size(100, 21);
			this.cbxIsAdmin.TabIndex = 34;
			// 
			// txtSrchName
			// 
			this.txtSrchName.Location = new System.Drawing.Point(515, 288);
			this.txtSrchName.Name = "txtSrchName";
			this.txtSrchName.Size = new System.Drawing.Size(182, 20);
			this.txtSrchName.TabIndex = 57;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(705, 284);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(82, 26);
			this.btnSearch.TabIndex = 56;
			this.btnSearch.Text = "Search Name";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(31, 125);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(72, 50);
			this.btnRefresh.TabIndex = 58;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 59;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainMenuToolStripMenuItem,
            this.signOffToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// backToMainMenuToolStripMenuItem
			// 
			this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
			this.backToMainMenuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.backToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
			this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click);
			// 
			// signOffToolStripMenuItem
			// 
			this.signOffToolStripMenuItem.Name = "signOffToolStripMenuItem";
			this.signOffToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.signOffToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.signOffToolStripMenuItem.Text = "Sign Off";
			this.signOffToolStripMenuItem.Click += new System.EventHandler(this.signOffToolStripMenuItem_Click);
			// 
			// ManageEmployeesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = global::TrabajoFinalVisualComp.Properties.Resources.Screenshot_2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.txtSrchName);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.cbxIsAdmin);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtEmpPW);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEmpUserN);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEmpName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmpNo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtgEmp);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ManageEmployeesForm";
			this.Text = "Employees";
			((System.ComponentModel.ISupportInitialize)(this.dtgEmp)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgEmp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEmpNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmpName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmpUserN;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmpPW;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxIsAdmin;
		private System.Windows.Forms.TextBox txtSrchName;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signOffToolStripMenuItem;
	}
}
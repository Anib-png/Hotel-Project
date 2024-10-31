
namespace TrabajoFinalVisualComp
{
	partial class CheckInForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAddCheckIn = new System.Windows.Forms.Button();
			this.txtGName = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.cmbRoomNo = new System.Windows.Forms.ComboBox();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.txtCost = new System.Windows.Forms.TextBox();
			this.lblCost = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Guest\'s Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Room Number";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(45, 239);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Date From:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 279);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Date To:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(142, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 31);
			this.label5.TabIndex = 4;
			this.label5.Text = "Check In";
			// 
			// btnAddCheckIn
			// 
			this.btnAddCheckIn.Location = new System.Drawing.Point(68, 339);
			this.btnAddCheckIn.Name = "btnAddCheckIn";
			this.btnAddCheckIn.Size = new System.Drawing.Size(95, 34);
			this.btnAddCheckIn.TabIndex = 5;
			this.btnAddCheckIn.Text = "Check-In";
			this.btnAddCheckIn.UseVisualStyleBackColor = true;
			this.btnAddCheckIn.Click += new System.EventHandler(this.btnAddCheckIn_Click);
			// 
			// txtGName
			// 
			this.txtGName.Location = new System.Drawing.Point(164, 118);
			this.txtGName.Name = "txtGName";
			this.txtGName.Size = new System.Drawing.Size(108, 20);
			this.txtGName.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(197, 339);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 34);
			this.button2.TabIndex = 10;
			this.button2.Text = "Go to Check In-Table";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// cmbRoomNo
			// 
			this.cmbRoomNo.FormattingEnabled = true;
			this.cmbRoomNo.Location = new System.Drawing.Point(164, 198);
			this.cmbRoomNo.Name = "cmbRoomNo";
			this.cmbRoomNo.Size = new System.Drawing.Size(108, 21);
			this.cmbRoomNo.TabIndex = 11;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFrom.Location = new System.Drawing.Point(164, 239);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(108, 20);
			this.dtpFrom.TabIndex = 74;
			// 
			// dtpTo
			// 
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTo.Location = new System.Drawing.Point(164, 279);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(108, 20);
			this.dtpTo.TabIndex = 75;
			// 
			// txtCost
			// 
			this.txtCost.Location = new System.Drawing.Point(164, 157);
			this.txtCost.Name = "txtCost";
			this.txtCost.Size = new System.Drawing.Size(108, 20);
			this.txtCost.TabIndex = 79;
			this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
			// 
			// lblCost
			// 
			this.lblCost.AutoSize = true;
			this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCost.Location = new System.Drawing.Point(92, 151);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new System.Drawing.Size(42, 20);
			this.lblCost.TabIndex = 78;
			this.lblCost.Text = "Cost";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 80;
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
			this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.backToMainMenuToolStripMenuItem.Text = "Back To Main Menu";
			this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click);
			// 
			// signOffToolStripMenuItem
			// 
			this.signOffToolStripMenuItem.Name = "signOffToolStripMenuItem";
			this.signOffToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.signOffToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.signOffToolStripMenuItem.Text = "Sign Off";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::TrabajoFinalVisualComp.Properties.Resources.Screenshot_5;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(344, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(493, 457);
			this.pictureBox1.TabIndex = 81;
			this.pictureBox1.TabStop = false;
			// 
			// CheckInForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtCost);
			this.Controls.Add(this.lblCost);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.cmbRoomNo);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtGName);
			this.Controls.Add(this.btnAddCheckIn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CheckInForm";
			this.Text = "Check-in";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAddCheckIn;
		private System.Windows.Forms.TextBox txtGName;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox cmbRoomNo;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label lblCost;
		private System.Windows.Forms.TextBox txtCost;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signOffToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
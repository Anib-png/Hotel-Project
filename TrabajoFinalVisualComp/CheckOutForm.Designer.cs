
namespace TrabajoFinalVisualComp
{
	partial class CheckOutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutForm));
			this.button2 = new System.Windows.Forms.Button();
			this.txtIDNo = new System.Windows.Forms.TextBox();
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPaidAmount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtgSearch = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dtpCO = new System.Windows.Forms.DateTimePicker();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgSearch)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(241, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 34);
			this.button2.TabIndex = 21;
			this.button2.Text = "Go to Check Out-Table";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtIDNo
			// 
			this.txtIDNo.Location = new System.Drawing.Point(186, 90);
			this.txtIDNo.Name = "txtIDNo";
			this.txtIDNo.Size = new System.Drawing.Size(109, 20);
			this.txtIDNo.TabIndex = 20;
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.Location = new System.Drawing.Point(106, 200);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(95, 34);
			this.btnCheckOut.TabIndex = 19;
			this.btnCheckOut.Text = "Check-Out";
			this.btnCheckOut.UseVisualStyleBackColor = true;
			this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(157, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 31);
			this.label5.TabIndex = 18;
			this.label5.Text = "Check Out";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 20);
			this.label3.TabIndex = 16;
			this.label3.Text = "Date Checked Out:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 20);
			this.label1.TabIndex = 14;
			this.label1.Text = "Guest\'s ID Number";
			// 
			// txtPaidAmount
			// 
			this.txtPaidAmount.Location = new System.Drawing.Point(186, 130);
			this.txtPaidAmount.Name = "txtPaidAmount";
			this.txtPaidAmount.Size = new System.Drawing.Size(109, 20);
			this.txtPaidAmount.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(50, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 20);
			this.label2.TabIndex = 24;
			this.label2.Text = "Paid Amount:";
			// 
			// dtgSearch
			// 
			this.dtgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgSearch.Location = new System.Drawing.Point(439, 12);
			this.dtgSearch.Name = "dtgSearch";
			this.dtgSearch.Size = new System.Drawing.Size(319, 150);
			this.dtgSearch.TabIndex = 26;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(445, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 20);
			this.label4.TabIndex = 27;
			this.label4.Text = "Search by name:";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(520, 225);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(140, 24);
			this.btnSearch.TabIndex = 28;
			this.btnSearch.Text = "Search Database";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(584, 182);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(174, 20);
			this.txtSearch.TabIndex = 29;
			// 
			// dtpCO
			// 
			this.dtpCO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCO.Location = new System.Drawing.Point(186, 162);
			this.dtpCO.Name = "dtpCO";
			this.dtpCO.Size = new System.Drawing.Size(109, 20);
			this.dtpCO.TabIndex = 75;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 76;
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
			this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click_1);
			// 
			// signOffToolStripMenuItem
			// 
			this.signOffToolStripMenuItem.Name = "signOffToolStripMenuItem";
			this.signOffToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.signOffToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.signOffToolStripMenuItem.Text = "Sign Off";
			this.signOffToolStripMenuItem.Click += new System.EventHandler(this.signOffToolStripMenuItem_Click_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
			this.pictureBox1.BackgroundImage = global::TrabajoFinalVisualComp.Properties.Resources.Screenshot_4;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(0, 255);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(800, 213);
			this.pictureBox1.TabIndex = 77;
			this.pictureBox1.TabStop = false;
			// 
			// CheckOutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dtpCO);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtgSearch);
			this.Controls.Add(this.txtPaidAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtIDNo);
			this.Controls.Add(this.btnCheckOut);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CheckOutForm";
			this.Text = "Check-out";
			((System.ComponentModel.ISupportInitialize)(this.dtgSearch)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtIDNo;
		private System.Windows.Forms.Button btnCheckOut;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPaidAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dtgSearch;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DateTimePicker dtpCO;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signOffToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
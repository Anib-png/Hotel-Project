
namespace TrabajoFinalVisualComp
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblLogin = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(243, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// btnSignIn
			// 
			this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
			this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignIn.ForeColor = System.Drawing.Color.Transparent;
			this.btnSignIn.Location = new System.Drawing.Point(405, 266);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(121, 40);
			this.btnSignIn.TabIndex = 1;
			this.btnSignIn.Text = "Sign in";
			this.btnSignIn.UseVisualStyleBackColor = false;
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(252, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 28);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.Color.White;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(383, 139);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(200, 31);
			this.txtUsername.TabIndex = 3;
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.BackColor = System.Drawing.Color.Transparent;
			this.lblLogin.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblLogin.Location = new System.Drawing.Point(222, 76);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(441, 41);
			this.lblLogin.TabIndex = 5;
			this.lblLogin.Text = "Hotel Administrator Login";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(383, 206);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(200, 31);
			this.txtPassword.TabIndex = 6;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::TrabajoFinalVisualComp.Properties.Resources.Screenshot_12;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSignIn);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.MaskedTextBox txtPassword;
	}
}


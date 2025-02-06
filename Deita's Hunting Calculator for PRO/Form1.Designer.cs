namespace Deita_s_Hunting_Calculator_for_PRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TB_Atk = new System.Windows.Forms.TextBox();
            this.TB_Def = new System.Windows.Forms.TextBox();
            this.TB_Spatk = new System.Windows.Forms.TextBox();
            this.TB_Spd = new System.Windows.Forms.TextBox();
            this.TB_Spdef = new System.Windows.Forms.TextBox();
            this.TB_HP = new System.Windows.Forms.TextBox();
            this.LBL_Atk = new System.Windows.Forms.Label();
            this.LBL_Spd = new System.Windows.Forms.Label();
            this.LBL_Def = new System.Windows.Forms.Label();
            this.LBL_Spdef = new System.Windows.Forms.Label();
            this.LBL_Spatk = new System.Windows.Forms.Label();
            this.LBL_HP = new System.Windows.Forms.Label();
            this.BTN_Calculate = new System.Windows.Forms.Button();
            this.RTB_Result = new System.Windows.Forms.RichTextBox();
            this.BTN_MoreDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Atk
            // 
            this.TB_Atk.BackColor = System.Drawing.SystemColors.Window;
            this.TB_Atk.Location = new System.Drawing.Point(120, 60);
            this.TB_Atk.Name = "TB_Atk";
            this.TB_Atk.Size = new System.Drawing.Size(100, 20);
            this.TB_Atk.TabIndex = 0;
            this.TB_Atk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Atk_KeyPress);
            this.TB_Atk.Leave += new System.EventHandler(this.TB_Atk_Leave);
            // 
            // TB_Def
            // 
            this.TB_Def.Location = new System.Drawing.Point(120, 100);
            this.TB_Def.Name = "TB_Def";
            this.TB_Def.Size = new System.Drawing.Size(100, 20);
            this.TB_Def.TabIndex = 1;
            // 
            // TB_Spatk
            // 
            this.TB_Spatk.Location = new System.Drawing.Point(120, 180);
            this.TB_Spatk.Name = "TB_Spatk";
            this.TB_Spatk.Size = new System.Drawing.Size(100, 20);
            this.TB_Spatk.TabIndex = 2;
            // 
            // TB_Spd
            // 
            this.TB_Spd.Location = new System.Drawing.Point(120, 140);
            this.TB_Spd.Name = "TB_Spd";
            this.TB_Spd.Size = new System.Drawing.Size(100, 20);
            this.TB_Spd.TabIndex = 3;
            // 
            // TB_Spdef
            // 
            this.TB_Spdef.Location = new System.Drawing.Point(120, 220);
            this.TB_Spdef.Name = "TB_Spdef";
            this.TB_Spdef.Size = new System.Drawing.Size(100, 20);
            this.TB_Spdef.TabIndex = 4;
            // 
            // TB_HP
            // 
            this.TB_HP.Location = new System.Drawing.Point(120, 260);
            this.TB_HP.Name = "TB_HP";
            this.TB_HP.Size = new System.Drawing.Size(100, 20);
            this.TB_HP.TabIndex = 5;
            // 
            // LBL_Atk
            // 
            this.LBL_Atk.AutoSize = true;
            this.LBL_Atk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Atk.Location = new System.Drawing.Point(44, 63);
            this.LBL_Atk.Name = "LBL_Atk";
            this.LBL_Atk.Size = new System.Drawing.Size(31, 16);
            this.LBL_Atk.TabIndex = 6;
            this.LBL_Atk.Text = "ATK";
            // 
            // LBL_Spd
            // 
            this.LBL_Spd.AutoSize = true;
            this.LBL_Spd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Spd.Location = new System.Drawing.Point(44, 143);
            this.LBL_Spd.Name = "LBL_Spd";
            this.LBL_Spd.Size = new System.Drawing.Size(34, 16);
            this.LBL_Spd.TabIndex = 7;
            this.LBL_Spd.Text = "SPD";
            // 
            // LBL_Def
            // 
            this.LBL_Def.AutoSize = true;
            this.LBL_Def.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Def.Location = new System.Drawing.Point(44, 103);
            this.LBL_Def.Name = "LBL_Def";
            this.LBL_Def.Size = new System.Drawing.Size(33, 16);
            this.LBL_Def.TabIndex = 8;
            this.LBL_Def.Text = "DEF";
            // 
            // LBL_Spdef
            // 
            this.LBL_Spdef.AutoSize = true;
            this.LBL_Spdef.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Spdef.Location = new System.Drawing.Point(44, 223);
            this.LBL_Spdef.Name = "LBL_Spdef";
            this.LBL_Spdef.Size = new System.Drawing.Size(51, 16);
            this.LBL_Spdef.TabIndex = 9;
            this.LBL_Spdef.Text = "SPDEF";
            // 
            // LBL_Spatk
            // 
            this.LBL_Spatk.AutoSize = true;
            this.LBL_Spatk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Spatk.Location = new System.Drawing.Point(44, 183);
            this.LBL_Spatk.Name = "LBL_Spatk";
            this.LBL_Spatk.Size = new System.Drawing.Size(48, 16);
            this.LBL_Spatk.TabIndex = 10;
            this.LBL_Spatk.Text = "SPATK";
            // 
            // LBL_HP
            // 
            this.LBL_HP.AutoSize = true;
            this.LBL_HP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HP.Location = new System.Drawing.Point(44, 263);
            this.LBL_HP.Name = "LBL_HP";
            this.LBL_HP.Size = new System.Drawing.Size(25, 16);
            this.LBL_HP.TabIndex = 11;
            this.LBL_HP.Text = "HP";
            // 
            // BTN_Calculate
            // 
            this.BTN_Calculate.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_Calculate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Calculate.Location = new System.Drawing.Point(120, 300);
            this.BTN_Calculate.Name = "BTN_Calculate";
            this.BTN_Calculate.Size = new System.Drawing.Size(100, 25);
            this.BTN_Calculate.TabIndex = 12;
            this.BTN_Calculate.Text = "Calculate";
            this.BTN_Calculate.UseVisualStyleBackColor = false;
            this.BTN_Calculate.Click += new System.EventHandler(this.BTN_Calculate_Click);
            // 
            // RTB_Result
            // 
            this.RTB_Result.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.RTB_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Result.Location = new System.Drawing.Point(267, 63);
            this.RTB_Result.Name = "RTB_Result";
            this.RTB_Result.ReadOnly = true;
            this.RTB_Result.Size = new System.Drawing.Size(405, 202);
            this.RTB_Result.TabIndex = 13;
            this.RTB_Result.Text = "Welcome to Deita\'s IV Probability Calculator for PRO!\n\nEnter your desired IVs and" +
    " click \"Calculate\"!";
            // 
            // BTN_MoreDetails
            // 
            this.BTN_MoreDetails.Location = new System.Drawing.Point(377, 295);
            this.BTN_MoreDetails.Name = "BTN_MoreDetails";
            this.BTN_MoreDetails.Size = new System.Drawing.Size(100, 30);
            this.BTN_MoreDetails.TabIndex = 0;
            this.BTN_MoreDetails.Text = "More Details";
            this.BTN_MoreDetails.UseVisualStyleBackColor = true;
            this.BTN_MoreDetails.Click += new System.EventHandler(this.BTN_MoreDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(680, 377);
            this.Controls.Add(this.BTN_MoreDetails);
            this.Controls.Add(this.RTB_Result);
            this.Controls.Add(this.BTN_Calculate);
            this.Controls.Add(this.LBL_HP);
            this.Controls.Add(this.LBL_Spatk);
            this.Controls.Add(this.LBL_Spdef);
            this.Controls.Add(this.LBL_Def);
            this.Controls.Add(this.LBL_Spd);
            this.Controls.Add(this.LBL_Atk);
            this.Controls.Add(this.TB_HP);
            this.Controls.Add(this.TB_Spdef);
            this.Controls.Add(this.TB_Spd);
            this.Controls.Add(this.TB_Spatk);
            this.Controls.Add(this.TB_Def);
            this.Controls.Add(this.TB_Atk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 420);
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.Name = "Form1";
            this.Text = "Deita\'s IV Probability Calculator for PRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Atk;
        private System.Windows.Forms.TextBox TB_Def;
        private System.Windows.Forms.TextBox TB_Spatk;
        private System.Windows.Forms.TextBox TB_Spd;
        private System.Windows.Forms.TextBox TB_Spdef;
        private System.Windows.Forms.TextBox TB_HP;
        private System.Windows.Forms.Label LBL_Atk;
        private System.Windows.Forms.Label LBL_Spd;
        private System.Windows.Forms.Label LBL_Def;
        private System.Windows.Forms.Label LBL_Spdef;
        private System.Windows.Forms.Label LBL_Spatk;
        private System.Windows.Forms.Label LBL_HP;
        private System.Windows.Forms.Button BTN_Calculate;
        private System.Windows.Forms.RichTextBox RTB_Result;
        private System.Windows.Forms.Button BTN_MoreDetails;
    }
}


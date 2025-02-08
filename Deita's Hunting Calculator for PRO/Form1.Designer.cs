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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CB_Ability = new System.Windows.Forms.ComboBox();
            this.CB_Nature = new System.Windows.Forms.ComboBox();
            this.LBL_Ability = new System.Windows.Forms.Label();
            this.LBL_Natures = new System.Windows.Forms.Label();
            this.CB_BMS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_HiddenPower = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Atk
            // 
            this.TB_Atk.BackColor = System.Drawing.SystemColors.Window;
            this.TB_Atk.Location = new System.Drawing.Point(171, 35);
            this.TB_Atk.Name = "TB_Atk";
            this.TB_Atk.Size = new System.Drawing.Size(100, 20);
            this.TB_Atk.TabIndex = 0;
            this.TB_Atk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Atk_KeyPress);
            this.TB_Atk.Leave += new System.EventHandler(this.TB_Atk_Leave);
            // 
            // TB_Def
            // 
            this.TB_Def.Location = new System.Drawing.Point(171, 75);
            this.TB_Def.Name = "TB_Def";
            this.TB_Def.Size = new System.Drawing.Size(100, 20);
            this.TB_Def.TabIndex = 1;
            // 
            // TB_Spatk
            // 
            this.TB_Spatk.Location = new System.Drawing.Point(171, 155);
            this.TB_Spatk.Name = "TB_Spatk";
            this.TB_Spatk.Size = new System.Drawing.Size(100, 20);
            this.TB_Spatk.TabIndex = 3;
            // 
            // TB_Spd
            // 
            this.TB_Spd.Location = new System.Drawing.Point(171, 115);
            this.TB_Spd.Name = "TB_Spd";
            this.TB_Spd.Size = new System.Drawing.Size(100, 20);
            this.TB_Spd.TabIndex = 2;
            // 
            // TB_Spdef
            // 
            this.TB_Spdef.Location = new System.Drawing.Point(171, 195);
            this.TB_Spdef.Name = "TB_Spdef";
            this.TB_Spdef.Size = new System.Drawing.Size(100, 20);
            this.TB_Spdef.TabIndex = 4;
            // 
            // TB_HP
            // 
            this.TB_HP.Location = new System.Drawing.Point(171, 235);
            this.TB_HP.Name = "TB_HP";
            this.TB_HP.Size = new System.Drawing.Size(100, 20);
            this.TB_HP.TabIndex = 5;
            // 
            // LBL_Atk
            // 
            this.LBL_Atk.AutoSize = true;
            this.LBL_Atk.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Atk.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Atk.Location = new System.Drawing.Point(35, 35);
            this.LBL_Atk.Name = "LBL_Atk";
            this.LBL_Atk.Size = new System.Drawing.Size(48, 17);
            this.LBL_Atk.TabIndex = 6;
            this.LBL_Atk.Text = "Attack";
            // 
            // LBL_Spd
            // 
            this.LBL_Spd.AutoSize = true;
            this.LBL_Spd.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Spd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Spd.Location = new System.Drawing.Point(35, 115);
            this.LBL_Spd.Name = "LBL_Spd";
            this.LBL_Spd.Size = new System.Drawing.Size(50, 17);
            this.LBL_Spd.TabIndex = 7;
            this.LBL_Spd.Text = "Speed";
            // 
            // LBL_Def
            // 
            this.LBL_Def.AutoSize = true;
            this.LBL_Def.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Def.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Def.Location = new System.Drawing.Point(35, 75);
            this.LBL_Def.Name = "LBL_Def";
            this.LBL_Def.Size = new System.Drawing.Size(63, 17);
            this.LBL_Def.TabIndex = 8;
            this.LBL_Def.Text = "Defense";
            // 
            // LBL_Spdef
            // 
            this.LBL_Spdef.AutoSize = true;
            this.LBL_Spdef.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Spdef.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Spdef.Location = new System.Drawing.Point(35, 195);
            this.LBL_Spdef.Name = "LBL_Spdef";
            this.LBL_Spdef.Size = new System.Drawing.Size(115, 17);
            this.LBL_Spdef.TabIndex = 9;
            this.LBL_Spdef.Text = "Special Defense";
            // 
            // LBL_Spatk
            // 
            this.LBL_Spatk.AutoSize = true;
            this.LBL_Spatk.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Spatk.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Spatk.Location = new System.Drawing.Point(35, 155);
            this.LBL_Spatk.Name = "LBL_Spatk";
            this.LBL_Spatk.Size = new System.Drawing.Size(99, 17);
            this.LBL_Spatk.TabIndex = 10;
            this.LBL_Spatk.Text = "Special Attack";
            // 
            // LBL_HP
            // 
            this.LBL_HP.AutoSize = true;
            this.LBL_HP.BackColor = System.Drawing.Color.Transparent;
            this.LBL_HP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HP.Location = new System.Drawing.Point(35, 235);
            this.LBL_HP.Name = "LBL_HP";
            this.LBL_HP.Size = new System.Drawing.Size(28, 17);
            this.LBL_HP.TabIndex = 11;
            this.LBL_HP.Text = "HP";
            // 
            // BTN_Calculate
            // 
            this.BTN_Calculate.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Calculate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Calculate.Location = new System.Drawing.Point(171, 440);
            this.BTN_Calculate.Name = "BTN_Calculate";
            this.BTN_Calculate.Size = new System.Drawing.Size(131, 25);
            this.BTN_Calculate.TabIndex = 10;
            this.BTN_Calculate.Text = "Calculate";
            this.BTN_Calculate.UseVisualStyleBackColor = false;
            this.BTN_Calculate.Click += new System.EventHandler(this.BTN_Calculate_Click);
            // 
            // RTB_Result
            // 
            this.RTB_Result.BackColor = System.Drawing.Color.White;
            this.RTB_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Result.Location = new System.Drawing.Point(339, 34);
            this.RTB_Result.Name = "RTB_Result";
            this.RTB_Result.ReadOnly = true;
            this.RTB_Result.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB_Result.Size = new System.Drawing.Size(405, 274);
            this.RTB_Result.TabIndex = 13;
            this.RTB_Result.TabStop = false;
            this.RTB_Result.Text = "Welcome to Deita\'s Hunting Calculator for PRO!\n\nEnter your desired stats and clic" +
    "k \"Calculate\"!";
            // 
            // BTN_MoreDetails
            // 
            this.BTN_MoreDetails.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_MoreDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MoreDetails.Location = new System.Drawing.Point(501, 349);
            this.BTN_MoreDetails.Name = "BTN_MoreDetails";
            this.BTN_MoreDetails.Size = new System.Drawing.Size(74, 30);
            this.BTN_MoreDetails.TabIndex = 11;
            this.BTN_MoreDetails.Text = "Details";
            this.BTN_MoreDetails.UseVisualStyleBackColor = false;
            this.BTN_MoreDetails.Visible = false;
            this.BTN_MoreDetails.Click += new System.EventHandler(this.BTN_MoreDetails_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(38, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 530);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // CB_Ability
            // 
            this.CB_Ability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Ability.FormattingEnabled = true;
            this.CB_Ability.Items.AddRange(new object[] {
            "Any",
            "Primary Abilities Only",
            "1/2 Primary Abilities",
            "1/2 Primary Abilities + H.A.",
            "Hidden Ability Only"});
            this.CB_Ability.Location = new System.Drawing.Point(171, 315);
            this.CB_Ability.Name = "CB_Ability";
            this.CB_Ability.Size = new System.Drawing.Size(131, 21);
            this.CB_Ability.TabIndex = 7;
            // 
            // CB_Nature
            // 
            this.CB_Nature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Nature.FormattingEnabled = true;
            this.CB_Nature.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Any"});
            this.CB_Nature.Location = new System.Drawing.Point(171, 274);
            this.CB_Nature.Name = "CB_Nature";
            this.CB_Nature.Size = new System.Drawing.Size(131, 21);
            this.CB_Nature.TabIndex = 6;
            // 
            // LBL_Ability
            // 
            this.LBL_Ability.AutoSize = true;
            this.LBL_Ability.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Ability.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Ability.Location = new System.Drawing.Point(35, 315);
            this.LBL_Ability.Name = "LBL_Ability";
            this.LBL_Ability.Size = new System.Drawing.Size(109, 17);
            this.LBL_Ability.TabIndex = 17;
            this.LBL_Ability.Text = "Preferred Ability";
            // 
            // LBL_Natures
            // 
            this.LBL_Natures.AutoSize = true;
            this.LBL_Natures.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Natures.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Natures.Location = new System.Drawing.Point(35, 275);
            this.LBL_Natures.Name = "LBL_Natures";
            this.LBL_Natures.Size = new System.Drawing.Size(124, 17);
            this.LBL_Natures.TabIndex = 18;
            this.LBL_Natures.Text = "Preferred Natures";
            this.LBL_Natures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_BMS
            // 
            this.CB_BMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_BMS.FormattingEnabled = true;
            this.CB_BMS.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.CB_BMS.Location = new System.Drawing.Point(171, 355);
            this.CB_BMS.Name = "CB_BMS";
            this.CB_BMS.Size = new System.Drawing.Size(131, 21);
            this.CB_BMS.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "BMS Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hidden Power";
            // 
            // CB_HiddenPower
            // 
            this.CB_HiddenPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_HiddenPower.FormattingEnabled = true;
            this.CB_HiddenPower.Items.AddRange(new object[] {
            "Any",
            "Fighting",
            "Flying",
            "Poison",
            "Ground",
            "Rock",
            "Bug",
            "Ghost",
            "Steel",
            "Fire",
            "Water",
            "Grass",
            "Electric",
            "Psychic",
            "Ice",
            "Dragon",
            "Dark"});
            this.CB_HiddenPower.Location = new System.Drawing.Point(171, 395);
            this.CB_HiddenPower.Name = "CB_HiddenPower";
            this.CB_HiddenPower.Size = new System.Drawing.Size(131, 21);
            this.CB_HiddenPower.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.BTN_MoreDetails);
            this.Controls.Add(this.CB_Nature);
            this.Controls.Add(this.CB_HiddenPower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_BMS);
            this.Controls.Add(this.LBL_Natures);
            this.Controls.Add(this.LBL_Ability);
            this.Controls.Add(this.CB_Ability);
            this.Controls.Add(this.RTB_Result);
            this.Controls.Add(this.LBL_Atk);
            this.Controls.Add(this.LBL_HP);
            this.Controls.Add(this.LBL_Spatk);
            this.Controls.Add(this.LBL_Spdef);
            this.Controls.Add(this.LBL_Def);
            this.Controls.Add(this.LBL_Spd);
            this.Controls.Add(this.BTN_Calculate);
            this.Controls.Add(this.TB_HP);
            this.Controls.Add(this.TB_Spdef);
            this.Controls.Add(this.TB_Spd);
            this.Controls.Add(this.TB_Spatk);
            this.Controls.Add(this.TB_Def);
            this.Controls.Add(this.TB_Atk);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 530);
            this.MinimumSize = new System.Drawing.Size(800, 530);
            this.Name = "Form1";
            this.Text = "Deita\'s Hunting Calculator for PRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CB_Ability;
        private System.Windows.Forms.ComboBox CB_Nature;
        private System.Windows.Forms.Label LBL_Ability;
        private System.Windows.Forms.Label LBL_Natures;
        private System.Windows.Forms.ComboBox CB_BMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_HiddenPower;
    }
}


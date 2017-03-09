namespace STournament
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
            this.addPlayer_B = new System.Windows.Forms.Button();
            this.start_B = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.tB_tour9 = new System.Windows.Forms.TextBox();
            this.tB_tour8 = new System.Windows.Forms.TextBox();
            this.tB_tour7 = new System.Windows.Forms.TextBox();
            this.tB_tour6 = new System.Windows.Forms.TextBox();
            this.tB_tour5 = new System.Windows.Forms.TextBox();
            this.tB_tour4 = new System.Windows.Forms.TextBox();
            this.tB_tour3 = new System.Windows.Forms.TextBox();
            this.tB_tour2 = new System.Windows.Forms.TextBox();
            this.tB_tour1 = new System.Windows.Forms.TextBox();
            this.head_name = new System.Windows.Forms.TextBox();
            this.head_surname = new System.Windows.Forms.TextBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPlayer_B
            // 
            this.addPlayer_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addPlayer_B.Location = new System.Drawing.Point(13, 293);
            this.addPlayer_B.Name = "addPlayer_B";
            this.addPlayer_B.Size = new System.Drawing.Size(135, 23);
            this.addPlayer_B.TabIndex = 0;
            this.addPlayer_B.Text = "Add New Player";
            this.addPlayer_B.UseVisualStyleBackColor = true;
            this.addPlayer_B.Click += new System.EventHandler(this.addPlayer_B_Click);
            // 
            // start_B
            // 
            this.start_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start_B.Location = new System.Drawing.Point(185, 293);
            this.start_B.Name = "start_B";
            this.start_B.Size = new System.Drawing.Size(134, 23);
            this.start_B.TabIndex = 1;
            this.start_B.Text = "Refresh";
            this.start_B.UseVisualStyleBackColor = true;
            this.start_B.Click += new System.EventHandler(this.start_B_Click);
            // 
            // b_save
            // 
            this.b_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_save.Location = new System.Drawing.Point(350, 293);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(134, 23);
            this.b_save.TabIndex = 3;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.table.ColumnCount = 11;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.table.Controls.Add(this.tB_tour9, 10, 0);
            this.table.Controls.Add(this.tB_tour8, 9, 0);
            this.table.Controls.Add(this.tB_tour7, 8, 0);
            this.table.Controls.Add(this.tB_tour6, 7, 0);
            this.table.Controls.Add(this.tB_tour5, 6, 0);
            this.table.Controls.Add(this.tB_tour4, 5, 0);
            this.table.Controls.Add(this.tB_tour3, 4, 0);
            this.table.Controls.Add(this.tB_tour2, 3, 0);
            this.table.Controls.Add(this.tB_tour1, 2, 0);
            this.table.Controls.Add(this.head_name, 1, 0);
            this.table.Controls.Add(this.head_surname, 0, 0);
            this.table.Location = new System.Drawing.Point(13, 12);
            this.table.Name = "table";
            this.table.RowCount = 13;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(471, 264);
            this.table.TabIndex = 4;
            // 
            // tB_tour9
            // 
            this.tB_tour9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_tour9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_tour9.Location = new System.Drawing.Point(423, 3);
            this.tB_tour9.Name = "tB_tour9";
            this.tB_tour9.ReadOnly = true;
            this.tB_tour9.Size = new System.Drawing.Size(24, 13);
            this.tB_tour9.TabIndex = 15;
            this.tB_tour9.TabStop = false;
            // 
            // tB_tour8
            // 
            this.tB_tour8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_tour8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_tour8.Location = new System.Drawing.Point(393, 3);
            this.tB_tour8.Name = "tB_tour8";
            this.tB_tour8.ReadOnly = true;
            this.tB_tour8.Size = new System.Drawing.Size(24, 13);
            this.tB_tour8.TabIndex = 14;
            this.tB_tour8.TabStop = false;
            // 
            // tB_tour7
            // 
            this.tB_tour7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_tour7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_tour7.Location = new System.Drawing.Point(363, 3);
            this.tB_tour7.Name = "tB_tour7";
            this.tB_tour7.ReadOnly = true;
            this.tB_tour7.Size = new System.Drawing.Size(24, 13);
            this.tB_tour7.TabIndex = 13;
            this.tB_tour7.TabStop = false;
            // 
            // tB_tour6
            // 
            this.tB_tour6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_tour6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_tour6.Location = new System.Drawing.Point(333, 3);
            this.tB_tour6.Name = "tB_tour6";
            this.tB_tour6.ReadOnly = true;
            this.tB_tour6.Size = new System.Drawing.Size(24, 13);
            this.tB_tour6.TabIndex = 12;
            this.tB_tour6.TabStop = false;
            // 
            // tB_tour5
            // 
            this.tB_tour5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_tour5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_tour5.Location = new System.Drawing.Point(303, 3);
            this.tB_tour5.Name = "tB_tour5";
            this.tB_tour5.ReadOnly = true;
            this.tB_tour5.Size = new System.Drawing.Size(24, 13);
            this.tB_tour5.TabIndex = 11;
            this.tB_tour5.TabStop = false;
            // 
            // tB_tour4
            // 
            this.tB_tour4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_tour4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_tour4.Location = new System.Drawing.Point(273, 3);
            this.tB_tour4.Name = "tB_tour4";
            this.tB_tour4.ReadOnly = true;
            this.tB_tour4.Size = new System.Drawing.Size(24, 13);
            this.tB_tour4.TabIndex = 10;
            this.tB_tour4.TabStop = false;
            // 
            // tB_tour3
            // 
            this.tB_tour3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_tour3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_tour3.Location = new System.Drawing.Point(243, 3);
            this.tB_tour3.Name = "tB_tour3";
            this.tB_tour3.ReadOnly = true;
            this.tB_tour3.Size = new System.Drawing.Size(24, 13);
            this.tB_tour3.TabIndex = 9;
            this.tB_tour3.TabStop = false;
            // 
            // tB_tour2
            // 
            this.tB_tour2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_tour2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_tour2.Location = new System.Drawing.Point(213, 3);
            this.tB_tour2.Name = "tB_tour2";
            this.tB_tour2.ReadOnly = true;
            this.tB_tour2.Size = new System.Drawing.Size(24, 13);
            this.tB_tour2.TabIndex = 8;
            this.tB_tour2.TabStop = false;
            // 
            // tB_tour1
            // 
            this.tB_tour1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_tour1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_tour1.Location = new System.Drawing.Point(183, 3);
            this.tB_tour1.Name = "tB_tour1";
            this.tB_tour1.ReadOnly = true;
            this.tB_tour1.Size = new System.Drawing.Size(24, 13);
            this.tB_tour1.TabIndex = 7;
            this.tB_tour1.TabStop = false;
            this.tB_tour1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // head_name
            // 
            this.head_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.head_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.head_name.Location = new System.Drawing.Point(103, 3);
            this.head_name.Name = "head_name";
            this.head_name.ReadOnly = true;
            this.head_name.Size = new System.Drawing.Size(74, 13);
            this.head_name.TabIndex = 6;
            this.head_name.TabStop = false;
            this.head_name.Text = "Name";
            // 
            // head_surname
            // 
            this.head_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.head_surname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.head_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.head_surname.Location = new System.Drawing.Point(3, 3);
            this.head_surname.Name = "head_surname";
            this.head_surname.ReadOnly = true;
            this.head_surname.Size = new System.Drawing.Size(94, 13);
            this.head_surname.TabIndex = 5;
            this.head_surname.TabStop = false;
            this.head_surname.Text = "Surname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 328);
            this.Controls.Add(this.table);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.start_B);
            this.Controls.Add(this.addPlayer_B);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tournament";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPlayer_B;
        private System.Windows.Forms.Button start_B;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.TextBox head_surname;
        private System.Windows.Forms.TextBox tB_tour1;
        private System.Windows.Forms.TextBox head_name;
        private System.Windows.Forms.TextBox tB_tour9;
        private System.Windows.Forms.TextBox tB_tour8;
        private System.Windows.Forms.TextBox tB_tour7;
        private System.Windows.Forms.TextBox tB_tour6;
        private System.Windows.Forms.TextBox tB_tour5;
        private System.Windows.Forms.TextBox tB_tour4;
        private System.Windows.Forms.TextBox tB_tour3;
        private System.Windows.Forms.TextBox tB_tour2;
    }
}


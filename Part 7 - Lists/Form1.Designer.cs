namespace Part_7___Lists
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
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblInstructionsNumbers = new System.Windows.Forms.Label();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblInstructionsHeroesAdd = new System.Windows.Forms.Label();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.lblInstructionsHeroesRemove = new System.Windows.Forms.Label();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(59, 27);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(108, 26);
            this.lblNumbers.TabIndex = 0;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.Location = new System.Drawing.Point(361, 27);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(88, 26);
            this.lblHeroes.TabIndex = 1;
            this.lblHeroes.Text = "Heroes";
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Location = new System.Drawing.Point(411, 56);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(75, 23);
            this.btnSortHeroes.TabIndex = 2;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.Location = new System.Drawing.Point(330, 56);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(75, 23);
            this.btnNewHeroes.TabIndex = 3;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = true;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Location = new System.Drawing.Point(140, 56);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnSortNumbers.TabIndex = 4;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Location = new System.Drawing.Point(59, 56);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnNewNumbers.TabIndex = 5;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(59, 85);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(156, 121);
            this.lstNumbers.TabIndex = 6;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(330, 85);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(156, 121);
            this.lstHeroes.TabIndex = 7;
            // 
            // lblInstructionsNumbers
            // 
            this.lblInstructionsNumbers.AutoSize = true;
            this.lblInstructionsNumbers.Location = new System.Drawing.Point(68, 209);
            this.lblInstructionsNumbers.Name = "lblInstructionsNumbers";
            this.lblInstructionsNumbers.Size = new System.Drawing.Size(141, 13);
            this.lblInstructionsNumbers.TabIndex = 8;
            this.lblInstructionsNumbers.Text = "Select a Number to Remove";
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Location = new System.Drawing.Point(59, 237);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveNumber.TabIndex = 9;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(140, 237);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAllNumbers.TabIndex = 10;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 279);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // lblInstructionsHeroesAdd
            // 
            this.lblInstructionsHeroesAdd.AutoSize = true;
            this.lblInstructionsHeroesAdd.Location = new System.Drawing.Point(342, 209);
            this.lblInstructionsHeroesAdd.Name = "lblInstructionsHeroesAdd";
            this.lblInstructionsHeroesAdd.Size = new System.Drawing.Size(132, 13);
            this.lblInstructionsHeroesAdd.TabIndex = 12;
            this.lblInstructionsHeroesAdd.Text = "Enter a Hero Name to Add";
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(330, 239);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(93, 20);
            this.txtAddHero.TabIndex = 13;
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(429, 237);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(57, 23);
            this.btnAddHero.TabIndex = 14;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // lblInstructionsHeroesRemove
            // 
            this.lblInstructionsHeroesRemove.AutoSize = true;
            this.lblInstructionsHeroesRemove.Location = new System.Drawing.Point(333, 279);
            this.lblInstructionsHeroesRemove.Name = "lblInstructionsHeroesRemove";
            this.lblInstructionsHeroesRemove.Size = new System.Drawing.Size(153, 13);
            this.lblInstructionsHeroesRemove.TabIndex = 15;
            this.lblInstructionsHeroesRemove.Text = "Enter a Hero Name to Remove";
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(330, 327);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(93, 20);
            this.txtRemoveHero.TabIndex = 16;
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Location = new System.Drawing.Point(429, 327);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(57, 23);
            this.btnRemoveHero.TabIndex = 17;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.lblInstructionsHeroesRemove);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.lblInstructionsHeroesAdd);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lblInstructionsNumbers);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblInstructionsNumbers;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblInstructionsHeroesAdd;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Label lblInstructionsHeroesRemove;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.Button btnRemoveHero;
    }
}


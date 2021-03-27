namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExistingLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentDashboardLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(62, 38);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(385, 50);
            this.tournamentDashboardLabel.TabIndex = 7;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingLabel
            // 
            this.loadExistingLabel.AutoSize = true;
            this.loadExistingLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadExistingLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadExistingLabel.Location = new System.Drawing.Point(96, 97);
            this.loadExistingLabel.Name = "loadExistingLabel";
            this.loadExistingLabel.Size = new System.Drawing.Size(322, 37);
            this.loadExistingLabel.TabIndex = 8;
            this.loadExistingLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(46, 150);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(427, 38);
            this.loadExistingTournamentDropDown.TabIndex = 23;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadTournamentButton.Location = new System.Drawing.Point(123, 203);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(264, 43);
            this.loadTournamentButton.TabIndex = 24;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            this.loadTournamentButton.Click += new System.EventHandler(this.loadTournamentButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentButton.Location = new System.Drawing.Point(71, 309);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(364, 91);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 437);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.loadExistingLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.Label loadExistingLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}
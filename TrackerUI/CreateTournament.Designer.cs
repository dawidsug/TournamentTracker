namespace TrackerUI
{
    partial class CreateTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournament));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.teamDropDown = new System.Windows.Forms.ComboBox();
            this.tournamentNameText = new System.Windows.Forms.TextBox();
            this.entryFeeText = new System.Windows.Forms.TextBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.teamsPlayersListbox = new System.Windows.Forms.ListBox();
            this.prizesListbox = new System.Windows.Forms.ListBox();
            this.teamsPlayersLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.teamsPlayersDelete = new System.Windows.Forms.Button();
            this.prizesDelete = new System.Windows.Forms.Button();
            this.createNewTeam = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.headerLabel.Location = new System.Drawing.Point(26, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(317, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentNameLabel.Location = new System.Drawing.Point(28, 88);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.tournamentNameLabel.TabIndex = 3;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.entryFeeLabel.Location = new System.Drawing.Point(28, 201);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.entryFeeLabel.TabIndex = 4;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectTeamLabel.Location = new System.Drawing.Point(28, 272);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.selectTeamLabel.TabIndex = 5;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // teamDropDown
            // 
            this.teamDropDown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamDropDown.FormattingEnabled = true;
            this.teamDropDown.Location = new System.Drawing.Point(35, 312);
            this.teamDropDown.Name = "teamDropDown";
            this.teamDropDown.Size = new System.Drawing.Size(308, 38);
            this.teamDropDown.TabIndex = 6;
            // 
            // tournamentNameText
            // 
            this.tournamentNameText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameText.Location = new System.Drawing.Point(35, 128);
            this.tournamentNameText.Name = "tournamentNameText";
            this.tournamentNameText.Size = new System.Drawing.Size(308, 35);
            this.tournamentNameText.TabIndex = 7;
            // 
            // entryFeeText
            // 
            this.entryFeeText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeText.Location = new System.Drawing.Point(177, 204);
            this.entryFeeText.Name = "entryFeeText";
            this.entryFeeText.Size = new System.Drawing.Size(166, 35);
            this.entryFeeText.TabIndex = 8;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamButton.Location = new System.Drawing.Point(93, 372);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(177, 43);
            this.addTeamButton.TabIndex = 9;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeButton.Location = new System.Drawing.Point(93, 439);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(177, 43);
            this.createPrizeButton.TabIndex = 10;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentButton.Location = new System.Drawing.Point(273, 495);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(228, 43);
            this.createTournamentButton.TabIndex = 11;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // teamsPlayersListbox
            // 
            this.teamsPlayersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamsPlayersListbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamsPlayersListbox.FormattingEnabled = true;
            this.teamsPlayersListbox.ItemHeight = 30;
            this.teamsPlayersListbox.Location = new System.Drawing.Point(386, 118);
            this.teamsPlayersListbox.Name = "teamsPlayersListbox";
            this.teamsPlayersListbox.Size = new System.Drawing.Size(305, 122);
            this.teamsPlayersListbox.TabIndex = 12;
            // 
            // prizesListbox
            // 
            this.prizesListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesListbox.FormattingEnabled = true;
            this.prizesListbox.ItemHeight = 30;
            this.prizesListbox.Location = new System.Drawing.Point(386, 312);
            this.prizesListbox.Name = "prizesListbox";
            this.prizesListbox.Size = new System.Drawing.Size(305, 122);
            this.prizesListbox.TabIndex = 13;
            // 
            // teamsPlayersLabel
            // 
            this.teamsPlayersLabel.AutoSize = true;
            this.teamsPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamsPlayersLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamsPlayersLabel.Location = new System.Drawing.Point(379, 78);
            this.teamsPlayersLabel.Name = "teamsPlayersLabel";
            this.teamsPlayersLabel.Size = new System.Drawing.Size(184, 37);
            this.teamsPlayersLabel.TabIndex = 14;
            this.teamsPlayersLabel.Text = "Teams/Players";
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.prizesLabel.Location = new System.Drawing.Point(379, 272);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(85, 37);
            this.prizesLabel.TabIndex = 15;
            this.prizesLabel.Text = "Prizes";
            // 
            // teamsPlayersDelete
            // 
            this.teamsPlayersDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamsPlayersDelete.Location = new System.Drawing.Point(709, 152);
            this.teamsPlayersDelete.Name = "teamsPlayersDelete";
            this.teamsPlayersDelete.Size = new System.Drawing.Size(108, 72);
            this.teamsPlayersDelete.TabIndex = 16;
            this.teamsPlayersDelete.Text = "Delete Selected";
            this.teamsPlayersDelete.UseVisualStyleBackColor = true;
            this.teamsPlayersDelete.Click += new System.EventHandler(this.teamsPlayersDelete_Click);
            // 
            // prizesDelete
            // 
            this.prizesDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesDelete.Location = new System.Drawing.Point(709, 343);
            this.prizesDelete.Name = "prizesDelete";
            this.prizesDelete.Size = new System.Drawing.Size(108, 72);
            this.prizesDelete.TabIndex = 17;
            this.prizesDelete.Text = "Delete Selected";
            this.prizesDelete.UseVisualStyleBackColor = true;
            this.prizesDelete.Click += new System.EventHandler(this.prizesDelete_Click);
            // 
            // createNewTeam
            // 
            this.createNewTeam.AutoSize = true;
            this.createNewTeam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.createNewTeam.Location = new System.Drawing.Point(212, 285);
            this.createNewTeam.Name = "createNewTeam";
            this.createNewTeam.Size = new System.Drawing.Size(131, 21);
            this.createNewTeam.TabIndex = 18;
            this.createNewTeam.TabStop = true;
            this.createNewTeam.Text = "Create New Team";
            this.createNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeam_LinkClicked);
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 564);
            this.Controls.Add(this.createNewTeam);
            this.Controls.Add(this.prizesDelete);
            this.Controls.Add(this.teamsPlayersDelete);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.teamsPlayersLabel);
            this.Controls.Add(this.prizesListbox);
            this.Controls.Add(this.teamsPlayersListbox);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.entryFeeText);
            this.Controls.Add(this.tournamentNameText);
            this.Controls.Add(this.teamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournament";
            this.Text = "Tournament Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox teamDropDown;
        private System.Windows.Forms.TextBox tournamentNameText;
        private System.Windows.Forms.TextBox entryFeeText;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.ListBox teamsPlayersListbox;
        private System.Windows.Forms.ListBox prizesListbox;
        private System.Windows.Forms.Label teamsPlayersLabel;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.Button teamsPlayersDelete;
        private System.Windows.Forms.Button prizesDelete;
        private System.Windows.Forms.LinkLabel createNewTeam;
    }
}
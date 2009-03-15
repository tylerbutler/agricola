namespace agricola
{
    partial class GameSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( GameSetupForm ) );
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numPlayersComboBox = new System.Windows.Forms.ComboBox();
            this.playersGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.player1ColorBox = new System.Windows.Forms.ComboBox();
            this.player2ColorBox = new System.Windows.Forms.ComboBox();
            this.player3ColorBox = new System.Windows.Forms.ComboBox();
            this.player4ColorBox = new System.Windows.Forms.ComboBox();
            this.player5ColorBox = new System.Windows.Forms.ComboBox();
            this.player1NameBox = new System.Windows.Forms.TextBox();
            this.player2NameBox = new System.Windows.Forms.TextBox();
            this.player3NameBox = new System.Windows.Forms.TextBox();
            this.player4NameBox = new System.Windows.Forms.TextBox();
            this.player5NameBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.familyRadioButton = new System.Windows.Forms.RadioButton();
            this.regularRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.playersGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add( this.groupBox2 );
            this.flowLayoutPanel1.Controls.Add( this.playersGroupBox );
            this.flowLayoutPanel1.Controls.Add( this.groupBox1 );
            this.flowLayoutPanel1.Controls.Add( this.cancelButton );
            this.flowLayoutPanel1.Controls.Add( this.okButton );
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point( 0, 0 );
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size( 268, 353 );
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.panel2 );
            this.groupBox2.Location = new System.Drawing.Point( 3, 3 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 260, 51 );
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number of Players";
            // 
            // panel2
            // 
            this.panel2.Controls.Add( this.numPlayersComboBox );
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point( 3, 16 );
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size( 254, 32 );
            this.panel2.TabIndex = 0;
            // 
            // numPlayersComboBox
            // 
            this.numPlayersComboBox.FormattingEnabled = true;
            this.numPlayersComboBox.Items.AddRange( new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"} );
            this.numPlayersComboBox.Location = new System.Drawing.Point( 7, 4 );
            this.numPlayersComboBox.Name = "numPlayersComboBox";
            this.numPlayersComboBox.Size = new System.Drawing.Size( 61, 21 );
            this.numPlayersComboBox.Sorted = true;
            this.numPlayersComboBox.TabIndex = 0;
            this.numPlayersComboBox.Text = "1";
            // 
            // playersGroupBox
            // 
            this.playersGroupBox.Controls.Add( this.tableLayoutPanel1 );
            this.playersGroupBox.Location = new System.Drawing.Point( 3, 60 );
            this.playersGroupBox.Name = "playersGroupBox";
            this.playersGroupBox.Size = new System.Drawing.Size( 260, 182 );
            this.playersGroupBox.TabIndex = 0;
            this.playersGroupBox.TabStop = false;
            this.playersGroupBox.Text = "Players";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 24F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 38F ) );
            this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 38F ) );
            this.tableLayoutPanel1.Controls.Add( this.label1, 0, 0 );
            this.tableLayoutPanel1.Controls.Add( this.label2, 0, 1 );
            this.tableLayoutPanel1.Controls.Add( this.label3, 0, 2 );
            this.tableLayoutPanel1.Controls.Add( this.label4, 0, 3 );
            this.tableLayoutPanel1.Controls.Add( this.label5, 0, 4 );
            this.tableLayoutPanel1.Controls.Add( this.player1ColorBox, 2, 0 );
            this.tableLayoutPanel1.Controls.Add( this.player2ColorBox, 2, 1 );
            this.tableLayoutPanel1.Controls.Add( this.player3ColorBox, 2, 2 );
            this.tableLayoutPanel1.Controls.Add( this.player4ColorBox, 2, 3 );
            this.tableLayoutPanel1.Controls.Add( this.player5ColorBox, 2, 4 );
            this.tableLayoutPanel1.Controls.Add( this.player1NameBox, 1, 0 );
            this.tableLayoutPanel1.Controls.Add( this.player2NameBox, 1, 1 );
            this.tableLayoutPanel1.Controls.Add( this.player3NameBox, 1, 2 );
            this.tableLayoutPanel1.Controls.Add( this.player4NameBox, 1, 3 );
            this.tableLayoutPanel1.Controls.Add( this.player5NameBox, 1, 4 );
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 6, 9 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            this.tableLayoutPanel1.Size = new System.Drawing.Size( 248, 167 );
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 11, 10 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 45, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 11, 43 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 45, 13 );
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 11, 76 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 45, 13 );
            this.label3.TabIndex = 2;
            this.label3.Text = "Player 3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 11, 109 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 45, 13 );
            this.label4.TabIndex = 2;
            this.label4.Text = "Player 4";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 11, 143 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 45, 13 );
            this.label5.TabIndex = 2;
            this.label5.Text = "Player 5";
            // 
            // player1ColorBox
            // 
            this.player1ColorBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.player1ColorBox.FormattingEnabled = true;
            this.player1ColorBox.Location = new System.Drawing.Point( 156, 6 );
            this.player1ColorBox.Name = "player1ColorBox";
            this.player1ColorBox.Size = new System.Drawing.Size( 89, 21 );
            this.player1ColorBox.TabIndex = 3;
            // 
            // player2ColorBox
            // 
            this.player2ColorBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.player2ColorBox.Enabled = false;
            this.player2ColorBox.FormattingEnabled = true;
            this.player2ColorBox.Items.AddRange( new object[] {
            agricola.PlayerColors.Blue,
            agricola.PlayerColors.Red,
            agricola.PlayerColors.White,
            agricola.PlayerColors.Purple,
            agricola.PlayerColors.Green} );
            this.player2ColorBox.Location = new System.Drawing.Point( 156, 39 );
            this.player2ColorBox.Name = "player2ColorBox";
            this.player2ColorBox.Size = new System.Drawing.Size( 89, 21 );
            this.player2ColorBox.TabIndex = 3;
            // 
            // player3ColorBox
            // 
            this.player3ColorBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.player3ColorBox.Enabled = false;
            this.player3ColorBox.FormattingEnabled = true;
            this.player3ColorBox.Items.AddRange( new object[] {
            agricola.PlayerColors.Blue,
            agricola.PlayerColors.Red,
            agricola.PlayerColors.White,
            agricola.PlayerColors.Purple,
            agricola.PlayerColors.Green} );
            this.player3ColorBox.Location = new System.Drawing.Point( 156, 72 );
            this.player3ColorBox.Name = "player3ColorBox";
            this.player3ColorBox.Size = new System.Drawing.Size( 89, 21 );
            this.player3ColorBox.TabIndex = 3;
            // 
            // player4ColorBox
            // 
            this.player4ColorBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.player4ColorBox.Enabled = false;
            this.player4ColorBox.FormattingEnabled = true;
            this.player4ColorBox.Items.AddRange( new object[] {
            agricola.PlayerColors.Blue,
            agricola.PlayerColors.Red,
            agricola.PlayerColors.White,
            agricola.PlayerColors.Purple,
            agricola.PlayerColors.Green} );
            this.player4ColorBox.Location = new System.Drawing.Point( 156, 105 );
            this.player4ColorBox.Name = "player4ColorBox";
            this.player4ColorBox.Size = new System.Drawing.Size( 89, 21 );
            this.player4ColorBox.TabIndex = 3;
            // 
            // player5ColorBox
            // 
            this.player5ColorBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.player5ColorBox.Enabled = false;
            this.player5ColorBox.FormattingEnabled = true;
            this.player5ColorBox.Items.AddRange( new object[] {
            agricola.PlayerColors.Blue,
            agricola.PlayerColors.Red,
            agricola.PlayerColors.White,
            agricola.PlayerColors.Purple,
            agricola.PlayerColors.Green} );
            this.player5ColorBox.Location = new System.Drawing.Point( 156, 139 );
            this.player5ColorBox.Name = "player5ColorBox";
            this.player5ColorBox.Size = new System.Drawing.Size( 89, 21 );
            this.player5ColorBox.TabIndex = 3;
            // 
            // player1NameBox
            // 
            this.player1NameBox.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.player1NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1NameBox.Location = new System.Drawing.Point( 62, 6 );
            this.player1NameBox.Name = "player1NameBox";
            this.player1NameBox.Size = new System.Drawing.Size( 88, 20 );
            this.player1NameBox.TabIndex = 4;
            // 
            // player2NameBox
            // 
            this.player2NameBox.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.player2NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2NameBox.Enabled = false;
            this.player2NameBox.Location = new System.Drawing.Point( 62, 39 );
            this.player2NameBox.Name = "player2NameBox";
            this.player2NameBox.Size = new System.Drawing.Size( 88, 20 );
            this.player2NameBox.TabIndex = 4;
            // 
            // player3NameBox
            // 
            this.player3NameBox.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.player3NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player3NameBox.Enabled = false;
            this.player3NameBox.Location = new System.Drawing.Point( 62, 72 );
            this.player3NameBox.Name = "player3NameBox";
            this.player3NameBox.Size = new System.Drawing.Size( 88, 20 );
            this.player3NameBox.TabIndex = 4;
            // 
            // player4NameBox
            // 
            this.player4NameBox.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.player4NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player4NameBox.Enabled = false;
            this.player4NameBox.Location = new System.Drawing.Point( 62, 105 );
            this.player4NameBox.Name = "player4NameBox";
            this.player4NameBox.Size = new System.Drawing.Size( 88, 20 );
            this.player4NameBox.TabIndex = 4;
            // 
            // player5NameBox
            // 
            this.player5NameBox.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.player5NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player5NameBox.Enabled = false;
            this.player5NameBox.Location = new System.Drawing.Point( 62, 139 );
            this.player5NameBox.Name = "player5NameBox";
            this.player5NameBox.Size = new System.Drawing.Size( 88, 20 );
            this.player5NameBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.panel1 );
            this.groupBox1.Location = new System.Drawing.Point( 3, 248 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 260, 69 );
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Mode";
            // 
            // panel1
            // 
            this.panel1.Controls.Add( this.familyRadioButton );
            this.panel1.Controls.Add( this.regularRadioButton );
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point( 3, 16 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 254, 50 );
            this.panel1.TabIndex = 2;
            // 
            // familyRadioButton
            // 
            this.familyRadioButton.AutoSize = true;
            this.familyRadioButton.Checked = true;
            this.familyRadioButton.Location = new System.Drawing.Point( 14, 3 );
            this.familyRadioButton.Name = "familyRadioButton";
            this.familyRadioButton.Size = new System.Drawing.Size( 54, 17 );
            this.familyRadioButton.TabIndex = 0;
            this.familyRadioButton.TabStop = true;
            this.familyRadioButton.Text = Properties.Resources.FamilyGameVersionString;
            this.familyRadioButton.UseVisualStyleBackColor = true;
            // 
            // regularRadioButton
            // 
            this.regularRadioButton.AutoSize = true;
            this.regularRadioButton.Enabled = false;
            this.regularRadioButton.Location = new System.Drawing.Point( 14, 26 );
            this.regularRadioButton.Name = "regularRadioButton";
            this.regularRadioButton.Size = new System.Drawing.Size( 62, 17 );
            this.regularRadioButton.TabIndex = 1;
            this.regularRadioButton.Text = Properties.Resources.RegularGameVersionString;
            this.regularRadioButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point( 3, 323 );
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size( 127, 23 );
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point( 136, 323 );
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size( 127, 23 );
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler( this.okButton_Click );
            // 
            // GameSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 268, 353 );
            this.Controls.Add( this.flowLayoutPanel1 );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "GameSetupForm";
            this.Text = "New Game";
            this.flowLayoutPanel1.ResumeLayout( false );
            this.groupBox2.ResumeLayout( false );
            this.panel2.ResumeLayout( false );
            this.playersGroupBox.ResumeLayout( false );
            this.tableLayoutPanel1.ResumeLayout( false );
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout( false );
            this.panel1.ResumeLayout( false );
            this.panel1.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox playersGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox player1ColorBox;
        public System.Windows.Forms.ComboBox player2ColorBox;
        public System.Windows.Forms.ComboBox player3ColorBox;
        public System.Windows.Forms.ComboBox player4ColorBox;
        public System.Windows.Forms.ComboBox player5ColorBox;
        public System.Windows.Forms.TextBox player1NameBox;
        public System.Windows.Forms.TextBox player2NameBox;
        public System.Windows.Forms.TextBox player3NameBox;
        public System.Windows.Forms.TextBox player4NameBox;
        public System.Windows.Forms.TextBox player5NameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton regularRadioButton;
        public System.Windows.Forms.RadioButton familyRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox numPlayersComboBox;
    }
}
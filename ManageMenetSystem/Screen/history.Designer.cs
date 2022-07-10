namespace ManageMenetSystem.Screen
{
    partial class history
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkups = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBySup = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkups)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.checkups, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1161, 589);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // checkups
            // 
            this.checkups.AllowCustomTheming = false;
            this.checkups.AllowUserToAddRows = false;
            this.checkups.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.checkups.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.checkups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.checkups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.checkups.ColumnHeadersHeight = 40;
            this.checkups.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.checkups.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkups.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.checkups.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.checkups.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.checkups.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.checkups.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.checkups.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkups.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.checkups.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.checkups.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.checkups.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.checkups.CurrentTheme.Name = null;
            this.checkups.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.checkups.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkups.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.checkups.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.checkups.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkups.DefaultCellStyle = dataGridViewCellStyle3;
            this.checkups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkups.EnableHeadersVisualStyles = false;
            this.checkups.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.checkups.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.checkups.HeaderBgColor = System.Drawing.Color.Empty;
            this.checkups.HeaderForeColor = System.Drawing.Color.White;
            this.checkups.Location = new System.Drawing.Point(3, 91);
            this.checkups.Name = "checkups";
            this.checkups.ReadOnly = true;
            this.checkups.RowHeadersVisible = false;
            this.checkups.RowHeadersWidth = 51;
            this.checkups.RowTemplate.Height = 40;
            this.checkups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkups.Size = new System.Drawing.Size(1155, 495);
            this.checkups.TabIndex = 0;
            this.checkups.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1155, 82);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 76);
            this.panel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(282, 76);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Search";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchBySup);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(291, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 76);
            this.panel2.TabIndex = 1;
            // 
            // SearchBySup
            // 
            this.SearchBySup.AcceptsReturn = false;
            this.SearchBySup.AcceptsTab = false;
            this.SearchBySup.AnimationSpeed = 200;
            this.SearchBySup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchBySup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchBySup.AutoSizeHeight = true;
            this.SearchBySup.BackColor = System.Drawing.Color.Transparent;
            this.SearchBySup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBySup.BackgroundImage")));
            this.SearchBySup.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SearchBySup.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SearchBySup.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SearchBySup.BorderColorIdle = System.Drawing.Color.Silver;
            this.SearchBySup.BorderRadius = 1;
            this.SearchBySup.BorderThickness = 1;
            this.SearchBySup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchBySup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBySup.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SearchBySup.DefaultText = "";
            this.SearchBySup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBySup.FillColor = System.Drawing.Color.White;
            this.SearchBySup.HideSelection = true;
            this.SearchBySup.IconLeft = null;
            this.SearchBySup.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBySup.IconPadding = 10;
            this.SearchBySup.IconRight = null;
            this.SearchBySup.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBySup.Lines = new string[0];
            this.SearchBySup.Location = new System.Drawing.Point(0, 16);
            this.SearchBySup.MaxLength = 32767;
            this.SearchBySup.MinimumSize = new System.Drawing.Size(1, 1);
            this.SearchBySup.Modified = false;
            this.SearchBySup.Multiline = false;
            this.SearchBySup.Name = "SearchBySup";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchBySup.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SearchBySup.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchBySup.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchBySup.OnIdleState = stateProperties4;
            this.SearchBySup.Padding = new System.Windows.Forms.Padding(3);
            this.SearchBySup.PasswordChar = '\0';
            this.SearchBySup.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.SearchBySup.PlaceholderText = "Enter text";
            this.SearchBySup.ReadOnly = false;
            this.SearchBySup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchBySup.SelectedText = "";
            this.SearchBySup.SelectionLength = 0;
            this.SearchBySup.SelectionStart = 0;
            this.SearchBySup.ShortcutsEnabled = true;
            this.SearchBySup.Size = new System.Drawing.Size(282, 41);
            this.SearchBySup.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SearchBySup.TabIndex = 2;
            this.SearchBySup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchBySup.TextMarginBottom = 0;
            this.SearchBySup.TextMarginLeft = 3;
            this.SearchBySup.TextMarginTop = 1;
            this.SearchBySup.TextPlaceholder = "Enter text";
            this.SearchBySup.UseSystemPasswordChar = false;
            this.SearchBySup.WordWrap = true;
            this.SearchBySup.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 19);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 16);
            this.panel5.TabIndex = 0;
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 669);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "history";
            this.Text = "All Patients History";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkups)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView checkups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBySup;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}
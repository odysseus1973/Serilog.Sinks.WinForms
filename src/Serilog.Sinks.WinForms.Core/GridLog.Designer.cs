namespace Serilog.Sinks.WinForms.Core
{
    partial class GridLog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            LogGridView = new DataGridView();
            TimeStamp = new DataGridViewTextBoxColumn();
            Level = new DataGridViewTextBoxColumn();
            Log = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)LogGridView).BeginInit();
            SuspendLayout();
            // 
            // LogGridView
            // 
            LogGridView.AllowUserToAddRows = false;
            LogGridView.AllowUserToDeleteRows = false;
            LogGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            LogGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            LogGridView.BackgroundColor = SystemColors.Control;
            LogGridView.BorderStyle = BorderStyle.Fixed3D;
            LogGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LogGridView.Columns.AddRange(new DataGridViewColumn[] { TimeStamp, Level, Log });
            LogGridView.Dock = DockStyle.Fill;
            LogGridView.Location = new Point(0, 0);
            LogGridView.Margin = new Padding(6, 7, 6, 7);
            LogGridView.Name = "LogGridView";
            LogGridView.RowHeadersVisible = false;
            LogGridView.RowHeadersWidth = 62;
            LogGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            LogGridView.Size = new Size(716, 346);
            LogGridView.TabIndex = 0;
            // 
            // TimeStamp
            // 
            TimeStamp.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TimeStamp.HeaderText = "TimeStamp";
            TimeStamp.MinimumWidth = 8;
            TimeStamp.Name = "TimeStamp";
            TimeStamp.Width = 152;
            // 
            // Level
            // 
            Level.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Level.HeaderText = "Level";
            Level.MinimumWidth = 8;
            Level.Name = "Level";
            Level.Width = 96;
            // 
            // Log
            // 
            Log.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Log.DefaultCellStyle = dataGridViewCellStyle1;
            Log.HeaderText = "Log";
            Log.MinimumWidth = 8;
            Log.Name = "Log";
            // 
            // GridLog
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LogGridView);
            Margin = new Padding(6, 7, 6, 7);
            Name = "GridLog";
            Size = new Size(716, 346);
            Load += GridLog_Load;
            ((System.ComponentModel.ISupportInitialize)LogGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LogGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log;
    }
}

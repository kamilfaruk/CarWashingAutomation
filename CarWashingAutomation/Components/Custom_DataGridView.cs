/* Coder by KFY */
using System.Drawing;
using System.Windows.Forms;

namespace CarWashingAutomation.Components
{
    class Custom_DataGridView : DataGridView
    {
        public Custom_DataGridView()
        {
            this.BackgroundColor = Color.FromArgb(64, 69, 76);
            this.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.BorderStyle = BorderStyle.None;
            this.RowsDefaultCellStyle.BackColor = Color.FromArgb(37, 40, 45);
            this.RowsDefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 192);
            this.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(74, 80, 89);
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 192);
            this.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(16, 154, 208);
            this.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 69, 76);
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            this.EnableHeadersVisualStyles = false;
            this.RowHeadersVisible = false;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 69, 76);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 192);
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReadOnly = true;
            this.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
            this.RowTemplate.Resizable = DataGridViewTriState.False;
            this.ClearSelection();
            this.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(delegate (object o, DataGridViewBindingCompleteEventArgs a)
            {
                this.ClearSelection();
            });
            this.SelectionChanged += new System.EventHandler(delegate (object o, System.EventArgs a)
            {
                this.ClearSelection();
            });
            this.Click += new System.EventHandler(delegate (object o, System.EventArgs a)
            {
                this.ClearSelection();
            });
        }
    }
}

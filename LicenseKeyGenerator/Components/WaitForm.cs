/* Coder by KFY*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace LicenseKeyGenerator.Components
{
    public partial class WaitForm : Form
    {
        public Action Worker { get; set; }
        public WaitForm(Action _worker, string _text, Image _image = null, float _textSize = 14F, ContentAlignment _contentAlignment = ContentAlignment.MiddleCenter)
        {
            try
            {
                InitializeComponent();
                if (_image == null)
                {
                    this.Gif_Pbx.Dispose();
                }
                else
                {
                    this.Gif_Pbx.Image = _image;
                    this.Form_Lbl.Parent = Gif_Pbx;
                }
                if (_worker == null && _text == null)
                {
                    this.Close();
                }
                else
                {
                    this.Form_Lbl.Text = _text;
                    this.Form_Lbl.Font = new Font("Microsoft Sans Serif", _textSize, FontStyle.Bold);
                    this.Form_Lbl.TextAlign = _contentAlignment;
                    Worker = _worker;
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("WaitForm.WaitForm -> ", _ex);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("WaitForm.OnLoad -> ", _ex);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                base.OnPaint(e);
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
                Pen pen = new Pen(Color.FromArgb(16, 154, 208));
                g.DrawRectangle(pen, rect);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("WaitForm.OnPaint -> ", _ex);
            }
        }
    }
}

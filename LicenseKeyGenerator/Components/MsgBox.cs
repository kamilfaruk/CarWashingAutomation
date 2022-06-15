/* Coder by KFY */
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace LicenseKeyGenerator.Components
{
    public class MsgBox : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        private Panel _plHeader = new Panel();
        private Panel _plFooter = new Panel();
        private Panel _plIcon = new Panel();
        private PictureBox _picIcon = new PictureBox();
        private FlowLayoutPanel _flpButtons = new FlowLayoutPanel();
        private Label _lblTitle;
        private Label _lblMessage;
        private List<Button> _buttonCollection = new List<Button>();
        public DialogResult _buttonResult = new DialogResult();
        private Timer _timer;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);
        /*
          using (MsgBox _msgBox = new MsgBox())
          {
             _msgBox.Show("message", "header", MsgBox.Buttons.X, MsgBox.Icons.X);
          }
        */
        public MsgBox()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(64, 69, 76);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new Padding(3);
            this.Width = 400;
            this.Icon = Properties.Resources.CarWashingAutomation_Icon;

            _lblTitle = new Label();
            _lblTitle.ForeColor = Color.FromArgb(16, 154, 208);
            _lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            _lblTitle.Dock = DockStyle.Top;
            _lblTitle.Height = 50;

            _lblMessage = new Label();
            _lblMessage.ForeColor = Color.FromArgb(192, 192, 192);
            _lblMessage.Font = new Font("Segoe UI", 10);
            _lblMessage.Dock = DockStyle.Fill;

            _flpButtons.FlowDirection = FlowDirection.RightToLeft;
            _flpButtons.Dock = DockStyle.Fill;

            _plHeader.Dock = DockStyle.Fill;
            _plHeader.Padding = new Padding(20);
            _plHeader.Controls.Add(_lblMessage);
            _plHeader.Controls.Add(_lblTitle);

            _plFooter.Dock = DockStyle.Bottom;
            _plFooter.Padding = new Padding(20);
            _plFooter.BackColor = Color.FromArgb(47, 52, 58);
            _plFooter.Height = 80;
            _plFooter.Controls.Add(_flpButtons);

            _picIcon.Width = 32;
            _picIcon.Height = 32;
            _picIcon.Location = new Point(30, 50);
            _picIcon.SizeMode = PictureBoxSizeMode.Zoom;

            _plIcon.Dock = DockStyle.Left;
            _plIcon.Padding = new Padding(20);
            _plIcon.Width = 70;
            _plIcon.Controls.Add(_picIcon);

            this.Controls.Add(_plHeader);
            this.Controls.Add(_plIcon);
            this.Controls.Add(_plFooter);
        }
        public void Show(string message)
        {
            Form _formBackground = new Form();
            try
            {
                _formBackground.StartPosition = FormStartPosition.Manual;
                _formBackground.FormBorderStyle = FormBorderStyle.None;
                _formBackground.Opacity = .50d;
                _formBackground.BackColor = Color.Black;
                _formBackground.WindowState = FormWindowState.Maximized;
                _formBackground.TopMost = true;
                _formBackground.Location = this.Location;
                _formBackground.ShowInTaskbar = false;
                _formBackground.Show();
                this.Owner = _formBackground;
                this._lblMessage.Text = message;
                this.Size = MessageSize(message);
                InitButtons(Buttons.OK);
                this.ShowDialog();
                MessageBeep(0);
                _formBackground.Dispose();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MsgBox.Show(message) -> ", _ex);
            }
            finally
            {
                _formBackground.Dispose();
            }
        }
        public void Show(string message, string title)
        {
            Form _formBackground = new Form();
            try
            {
                _formBackground.StartPosition = FormStartPosition.Manual;
                _formBackground.FormBorderStyle = FormBorderStyle.None;
                _formBackground.Opacity = .50d;
                _formBackground.BackColor = Color.Black;
                _formBackground.WindowState = FormWindowState.Maximized;
                _formBackground.TopMost = true;
                _formBackground.Location = this.Location;
                _formBackground.ShowInTaskbar = false;
                _formBackground.Show();
                this.Owner = _formBackground;
                this._lblMessage.Text = message;
                this._lblTitle.Text = title;
                this.Size = MessageSize(message);
                InitButtons(Buttons.OK);
                this.ShowDialog();
                MessageBeep(0);
                _formBackground.Dispose();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MsgBox.Show(message,title) -> ", _ex);
            }
            finally
            {
                _formBackground.Dispose();
            }
        }
        public DialogResult Show(string message, string title, Buttons buttons)
        {
            Form _formBackground = new Form();
            try
            {
                _formBackground.StartPosition = FormStartPosition.Manual;
                _formBackground.FormBorderStyle = FormBorderStyle.None;
                _formBackground.Opacity = .50d;
                _formBackground.BackColor = Color.Black;
                _formBackground.WindowState = FormWindowState.Maximized;
                _formBackground.TopMost = true;
                _formBackground.Location = this.Location;
                _formBackground.ShowInTaskbar = false;
                _formBackground.Show();
                this.Owner = _formBackground;
                this._lblMessage.Text = message;
                this._lblTitle.Text = title;
                this._plIcon.Hide();
                InitButtons(buttons);
                this.Size = MessageSize(message);
                this.ShowDialog();
                MessageBeep(0);
                _formBackground.Dispose();
                return _buttonResult;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MsgBox.Show(message,title,button) -> ", _ex);
                return DialogResult.None;
            }
            finally
            {
                _formBackground.Dispose();
            }
        }
        public DialogResult Show(string message, string title, Buttons buttons, Icons icon)
        {
            Form _formBackground = new Form();
            try
            {
                _formBackground.StartPosition = FormStartPosition.Manual;
                _formBackground.FormBorderStyle = FormBorderStyle.None;
                _formBackground.Opacity = .50d;
                _formBackground.BackColor = Color.Black;
                _formBackground.WindowState = FormWindowState.Maximized;
                _formBackground.TopMost = true;
                _formBackground.Location = this.Location;
                _formBackground.ShowInTaskbar = false;
                _formBackground.Show();
                this.Owner = _formBackground;
                this._lblMessage.Text = message;
                this._lblTitle.Text = title;
                InitButtons(buttons);
                InitIcon(icon);
                this.Size = MessageSize(message);
                this.ShowDialog();
                MessageBeep(0);
                _formBackground.Dispose();
                return _buttonResult;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MsgBox.Show(message,title,button,icon) -> ", _ex);
                return DialogResult.None;
            }
            finally
            {
                _formBackground.Dispose();
            }
        }
        public DialogResult Show(string message, string title, Buttons buttons, Icons icon, AnimateStyle style)
        {
            Form _formBackground = new Form();
            try
            {
                _formBackground.StartPosition = FormStartPosition.Manual;
                _formBackground.FormBorderStyle = FormBorderStyle.None;
                _formBackground.Opacity = .50d;
                _formBackground.BackColor = Color.Black;
                _formBackground.WindowState = FormWindowState.Maximized;
                _formBackground.TopMost = true;
                _formBackground.Location = this.Location;
                _formBackground.ShowInTaskbar = false;
                _formBackground.Show();
                this.Owner = _formBackground;

                this._lblMessage.Text = message;
                this._lblTitle.Text = title;
                this.Height = 0;
                InitButtons(buttons);
                InitIcon(icon);
                _timer = new Timer();
                Size formSize = MessageSize(message);
                switch (style)
                {
                    case MsgBox.AnimateStyle.SlideDown:
                        this.Size = new Size(formSize.Width, 0);
                        _timer.Interval = 1;
                        _timer.Tag = new AnimateMsgBox(formSize, style);
                        break;

                    case MsgBox.AnimateStyle.FadeIn:
                        this.Size = formSize;
                        this.Opacity = 0;
                        _timer.Interval = 20;
                        _timer.Tag = new AnimateMsgBox(formSize, style);
                        break;

                    case MsgBox.AnimateStyle.ZoomIn:
                        this.Size = new Size(formSize.Width + 100, formSize.Height + 100);
                        _timer.Tag = new AnimateMsgBox(formSize, style);
                        _timer.Interval = 1;
                        break;
                }
                _timer.Tick += timer_Tick;
                _timer.Start();
                this.ShowDialog();
                MessageBeep(0);
                _formBackground.Dispose();
                return _buttonResult;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("MsgBox.Show(message,title,button,icon,animatestyle) -> ", _ex);
                return DialogResult.None;
            }
            finally
            {
                _formBackground.Dispose();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            AnimateMsgBox animate = (AnimateMsgBox)timer.Tag;

            switch (animate.Style)
            {
                case MsgBox.AnimateStyle.SlideDown:
                    if (this.Height < animate.FormSize.Height)
                    {
                        this.Height += 17;
                        this.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;

                case MsgBox.AnimateStyle.FadeIn:
                    if (this.Opacity < 1)
                    {
                        this.Opacity += 0.1;
                        this.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;

                case MsgBox.AnimateStyle.ZoomIn:
                    if (this.Width > animate.FormSize.Width)
                    {
                        this.Width -= 17;
                        this.Invalidate();
                    }
                    if (this.Height > animate.FormSize.Height)
                    {
                        this.Height -= 17;
                        this.Invalidate();
                    }
                    break;
            }
        }
        private void InitButtons(Buttons buttons)
        {
            switch (buttons)
            {
                case MsgBox.Buttons.AbortRetryIgnore:
                    this.InitAbortRetryIgnoreButtons();
                    break;

                case MsgBox.Buttons.OK:
                    this.InitOKButton();
                    break;

                case MsgBox.Buttons.OKCancel:
                    this.InitOKCancelButtons();
                    break;

                case MsgBox.Buttons.RetryCancel:
                    this.InitRetryCancelButtons();
                    break;

                case MsgBox.Buttons.YesNo:
                    this.InitYesNoButtons();
                    break;

                case MsgBox.Buttons.YesNoCancel:
                    this.InitYesNoCancelButtons();
                    break;
            }

            this._flpButtons.Controls.Clear();
            foreach (Button btn in this._buttonCollection)
            {
                btn.ForeColor = Color.FromArgb(170, 170, 170);
                btn.Font = new System.Drawing.Font("Segoe UI", 8);
                btn.Padding = new Padding(3);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Height = 30;
                btn.FlatAppearance.BorderColor = Color.FromArgb(99, 99, 98);

                this._flpButtons.Controls.Add(btn);
            }
        }
        private void InitIcon(Icons _icons)
        {
            switch (_icons)
            {
                case MsgBox.Icons.Application:
                    this._picIcon.Image = SystemIcons.Application.ToBitmap();
                    break;

                case MsgBox.Icons.Exclamation:
                    this._picIcon.Image = SystemIcons.Exclamation.ToBitmap();
                    break;

                case MsgBox.Icons.Error:
                    this._picIcon.Image = SystemIcons.Error.ToBitmap();
                    break;

                case MsgBox.Icons.Info:
                    this._picIcon.Image = SystemIcons.Information.ToBitmap();
                    break;

                case MsgBox.Icons.Question:
                    this._picIcon.Image = SystemIcons.Question.ToBitmap();
                    break;

                case MsgBox.Icons.Shield:
                    this._picIcon.Image = SystemIcons.Shield.ToBitmap();
                    break;

                case MsgBox.Icons.Warning:
                    this._picIcon.Image = SystemIcons.Warning.ToBitmap();
                    break;
            }
        }
        private void InitAbortRetryIgnoreButtons()
        {
            Button btnAbort = new Button();
            btnAbort.Text = "İptal Et";
            btnAbort.Click += ButtonClick;

            Button btnRetry = new Button();
            btnRetry.Text = "Yeniden Dene";
            btnRetry.Click += ButtonClick;

            Button btnIgnore = new Button();
            btnIgnore.Text = "Yoksay";
            btnIgnore.Click += ButtonClick;

            this._buttonCollection.Clear();
            this._buttonCollection.Add(btnAbort);
            this._buttonCollection.Add(btnRetry);
            this._buttonCollection.Add(btnIgnore);
        }
        private void InitOKButton()
        {
            Button btnOK = new Button();
            btnOK.Text = "Tamam";
            btnOK.Click += ButtonClick;

            this._buttonCollection.Clear();
            this._buttonCollection.Add(btnOK);
        }
        private void InitOKCancelButtons()
        {
            Button btnOK = new Button();
            btnOK.Text = "Tamam";
            btnOK.Click += ButtonClick;

            Button btnCancel = new Button();
            btnCancel.Text = "İptal";
            btnCancel.Click += ButtonClick;

            this._buttonCollection.Clear();
            this._buttonCollection.Add(btnOK);
            this._buttonCollection.Add(btnCancel);

        }
        private void InitRetryCancelButtons()
        {
            Button btnRetry = new Button();
            btnRetry.Text = "Tamam";
            btnRetry.Click += ButtonClick;

            Button btnCancel = new Button();
            btnCancel.Text = "İptal";
            btnCancel.Click += ButtonClick;

            this._buttonCollection.Clear();
            this._buttonCollection.Add(btnRetry);
            this._buttonCollection.Add(btnCancel);
        }
        private void InitYesNoButtons()
        {
            Button btnYes = new Button();
            btnYes.Text = "Evet";
            btnYes.Click += ButtonClick;

            Button btnNo = new Button();
            btnNo.Text = "Hayır";
            btnNo.Click += ButtonClick;

            this._buttonCollection.Clear();
            this._buttonCollection.Add(btnYes);
            this._buttonCollection.Add(btnNo);
        }
        private void InitYesNoCancelButtons()
        {
            Button btnYes = new Button();
            btnYes.Text = "Evet";
            btnYes.Click += ButtonClick;

            Button btnNo = new Button();
            btnNo.Text = "Hayır";
            btnNo.Click += ButtonClick;

            Button btnCancel = new Button();
            btnCancel.Text = "İptal";
            btnCancel.Click += ButtonClick;

            this._buttonCollection.Clear();
            this._buttonCollection.Add(btnYes);
            this._buttonCollection.Add(btnNo);
            this._buttonCollection.Add(btnCancel);
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "Abort":
                    _buttonResult = DialogResult.Abort;
                    break;

                case "İptal Et":
                    _buttonResult = DialogResult.Abort;
                    break;

                case "Retry":
                    _buttonResult = DialogResult.Retry;
                    break;

                case "Yeniden Dene":
                    _buttonResult = DialogResult.Retry;
                    break;

                case "Ignore":
                    _buttonResult = DialogResult.Ignore;
                    break;

                case "Yoksay":
                    _buttonResult = DialogResult.Ignore;
                    break;

                case "OK":
                    _buttonResult = DialogResult.OK;
                    break;

                case "Tamam":
                    _buttonResult = DialogResult.OK;
                    break;

                case "Cancel":
                    _buttonResult = DialogResult.Cancel;
                    break;

                case "İptal":
                    _buttonResult = DialogResult.Cancel;
                    break;

                case "Yes":
                    _buttonResult = DialogResult.Yes;
                    break;

                case "Evet":
                    _buttonResult = DialogResult.Yes;
                    break;

                case "No":
                    _buttonResult = DialogResult.No;
                    break;

                case "Hayır":
                    _buttonResult = DialogResult.No;
                    break;
            }
            this.Dispose();
        }
        private Size MessageSize(string message)
        {
            Graphics g = this.CreateGraphics();
            int width = 350;
            int height = 230;

            SizeF size = g.MeasureString(message, new System.Drawing.Font("Segoe UI", 10));

            if (message.Length < 150)
            {
                if ((int)size.Width > 350)
                {
                    width = (int)size.Width;
                }
            }
            else
            {
                string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
                int lines = groups.Length + 1;
                width = 700;
                height += (int)(size.Height + 10) * lines;
            }
            return new Size(width, height);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Pen pen = new Pen(Color.FromArgb(16, 154, 208));
            g.DrawRectangle(pen, rect);
        }
        public enum Buttons
        {
            AbortRetryIgnore = 1,
            OK = 2,
            OKCancel = 3,
            RetryCancel = 4,
            YesNo = 5,
            YesNoCancel = 6
        }
        public enum Icons
        {
            Application = 1,
            Exclamation = 2,
            Error = 3,
            Warning = 4,
            Info = 5,
            Question = 6,
            Shield = 7,
            Search = 8
        }
        public enum AnimateStyle
        {
            SlideDown = 1,
            FadeIn = 2,
            ZoomIn = 3
        }

    }

    class AnimateMsgBox
    {
        public Size FormSize;
        public MsgBox.AnimateStyle Style;

        public AnimateMsgBox(Size formSize, MsgBox.AnimateStyle style)
        {
            this.FormSize = formSize;
            this.Style = style;
        }
    }
}

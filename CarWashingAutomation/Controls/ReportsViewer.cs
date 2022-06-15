/* Coder by KFY */
using System;
using System.IO;
using System.Windows.Forms;
using CarWashingAutomation.Components;
using CarWashingAutomation.Models;
using CarWashingAutomation.Tools;

namespace CarWashingAutomation.Controls
{
    public partial class ReportsViewer : UserControl
    {
        public ReportsViewer()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ReportsViewer.ReportsViewer -> ", _ex);
            }
        }
        private void NewReport_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBManager _dbManager = new DBManager())
                {
                    User _user = _dbManager.GetUser(Constants.CurrentUserId);
                    PdfReport _pdfReport = new PdfReport();
                    if (_pdfReport.GenerateAndSaveReport("Kullanıcı Talebi (" + _user.ToString() + ")"))
                    {
                        RefreshReportsList();
                    }
                    else
                    {
                        using (MsgBox _msgBox = new MsgBox())
                        {
                            string _message = "Ne yazıkki güncel sistem durumunu içeren rapor dosyası oluşturulamadı. Lütfen daha sonra tekrar deneyiniz!";
                            string _title = "RAPOR OLUŞTURULAMADI";
                            _msgBox.Show(_message, _title, MsgBox.Buttons.OK, MsgBox.Icons.Warning);
                        }
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ReportsViewer.NewReport_Btn_Click -> ", _ex);
            }
        }
        private void ReadReport_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string _pdfPath = Application.StartupPath.ToString() + @"\" + Constants.ReportsDirectory + @"\" + ReportSelect_Cbx.SelectedItem.ToString();
                PDFViewer_Adobe.LoadFile(_pdfPath);
                PDFViewer_Adobe.src = _pdfPath;
                PDFViewer_Adobe.setShowToolbar(false);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ReportsViewer.ReadReport_Btn_Click -> ", _ex);
            }
        }
        private void ReportsViewer_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshReportsList();
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ReportsViewer.ReportsViewer_Load -> ", _ex);
            }
        }
        private void RefreshReportsList()
        {
            try
            {
                ReportSelect_Cbx.Items.Clear();
                string[] _reports = Directory.GetFiles(Constants.ReportsDirectory);
                foreach (string _report in _reports)
                {
                    if (_report.EndsWith(".pdf"))
                        ReportSelect_Cbx.Items.Add(Path.GetFileName(_report));
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("ReportsViewer.RefreshReportsList -> ", _ex);
            }
        }
    }
}

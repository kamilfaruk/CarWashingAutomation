/* Coder by KFY */
using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using CarWashingAutomation.Components;
using CarWashingAutomation.Models;
using System.Collections.Generic;
using System.Globalization;

namespace CarWashingAutomation.Tools
{
    public class PdfReport
    {
        public static string icSureDk;
        public static string disSure;
        public static string fabrikaDisiSureDk;

        public bool GenerateAndSaveReport(string _creationReasonText)
        {
            try
            {
                BaseFont STF_Helvetica_Turkish = BaseFont.CreateFont("Helvetica", "CP1254", BaseFont.NOT_EMBEDDED);
                Font fontBaslik = new Font(STF_Helvetica_Turkish, 12, Font.BOLD);
                Font fontKey = new Font(STF_Helvetica_Turkish, 10, Font.BOLD);
                Font fontValue = new Font(STF_Helvetica_Turkish, 10, Font.NORMAL);
                DateTime _reportStartDateTime = GetReportStartTime();
                //                    
                string _reportPath = Application.StartupPath.ToString() + @"\" + Constants.ReportsDirectory + @"\" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".pdf";
                FileStream fs = new FileStream(_reportPath, FileMode.Create, FileAccess.Write, FileShare.None);
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                //
                string _imagePath = Application.StartupPath.ToString() + "\\" + Constants.TempDirectory + "\\" + Constants.LogoFormImage;
                Image _companyImage = Image.GetInstance(_imagePath);
                _companyImage.ScaleToFit(110f, 110f);
                _companyImage.Alignment = Image.TEXTWRAP | Image.ALIGN_RIGHT;
                doc.Add(_companyImage);
                //
                doc.Add(new Paragraph(Environment.NewLine));
                doc.Add(new Paragraph("Rapor Genel Bilgileri", fontBaslik));
                //
                Chunk _companyHeader = new Chunk("Firma : ", fontKey);
                Chunk _companyValue = new Chunk(Constants.LogoFormMessage, fontValue);
                Paragraph _company = new Paragraph
                {
                    _companyHeader,
                    _companyValue
                };
                doc.Add(_company);
                //
                Chunk _reportStartTimeHeader = new Chunk("Rapor Baslangıc Saati : ", fontKey);
                Chunk _reportStartTimeValue = new Chunk(_reportStartDateTime.ToString(), fontValue);
                Paragraph _reportStartTime = new Paragraph
                {
                    _reportStartTimeHeader,
                    _reportStartTimeValue
                };
                doc.Add(_reportStartTime);
                //
                Chunk _reportStopTimeHeader = new Chunk("Rapor Bitis Saati : ", fontKey);
                Chunk _reportStopTimeValue = new Chunk(DateTime.Now.ToString(), fontValue);
                Paragraph _reportStopTime = new Paragraph
                {
                    _reportStopTimeHeader,
                    _reportStopTimeValue
                };
                doc.Add(_reportStopTime);
                //
                Chunk _creationReasonHeader = new Chunk("Rapor Olusturulma Nedeni : ", fontKey);
                Chunk _creationReasonValue = new Chunk(_creationReasonText, fontValue);
                Paragraph _creationReason = new Paragraph
                {
                    _creationReasonHeader,
                    _creationReasonValue
                };
                doc.Add(_creationReason);
                //
                doc.Add(new Paragraph(Environment.NewLine));
                doc.Add(new Paragraph(Environment.NewLine));
                //
                doc.Add(new Paragraph("Sayın Yetkili;", fontValue));
                string _reportDescription = "Bu rapor belirli bir aralıkta sahip oldugunuz makinlerde gerçeklesmis olan islemler hakkında kullanıcıların bilgilendirilmesi amaclı olusturulmaktadır. " +
                    "Raporda yer alan bilgiler makine sahibinin veya son kullanıcıların sisteme fiziki müdahalesi sonucu yanlıs hesaplanmıs olabilir. " +
                    "Bu nedenden oturu rapor kapsamında sunulan bilgilerin tamamı bilgilendirme amaclı olup herhangi bir resmi belge niteliği tasımamaktadır. Anlayısınız için tesekkür ederiz.";
                doc.Add(new Paragraph(_reportDescription, fontValue));
                doc.Add(new Paragraph(Environment.NewLine));
                //
                using (DBManager _dbManager = new DBManager())
                {
                    List<Machine> _machineList = _dbManager.GetMachineList();
                    foreach (Machine _machine in _machineList)
                    {
                        PdfPTable _machineTable = new PdfPTable(4);
                        _machineTable.WidthPercentage = 90;
                        PdfPCell cellPdks = new PdfPCell(new Phrase(_machine.Alias, fontKey))
                        {
                            Colspan = 4,
                            HorizontalAlignment = 1 //0=Left, 1=Centre, 2=Right
                        };
                        _machineTable.AddCell(cellPdks);
                        //
                        List<MachineAlarm> _alarmList = _dbManager.GetMachineAlarmList().FindAll(_machineAlarm => _machineAlarm.Machine == _machine);
                        _machineTable.AddCell(new PdfPCell(new Phrase("Toplam Alarm Adedi", fontKey)) { Colspan = 2, HorizontalAlignment = 2 });
                        _machineTable.AddCell(new PdfPCell(new Phrase(_alarmList.Count.ToString(), fontValue)) { Colspan = 2, HorizontalAlignment = 0 });
                        //
                        _machineTable.AddCell(new PdfPCell(new Phrase("Toplam Para", fontKey)) { Colspan = 2, HorizontalAlignment = 2 });
                        _machineTable.AddCell(new PdfPCell(new Phrase(_machine.TotalMoney.ToString(), fontValue)) { Colspan = 2, HorizontalAlignment = 0 });
                        //
                        _machineTable.AddCell(new PdfPCell(new Phrase("Periyodik Bakım Kalan Süre", fontKey)) { Colspan = 2, HorizontalAlignment = 2 });
                        _machineTable.AddCell(new PdfPCell(new Phrase((_machine.PeriodicMaintenanceHour - (_machine.TotalDeviceWorkTime / 3600)).ToString() + " Saat", fontValue)) { Colspan = 2, HorizontalAlignment = 0 });
                        //
                        _machineTable.AddCell(new PdfPCell(new Phrase("Aktif Çalısma Modları", fontKey)) { Colspan = 2, HorizontalAlignment = 2 });
                        _machineTable.AddCell(new PdfPCell(new Phrase(_machine.GetActiveMods(), fontValue)) { Colspan = 2, HorizontalAlignment = 0 });
                        //
                        _machineTable.AddCell(new PdfPCell(new Phrase("Makine Toplam Çalısma Süresi", fontKey)) { Colspan = 2, HorizontalAlignment = 2 });
                        _machineTable.AddCell(new PdfPCell(new Phrase((_machine.TotalDeviceWorkTime / 3600).ToString() + " Saat", fontValue)) { Colspan = 2, HorizontalAlignment = 0 });
                        //
                        doc.Add(_machineTable);
                        //
                        //MODS
                        //
                        PdfPTable _modsTable = new PdfPTable(4);
                        _modsTable.WidthPercentage = 90;
                        float[] withs = new float[] { 25f, 25f, 25f, 25f };
                        _modsTable.SetWidths(withs);
                        _modsTable.AddCell(new PdfPCell(new Phrase("MOD", fontKey)));
                        _modsTable.AddCell(new PdfPCell(new Phrase("TOPLAM PARA", fontKey)));
                        _modsTable.AddCell(new PdfPCell(new Phrase("TOPLAM SÜRE", fontKey)));
                        _modsTable.AddCell(new PdfPCell(new Phrase("ÇALISMA ADEDI", fontKey)));
                        FillTableCells(_modsTable, fontValue, "Yıkama", _machine.WashingTotalMoney.ToString(), _machine.WashingTotalTime.ToString(), _machine.WashingWorkCount.ToString());
                        FillTableCells(_modsTable, fontValue, "Paspas", _machine.MopTotalMoney.ToString(), _machine.MopTotalTime.ToString(), _machine.MopWorkCount.ToString());
                        FillTableCells(_modsTable, fontValue, "Köpük", _machine.FoamTotalMoney.ToString(), _machine.FoamTotalTime.ToString(), _machine.FoamWorkCount.ToString());
                        FillTableCells(_modsTable, fontValue, "Hava", _machine.AirmaticTotalMoney.ToString(), _machine.AirmaticTotalTime.ToString(), _machine.AirmaticWorkCount.ToString());
                        FillTableCells(_modsTable, fontValue, "Süpürge", _machine.VacuummaticTotalMoney.ToString(), _machine.VacuummaticTotalTime.ToString(), _machine.VacuummaticWorkCount.ToString());
                        FillTableCells(_modsTable, fontValue, "Cila", _machine.VarnishTotalMoney.ToString(), _machine.VarnishTotalTime.ToString(), _machine.VarnishWorkCount.ToString());
                        doc.Add(_modsTable);
                        doc.Add(new Paragraph(Environment.NewLine));
                    }
                }
                Paragraph _goodWork = new Paragraph("iyi çalısmalar", fontKey);
                _goodWork.SetAlignment("RIGHT");
                doc.Add(_goodWork);
                doc.Close();
                return true;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("PdfReport.GenerateAndSaveReport -> ", _ex);
                return false;
            }
        }
        void FillTableCells(PdfPTable table, Font fontValue, string _modName, string _totalMoney, string _totalTime, string _workCount)
        {
            try
            {
                table.AddCell(new PdfPCell(new Phrase(_modName, fontValue)));
                table.AddCell(new PdfPCell(new Phrase(_totalMoney, fontValue)));
                table.AddCell(new PdfPCell(new Phrase(_totalTime, fontValue)));
                table.AddCell(new PdfPCell(new Phrase(_workCount, fontValue)));
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("PdfReport.FillTableCells -> ", _ex);
            }

        }
        private DateTime GetReportStartTime()
        {
            try
            {
                DateTime _lastRaportDate = DateTime.Now.AddYears(-5);
                string[] _reports = Directory.GetFiles(Constants.ReportsDirectory);
                foreach (string _report in _reports)
                {
                    if (_report.EndsWith(".pdf"))
                    {
                        string _filename = Path.GetFileNameWithoutExtension(_report);
                        DateTime _date = DateTime.ParseExact(_filename, "yyyy-dd-M--HH-mm-ss", CultureInfo.InvariantCulture);
                        if (_lastRaportDate < _date)
                        {
                            _lastRaportDate = _date;
                        }
                    }
                }
                return _lastRaportDate;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("PdfReport.GetReportStartTime -> ", _ex);
                return DateTime.Now;
            }
        }
    }
}

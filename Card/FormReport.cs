using Microsoft.Reporting.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Card
{
    public partial class FormReport : Form
    {
        string connectionString;
        int card1=0, card2 = 0, card3 = 0, card5 = 0, card10 = 0, card20 = 0, card30 = 0, cardTotal = 0, scan1 = 0, scan2 = 0, scan3 = 0, scan5 = 0, scan10 = 0, scan20 = 0, scan30 = 0, scanTotal = 0;

        public FormReport(int s1,int s2,int s3,int s5,int s10,int s20,int s30)
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\My Doc\C# Project\Card\Card\Database1.mdf;Integrated Security=True";
            countCard();
            countCardScan();
            scan1 = s1;
            scan2 = s2;
            scan3 = s3;
            scan5 = s5;
            scan10 = s10;
            scan20 = s20;
            scan30 = s30;
            scanTotal = scan1 + scan2 + scan3 + scan5 + scan10 + scan20 + scan30;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Date", "Date : " + DateTime.Now.ToShortDateString()));
            reportParameters.Add(new ReportParameter("card1L", card1.ToString()));
            reportParameters.Add(new ReportParameter("card2L", card2.ToString()));
            reportParameters.Add(new ReportParameter("card3L", card3.ToString()));
            reportParameters.Add(new ReportParameter("card5L", card5.ToString()));
            reportParameters.Add(new ReportParameter("card10L",card10.ToString()));
            reportParameters.Add(new ReportParameter("card20L",card20.ToString()));
            reportParameters.Add(new ReportParameter("card30L",card30.ToString()));
            reportParameters.Add(new ReportParameter("cardTotal",cardTotal.ToString()));
            reportParameters.Add(new ReportParameter("scan1L", scan1.ToString()));
            reportParameters.Add(new ReportParameter("scan2L", scan2.ToString()));
            reportParameters.Add(new ReportParameter("scan3L", scan3.ToString()));
            reportParameters.Add(new ReportParameter("scan5L", scan5.ToString()));
            reportParameters.Add(new ReportParameter("scan10L",scan10.ToString()));
            reportParameters.Add(new ReportParameter("scan20L",scan20.ToString()));
            reportParameters.Add(new ReportParameter("scan30L",scan30.ToString()));
            reportParameters.Add(new ReportParameter("scanTotal",scanTotal.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }


        #region Methods

        void countCard()
        {
            string sql1 = "SELECT COUNT(Amount) FROM tbCard WHERE Amount='1L'";
            string sql2 = "SELECT COUNT(Amount) FROM tbCard WHERE Amount='2L'";
            string sql3 = "SELECT COUNT(Amount) FROM tbCard WHERE Amount='3L'";
            string sql4 = "SELECT COUNT(Amount) FROM tbCard WHERE Amount='5L'";
            string sql5 = "SELECT COUNT(Amount) FROM tbCard WHERE Amount='10L'";
            string sql6 = "SELECT COUNT(Amount) FROM tbCard WHERE Amount='20L'";
            string sql7 = "SELECT COUNT(Amount) FROM tbCard WHERE Amount='30L'";
            string sql8 = "SELECT COUNT(Amount) FROM tbCard";

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd1 = new SqlCommand(sql1, cnn);
            SqlCommand cmd2 = new SqlCommand(sql2, cnn);
            SqlCommand cmd3 = new SqlCommand(sql3, cnn);
            SqlCommand cmd4 = new SqlCommand(sql4, cnn);
            SqlCommand cmd5 = new SqlCommand(sql5, cnn);
            SqlCommand cmd6 = new SqlCommand(sql6, cnn);
            SqlCommand cmd7 = new SqlCommand(sql7, cnn);
            SqlCommand cmd8 = new SqlCommand(sql8, cnn);

            card1 = (int)cmd1.ExecuteScalar();
            card2 = (int)cmd2.ExecuteScalar();
            card3 = (int)cmd3.ExecuteScalar();
            card5 = (int)cmd4.ExecuteScalar();
            card10 = (int)cmd5.ExecuteScalar();
            card20 = (int)cmd6.ExecuteScalar();
            card30 = (int)cmd7.ExecuteScalar();
            cardTotal = (int)cmd8.ExecuteScalar();

            cmd1.Dispose();
            cmd2.Dispose();
            cmd3.Dispose();
            cmd4.Dispose();
            cmd5.Dispose();
            cmd6.Dispose();
            cmd7.Dispose();
            cmd8.Dispose();
            cnn.Close();
        }

        void countCardScan()
        {
            string sql8 = "SELECT COUNT(ScanTimes) FROM tbCardScan";

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd8 = new SqlCommand(sql8, cnn);

            scanTotal = (int)cmd8.ExecuteScalar();

            cmd8.Dispose();
            cnn.Close();
        }
        #endregion
    }
}

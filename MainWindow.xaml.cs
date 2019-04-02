using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WinReportSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button currentButton = sender as Button;
            if (currentButton.Name == "btnPrint")
            {
                Print();
            }
            if (currentButton.Name == "btnClear")
            {
                RV.Clear();
            }
            if (currentButton.Name == "btnPrint1")
            {
                Print1();
            }
            if (currentButton.Name == "btnClear1")
            {
                UC.RV1.Clear();
            }

        }
        private void Print()
        {
            List<Student> stdList = new List<Student>();
            for (int i = 1; i < 50; i++)
            {
                stdList.Add(new Student { Name = "Student_" + i.ToString(), Address = "Yangon", Phone = "09847376" + i.ToString(), NRC = i.ToString() });
            }
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new  Microsoft.Reporting.WinForms.ReportDataSource();

            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = stdList;

            this.RV.LocalReport.DataSources.Clear();
            this.RV.LocalReport.DataSources.Add(reportDataSource1);

            this.RV.LocalReport.ReportPath = "../../Report1.rdlc";

            this.RV.RefreshReport();
        }
        private void Print1()
        {
            List<Student> stdList = new List<Student>();
            for (int i = 1; i < 50; i++)
            {
                stdList.Add(new Student { Name = "Student_UC_" + i.ToString(), Address = "Yangon", Phone = "09847376" + i.ToString(), NRC = i.ToString() });
            }
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = stdList;

            UC.RV1.LocalReport.DataSources.Clear();
            UC.RV1.LocalReport.DataSources.Add(reportDataSource1);

            UC.RV1.LocalReport.ReportPath = "../../Report1.rdlc";

            UC.RV1.RefreshReport();
        }
    }
}

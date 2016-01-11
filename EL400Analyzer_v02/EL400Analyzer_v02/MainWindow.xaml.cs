using System.Collections.Generic;
using System.Windows;
using EL400Analyzer_v02.Model;
using System;

namespace EL400Analyzer_v02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<logBase> LogList;

        public MainWindow()
        {
            InitializeComponent();

            LogList = new List<logBase>();
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logText(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            LogList.Add(new logObject(DateTime.Now));
            LogList.Add(new logCabinet(DateTime.Now));
            this.ListViewForLogs.DataContext = LogList;
        }
    }
}

﻿using DSP_lab2.Signals;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DSP_lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SignalViewModel signalViewModel = new(SignalsPlot, PhasePlot, AmplitudePlot);
            DataContext = signalViewModel;

        }

        private void SignalsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

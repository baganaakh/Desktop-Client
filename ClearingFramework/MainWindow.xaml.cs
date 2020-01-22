﻿using Clearing.pages;
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

namespace ClearingFramework
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
        #region DocPanel
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }
        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();

        }
        #endregion
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Start();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Create();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Settlement();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Acc_balance();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PostTrade();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Fee();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Repo();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Lend();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Collateral();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Login();
        }

    }
}

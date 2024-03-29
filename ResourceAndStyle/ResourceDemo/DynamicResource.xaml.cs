﻿using System;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ResourceDemo
{
    /// <summary>
    /// DynamicResource.xaml 的交互逻辑
    /// </summary>
    public partial class DynamicResource : Window
    {
        public DynamicResource()
        {
            InitializeComponent();
        }

        private void ChangeBrushToYellow_Click(object sender, RoutedEventArgs e)
        {
            // 改变资源
            this.Resources["RedBrush"] = new SolidColorBrush(Colors.Yellow);
            
        }
    }
}

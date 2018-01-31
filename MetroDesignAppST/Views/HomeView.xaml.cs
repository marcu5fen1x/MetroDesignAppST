﻿using MetroDesignAppST.Models;
using MetroDesignAppST.ViewModel;
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

namespace MetroDesignAppST.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeViewModel vm;
        public HomeView()
        {
            InitializeComponent();
            vm = new HomeViewModel();
            this.DataContext = vm;
            list.ItemsSource = vm.mc.mfiles;
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MusicFile selected = (MusicFile)list.SelectedItem;
            vm.SendSelectedItem(selected);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

namespace Work.Windows
{
    /// <summary>
    /// Логика взаимодействия для Calculation.xaml
    /// </summary>
    public partial class Calculation : Window
    {
        Contarct contractAdd;
        public Calculation(Contarct contract)
        {
            InitializeComponent();
            contractAdd = contract;
        }
    }
}
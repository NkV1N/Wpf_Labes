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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Paint_Wpf_2
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
        private void Black(object sender, RoutedEventArgs e)
        {
            DrawingAttr.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void Yellow(object sender, RoutedEventArgs e)
        {
            DrawingAttr.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void Green(object sender, RoutedEventArgs e)
        {
            DrawingAttr.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Blue(object sender, RoutedEventArgs e)
        {
            DrawingAttr.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Red(object sender, RoutedEventArgs e)
        {
            DrawingAttr.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void White(object sender, RoutedEventArgs e)
        {
            DrawingAttr.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void Purple(object sender, RoutedEventArgs e)
        {
            DrawingAttr.DefaultDrawingAttributes.Color = Colors.Purple;
        }

        private void Slider(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (label == null)
            {

            }
            else
            {
                DrawingAttr.DefaultDrawingAttributes.Width = slider.Value;
                DrawingAttr.DefaultDrawingAttributes.Height = slider.Value;
                label.Content = slider.Value.ToString();
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DrawingAttr.Strokes.Clear();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            DrawingAttr.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void Pen(object sender, RoutedEventArgs e)
        {
            DrawingAttr.EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}

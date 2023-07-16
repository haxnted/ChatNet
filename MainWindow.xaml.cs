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
using System.Drawing;
namespace ChatNet
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

        private void SendMessage(object sender, RoutedEventArgs e)
        {












            //int length = TextForMessage.Text.Length;
            //if (string.IsNullOrEmpty(TextForMessage.Text))
            //{
            //    return;
            //}
            //int width = TextForMessage.Text.Length;
            //for (int i = 0; i < length; i++)
            //{
            //    width += 10;
            //}
            //Label textLabel = new Label()
            //{
            //    HorizontalAlignment = HorizontalAlignment.Left,
            //    VerticalAlignment = VerticalAlignment.Center,
            //    Margin = new Thickness(5),
            //    Width = width, 
            //    Height = 30,
            //    FontSize = 10.0,
            //    Background = Brushes.LightGreen,
            //    Content = TextForMessage.Text,
            //};
            //Paragraph paragraph = new Paragraph()
            //{
            //    LineHeight = 0.1,
            //    BorderThickness = new Thickness(0),
            //    TextAlignment = TextAlignment.Right
            //};
            //InlineUIContainer container = new InlineUIContainer(textLabel);
            //paragraph.Inlines.Add(container);
            //paragraph.Inlines.Add(new LineBreak());

            //FlowDocument flow = Messages.Document;
            //flow.Blocks.Add(paragraph);

            //TextForMessage.Text = string.Empty;
        }
    }
}

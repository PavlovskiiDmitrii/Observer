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

namespace Observer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConcreteSubject subject;
        ConcreteObserver ob1;
        ConcreteObserver ob2;
        ConcreteObserver ob3;


        public MainWindow()
        {
            InitializeComponent();
            subject = new ConcreteSubject();
            //subject.Attach(new ConcreteObserver(subject,Rec));
           // subject.Attach(new ConcreteObserver(subject,Ell));
           // subject.Attach(new ConcreteObserver(subject,RecRec));
          //  subject.brush = Brushes.Red;
        }

        private void BtNotify_Click(object sender, RoutedEventArgs e)
        {
            if (Cb.SelectedIndex == 0)
            {
                subject.brush = Brushes.Red;
            }
            if (Cb.SelectedIndex == 1)
            {
                subject.brush = Brushes.Black;
            }
            if (Cb.SelectedIndex == 2)
            {
                subject.brush = Brushes.Blue;
            }

            subject.Notify();
        }

        private void Chb1_Checked(object sender, RoutedEventArgs e)
        {
            ob1 = new ConcreteObserver(subject, Rec);
            subject.Attach(ob1);
        }

        private void Chb2_Checked(object sender, RoutedEventArgs e)
        {
            ob2 = new ConcreteObserver(subject, Ell);
            subject.Attach(ob2);
        }

        private void Chb3_Checked(object sender, RoutedEventArgs e)
        {
            ob3 = new ConcreteObserver(subject, RecRec);
            subject.Attach(ob3);
        }

        private void Chb1_Unchecked(object sender, RoutedEventArgs e)
        {
            subject.Detach(ob1);
        }

        private void Chb2_Unchecked(object sender, RoutedEventArgs e)
        {
            subject.Detach(ob2);
        }

        private void Chb3_Unchecked(object sender, RoutedEventArgs e)
        {
            subject.Detach(ob3);
        }
  
    }
}

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

namespace Domaći1.Controls
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
            this.DeleteUser.MouseDown += DeleteImage_MouseDown;
            this.EditUser.MouseDown += EditUser_MouseDown;
        }

        void DeleteImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RaiseDeleteEvent();
        }

        void RaiseDeleteEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(User.DeleteEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly RoutedEvent DeleteEvent = EventManager.RegisterRoutedEvent("Delete", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(User));

        public event RoutedEventHandler Delete
        {
            add { AddHandler(DeleteEvent, value); }
            remove { RemoveHandler(DeleteEvent, value); }
        }

        void EditUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RaiseEditEvent();
        }

        void RaiseEditEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(User.EditEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly RoutedEvent EditEvent = EventManager.RegisterRoutedEvent("Edit", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(User));

        public event RoutedEventHandler Edit
        {
            add { AddHandler(EditEvent, value); }
            remove { RemoveHandler(DeleteEvent, value); }
        }

        public String UserName
        {
            get { return (String)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserNameProperty =
            DependencyProperty.Register("UserName", typeof(String), typeof(User), new PropertyMetadata(""));

        
    }
}

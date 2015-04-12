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
    /// Interaction logic for Post.xaml
    /// </summary>
    public partial class Post : UserControl
    {
        public Post()
        {
            InitializeComponent();
            this.DeletePost.MouseDown += DeletePost_MouseDown;
            this.EditPost.MouseDown += EditPost_MouseDown;
        }

        void EditPost_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RaiseEditEvent();
        }

        private void RaiseEditEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(Post.EditEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly RoutedEvent EditEvent = EventManager.RegisterRoutedEvent("Edit", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Post));

        public event RoutedEventHandler Edit
        {
            add { AddHandler(EditEvent, value); }
            remove { RemoveHandler(EditEvent, value); }
        }

        void DeletePost_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RaiseDeleteEvent();
        }

        private void RaiseDeleteEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(Post.DeleteEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly RoutedEvent DeleteEvent = EventManager.RegisterRoutedEvent("Delete", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Post));

        public event RoutedEventHandler Delete
        {
            add { AddHandler(DeleteEvent, value); }
            remove { RemoveHandler(DeleteEvent, value); }
        }

        public String PostUserName
        {
            get { return (String)GetValue(PostUserNameProperty); }
            set { SetValue(PostUserNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PostUserName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PostUserNameProperty =
            DependencyProperty.Register("PostUserName", typeof(String), typeof(Post), new PropertyMetadata(""));

        

        public String PostText
        {
            get { return (String)GetValue(PostTextProperty); }
            set { SetValue(PostTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PostText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PostTextProperty =
            DependencyProperty.Register("PostText", typeof(String), typeof(Post), new PropertyMetadata(""));

        
    }
}

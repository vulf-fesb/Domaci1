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
using Domaći1.Controls;

namespace Domaći1
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

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.DodajL.Click += DodajL_Click;
            this.DodajR.Click += DodajR_Click;

            RegisterUserDelete();
            RegisterUserEdit();
            RegisterPostDelete();
            RegisterPostEdit();
        }

        private void RegisterPostEdit()
        {
            foreach (var child in this.PostContainer.Children)
            {
                if (child is Post)
                {
                    var post = (Post)child;

                    post.Edit += post_Edit;
                }
            }
        }

        void post_Edit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit post event raised");
        }

        void RegisterPostDelete()
        {
            foreach (var child in this.PostContainer.Children)
            {
                if (child is Post)
                {
                    var post = (Post)child;

                    post.Delete += post_Delete;
                }
            }
        }

        void post_Delete(object sender, RoutedEventArgs e)
        {
            if (!(sender is Post)) { return; }

            var post = (Post)sender;

            this.PostContainer.Children.Remove(post);
        }

        void RegisterUserEdit()
        {
            foreach (var child in this.UserContainer.Children)
            {
                if (child is User)
                {
                    var user = (User)child;

                    user.Edit += user_Edit;
                }
            }
        }

        void user_Edit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit user event raised");
        }

        void RegisterUserDelete()
        {
            foreach (var child in this.UserContainer.Children)
            {
                if(child is User)
                {
                    var user = (User) child;

                    user.Delete+=user_Delete;
                }
            }
        }

        void user_Delete(object sender, RoutedEventArgs e)
        {
     	    if(!(sender is User)) {return;}

            var user = (User) sender;

            this.UserContainer.Children.Remove(user);
        }

        void DodajR_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            Post post = new Post();

            post.PostUserName = "AAABBB";
            post.PostText = "asdasd";
            post.Edit += post_Edit;
            post.Delete += post_Delete;

            /*Rectangle rectangle = new Rectangle();

            rectangle.Height = 30;
            rectangle.Width = 350;
            rectangle.Fill = Brushes.Red;
            rectangle.Margin = new Thickness(5);*/

            this.PostContainer.Children.Add(post);
        }

        void DodajL_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            User user = new User();

            user.UserName = "AAABBB";
            user.Edit+=user_Edit;
            user.Delete+=user_Delete;

            /*Rectangle rectangle = new Rectangle();

            rectangle.Height = 60;
            rectangle.Width = 60;
            rectangle.Fill = Brushes.Orange;
            rectangle.Margin = new Thickness(5);*/

            this.UserContainer.Children.Add(user);
        }
    }
}

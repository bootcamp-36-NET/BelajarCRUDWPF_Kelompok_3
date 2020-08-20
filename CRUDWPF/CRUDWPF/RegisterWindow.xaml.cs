using CRUDWPF.Context;
using CRUDWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CRUDWPF
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        MyContext myContext = new MyContext();
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool isEmail = Regex.IsMatch(Txt_email.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            //MailAddress m = new MailAddress();
            var hashPass = BCrypt.Net.BCrypt.HashPassword(Txt_Pass.Password, 13);
            //bool isvalid = 
            var val = myContext.Suppliers.Where(x => x.Email.Contains(Txt_email.Text)).SingleOrDefault();

            if (Txt_Name.Text.Equals("") && Txt_email.Text.Equals("") && Txt_Pass.Password.Equals(""))
            {
                MessageBox.Show("Input cant be null");
                Txt_Name.Focus();
            }
            else if (Txt_email.Text.Equals("") && Txt_Pass.Password.Equals(""))
            {
                MessageBox.Show("Email cant be null");
                Txt_email.Focus();
            }
            else if (Txt_Pass.Password.Equals(""))
            {
                MessageBox.Show("Password cant be null");
                Txt_Pass.Focus();
            }
            else if (isEmail == false)
            {
                MessageBox.Show("Incorrect Email Format");
                Txt_email.Focus();
            }
            else if (val != null)
            {
                MessageBox.Show("Email Has Been Registered");
                Txt_email.Focus();
            }
            else
            {
                var input = new Supplier()
                {
                    Name = Txt_Name.Text,
                    Email = Txt_email.Text,
                    Password = hashPass
                };
                //string mySalt = BCrypt.GenerateSalt();
                myContext.Suppliers.Add(input);
                myContext.SaveChanges();
                MessageBox.Show("Register Successfull");
                LoginWindow login = new LoginWindow();
                login.Show();
                this.Close();

            }


            //var val = myContext.Suppliers.Where(x => x.Email.Contains(Txt_email.Text)).SingleOrDefault();

            //if (Txt_email.Text.Equals("") || Txt_Pass.Password.Equals(""))
            //{
            //    MessageBox.Show("Email or Pass is must be filled");
            //}
            //else if (val == null)
            //{
            //    MessageBox.Show("Email not available");
            //}
            //else if (isEmail == false)
            //{
            //    MessageBox.Show("Incorrect Email Format");
            //}

            //else
            //{
            //    //if (txtEmail.Text != validate.Email && txtPass.Text != validate.Pass)
            //    if (Txt_email.Text != val.Email && Txt_Pass.Password.ToString() != val.Password)
            //    {
            //        MessageBox.Show("Email or Pass is wrong");
            //    }

            //    else
            //    {
            //        //if (Chk_RememberMe.IsChecked == true)
            //        //{
            //        //    Properties.Settings.Default.Email = Txt_email.Text;
            //        //    Properties.Settings.Default.Password = Txt_Pass.Password;
            //        //    //Properties.Settings.Default.Save();
            //        //}
            //        //Properties.Settings.Default.Email = Txt_email.Text;
            //        //Properties.Settings.Default.Password = Txt_Pass.Password;
            //        //Properties.Settings.Default.Save();
            //        //UserControlLogin usl = new UserControlLogin();
            //        MainWindow main = new MainWindow();
            //        main.Show();
            //        this.Close();
            //    }
            //}
        }

        private void Txt_email_TextChanged(object sender, TextChangedEventArgs e)
        {
            //bool isEmail = Regex.IsMatch(Txt_email.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //if (isEmail == false)
            //{
            //    ErrorMessage.Content.Equals("Incorrect Email Format");
            //    //MessageBox.Show("Incorrect Email Format");
            //    //Txt_email.Focus();
            //}
            //else
            //{
            //    ErrorMessage.Content.Equals("");
            //}
        }

        private void Txt_Pass_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Txt_email_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Txt_Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}

using CRUDWPF.Context;
using CRUDWPF.Models;
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

namespace CRUDWPF
{
    /// <summary>
    /// Interaction logic for UserControlTransaction.xaml
    /// </summary>
    public partial class UserControlTransaction : UserControl
    {
        MyContext myContext = new MyContext();
        public UserControlTransaction()
        {
            InitializeComponent();
            dg_Supplier.ItemsSource = myContext.Transactions.ToList();
        }

        private void Txt_Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if(txt_Name)
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (datePicker1.SelectedDate == null)
            {
                MessageBox.Show("Input cant be null");
            }
            else
            {
                var input = new Transaction(datePicker1.SelectedDate.Value);
                myContext.Transactions.Add(input);
                myContext.SaveChanges();
                MessageBox.Show("1 row has been inserted");
                datePicker1.SelectedDate = null;
            }
            datePicker1.SelectedDate = null;
            txt_ID.Text = "";

            dg_Supplier.SelectedItem = null;
            dg_Supplier.ItemsSource = myContext.Transactions.ToList();
        }

        private void Dg_Supplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dg_Supplier.SelectedItem != null)
            {
                var trans = dg_Supplier.SelectedItem as Transaction;
                txt_ID.Text = Convert.ToString(trans.Id);
                datePicker1.SelectedDate = trans.OrderDate;
                
            }

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //var supp = myContext.suppliers.Find(Convert.ToInt32(txt_ID.Text));
            //    myContext.suppliers.Remove(supp);
            //    myContext.SaveChanges();
            //    MessageBox.Show("1 row has been delete");
            int Id = Convert.ToInt32(txt_ID.Text);
            var trans = myContext.Transactions.Find(Id);
            myContext.Transactions.Remove(trans);
            myContext.SaveChanges();
            MessageBox.Show("1 row has been delete");

            dg_Supplier.ItemsSource = myContext.Transactions.ToList();
            datePicker1.SelectedDate = null;
            txt_ID.Text = "";
            dg_Supplier.SelectedItem = null;


        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(txt_ID.Text);
            var trans = myContext.Transactions.Find(Id);
            trans.OrderDate = datePicker1.SelectedDate.Value;
            myContext.SaveChanges();
            MessageBox.Show("1 row has been update");
            dg_Supplier.ItemsSource = myContext.Transactions.ToList();

            datePicker1.SelectedDate = null;
            txt_ID.Text = "";

            dg_Supplier.SelectedItem = null;
        }

        private void Txt_Search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Txt_Search_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Txt_Search_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var filtered = myContext.Transactions.Where(Supplier => Supplier.Id.ToString().Contains(Txt_Search.Text)).ToList();
            //string qry = "Select * from public.TB_M_Supplier where Name like '%" + Txt_Search.Text + "%'";
            dg_Supplier.ItemsSource = filtered;
        }

        private void DatePicker1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void DatePicker1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            dg_Supplier.ItemsSource = myContext.Transactions.ToList();

            datePicker1.SelectedDate = null;
            txt_ID.Text = "";

            dg_Supplier.SelectedItem = null;
        }
    }
}

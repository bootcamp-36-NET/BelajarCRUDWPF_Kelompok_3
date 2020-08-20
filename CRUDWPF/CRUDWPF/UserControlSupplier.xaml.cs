using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using CRUDWPF.Context;
using CRUDWPF.Models;

namespace CRUDWPF
{
    /// <summary>
    /// Interaction logic for UserControlSupplier.xaml
    /// </summary>
    public partial class UserControlSupplier : UserControl
    {
        MyContext myContext = new MyContext();
        //MyContext myContext = new MyContext();
        public UserControlSupplier()
        {
            InitializeComponent();
            dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Nama.Text.Equals(""))
            {
                MessageBox.Show("Input cant be null");
            }
            else
            {
                var input = new Supplier() {
                    Name= txt_Nama.Text,
                    JoinDate=DatePicker1.SelectedDate.Value
                };
                myContext.Suppliers.Add(input);
                myContext.SaveChanges();
                MessageBox.Show("1 row has been inserted");
                txt_Nama.Text = "";
            }
            txt_Nama.Text = "";
            txt_ID.Text = "";

            dg_Supplier.SelectedItem = null;
            dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
        }

        private void Dg_Supplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dg_Supplier.SelectedItem != null)
            {
                var supp = dg_Supplier.SelectedItem as Supplier;
                txt_ID.Text = Convert.ToString(supp.Id);
                txt_Nama.Text = Convert.ToString(supp.Name);
                DatePicker1.SelectedDate = supp.JoinDate;
            }
        }

        private void Txt_ID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Txt_Nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(txt_ID.Text);
            var sup = myContext.Suppliers.Find(Id);
            sup.Name = txt_Nama.Text;
            myContext.SaveChanges();
            MessageBox.Show("1 row has been update");
            dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
            txt_Nama.Text = "";
            txt_ID.Text = "";

            dg_Supplier.SelectedItem = null;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(txt_ID.Text);
            var supp = myContext.Suppliers.Find(Id);
            myContext.Suppliers.Remove(supp);
            myContext.SaveChanges();
            MessageBox.Show("1 row has been delete");

            dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
            txt_Nama.Text = "";
            txt_ID.Text = "";
            dg_Supplier.SelectedItem = null;


        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            var filteredData = myContext.Suppliers.Where(Q =>  Q.Name.ToString().Contains(Txt_Search.Text)).ToList();
            dg_Supplier.ItemsSource = filteredData;
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            if (BtnUpdate.IsEnabled == true)
            {
                //dg_Supplier.SelectedItem.Equals("");
                txt_ID.Text = "";
                txt_Nama.Text = "";
                DatePicker1 = null;
                Txt_Search.Text = "";
                dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
                BtnUpdate.IsEnabled = false;
                BtnInsert.IsEnabled = true;
            }
            else {
                txt_ID.Text = "";
                txt_Nama.Text = "";
                DatePicker1 = null;
                Txt_Search.Text = "";
                dg_Supplier.SelectedItem = null;
                dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
            }
            
        }

        private void Txt_Search_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void DatePicker1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Txt_Search_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Txt_Nama_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Txt_Nama_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {

        }

        private void Txt_ID_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}

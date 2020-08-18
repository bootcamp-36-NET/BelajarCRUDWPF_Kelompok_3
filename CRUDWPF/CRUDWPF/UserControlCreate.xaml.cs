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
    /// Interaction logic for UserControlCreate.xaml
    /// </summary>
    public partial class UserControlCreate : UserControl
    {
        MyContext myContext = new MyContext();
        public UserControlCreate()
        {
            InitializeComponent();
            dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
        }

        private void Txt_Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if(txt_Name)
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txt_Name.Text.Equals(""))
            {
                MessageBox.Show("Input cant be null");
            }
            else
            {
                var input = new Supplier(txt_Name.Text);
                myContext.Suppliers.Add(input);
                myContext.SaveChanges();
                MessageBox.Show("1 row has been inserted");
                txt_Name.Text = "";
            }
            txt_Name.Text = "";
            txt_ID.Text = "";

            dg_Supplier.SelectedItem = null;
            dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
        }

        private void Dg_Supplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dg_Supplier.SelectedItem != null)
            {
                var supp = dg_Supplier.SelectedItem as Supplier;
                txt_Name.Text = supp.Name;
                txt_ID.Text = Convert.ToString(supp.Id);
            }

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //var supp = myContext.suppliers.Find(Convert.ToInt32(txt_ID.Text));
            //    myContext.suppliers.Remove(supp);
            //    myContext.SaveChanges();
            //    MessageBox.Show("1 row has been delete");
            int Id = Convert.ToInt32(txt_ID.Text);
            var supp = myContext.Suppliers.Find(Id);
            myContext.Suppliers.Remove(supp);
            myContext.SaveChanges();
            MessageBox.Show("1 row has been delete");

            dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
            txt_Name.Text = "";
            txt_ID.Text = "";
            dg_Supplier.SelectedItem = null;


        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(txt_ID.Text);
            var supp = myContext.Suppliers.Find(Id);
            supp.Name = txt_Name.Text;
            myContext.SaveChanges();
            MessageBox.Show("1 row has been update");
            dg_Supplier.ItemsSource = myContext.Suppliers.ToList();
            txt_Name.Text = "";
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
            var filtered = myContext.Suppliers.Where(Supplier => Supplier.Name.ToString().Contains(Txt_Search.Text)).ToList();
            //string qry = "Select * from public.TB_M_Supplier where Name like '%" + Txt_Search.Text + "%'";
            dg_Supplier.ItemsSource = filtered;
        }
    }
}

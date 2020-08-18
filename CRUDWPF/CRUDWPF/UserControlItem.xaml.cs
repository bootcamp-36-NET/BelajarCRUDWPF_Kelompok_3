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
using CRUDWPF.Models;
using CRUDWPF.Context;

namespace CRUDWPF
{
    /// <summary>
    /// Interaction logic for UserControlItem.xaml
    /// </summary>
    public partial class UserControlItem : UserControl
    {
        MyContext myContext = new MyContext();
        public UserControlItem()
        {
            InitializeComponent();
            dg_Supplier.ItemsSource = myContext.Items.ToList();
            Combo_item.ItemsSource = myContext.Suppliers.Select(Q => Q.Id).ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (txtID.Text.Equals(""))
            //{
            //    MessageBox.Show("");
            //}
            //else
            //{
                var getId = myContext.Items.Find(Convert.ToInt32(txtID.Text));
                myContext.Items.Remove(getId);
                myContext.SaveChanges();
                MessageBox.Show("Data Berhasil Delete");
           // }
            Refresh();
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Equals("") || Combo_item.SelectedValue == null)
            {
                MessageBox.Show("Input Cant Be Null");
            }
            else
            {
                var getId = myContext.Suppliers.Find(Convert.ToInt32(Combo_item.SelectedValue));
                var input = new Item() {
                    Price = Convert.ToInt32(txtPrice.Text),
                    Name = txtName.Text,
                    Stock= Convert.ToInt32(txtStock.Text),
                    Supplier_Id=Convert.ToInt32(Combo_item.SelectedValue)
                };
                myContext.Items.Add(input);
                myContext.SaveChanges();
                MessageBox.Show("1 row has been inserted");
            }
            Refresh();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            var filteredData = myContext.Items.Where(Q => Q.Id.ToString().Contains(txtSearch.Text) || Q.Name.Contains(txtSearch.Text)).ToList();
            dg_Supplier.ItemsSource = filteredData;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Input Cant be Null");
            }
            else
            {
                var getId = myContext.Items.Find(Convert.ToInt32(txtID.Text));
                getId.Name = txtName.Text;
                getId.Price = Convert.ToInt32(txtPrice.Text);
                getId.Stock = Convert.ToInt32(txtStock.Text);
                getId.Supplier_Id = Convert.ToInt32(Combo_item.SelectedValue);
                myContext.SaveChanges();
                MessageBox.Show("1 row has been updated");
            }
            Refresh();
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
                txtID.Text = "";
                txtName.Text = "";
                txtPrice.Text = null;
                txtStock.Text = null;
                Combo_item.SelectedValue = null;
                txtSearch.Text = "";
                dg_Supplier.ItemsSource = myContext.Items.ToList();
                BtnUpdate.IsEnabled = false;
                BtnInsert.IsEnabled = true;
            }
            else
            {
                txtID.Text = "";
                txtName.Text = "";
                txtPrice.Text = null;
                txtStock.Text = null;
                Combo_item.SelectedValue = null;
                txtSearch.Text = "";
                dg_Supplier.SelectedItem = null;
                dg_Supplier.ItemsSource = myContext.Items.ToList();
            }

        }

        private void Dg_Supplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dg_Supplier.SelectedItem != null)
            {
                var item = dg_Supplier.SelectedItem as Item;
                txtID.Text = Convert.ToString(item.Id);
                txtName.Text = item.Name;
                txtPrice.Text =Convert.ToString(item.Price);
                txtStock.Text = Convert.ToString(item.Stock);
                Combo_item.SelectedValue = item.Supplier_Id;
               

            }
        }

        private void Combo_item_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Combo_item_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Combo_item_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void BtnSearch_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

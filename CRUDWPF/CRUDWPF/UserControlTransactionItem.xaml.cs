using CRUDWPF.Context;
using CRUDWPF.Models;
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

namespace CRUDWPF
{
    /// <summary>
    /// Interaction logic for UserControlTransactionItem.xaml
    /// </summary>
    public partial class UserControlTransactionItem : UserControl
    {
        MyContext myContext = new MyContext();
        public UserControlTransactionItem()
        {
            InitializeComponent();
            dg_Supplier.ItemsSource = myContext.TransactionItems.ToList();
            Combo_Transaction.ItemsSource = myContext.Transactions.Select(Q => Q.Id).ToList();
            Combo_Item.ItemsSource = myContext.Items.Select(Z => Z.Id).ToList();
        }
        
        //public List<TransactionItem> MyProperty { get; set; }

        private void Txt_Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if(txt_Name)
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Txt_Qty.Text.Equals("") || Combo_Item.SelectedValue == null || Combo_Transaction.SelectedValue == null)
            {
                MessageBox.Show("Input cant be null");
            }
            else
            {
                var input = new TransactionItem()
                {
                    Quantity = Convert.ToInt32(Txt_Qty.Text),
                    TransactionId = Convert.ToInt32(Combo_Transaction.SelectedValue),
                    ItemId = Convert.ToInt32(Combo_Item.SelectedValue)
                };
                myContext.TransactionItems.Add(input);
                myContext.SaveChanges();
                MessageBox.Show("1 row has been inserted");
                //datePicker1.SelectedDate = null;
            }
            Combo_Transaction.SelectedValue = null;
            Combo_Item.SelectedValue = null;
            txt_ID.Text = "";
            Txt_Qty.Text = "";

            dg_Supplier.SelectedItem = null;
            dg_Supplier.ItemsSource = myContext.TransactionItems.ToList();
        }

        private void Dg_Supplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dg_Supplier.SelectedItem != null)
            {
                var transItem = dg_Supplier.SelectedItem as TransactionItem;
                txt_ID.Text = Convert.ToString(transItem.Id);
                Txt_Qty.Text = Convert.ToString(transItem.Quantity);
                Combo_Transaction.SelectedValue = transItem.TransactionId;
                Combo_Item.SelectedValue = transItem.ItemId;
            }

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //var supp = myContext.suppliers.Find(Convert.ToInt32(txt_ID.Text));
            //    myContext.suppliers.Remove(supp);
            //    myContext.SaveChanges();
            //    MessageBox.Show("1 row has been delete");
            int Id = Convert.ToInt32(txt_ID.Text);
            var trans = myContext.TransactionItems.Find(Id);
            myContext.TransactionItems.Remove(trans);
            myContext.SaveChanges();
            MessageBox.Show("1 row has been delete");

            dg_Supplier.ItemsSource = myContext.TransactionItems.ToList();
            txt_ID.Text = "";
            dg_Supplier.SelectedItem = null;


        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(txt_ID.Text);
            var trans = myContext.TransactionItems.Find(Id);
            trans.Quantity = Convert.ToInt32(Txt_Qty.Text);
            trans.TransactionId = Convert.ToInt32(Combo_Transaction.SelectedValue);
            trans.ItemId = Convert.ToInt32(Combo_Item.SelectedValue);

            myContext.SaveChanges();
            MessageBox.Show("1 row has been update");
            dg_Supplier.ItemsSource = myContext.TransactionItems.ToList();
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
            var filtered = myContext.TransactionItems.Where(Supplier => Supplier.Id.ToString().Contains(Txt_Search.Text)).ToList();
            //string qry = "Select * from public.TB_M_Supplier where Name like '%" + Txt_Search.Text + "%'";
            dg_Supplier.ItemsSource = filtered;
        }

        private void DatePicker1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void DatePicker1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void bindComboTransaction()
        //{
        //    var trans = myContext.transactions.ToList();

        //}

        //private void Combo_Transaction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //   // var trans = Combo_Transaction.SelectedItem as Transaction;
        //    var trans = myContext.transactions.ToList();
        //    Combo_Transaction.ItemsSource = trans;
        //}

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var trans = dg_Supplier.SelectedItem as Transaction;
        //}

        //public void FillComboBoxTransaction()
        //{
        //    try
        //    {
        //        String connectionString = "Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=CRUDWPF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //        SqlConnection con = new SqlConnection(connectionString);
        //        SqlCommand cmd = new SqlCommand("select * from TB_M_Transaction", con);
        //        con.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        var trans = dg_Supplier.SelectedItem as Transaction;
        //        Combo_Transaction.ItemsSource = dt.DefaultView; 
        //        Combo_Transaction.DisplayMemberPath = "Id";
        //        Combo_Transaction.SelectedValuePath = "Id";
        //        cmd.Dispose();
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        private void Combo_Transaction_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void Txt_Qty_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Combo_Item_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void Btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            dg_Supplier.ItemsSource = myContext.TransactionItems.ToList();
            txt_ID.Text = "";
            Txt_Qty.Text = "";

            dg_Supplier.SelectedItem = null;
        }

        //private void Combo_Transaction_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //List<string> data = new List<string>();
        //    //data.Add("A");
        //    //data.Add("b");
        //    //data.Add("c");
        //    //var combo = sender as ComboBox;
        //    //combo.ItemsSource = data;
        //    //combo.SelectedIndex = 0;

        //    String connectionString = "Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=CRUDWPF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //    SqlConnection con = new SqlConnection(connectionString);
        //    SqlCommand cmd = new SqlCommand("select * from TB_M_Transaction", con);
        //    con.Open();
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    var trans = dg_Supplier.SelectedItem as Transaction;
        //    Combo_Transaction.ItemsSource = dt.DefaultView;
        //    Combo_Transaction.DisplayMemberPath = "Id";
        //    Combo_Transaction.SelectedValuePath = "Id";
        //    cmd.Dispose();
        //    con.Close();

        //}

        //private void Combo_Transaction_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        //{
        //    var selectedcomboitem = sender as ComboBox;
        //    string name = selectedcomboitem.SelectedItem as string;
        //    //MessageBox.Show(name);
        //}
    }
}

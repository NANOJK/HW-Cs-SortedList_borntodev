using System;
using System.Collections;
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

namespace SortedList_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            //Add and Show

            //Blank Dectect
            if (Key.Text == "")
            {
                MessageBox.Show("Please Insert Key !!!");
            }
            else if (Value.Text == "")
            {
                MessageBox.Show("Please Insert Value !!!");
            }
            else if (Key.Text == "" && Value.Text == "")
            {
                MessageBox.Show("Please Insert Key and Value !!!");
            }
            else
            {
                //SameKayDectect
                if (sortedList.ContainsKey(int.Parse(Key.Text)) == true)
                {
                    MessageBox.Show("This Key already have in SortedList !!! Please Insert New Key");
                    Key.Text = "";
                    Value.Text = "";
                }
                else
                {
                    sortedList.Add(int.Parse(Key.Text), Value.Text);
                    Key.Text = "";
                    Value.Text = "";

                    string output = "";

                    ICollection collection = sortedList.Keys;

                    foreach (int key in collection)
                    {
                        output = output + "\n" + sortedList[key].ToString();
                    }
                    MessageBox.Show(output);
                    MessageBox.Show("Total member : " + sortedList.Keys.Count);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweySort
{
    public partial class Replacing_Books : Form
    {

        public Replacing_Books()
        {
            InitializeComponent();
            
        }
        List<String> TheUnsortedList = new List<string>();
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //meoth to start game
        //loads 10 random call numbers
        private void button3_Click(object sender, EventArgs e)
        {
            List<string> nonSortedLists = new List<string>();
            listView1.Enabled = true;
            string theItem;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                theItem = generate.generateEverything(random);
                listView1.Items.Add(theItem);
                nonSortedLists.Add(theItem);
            }
            TheUnsortedList = nonSortedLists;
        }
        //method to move call numbers to second listview
        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = listView1.SelectedItems[0].Text;
            listView2.Items.Add(selectedItem);
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        //method to move call numbers back to first listview
        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = listView2.SelectedItems[0].Text;
            listView1.Items.Add(selectedItem);
            listView2.Items.Remove(listView2.SelectedItems[0]);
        }
        //method to check the attempt sorted list by user
        //outputs score 
        private void button4_Click(object sender, EventArgs e)
        {
            List<string> selectedList = new List<string>();
            foreach (var item in listView2.Items)
            {
                selectedList.Add(item.ToString());
            }

            List<string> sortedList = new List<string>();
            TheUnsortedList.Sort();
            sortedList = TheUnsortedList;

            //end the timer

            //
            int count =0;
            for (int i = 0; i < 10; i++)
            {
                if(sortedList[i]== selectedList[i])
                {
                    count++;
                }
            }
            MessageBox.Show("Your Score is: " + count);
            //clear listview
            listView2.Items.Clear();
            listView1.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

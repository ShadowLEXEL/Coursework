using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coursework
{
    string[] words =
            { "the", "fox", "jumped", "over", "the", "dog" };
    LinkedList<string> sentence = new LinkedList<string>(words);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    class medicine
    {
        int count;
        string name;
        double costbuy;
        double costsale;
        DateTime production;
        DateTime death;
        public medicine(int count1,string name1,double costbuy1,double costsale1,DateTime production1,DateTime death1)
        {
            name = name1;
            costbuy = costbuy1;
            costsale = costsale1;
            production = production1;
            death = death1;
            count = count1;
        }
    }

}

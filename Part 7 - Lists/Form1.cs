using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_7___Lists
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random generator = new Random();
        int numberIndex;
        int numberValue;
        string heroesValue;
        string heroesValueUpper;
        string heroesValueAdd;
        string heroesValueAddUpper;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(generator.Next(100));
            }
            lstNumbers.DataSource = numbers;
            heroes.Add("SUPERMAN");
            heroes.Add("BATMAN");
            lstHeroes.DataSource = heroes;
        }


        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            lstNumbers.DataSource = null;
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(generator.Next(100));
            }
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("Status: New Numbers Generated");
        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("SUPERMAN");
            heroes.Add("BATMAN");
            lstHeroes.DataSource = heroes;
            lblStatus.Text = ("Status: Heroes List Reset");
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            if(lstNumbers.SelectedIndex > 0)
            {
                numberIndex = lstNumbers.SelectedIndex;
                numbers.RemoveAt(numberIndex);
                lstNumbers.DataSource = null;
                lstNumbers.DataSource = numbers;
                lblStatus.Text = ("Status: Number Removed");
            }
            else
            {
                lblStatus.Text = ("Select a number to be removed");
            }
        }

        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
            if(lstNumbers.SelectedIndex > 0)
            {
                numberValue = (Int32)lstNumbers.SelectedItem;
                while (numbers.Remove(numberValue)) ;
                lstNumbers.DataSource = null;
                lstNumbers.DataSource = numbers;
                lblStatus.Text = ("Status: Numbers(s) Removed");
            }
            else
            {
                lblStatus.Text = ("Select a number to be removed");
            }
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            heroesValue = txtRemoveHero.Text;
            heroesValue = heroesValue.Trim();
            heroesValueUpper = heroesValue.ToUpper();
            heroes.Remove(heroesValueUpper);
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = ("Status: Hero Removed");
            txtRemoveHero.Text = "";
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            heroesValueAdd = txtAddHero.Text;
            heroesValueAdd = heroesValueAdd.Trim();
            heroesValueAddUpper = heroesValueAdd.ToUpper();
            heroes.Add(heroesValueAddUpper);
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = ("Status: Hero Added");
            txtAddHero.Text = "";
        }

        private void btnSortHeroesAscending_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = ("Status: Heroes Sorted - Ascending A-Z");
        }

        private void btnSortNumbersAscending_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("Status: Numbers Sorted - Ascending A-Z");
        }

        private void btnSortNumbersDescending_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            numbers.Reverse();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("Status: Numbers Sorted - Descending Z-A");
        }

        private void btnSortHeroesDescending_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            heroes.Reverse();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = ("Status: Heroes Sorted - Descending Z-A");
        }
    }
}

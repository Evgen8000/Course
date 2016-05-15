using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

    namespace Kursovaya
{
    public partial class Add_Form : Form
    {
        
        public Add_Form(PrisonerList jailed) 
        {
            InitializeComponent();
            this.jailed = jailed;
            this.forEdit = false;
        }
        public bool Data()
        {
            if (DateTime.Now.Year > Convert.ToInt32(Year.Text))
            {
                return true;
            }
            else
            {
                if (DateTime.Now.Year == Convert.ToInt32(Year.Text))
                {
                    if (DateTime.Now.Month > Convert.ToInt32(Month.Text))
                    {
                        return true;
                    }
                    else
                    {
                        if (DateTime.Now.Month == Convert.ToInt32(Month.Text))
                        {
                            if (DateTime.Now.Day >= Convert.ToInt32(Day.Text)) return true;
                            else return false;
                        }
                        else return false;
                    }
                }
                else return false;
            }
        }

        public PrisonerList jailed = null;
        private bool forEdit = false; 
        private int index = 0;

        public Add_Form(int index, PrisonerList jailed) 
        {
            InitializeComponent();
            this.jailed =jailed;
            this.forEdit = true;
            this.index = index;
            Prisoner prisoner = jailed[index];                    
            First_Name.Text = prisoner.First_Name;
            Second_Name.Text =prisoner.Second_Name;
            Room.Text = Convert.ToString(prisoner.Room);
            Criminality.Text = prisoner.Criminality;
            Day.Text = Convert.ToString(prisoner.DateOfJailed.Day);
            Month.Text = Convert.ToString(prisoner.DateOfJailed.Month);
            Year.Text = Convert.ToString(prisoner.DateOfJailed.Year);
            PITPH.Text = prisoner.PITPH;
            Relatives.Text = prisoner.Relatives;
            Temper.Text = prisoner.Temper;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (requiredCheck() && Year.Text.Length == 4 && Data())
            {
                if (forEdit == false)
                {
                    jailed.Add(new Prisoner(First_Name.Text, Second_Name.Text, Convert.ToInt32(Room.Text), Criminality.Text, new Date(Convert.ToInt32(Day.Text), Convert.ToInt32(Month.Text), Convert.ToInt32(Year.Text)), PITPH.Text, Relatives.Text, Temper.Text));

                    this.Close();
                }
                else                 
                {
                    jailed[index] = (new Prisoner(First_Name.Text, Second_Name.Text, Convert.ToInt32(Room.Text), Criminality.Text, new Date(Convert.ToInt32(Day.Text), Convert.ToInt32(Month.Text), Convert.ToInt32(Year.Text)), PITPH.Text, Relatives.Text, Temper.Text));
                    this.Close();
                }
            }
         }
        private void cancelButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void check(object sender, KeyPressEventArgs e) //поля только с числами
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private bool requiredCheck()  //проверка необходимых полей
        {
            bool result = checkOne(Room) & checkOne(Day) & checkOne(Month) & checkOne(Year) & checkOne(First_Name) & checkOne(Second_Name) & checkOne(Temper) ;
            return result;
        }

        private bool checkOne(TextBox input) //проверка одного поля
        {
            bool result = true;
            if (input.Text == "")
            {
                result = false;
                ToolTip req = new System.Windows.Forms.ToolTip();
                req.Show("Заполните это поле", input, 1000);
            }
            return result;
        }
    }
}

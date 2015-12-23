using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Arraylistone
{
    public partial class Form1 : Form
    {
        ArrayList arrlist = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < rtbword.Text.Length; i++)
                arrlist.Add(rtbword.Text[i]);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (index == arrlist.Count)/////////////////////////////////////////////////
                return;
            picleft.Image = picright.Image = null;
            lblHelp.Text = "Press" + " " + arrlist[index];
            lblcount.Text = arrlist.Count.ToString();
            switch (arrlist[index].ToString())
            {
                case "q": case "a": case "z": case"Q": case"A": case"Z":
                    picleft.Image = imageList1.Images[4];break;
                case "w": case "s": case "x":case"W":case"S":case"X":
                    picleft.Image = imageList1.Images[3];break;
                case "e":case "d": case "c": case"E": case"D": case"C":
                    picleft.Image = imageList1.Images[2]; break;
                case "r": case "f": case "v": case "t": case "b":
                    picleft.Image = imageList1.Images[1]; break;
                case " ":
                    picleft.Image = imageList1.Images[0]; break;
                case "y": case "h": case "n": case "u": case "j":
                    picright.Image = imageList1.Images[6]; break;
                case "i": case "k": case "m":
                    picright.Image = imageList1.Images[7]; break;
                case "o": case "l": case "p":
                    picright.Image = imageList1.Images[8]; break;
            }
           
        }

      

        private void rtbtyping_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (index <= arrlist.Count)//////////////////////////////////////////////////
            {
                if (e.KeyChar == Convert.ToChar(arrlist[index]))
                {
                    rtbword.Select(index, 1);
                    rtbword.SelectionColor = Color.Red;
                    index += 1;
                    progressbar1.Value = (index*100)/arrlist.Count;
                    lblright.Text = index.ToString();
                    Form1_Load(null, null);
                }
                else
                {
                    lblwrong.Text = (int.Parse(lblwrong.Text)+1).ToString(); 
                    e.KeyChar = '\0';
                }
            }
            else { e.KeyChar = '\0'; }
        }
    }
}

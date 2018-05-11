using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RgrZhevakinArtemenkoVariant_5_IS_73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

      
          
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

           
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form2 xuy = new Form2();
            xuy.Show();
            Hide();          
        }



        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
            label1.Font=new Font(label1.Font,FontStyle.Underline);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 xuy = new Form2();
            xuy.Show();
            Hide();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Regular);
            label1.ForeColor = Color.Black;
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox4.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.Checked = false;
        }

        private void checkBox3_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox3.Checked = true;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void MouseEnterInPanelWithChechBox(Panel usingPanel, CheckBox usingCheckBox)
        {
            usingPanel.BackColor = Color.Black;
            usingCheckBox.BackColor = Color.Black;
            usingCheckBox.ForeColor = Color.White;
        }
        private void panel4_MouseEnter(object sender, EventArgs e) => MouseEnterInPanelWithChechBox(panel4, checkBox1);
        private void panel5_MouseEnter(object sender, EventArgs e) => MouseEnterInPanelWithChechBox(panel5, checkBox4);
        private void panel6_MouseEnter(object sender, EventArgs e) => MouseEnterInPanelWithChechBox(panel6, checkBox3);
        private void panel7_MouseEnter(object sender, EventArgs e) => MouseEnterInPanelWithChechBox(panel7,checkBox2);
        private void MouseLeaveInPanelWithChechBox(Panel usingPanel, CheckBox usingCheckBox)
        {
            usingPanel.BackColor = Color.Silver;
            usingCheckBox.BackColor = Color.Transparent;
            usingCheckBox.ForeColor = Color.Black;
        }
        private void panel4_MouseLeave(object sender, EventArgs e) => MouseLeaveInPanelWithChechBox(panel4, checkBox1);
        private void panel5_MouseLeave(object sender, EventArgs e) => MouseLeaveInPanelWithChechBox(panel5, checkBox4);
        private void panel6_MouseLeave(object sender, EventArgs e) => MouseLeaveInPanelWithChechBox(panel6, checkBox3);
        private void panel7_MouseLeave(object sender, EventArgs e) => MouseLeaveInPanelWithChechBox(panel7, checkBox2);

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
           
        }
    }    
}

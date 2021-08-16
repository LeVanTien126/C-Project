using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm2
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            record Tien = new record("Le Van Tien", "Hai Duong", 0908666826, "Male", "06/12/1999",01);
            record Thang = new record("Pham Duc Thang", "Hai Duong", 0987654321, "Male", "07/27/1999",02);
            record Phong = new record("Luong Dinh Phong", "Ha Giang", 0123987654, "Male", "06/04/1999",03);
            record P = new record("P T V P", "Hai Duong", 076654189, "Female", "10/13/1999",04);

            CbbPR.Items.Add(Tien);
            CbbPR.Items.Add(Thang);
            CbbPR.Items.Add(Phong);
            CbbPR.Items.Add(P);
        }

        private void CbbPR_SelectedIndexChanged(object sender, EventArgs e)
        {
            record selectedItem = (record)CbbPR.SelectedItem;
            TxtAdd.Text = selectedItem.Add;
            TxtName.Text = selectedItem.Name;
            TxtPhone.Text = string.Concat("0", selectedItem.Phone.ToString());
            DtmDate.Text = selectedItem.Date;
            CbbSex.Text = selectedItem.Sex;
            TxtRoom.Text = string.Concat("0",selectedItem.Room.ToString());
            PicAvatar.Image = selectedItem.Avatar1;

            if (CbbPR.SelectedIndex != -1)
            {
                DtmDate.Visible = true;
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string add = TxtAdd.Text;
            double phone = Convert.ToInt32(TxtPhone.Text);
            string sex = CbbSex.Text;
            string date = DtmDate.Text;
            int room = Convert.ToInt32(TxtRoom.Text);
            Image avatar = PicAvatar.Image;

            record addRecord = new record(name, add, phone, sex, date, room);
            CbbPR.Items.Add(addRecord);

            MessageBox.Show("Add Successful");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CbbPR.SelectedIndex != -1)
            {
                record updateRecord = (record)CbbPR.SelectedItem;
                updateRecord.Name = TxtName.Text;
                updateRecord.Add = TxtAdd.Text;
                updateRecord.Phone = Convert.ToInt32(TxtPhone.Text);
                updateRecord.Sex = CbbSex.Text;
                updateRecord.Date = DtmDate.Text;
                updateRecord.Room = Convert.ToInt32(TxtRoom.Text);
                updateRecord.Avatar1 = PicAvatar.Image;

                MessageBox.Show("Update successful", "Patient Management", MessageBoxButtons.OK);



            }
            else
                MessageBox.Show("Please Choose the Patient Record", "Invalid Selected", MessageBoxButtons.OK);
        }

       

        private void BtnNext_Click(object sender, EventArgs e)
        {
            //CbbPR.SelectedIndex++;

            //    if (CbbPR.SelectedIndex >= CbbPR.Items.Count -1 ) 
            //    {
            //        CbbPR.SelectedIndex = 0;
            //    }

            if (CbbPR.SelectedIndex != -1)
            {
                if (CbbPR.SelectedIndex == CbbPR.Items.Count - 1)
                    MessageBox.Show("Het roi, tim gi nua");

                else
                    CbbPR.SelectedIndex++;



            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (CbbPR.SelectedIndex != -1)
            {
                if (CbbPR.SelectedIndex == 0)
                    MessageBox.Show("Can Back Anymore");
                else
                    CbbPR.SelectedIndex--;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutdesign From = new aboutdesign();
            From.Show();
        }

        

        private void PicAvatar_MouseClick(object sender, MouseEventArgs e)
        {
            //{
            //    OpenFileDialog anhdaidien = new OpenFileDialog();
            //    if (anhdaidien.ShowDialog() == DialogResult.OK)
            //    {
            //        Image avatar = Image.FromFile(anhdaidien.FileName);
            //        PicAvatar.Image = avatar;


            //    }


            //}
        }

        private void PicAvatar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

        }

        private void PicAvatar_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
if (CbbPR.SelectedIndex == CbbPR.Items.Count - 1)
                MessageBox.Show("Het roi, tim gi nua");

            else
                CbbPR.SelectedIndex++;
        }
    }
    
}

  
    


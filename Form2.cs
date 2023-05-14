using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_04_2023
{

    public partial class Form2 : Form
    {
        List<Tovar> tovar = new List<Tovar>
        {
                new Tovar ("name1", 45, 9),
                new Tovar ("name2", 78, 19),
                new Tovar ("name3", 12, 3),
                new Tovar ("name4", 36, 25),
                new Tovar ("name5", 25, 88),
                new Tovar ("name6", 26, 23),
                new Tovar ("name7", 69, 93),
                new Tovar ("name8", 17, 83),
                new Tovar ("name9", 14, 13)
        };
        Bitmap bmp;
        ListView lv;
        
        public Form2()
        {
            InitializeComponent();
            lv = new ListView();
            lv.SetBounds(5, 20, 700, 200);
            lv.SmallImageList = imageList1;
            Controls.Add(lv);
        }

        private void bt_fill_Click(object sender, EventArgs e)
        {

          
            lv.Items.Add(new ListViewItem(""));
            lv.Items.Add(new ListViewItem(""));
            lv.Items.Add(new ListViewItem(""));
            lv.Items.Add(new ListViewItem(""));

            lv.Columns.Add("IMAGE");
            lv.Columns[0].Width = 100;
            lv.Columns.Add("NAME");
            lv.Columns[1].Width = 100;
            lv.Columns.Add("PRICE");
            lv.Columns[2].Width = 100;
            lv.Columns.Add("COUNT");
            lv.Columns[3].Width = 100;
            //lv.Columns[3].ImageIndex[];
            int i = 0;
            foreach (ListViewItem item in lv.Items)
            {
                item.ImageIndex = i;
                item.SubItems.Add($"{tovar[i].name}");
                item.SubItems.Add($"{tovar[i].price}");
                item.SubItems.Add($"{tovar[i].count}");
                i++;
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.Details;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.LargeIcon;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.List;
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv.View = View.Tile;
        }
    }
}

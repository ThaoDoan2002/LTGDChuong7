using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoAlbum
{
    public partial class PhotoAlbum : Form
    {
        public PhotoAlbum()
        {
            InitializeComponent();
        }



        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                picFile.Image = null;
                pnImg.Controls.Clear(); //Phai clear moi khi click
                string[] files = Directory.GetFiles(e.Node.FullPath); //Full path la text cua node roof + text node hien tai duoc nhan select
                foreach (string f in files)
                {
                    if (f.ToLower().EndsWith("jpg") ||
                        f.ToLower().EndsWith("jpeg") ||
                        f.ToLower().EndsWith("gif") ||
                        f.ToLower().EndsWith("png") ||
                        f.ToLower().EndsWith("bmp"))
                    {
                        PictureBox pic = new PictureBox();
                        pic.Height = pnImg.Height - 10;
                        pic.Width = 5 / 4 * pic.Height;
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Image = Image.FromFile(f);//Phai chi ra duong dan

                        pic.Cursor = Cursors.Hand;
                        pnImg.Controls.Add(pic);
                        pic.Click += new EventHandler(pic_Click);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            picFile.Image = pic.Image;
        }

        private void PhotoAlbum_Load(object sender, EventArgs e)
        {
            initTree();
        }

        private void initTree()
        {
            try
            {
                string[] drive = Directory.GetLogicalDrives();
                TreeNode roof;
                foreach (string dr in drive)
                {
                    roof = new TreeNode(dr);//roof.Text = dr;
                    treeFolder.Nodes.Add(roof);
                    roof.Nodes.Add("Temp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Moi lan nhan mo rong 1 node se duyet thu muc trong node do
        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                TreeNode node = e.Node; // Node duoc nhan chon
                node.Nodes.Clear();
                node.ImageIndex = 1;
                string[] folders = Directory.GetDirectories(node.FullPath);//Lay duong dan tu node
                TreeNode n;
                foreach (string folder in folders)
                {
                    n = new TreeNode(Path.GetFileName(folder));//Chi lay ten thu muc
                    node.Nodes.Add(n);
                    n.Nodes.Add("Temp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Node.ImageIndex = 0;
            }
        }

        //Moi lan dong lai hinh tren node se ve lai nhu cu
        private void treeFolder_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }
    }
}

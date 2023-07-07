using System.IO;
namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] drives = Directory.GetLogicalDrives();

                foreach (string drive in drives)
                {
                    comboxDrives.Items.Add(drive);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void layFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo f = new FileInfo(file);
                ListViewItem item = new ListViewItem(Path.GetFileName(file));
                item.ImageIndex = 1;
                item.SubItems.Add(f.Length.ToString());
                item.SubItems.Add(f.LastAccessTime.ToString());
                listViewFolder.Items.Add(item);
            }
        }

        private void layThuMucs(string path)
        {
            string[] thuMucs = Directory.GetDirectories(path);
            foreach (string tm in thuMucs)
            {
                DirectoryInfo dr = new DirectoryInfo(tm);
                ListViewItem item = new ListViewItem(Path.GetFileName(tm));
                item.SubItems.Add("");
                item.SubItems.Add(dr.LastAccessTime.ToString());
                item.ImageIndex = 0;
                listViewFolder.Items.Add(item);
            }
        }






        private void comboxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxDrives.SelectedIndex != -1)
            {
                if (comboxDrives.SelectedItem.ToString() == @"D:\")
                {
                    listViewFolder.Items.Clear();
                    layThuMucs(comboxDrives.SelectedItem.ToString());
                    layFiles(comboxDrives.SelectedItem.ToString());
                    lbDrive.Text = comboxDrives.SelectedItem.ToString();
                }

                else if (comboxDrives.SelectedItem.ToString() == @"C:\")
                {
                    listViewFolder.Items.Clear();
                    layThuMucs(comboxDrives.SelectedItem.ToString());
                    layFiles(comboxDrives.SelectedItem.ToString());
                    lbDrive.Text = comboxDrives.SelectedItem.ToString();


                }
                else if (comboxDrives.SelectedItem.ToString() == @"E:\")
                {
                    try
                    {
                        listViewFolder.Items.Clear();
                        layThuMucs(comboxDrives.SelectedItem.ToString());
                        layFiles(comboxDrives.SelectedItem.ToString());
                        lbDrive.Text = comboxDrives.SelectedItem.ToString();

                    }
                    catch (Exception)
                    {
                        lbDrive.Text = comboxDrives.SelectedItem.ToString();
                        listViewFolder.Items.Add("Khong co thu muc nao");
                    }
                }
            }
        }

        private void listViewFolder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewFolder.Items.Count > 0)
            {
                foreach (ListViewItem item in listViewFolder.Items)
                {
                    if (item.Selected)
                    {
                        DirectoryInfo d = new DirectoryInfo(comboxDrives.SelectedItem.ToString() + item.Text);
                        if(d.Attributes == FileAttributes.Directory)
                        {
                            listViewFolder.Items.Clear();
                            layFiles(comboxDrives.SelectedItem.ToString() + item.Text);
                            layThuMucs(comboxDrives.SelectedItem.ToString() + item.Text);
                            break;
                        }     
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listViewFolder.View = View.LargeIcon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listViewFolder.View = View.SmallIcon;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listViewFolder.View = View.List;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listViewFolder.View = View.Details;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listViewFolder.View = View.Tile;
        }
    }
}
namespace EmployeeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Employee> listEm = new List<Employee>();

        private void addDataEm(Employee em)
        {
            ListViewItem item = new ListViewItem(em.Name);
            item.SubItems.Add(em.Age.ToString());
            item.SubItems.Add(em.Address);
            listViewEm.Items.Add(item);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Employee em = new Employee();
                em.Name = txtName.Text;
                em.Age = int.Parse(txtAge.Text);
                em.Address = txtAddress.Text;
                listEm.Add(em);

                addDataEm(em);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtName.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save as";
            sf.Filter = "Empl file|*.empl";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                SerializationFile.ghiFile(listEm, sf.FileName);
                MessageBox.Show($"Da luu file thanh cong tai {sf.FileName}");
                listViewEm.Items.Clear();
                listEm = null;
            }
            else
            {
                MessageBox.Show("Ban chua lua chon file!");
            }
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Open";
            of.Filter = "Empl file|*.empl";
            if(of.ShowDialog() == DialogResult.OK)
            {
                listEm = SerializationFile.docFile(of.FileName);
                foreach(Employee em in listEm)
                {
                    addDataEm(em);
                }
                MessageBox.Show("Da mo file thanh cong!");
            }
            else
            {
                MessageBox.Show("Ban chua chon file open!");
            }
        }
    }
}
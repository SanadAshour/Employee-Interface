using System.Data;
using System.Data.SqlClient;

namespace EmpInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=Sanad_HpEnvy\\SQLEXPRESS ;database=EmpInt; integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cm;
        SqlCommandBuilder cmdb;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("Select * from info", con);
                ds.Clear();
                da.Fill(ds, "info");
                cm = (CurrencyManager)BindingContext[ds.Tables["info"]];
                idTB.DataBindings.Add("text", ds.Tables["info"], "id");
                nameTB.DataBindings.Add("text", ds.Tables["info"], "name");
                emailTB.DataBindings.Add("text", ds.Tables["info"], "email");
                salaryTB.DataBindings.Add("text", ds.Tables["info"], "salary");
                maleRB.DataBindings.Add("text", ds.Tables["info"], "gender");
                femaleRB.DataBindings.Add("text", ds.Tables["info"], "gender");
                DatePicker.DataBindings.Add("text", ds.Tables["info"], "date");
                pic.DataBindings.Add(new Binding("image", ds.Tables["info"], "img", true));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            cm.AddNew();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ds.Tables[0].Rows[cm.Position].Delete();
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            cm.Position -= 1;
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            cm.Position += 1;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            cm.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(ds, "info");
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Jpg | *jpg";
            if(DialogResult.OK == ofd.ShowDialog())
            {
                pic.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}

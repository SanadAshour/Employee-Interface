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

        private void PositionChanged(object sender, EventArgs e)
        {
            DataRowView current = (DataRowView)cm.Current;
            if (current["gender"].ToString() == "Male")
            {
                maleRB.Checked = true;
            }
            else
            {
                femaleRB.Checked = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("Select * from info", con);
                ds.Clear();
                da.Fill(ds, "info");
                this.BindingContext[ds.Tables["info"]].PositionChanged += new EventHandler(PositionChanged);
                cm = (CurrencyManager)BindingContext[ds.Tables["info"]];
                idTB.DataBindings.Add("text", ds.Tables["info"], "id");
                nameTB.DataBindings.Add("text", ds.Tables["info"], "name");
                emailTB.DataBindings.Add("text", ds.Tables["info"], "email");
                salaryTB.DataBindings.Add("text", ds.Tables["info"], "salary");              
                DatePicker.DataBindings.Add("Text", ds.Tables["info"], "dt");
                pic.DataBindings.Add(new Binding("image", ds.Tables["info"], "img", true));

                if (ds.Tables["info"].Rows.Count == 0)
                {
                    cm.AddNew();
                    maleRB.Checked = false;
                    femaleRB.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            cm.AddNew();
            maleRB.Checked = false;
            femaleRB.Checked = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ds.Tables[0].Rows[cm.Position].Delete();
            MessageBox.Show("EMPLOYEE DELETED SUCCESSFULLY!", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DataRowView current = (DataRowView)cm.Current;
            if (maleRB.Checked)
            {
                current["gender"] = "Male";
            }
            else if (femaleRB.Checked)
            {
                current["gender"] = "Female";
            }

            cm.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(ds, "info");
            MessageBox.Show("EMPLOYEE ADDED!","INSERTION SUCCESSFUL!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
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

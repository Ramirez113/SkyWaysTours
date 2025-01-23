using UI.Account;
using UI.AddTour;
using UI.Information;
using UI.Interaction;
using UI.Tours;

namespace UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customDesign();
        }
        private void customDesign()
        {
            subPanHome.Visible = false;
            subPanInfo.Visible = false;
            subPanTours.Visible = false;

        }
        private void hideSub()
        {
            if (subPanHome.Visible == true)
                subPanHome.Visible = false;
            if (subPanInfo.Visible == true)
                subPanInfo.Visible = false;
            if (subPanTours.Visible == true)
                subPanTours.Visible = false;
        }
        private void showSub(Panel subMenu)
        {
            if (subPanHome.Visible == false)
            {
                hideSub();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            showSub(subPanHome);
        }
        private void btnTours_Click(object sender, EventArgs e)
        {
            showSub(subPanTours);
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            showSub(subPanInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Request());
            hideSub();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomCreation());
            hideSub();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new BlackList());
            hideSub();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Add());
            hideSub();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Edit());
            hideSub();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Delete());
            hideSub();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new Analitics());
            hideSub();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new Database());
            hideSub();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new Updates());
            hideSub();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new UserAcc());
            hideSub();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childeForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childeForm;
            childeForm.TopLevel = false;
            childeForm.FormBorderStyle = FormBorderStyle.None;
            childeForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childeForm);
            panelChildForm.Tag = childeForm;
            childeForm.BringToFront();
            childeForm.Show();
        }

    }
}

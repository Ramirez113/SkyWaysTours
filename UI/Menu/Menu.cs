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
            hideSub();
        }
    }
}

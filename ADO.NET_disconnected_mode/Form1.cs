namespace ADO.NET_disconnected_mode
{
    public partial class Form1 : Form
    {
        HospitalDbManager manager = new HospitalDbManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void donateBtn_Click(object sender, EventArgs e)
        {
            decimal amount = amountNumeric.Value;
            int depId = (int)depIdNumeric.Value;
            int sponsorId = (int)sponsorIdNumeric.Value;

            // TODO: add validators

            try
            {
                manager.Donate(amount, depId, sponsorId);
                MessageBox.Show("Operation was successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using System.Windows.Forms;

namespace SecretsGui.Views
{
    public partial class SecretValueForm : Form
    {
        private readonly string _name;
        private readonly string _value;

        public SecretValueForm(string name, string value)
        {
            _name = name;
            _value = value;
            InitializeComponent();

            UpdateView();
        }

        private void UpdateView()
        {
            Text = _name;
            nameBox.Text = _name;
            valueBox.Text = _value;
        }

        private void SecretValueForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }
    }
}

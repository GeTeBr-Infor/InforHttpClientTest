using System.Net.Http.Headers;

namespace HttpClientTest
{
    public partial class Form1 : Form
    {
        private M3HttpClient _m3HttpClient;
        public Form1()
        {
            InitializeComponent();
            _m3HttpClient = M3HttpClient.Instance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Execute(useCookiesCheckBox.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private async void Execute(bool useCookies)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            var authenticationString = $"{username}:{password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));

            var client = _m3HttpClient.GetHttpClient(useCookies);


            string uri = $"{requestTextBox.Text}&_rid={DateTime.Now.Ticks}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);

            var response = await client.GetAsync(uri);
            var t = await response.Content.ReadAsStringAsync();
            responseTextBox.Text = t;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
namespace _1_FormGiris
{
    // Code Behind
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Açýlýyor");
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            btnTikla.Left = btnTikla.Left + 20;
        }


        int red = 10, green = 20, blue = 30;



        private void btnAta_Click(object sender, EventArgs e)
        {
            lblAdi.Text = txtAdi.Text;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (cboxKontrol.Checked)
            {
                Random rnd = new Random();

                red = rnd.Next(0, 255);
                green = rnd.Next(0, 255);
                blue = rnd.Next(0, 255);

                //this.BackColor = Color.Tomato;
                this.BackColor = Color.FromArgb(red, green, blue);
            }
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            // listbox'a txtIsim'in Text'ini ekle...
            lboxIsim.Items.Add(txtIsim.Text);
            txtIsim.Clear(); // txtIsim'in text'ini temizle
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {
            // Enabled kontrolün aktif/pasif olma özelliðidir....
            if (txtIsim.Text.Length > 0)
                btnEkle.Enabled = true;
            else
                btnEkle.Enabled = false;
        }
    }
}
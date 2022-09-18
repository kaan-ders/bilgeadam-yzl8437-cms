using CmsWindowsClient.Models;
using Flurl.Http;
using System.Text.Json;

namespace CmsWindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var sonuc = "https://localhost:7222/api/contentapi/DergiListele".GetJsonAsync<List<Dergi>>().Result;
            cbDergi.Items.AddRange(sonuc.ToArray());
        }

        private void cbDergi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDergi.SelectedItem != null)
            {
                Dergi seciliDergi = (Dergi)cbDergi.SelectedItem;
                var sonuc = $"https://localhost:7222/api/contentapi/SayiListele/{seciliDergi.Id}".GetJsonAsync<List<Sayi>>().Result;

                cbSayi.Items.Clear();
                cbSayi.Items.AddRange(sonuc.ToArray());
            }
        }

        private void cbSayi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSayi.SelectedItem != null)
            {
                Sayi seciliSayi = (Sayi)cbSayi.SelectedItem;
                var sonuc = $"https://localhost:7222/api/contentapi/MakaleListele/{seciliSayi.Id}".GetJsonAsync<List<Makale>>().Result;

                cbMakale.Items.Clear();
                cbMakale.Items.AddRange(sonuc.ToArray());
            }
        }

        private void cbMakale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMakale.SelectedItem != null)
            {
                Makale seciliMakale = (Makale)cbMakale.SelectedItem;
                var sonuc = $"https://localhost:7222/api/contentapi/MakaleDetay/{seciliMakale.Id}".GetJsonAsync<Makale>().Result;

                lblBaslik.Text = sonuc.Baslik;
                txtMakale.Text = sonuc.Icerik;
            }
        }
    }
}
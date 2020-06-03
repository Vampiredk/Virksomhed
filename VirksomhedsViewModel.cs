using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Windows.Storage;

namespace Virksomhed
{
    public class VirksomhedsViewModel
    {
        private string brugernavn;
        private string password;
        private string email;
        private string info;
        private string profession;
        private string LoginBrugerNavn;
        private string LoginPassword;
        private string kontraktlængde;
        private string løn;
        private Virksomhed bruger;
        private Virksomhed selectedVirksomhed;

        public ObservableCollection<Virksomhed> OC_Bruger { get; set; }
        public ObservableCollection<Announce> OC_Announce { get; set; }

        public string Password { get => password; set => password = value; }
        public string Brugernavn { get => brugernavn; set => brugernavn = value; }
        public string Email { get => email; set => email = value; }
        //propaties for announce
        public string Info { get => info; set => info = value; }
        public string Profession { get => profession; set => profession = value; }
        public string Kontraktlængde { get => kontraktlængde; set => kontraktlængde = value; }
        public string Løn { get => løn; set => løn = value; }
        public Virksomhed Bruger { get => bruger; set => bruger = value; }


        public Announce SelectedAnnounce { get; set; }


        public RelayCommand AddNyVirksomhed { get; set; }

        public RelayCommand AddNyAnnounce { get; set; }
        public RelayCommand VirksomhedListe { get; set; }


        public VirksomhedsViewModel()
        {

            OC_Bruger = new ObservableCollection<Virksomhed>();
            OC_Announce = new ObservableCollection<Announce>();

            AddNyVirksomhed = new RelayCommand(AddVirksomhed);
            AddNyAnnounce = new RelayCommand(AddAnnouce);
            VirksomhedListe = new RelayCommand(SelectedVirksomhedsListe);
            SelectedVirksomhed = new Virksomhed();
            SelectedAnnounce = new Announce();
            // AddNyAnnounce = new RelayCommand(LoginBrugerTest);
        }

        /* public void LoginBrugerTest()
         {
             foreach (Virksomhed bruger in OC_Bruger)
             {
                 if (bruger.OpretBrugernavn == LoginBrugerNavn && bruger.OpretPassword == LoginPassword)
                 {
                     Messagebox = "Login Succesfull";
                 }
                 else
                 {
                     Messagebox = "Login Failed";
                 }
             }
         }*/


        public void AddVirksomhed()
        {
            Virksomhed oVirksomhed = new Virksomhed(Brugernavn, Password, Email);

            OC_Bruger.Add(oVirksomhed);

        }

        private void SletBruger()
        {
            OC_Bruger.Remove(SelectedVirksomhed);
        }

        private bool canDeleteBrugerListe()
        {
            return OC_Bruger.Count > 0;
        }

        public Virksomhed SelectedVirksomhed
        {
            get => selectedVirksomhed; set
            {
                selectedVirksomhed = value;
            }
        }

        public void SelectedVirksomhedsListe()
        {
            OC_Announce.Clear();
            foreach (Announce announce in SelectedVirksomhed.List_Announce)
            {
                OC_Announce.Add(announce);
            }
        }

        public void AddAnnouce()
        {
            Announce OAnnounce = new Announce(Info, Profession, Kontraktlængde, Løn);

            //Announce OAnnounce = new Announce("Føtex", "Butik", "34timer", "27kr/t");
            //OC_Announce.Add(OAnnounce);

            SelectedVirksomhed.List_Announce.Add(OAnnounce);
        }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Virksomhed
{
    public class Virksomhed : INotifyPropertyChanged
    {
        private string opretBrugernavn;

        public List<Announce> List_Announce
        {
            get => list_Announce; set
            {
                list_Announce = value;
                OnPropertyChanged();
            }
        }



        public string OpretBrugernavn
        {
            get { return opretBrugernavn; }
            set
            {
                opretBrugernavn = value;
                OnPropertyChanged();
            }
        }
        private string opretPassword;

        public string OpretPassword
        {
            get { return opretPassword; }
            set
            {
                opretPassword = value;
                OnPropertyChanged();
            }
        }
        private string opretEmail;
        private List<Announce> list_Announce;

        public string OpretEmail
        {
            get { return opretEmail; }
            set
            {
                opretEmail = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Virksomhed(string navn, string password, string email)
        {
            this.OpretBrugernavn = navn;
            this.OpretPassword = password;
            this.OpretEmail = email;

            List_Announce = new List<Announce>();
        }

        public Virksomhed()
        {

        }

        /*public void AddAnnouce()
        {
            Announce OAnnounce = new Announce(Info, Profession, Kontraktlængde, Løn, Bruger);

            List_Announce.Add(OAnnounce);
        }*/



        /*public Announce() 
        {
        
        }*/

    }
}
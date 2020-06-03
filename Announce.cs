using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace Virksomhed
{
    public class Announce : INotifyPropertyChanged
    {

        private string opretInfo;

        public string OpretInfo
        {
            get { return opretInfo; }
            set
            {
                opretInfo = value;
                OnPropertyChanged();
            }
        }
        private string opretProfession;

        public string OpretProfession
        {
            get { return opretProfession; }
            set
            {
                opretProfession = value;
                OnPropertyChanged();
            }
        }
        private string opretKontrakLængde;

        public string OpretKontrakLængde
        {
            get { return opretKontrakLængde; }
            set
            {
                opretKontrakLængde = value;
                OnPropertyChanged();
            }
        }

        private string opretLøn;

        public string OpretLøn
        {
            get { return opretLøn; }
            set
            {
                opretLøn = value;
                OnPropertyChanged();
            }
        }
        private Virksomhed bruger;
        public Virksomhed Bruger
        {
            get { return bruger; }
            set
            {
                bruger = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Companies announce
        public Announce(string info, string profession, string Kontraktlængde, string løn)
        {
            this.opretInfo = info;
            this.opretProfession = profession;
            this.opretKontrakLængde = Kontraktlængde;
            this.opretLøn = løn;
        }

        public Announce()
        {

        }

    }
}



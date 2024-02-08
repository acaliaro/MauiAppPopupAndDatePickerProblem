using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp7
{
    public partial class NewViewModel1 : ObservableObject
    {

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsStringaEmpty))]
        string stringa;

        [ObservableProperty] 
        [NotifyPropertyChangedFor(nameof(IsStringaEmpty))]
        string _bleConnectionState;

        public bool IsStringaEmpty => string.IsNullOrEmpty(Stringa) && IsBluetoothOffline;

        public bool IsBluetoothOffline => BleConnectionState != "PIPPO";

        [RelayCommand]
        private void SetPippo()
        {
            if (string.IsNullOrEmpty(BleConnectionState))
                BleConnectionState = "PIPPO";
            else
                BleConnectionState = string.Empty;
        }

    }
}

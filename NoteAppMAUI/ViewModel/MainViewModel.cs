using CommunityToolkit.Mvvm.ComponentModel;
using NoteAppMaui.Model;

namespace NoteAppMaui.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public string detail;
    }
}

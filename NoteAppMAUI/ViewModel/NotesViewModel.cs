using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using NoteAppMaui.Model;
using CommunityToolkit.Mvvm.Input;

namespace NoteAppMaui.ViewModel
{
    partial class NotesViewModel : ObservableObject 
    {
        [ObservableProperty]
        private ObservableCollection<Note> notes = new();

        [ObservableProperty]
        private Note note = new();

        [RelayCommand]
        private void Save()
        {
            Notes.Add(Note);
            Note = new();
        }
    }
}

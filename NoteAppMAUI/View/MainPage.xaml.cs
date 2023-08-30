using NoteAppMaui.ViewModel;

namespace NoteAppMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        	BindingContext = new NotesViewModel();
    	}
}


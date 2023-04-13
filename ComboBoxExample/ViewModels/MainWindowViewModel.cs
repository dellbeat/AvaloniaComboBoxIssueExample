using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace CommoBoxExample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string[] Items { get; set; }

    [Reactive]
    public string SelectedItemText { get; set; }//Add BreakPoint to this setter
    [Reactive]
    public string ShowedLabelText { get; set; }
    
    public ReactiveCommand<Unit,Unit> SelectionChangedCommand { get; set; }

    public MainWindowViewModel()
    {
        Items = new[]
        {
            "First", "Second", "Third", "Fourth"
        };

        SelectionChangedCommand = ReactiveCommand.Create(OnSelectionChanged);
    }

    private void OnSelectionChanged()
    {
        ShowedLabelText = $"Current Selected {SelectedItemText}";//Add breakpoint to this sentence
    }
}
using GongSolutions.Wpf.DragDrop;
using System.Collections.ObjectModel;

namespace WpfListViewExtendedSelectionIssue
{
    public class MainViewModel : IDropTarget
    {
        public MainViewModel()
        {
            for (var i = 0; i < 10; i++)
            {
                Items.Add($"item {i}");
            }
        }

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();

        public void DragOver(IDropInfo dropInfo)
        {

        }

        public void Drop(IDropInfo dropInfo)
        {

        }
    }
}

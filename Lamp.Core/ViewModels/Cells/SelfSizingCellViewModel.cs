using MvvmCross.ViewModels;

namespace Lamp.Core.ViewModels.Cells
{
    public class SelfSizingCellViewModel : MvxViewModel
    {
        public SelfSizingCellViewModel(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}

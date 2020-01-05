using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Lamp.Core.ViewModels.Cells;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Lamp.Core.ViewModels
{
    public class SelfSizingTableViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _mvxNavigationService;

        public SelfSizingTableViewModel(IMvxNavigationService mvxNavigationService)
        {
            _mvxNavigationService = mvxNavigationService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            Titles = new MvxObservableCollection<SelfSizingCellViewModel>
            {
                new SelfSizingCellViewModel("1", "asd asjdlak asdjalkdj  asjlkdaj asdjla jal lasdjla aljsdlj lajdas alsjd lasjdl"),
                new SelfSizingCellViewModel("2", "asdlad asdasd as ad a"),
                new SelfSizingCellViewModel("3", "asdas aaa adja ljakj aljlk jfaj asj a adfja;lj ; ja; ;ajs;djask  sadjlaj as aksd asd kla as asdka ;ka askl;dakd ak a;slk d;la ka; ks;a ka;sk ;alks;d ka; ka; k;askd;a ka;l")
            };
        }

        private MvxObservableCollection<SelfSizingCellViewModel> _titles;
        public MvxObservableCollection<SelfSizingCellViewModel> Titles
        {
            get => _titles; 
            set
            {
                _titles = value;
                RaisePropertyChanged(() => Titles);
            }
        }
    }
}

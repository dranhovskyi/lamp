using System.Threading.Tasks;
using Lamp.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Lamp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _mvxNavigationService;
        private readonly ICalculationService _calculationService;

        public MainViewModel(IMvxNavigationService mvxNavigationService, ICalculationService calculationService)
        {
            _mvxNavigationService = mvxNavigationService;
            _calculationService = calculationService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            _subTotal = 100;
            _generosity = 10;

            Recalculate();
        }

        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get => _generosity;
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalculate();
            }
        }

        private double _tip;
        public double Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        private IMvxAsyncCommand _navigateToTableViewCommand;
        public IMvxAsyncCommand NavigateToTableViewCommand
        {
            get
            {
                _navigateToTableViewCommand ??= new MvxAsyncCommand(async () => await NavigateToTableView());
                return _navigateToTableViewCommand;
            }
        }

        private IMvxAsyncCommand _navigateToDynamicScrollViewCommand;
        public IMvxAsyncCommand NavigateToDynamicScrollViewCommand
        {
            get
            {
                _navigateToDynamicScrollViewCommand ??= new MvxAsyncCommand(async () => await NavigateToDynamicScrollView());
                return _navigateToDynamicScrollViewCommand;
            }
        }

        private void Recalculate()
        {
            Tip = _calculationService.TipAmount(SubTotal, Generosity);
        }

        private async Task NavigateToTableView()
        {
            await _mvxNavigationService.Navigate<SelfSizingTableViewModel>();
        }

        private async Task NavigateToDynamicScrollView()
        {
            await _mvxNavigationService.Navigate<DynamicScrollViewModel>();
        }
    }
}

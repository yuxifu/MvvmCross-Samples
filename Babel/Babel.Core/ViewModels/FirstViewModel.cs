using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.JsonLocalization;
using System.Windows.Input;

namespace Babel.Core.ViewModels
{
    public class FirstViewModel
        : BaseViewModel
    {
        private readonly IMvxTextProviderBuilder _builder;

        public FirstViewModel(IMvxTextProviderBuilder builder)
        {
            _builder = builder;
        }

        private string _hello = string.Empty;

        public string Hello
        {
            get { return _hello; }
            set
            {
                _hello = value;
                RaisePropertyChanged(() => Hello);
            }
        }

        public ICommand LolCatCommand
        {
            get { return new MvxCommand(() => PickLanguage("LolCat")); }
        }

        public ICommand ProperEnglishCommand
        {
            get { return new MvxCommand(() => PickLanguage("ProperEnglish")); }
        }

        public ICommand DefaultCommand
        {
            get { return new MvxCommand(() => PickLanguage(string.Empty)); }
        }

        private void PickLanguage(string which)
        {
            _builder.LoadResources(which);
        }

        public ICommand GoCommand
        {
            get { return new MvxCommand(() => ShowViewModel<SecondViewModel>()); }
        }

        public ICommand ForceTextRefreshCommand
        {
            get { return new MvxCommand(() => RaisePropertyChanged(() => TextSource)); }
        }
    }
}
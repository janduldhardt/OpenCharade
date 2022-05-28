

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;

namespace OpenCharade.Views
{
    public abstract partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string _title;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotBusy))]
        bool _isBusy;

        public bool IsNotBusy { get { return !IsBusy; } }

        public ILogger Logger { get; }

        public INavigation Navigation { get; }

        public BaseViewModel() { }

        public BaseViewModel(INavigation navigation, ILogger logger)
        {
            Navigation = navigation;
            Logger = logger;

        }
        public BaseViewModel(ILogger logger)
        {
            Logger = logger;
        }
    }
}

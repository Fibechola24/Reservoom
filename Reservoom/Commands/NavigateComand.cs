using Reservoom.Services;
using Reservoom.Stores;
using Reservoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Commands;

public class NavigateComand : CommandBase
{
    private readonly NavigationService _navigationService;
    public NavigateComand (NavigationService navigationService)
    {
        _navigationService = navigationService;
    }
    public override void Execute(object? parameter)
    {
        _navigationService.Navigate();
    }
}

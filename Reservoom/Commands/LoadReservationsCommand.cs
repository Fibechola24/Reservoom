using Reservoom.Models;
using Reservoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom.Commands;

public class LoadReservationsCommand : AsyncCommandBase
{
    private readonly Hotel _hotel;
    private readonly ReservationListingViewModel _viewModel;
    private ReservationListingViewModel reservationListingViewModel;
    private Hotel hotel;

    public LoadReservationsCommand(Hotel hotel, ReservationListingViewModel viewModel)
    {
        _hotel = hotel;
        _viewModel = viewModel;
    }

    public LoadReservationsCommand(ReservationListingViewModel reservationListingViewModel, Hotel hotel)
    {
        this.reservationListingViewModel = reservationListingViewModel;
        this.hotel = hotel;
    }

    //public override void Execute(object? parameter)
    //{
    //    throw new NotImplementedException();
    //}

    public override async Task ExecuteAsync(object? parameter)
    {
        try
        {
            IEnumerable<Reservation> reservations = await _hotel.GetAllReservations();
            _viewModel.UpdateReservations(reservations);
        }
        catch (Exception)
        {

            MessageBox.Show("failed to load reservations.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

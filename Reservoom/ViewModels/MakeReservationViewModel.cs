﻿using Reservoom.Commands;
using Reservoom.Models;
using Reservoom.Services;
using Reservoom.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservoom.ViewModels;

public class MakeReservationViewModel : ViewModelBase
{


    private string _username;
    public string Username
    {
        get
        {
            return _username;
        }

        set
        {
            _username = value;
            OnPropertyChangeed(nameof(Username));
        }
    }

 

    private int _floorNumber;
    public int FloorNumber
    { 
        get 
        {
            return _floorNumber; 
        }

        set
        {
            _floorNumber = value;
            OnPropertyChangeed(nameof(FloorNumber));
        } 
    }

    private int _roomNumber;
    public int RoomNumber
    {
        get
        {
            return _roomNumber;
        }

        set
        {
            _roomNumber = value;
            OnPropertyChangeed(nameof(RoomNumber));
        }
    }

    private DateTime _startDate = new DateTime(2021,1,1);
    public DateTime StartDate
    {
        get
        {
            return _startDate;
        }

        set
        {
            _startDate = value;
            OnPropertyChangeed(nameof(StartDate));
        }
    }

    private DateTime _endDate = new DateTime(2021,1,8);
    public DateTime EndDate
    {
        get
        {
            return _endDate;
        }

        set
        {
            _endDate = value;
            OnPropertyChangeed(nameof(EndDate));
        }
    }

    public ICommand? SubmitCommand { get; }
    public ICommand? CancelCommand { get; }

    public MakeReservationViewModel(Hotel hotel, NavigationService reservationViewNavigationService)
    {
        SubmitCommand = new MakeReservationCommand(this, hotel, reservationViewNavigationService);
        CancelCommand = new NavigateComand(reservationViewNavigationService);
    }
}

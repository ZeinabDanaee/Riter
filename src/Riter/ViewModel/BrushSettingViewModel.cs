﻿using Riter.Core;
using Riter.ViewModel.Handlers;

namespace Riter.ViewModel;

public sealed class BrushSettingsViewModel : BaseViewModel
{
    private readonly IBrushSettingsHandler _brushSettingsHandler;

    public BrushSettingsViewModel(IBrushSettingsHandler brushSettingsHandler)
    {
        _brushSettingsHandler = brushSettingsHandler;
        _brushSettingsHandler.PropertyChanged += OnStateChanged;
    }

    public string ColorSelected => _brushSettingsHandler.InkColor;

    public double SizeOfBrush => _brushSettingsHandler.SizeOfBrush;

    public string InkColor => _brushSettingsHandler.InkColor;

    public ICommand SetInkColorCommand => new RelayCommand<string>(_brushSettingsHandler.SetInkColor);

    public ICommand SetSizeOfBrushCommand => new RelayCommand<string>(_brushSettingsHandler.SetSizeOfBrush);
}

﻿using System.Windows.Controls;
using Riter.Core;

namespace Riter.ViewModel;
public sealed class DrawingViewModel : BaseViewModel
{
    private readonly IDrawingHandler _drawingHandler;

    public DrawingViewModel(IDrawingHandler drawingHandler)
    {
        _drawingHandler = drawingHandler;
        _drawingHandler.PropertyChanged += OnStateChanged;
    }

    public bool IsReleased => _drawingHandler.IsReleased;

    public bool IsHighlighter => _drawingHandler.IsHighlighter;

    public Visibility SettingPanelVisibility => _drawingHandler.SettingPanelVisibility ? Visibility.Visible : Visibility.Hidden;

    public string ButtonSelectedName => _drawingHandler.ButtonSelectedName;

    public InkCanvasEditingMode InkEditingMode => _drawingHandler.InkEditingMode;

    public ICommand StartDrawingCommand => new RelayCommand(_drawingHandler.StartDrawing);

    public ICommand StartErasingCommand => new RelayCommand(_drawingHandler.StartErasing);

    public ICommand ReleaseCommand => new RelayCommand(_drawingHandler.Release);

    public ICommand ToggleHighlighterCommand => new RelayCommand(_drawingHandler.EnableHighlighter);

    public ICommand ToggleSettingsPanelCommand => new RelayCommand(_drawingHandler.ToggleSettingsPanel);
}

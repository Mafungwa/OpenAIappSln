using Newtonsoft.Json;
using OpenAIapp.Services;
using OpenAIapp.ViewModels;
using System.Windows.Input;

namespace OpenAIapp.Views;

public partial class DisplayView : ContentPage
{
    DisplayViewModel _viewModel;

    OpenAIService openAIService;
    private OpenAIService? svc;

    public DisplayView(DisplayViewModel vm)
	{
        _viewModel = vm;

        InitializeComponent();

        BindingContext = _viewModel;

        BindingContext = this;

        openAIService = svc;


    }

    
}
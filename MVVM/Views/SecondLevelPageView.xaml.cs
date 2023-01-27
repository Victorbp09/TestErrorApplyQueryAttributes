using TestErrorApplyQueryAttributes.MVVM.ViewModels;

namespace TestErrorApplyQueryAttributes.MVVM.Views;

public partial class SecondLevelPageView : ContentPage
{
	public SecondLevelPageView(SecondLevelPageViewModel secondLevelPageViewModel)
	{
		BindingContext = secondLevelPageViewModel;
        InitializeComponent();
	}
}
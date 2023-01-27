using TestErrorApplyQueryAttributes.MVVM.ViewModels;

namespace TestErrorApplyQueryAttributes.MVVM.Views;

public partial class Page2View : ContentPage
{
	public Page2View(Page2ViewModel page2ViewModel)
	{
		BindingContext = page2ViewModel;
		InitializeComponent();
	}
}
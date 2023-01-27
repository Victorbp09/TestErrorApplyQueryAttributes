using TestErrorApplyQueryAttributes.MVVM.ViewModels;

namespace TestErrorApplyQueryAttributes.MVVM.Views;

public partial class Page1View : ContentPage
{
	public Page1View(Page1ViewModel page1ViewModel)
	{
		BindingContext = page1ViewModel;
		InitializeComponent();
	}
}
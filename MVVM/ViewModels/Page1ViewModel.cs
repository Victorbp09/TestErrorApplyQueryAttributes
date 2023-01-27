using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestErrorApplyQueryAttributes.MVVM.Views;

namespace TestErrorApplyQueryAttributes.MVVM.ViewModels
{
    public class Page1ViewModel : IQueryAttributable
    {
        public ICommand GoToSecondLevelCommand => new Command(async () => await GoToSecondLevel());

        private async Task GoToSecondLevel()
        {
            await Shell.Current.GoToAsync(nameof(SecondLevelPageView), true);
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var test = query["test"].ToString();
        }
    }
}

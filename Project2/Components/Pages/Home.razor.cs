using MatBlazor;
using Microsoft.AspNetCore.Components;

namespace Project2.Components.Pages
{
    public partial class Home : ComponentBase
    {
        MatTheme theme1 = new MatTheme()
        {
            Primary = MatThemeColors.Green._900.Value,
            Secondary = MatThemeColors.Red._900.Value
        };
        protected override void OnInitialized()//treat this like our main?
        {
            base.OnInitialized();
            //Add code here to run when the component is initialized
        }
  
    }
}

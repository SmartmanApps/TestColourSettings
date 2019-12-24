using Xamarin.Forms;

namespace TestColourSettings {public class MainPage :ContentPage {

public MainPage() {
    Title="TestColourSettings MainPage";
    BackgroundColor=Color.Black;
    Label TopLabel=new Label{
        HorizontalTextAlignment=TextAlignment.Center,
        VerticalTextAlignment=TextAlignment.Center
        };
    TopLabel.TextColor=Color.FromHex("009933");
    TopLabel.Text="TestColourSettings MainPage";
//    var MainStack=new StackLayout{VerticalOptions=LayoutOptions.Center};
//    MainStack.Children.Add(TopLabel);
//    Content=MainStack;
    Content=TopLabel;
    }

}}
﻿using Xamarin.Forms;

namespace TestColourSettings {public class TestCSPPage :ContentPage {
public TestCSPPage() {
    Title="TestCSPPage Label";
    BackgroundColor=Color.Black;
   Label TestCSPLabel=new Label{
        HorizontalTextAlignment=TextAlignment.Center,
        VerticalTextAlignment=TextAlignment.Center
        };
    TestCSPLabel.TextColor=Color.FromHex("009933");
    TestCSPLabel.Text="TestCSPPage label";
//    var MainStack=new StackLayout{VerticalOptions=LayoutOptions.Center};
//    MainStack.Children.Add(TopLabel);
//    Content=MainStack;
    Content=TestCSPLabel;
    }

}}
using System;

namespace App3
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage());
        }
    }
}

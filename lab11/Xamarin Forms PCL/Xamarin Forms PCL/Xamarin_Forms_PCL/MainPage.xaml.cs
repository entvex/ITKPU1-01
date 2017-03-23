using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Forms_PCL
{
    public partial class MainPage : ContentPage
    {

        CprDll cprDll;
        public MainPage()
        {
            InitializeComponent();
            
            cprDll = new CprDll();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            CprError cprError;
            cprDll.Check(EntryCprNummber.Text, out cprError);

            if (cprError == CprError.NoError)
            {
                Result.TextColor =Color.Lime;
                Result.Text = "Looks OKAY!";
            }
            else
            {
                Result.TextColor = Color.Red;
                Result.Text = "Looks NOT okay!";

            }
        }
    }
}

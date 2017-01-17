using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public class Page_BarcodeScanner : ContentPage
    {
        public Page_BarcodeScanner()
        {
            Button btnScan = new Button
            {
                Text = "Scan Barcode",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            btnScan.Clicked += async (a, b) =>
            {
                Launch_BarcodeSearch();
            };

            this.Content = new StackLayout
            {
                Children =
            {
                btnScan,
            },
            };
        }

       async  void Launch_BarcodeSearch()
        {
           
            var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            var result =  await scanner.Scan();
            if (result != null)
                await this.DisplayAlert("Scanned Barcode: ",result.Text,"OK");
        }
    }
}

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using System;
using System.Globalization;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RuffysCulturesFlags;

public sealed class CultureFlags : Control
{
    public CultureFlags()
    {
        this.DefaultStyleKey = typeof(CultureFlags);
    }

    private BitmapImage Convert(int value)
    {
        var c = CultureInfo.GetCultureInfo(value).TwoLetterISOLanguageName;
        Uri x = new Uri(new Uri(AppContext.BaseDirectory), $"RuffysCulturesFlags/Images/{c}.png");

        BitmapImage bmp = new BitmapImage(x);
        return bmp;
    }


    public int LcId
    {
        get => (int)GetValue(LcIdProperty);
        set {
            SetValue(LcIdProperty, value); CultureLcId = Convert(value);
        }
    }

    // Using a DependencyProperty as the backing store for LcId.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty LcIdProperty =
        DependencyProperty.Register("LcId", typeof(int), typeof(CultureFlags), new PropertyMetadata(0));



    public BitmapImage CultureLcId
    {
        get => (BitmapImage)GetValue(CultureLcIdProperty);
        set => SetValue(CultureLcIdProperty, value);
    }

    // Using a DependencyProperty as the backing store for CultureLcId.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty CultureLcIdProperty =
        DependencyProperty.Register("CultureLcId", typeof(BitmapImage), typeof(CultureFlags), new PropertyMetadata(0));


}

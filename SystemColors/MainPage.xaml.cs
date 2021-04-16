using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace SystemColors
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ExportAccentButton_Click(object sender, RoutedEventArgs e)
        {
            var accentColor = Application.Current.Resources["SystemAccentColor"] as Color?;
            var accentColorDark1 = Application.Current.Resources["SystemAccentColorDark1"] as Color?;
            var accentColorDark2 = Application.Current.Resources["SystemAccentColorDark2"] as Color?;
            var accentColorDark3 = Application.Current.Resources["SystemAccentColorDark3"] as Color?;
            var accentColorLight1 = Application.Current.Resources["SystemAccentColorLight1"] as Color?;
            var accentColorLight2 = Application.Current.Resources["SystemAccentColorLight2"] as Color?;
            var accentColorLight3 = Application.Current.Resources["SystemAccentColorLight3"] as Color?;

            StringBuilder builder = new StringBuilder();
            builder.Append("static const RedmondAccentColor name = RedmondAccentColor(\n" +
                '\t' + accentColor.ToString().Replace("#", "0x") + ",\n" +
                "\t{\n" +
                    "\t\t100: Color(" + accentColorDark1.ToString().Replace("#", "0x")  + "),\n" +
                    "\t\t200: Color(" + accentColorDark2.ToString().Replace("#", "0x")  + "),\n" +
                    "\t\t300: Color(" + accentColorDark3.ToString().Replace("#", "0x")  + "),\n" +
                    "\t\t400: Color(" + accentColor.ToString().Replace("#", "0x")       + "),\n" +
                    "\t\t500: Color(" + accentColorLight1.ToString().Replace("#", "0x") + "),\n" +
                    "\t\t600: Color(" + accentColorLight2.ToString().Replace("#", "0x") + "),\n" +
                    "\t\t700: Color(" + accentColorLight3.ToString().Replace("#", "0x") + "),\n" +
                "\t}\n" +
                ");");

            var result = builder.ToString();
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText(result);
            Clipboard.SetContent(dataPackage);

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemAltHighColor}" ColorName="SystemAltHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemAltMediumHighColor}" ColorName="SystemAltMediumHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemAltMediumColor}" ColorName="SystemAltMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemAltMediumLowColor}" ColorName="SystemAltMediumLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemAltLowColor}" ColorName="SystemAltLowColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemBaseHighColor}" ColorName="SystemBaseHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemBaseMediumHighColor}" ColorName="SystemBaseMediumHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemBaseMediumColor}" ColorName="SystemBaseMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemBaseMediumLowColor}" ColorName="SystemBaseMediumLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemBaseLowColor}" ColorName="SystemBaseLowColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeLowColor}" ColorName="SystemChromeLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeMediumLowColor}" ColorName="SystemChromeMediumLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeMediumColor}" ColorName="SystemChromeMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeMediumHighColor}" ColorName="SystemChromeMediumHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeHighColor}" ColorName="SystemChromeHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeWhiteColor}" ColorName="SystemChromeWhiteColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeGrayColor}" ColorName="SystemChromeGrayColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeAltHighColor}" ColorName="SystemChromeAltHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeAltMediumHighColor}" ColorName="SystemChromeAltMediumHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeAltLowColor}" ColorName="SystemChromeAltLowColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeBlackMediumLowColor}" ColorName="SystemChromeBlackMediumLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeBlackLowColor}" ColorName="SystemChromeBlackLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeBlackMediumColor}" ColorName="SystemChromeBlackMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeBlackHighColor}" ColorName="SystemChromeBlackHighColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeDisabledHighColor}" ColorName="SystemChromeDisabledHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeDisabledLowColor}" ColorName="SystemChromeDisabledLowColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeGrayColor}" ColorName="SystemChromeGrayColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeHighColor}" ColorName="SystemChromeHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeLowColor}" ColorName="SystemChromeLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeMediumColor}" ColorName="SystemChromeMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeMediumHighColor}" ColorName="SystemChromeMediumHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeMediumLowColor}" ColorName="SystemChromeMediumLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemChromeWhiteColor}" ColorName="SystemChromeWhiteColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorActiveCaptionColor}" ColorName="SystemColorActiveCaptionColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorBackgroundColor}" ColorName="SystemColorBackgroundColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorButtonFaceColor}" ColorName="SystemColorButtonFaceColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorButtonTextColor}" ColorName="SystemColorButtonTextColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorCaptionTextColor}" ColorName="SystemColorCaptionTextColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorControlAccentColor}" ColorName="SystemColorControlAccentColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorDisabledTextColor}" ColorName="SystemColorDisabledTextColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorGrayTextColor}" ColorName="SystemColorGrayTextColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorHighlightColor}" ColorName="SystemColorHighlightColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorHotlightColor}" ColorName="SystemColorHotlightColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorInactiveCaptionColor}" ColorName="SystemColorInactiveCaptionColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorInactiveCaptionTextColor}" ColorName="SystemColorInactiveCaptionTextColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorWindowColor}" ColorName="SystemColorWindowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemColorWindowTextColor}" ColorName="SystemColorWindowTextColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemErrorTextColor}" ColorName="SystemErrorTextColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemListAccentHighColor}" ColorName="SystemListAccentHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemListAccentLowColor}" ColorName="SystemListAccentLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemListAccentMediumColor}" ColorName="SystemListAccentMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemListLowColor}" ColorName="SystemListLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemListMediumColor}" ColorName="SystemListMediumColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealAltHighColor}" ColorName="SystemRevealAltHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealAltMediumHighColor}" ColorName="SystemRevealAltMediumHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealAltMediumColor}" ColorName="SystemRevealAltMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealAltMediumLowColor}" ColorName="SystemRevealAltMediumLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealAltLowColor}" ColorName="SystemRevealAltLowColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealBaseHighColor}" ColorName="SystemRevealBaseHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealBaseMediumHighColor}" ColorName="SystemRevealBaseMediumHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealBaseMediumColor}" ColorName="SystemRevealBaseMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealBaseMediumLowColor}" ColorName="SystemRevealBaseMediumLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealBaseLowColor}" ColorName="SystemRevealBaseLowColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeWhiteColor}" ColorName="SystemRevealChromeWhiteColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeGrayColor}" ColorName="SystemRevealChromeGrayColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeBlackHighColor}" ColorName="SystemRevealChromeBlackHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeBlackMediumColor}" ColorName="SystemRevealChromeBlackMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeBlackMediumLowColor}" ColorName="SystemRevealChromeBlackMediumLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeBlackLowColor}" ColorName="SystemRevealChromeBlackMediumLowColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeHighColor}" ColorName="SystemRevealChromeHighColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeMediumColor}" ColorName="SystemRevealChromeMediumColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeMediumLowColor}" ColorName="SystemRevealChromeMediumLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealChromeLowColor}" ColorName="SystemRevealChromeLowColor"></local:ColorInfo>

            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealListLowColor}" ColorName="SystemRevealListLowColor"></local:ColorInfo>
            //<local:ColorInfo Margin="0, 0, 0, 20" Color="{ThemeResource SystemRevealListMediumColor}" ColorName="SystemRevealListMediumColor"></local:ColorInfo>
        }
    }
}

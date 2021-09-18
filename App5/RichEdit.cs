using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace App5
{
    public sealed class RichEdit : RichEditBox
    {
        public RichEdit()
        {
            this.DefaultStyleKey = typeof(RichEditBox);
            Loaded += RichEdit_Loaded;
        }
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        private void RichEdit_Loaded(object sender, RoutedEventArgs e)
        {
            var document = this.Document;
            document.SetText(TextSetOptions.None, "@12345678");
            var range = document.GetRange(0, 2);
            range.CharacterFormat.ForegroundColor = Colors.Red;
        }
    }
}

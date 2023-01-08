using Lister.Models;

namespace Lister.Extensions
{
    public static class RichTextBoxExtensions
    {
        public static void BeginAppendText(this RichTextBox box, string text) 
        {
            box.BeginInvoke(() =>
            {
                box.AppendText(text);
            });
        }
    }
}

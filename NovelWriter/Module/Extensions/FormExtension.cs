using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelWriter.Module.Extensions
{
    static class FormExtension
    {
        public static TextBox SetTags_Init(this TextBox sender, Label lCount, int countLimit, Label lTitle, string title) 
            => SetTags_Init(sender, (lCount, countLimit, lTitle, title));
        public static TextBox SetTags_Init(this TextBox sender, ValueTuple<Label, int, Label, string> tuple)
        {
            if (sender is null) { throw new Exception("sender was null"); }

            sender.Tag = tuple;
            tuple.Item3.Text = tuple.Item4;

            return sender;
        }

        public static TextBox TextChange_Dynamic(this TextBox sender)
        {
            if (sender is null) { throw new Exception("sender was null"); }

            int count = sender.Text.Count();
            var tag = (ValueTuple<Label, int, Label, string>)sender.Tag;
            Label strCountIndicator = tag.Item1;
            strCountIndicator.Text = $"{count}/{tag.Item2}";
            return sender;
        }
    }
}

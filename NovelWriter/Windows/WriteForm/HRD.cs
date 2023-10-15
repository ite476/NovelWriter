using NovelWriter.Module;
using NovelWriter.Module.Extensions;

namespace NovelWriter.Windows.WriteForm
{
    public partial class HRD : WriteForm
    {
        public HRD()
        {
            InitializeComponent();

            var titlesAndLimits = new (int, string)[] {
                (500 , "성장과정 (300자 이상 500자 이하)"),
                (500 , "직무동기 (300자 이상 500자 이하)"),
                (500 , "사회경험 및 활동 (300자 이상 500자 이하)"),
                (500 , "입사 후 포부 (300자 이상 500자 이하)")
            };

            InitializeEditor("HRD", titlesAndLimits);
        }
    }
}
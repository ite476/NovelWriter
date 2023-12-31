using NovelWriter.Module;
using NovelWriter.Module.Extensions;

namespace NovelWriter.Windows.WriteForm
{
    public partial class Nexon : WriteForm
    {
        public Nexon()
        {
            InitializeComponent();

            var titlesAndLimits = new (int, string)[] {
                (1000, "넥슨과 선택하신 직무에 지원하신 동기와 입사 후 성장 목표를 서술해 주세요. (1,000자)"),
                (1000, "선택하신 직무 관련 역량을 갖추기 위해 구체적으로 어떠한 준비를 해오셨는지 경험과 결과를 중심으로 기재해 주세요. (1,000자)"),
                (500, "지원하신 직무와 관련해 활용 가능한 스킬셋(기술스택, 플랫폼 등)과 각각의 활용 수준을 적어주세요. (500자)"),
                (0, "자유메모...")
            };

            InitializeEditor("Nexon", titlesAndLimits);
        }
    }
}
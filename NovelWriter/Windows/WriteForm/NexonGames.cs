using NovelWriter.Module;
using NovelWriter.Module.Extensions;

namespace NovelWriter.Windows.WriteForm
{
    public partial class NexonGames : WriteForm
    {
        public NexonGames()
        {
            InitializeComponent();

            var titlesAndLimits = new (int, string)[]
            {
                (1000, "넥슨게임즈를 선택한 이유와 지원 동기에 대해 서술해 주세요. (1,000자)"),
                (1000, "지원 포지션과 관련된 본인의 역량 및 경험에 대해 자유롭게 서술해 주세요. (1,000자)"),
                (1000, "입사 후 포부 및 성장 목표에 대해 서술해 주세요. (1000자)"),
                (0, "자유메모...")
            };

            InitializeEditor("NexonGames", titlesAndLimits);
        }
    }
}
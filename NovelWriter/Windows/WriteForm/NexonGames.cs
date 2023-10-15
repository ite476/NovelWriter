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
                (1000, "�ؽ������ ������ ������ ���� ���⿡ ���� ������ �ּ���. (1,000��)"),
                (1000, "���� �����ǰ� ���õ� ������ ���� �� ���迡 ���� �����Ӱ� ������ �ּ���. (1,000��)"),
                (1000, "�Ի� �� ���� �� ���� ��ǥ�� ���� ������ �ּ���. (1000��)"),
                (0, "�����޸�...")
            };

            InitializeEditor("NexonGames", titlesAndLimits);
        }
    }
}
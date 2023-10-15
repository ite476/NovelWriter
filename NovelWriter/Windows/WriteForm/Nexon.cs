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
                (1000, "�ؽ��� �����Ͻ� ������ �����Ͻ� ����� �Ի� �� ���� ��ǥ�� ������ �ּ���. (1,000��)"),
                (1000, "�����Ͻ� ���� ���� ������ ���߱� ���� ��ü������ ��� �غ� �ؿ��̴��� ����� ����� �߽����� ������ �ּ���. (1,000��)"),
                (500, "�����Ͻ� ������ ������ Ȱ�� ������ ��ų��(�������, �÷��� ��)�� ������ Ȱ�� ������ �����ּ���. (500��)"),
                (0, "�����޸�...")
            };

            InitializeEditor("Nexon", titlesAndLimits);
        }
    }
}
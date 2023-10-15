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
                (500 , "������� (300�� �̻� 500�� ����)"),
                (500 , "�������� (300�� �̻� 500�� ����)"),
                (500 , "��ȸ���� �� Ȱ�� (300�� �̻� 500�� ����)"),
                (500 , "�Ի� �� ���� (300�� �̻� 500�� ����)")
            };

            InitializeEditor("HRD", titlesAndLimits);
        }
    }
}
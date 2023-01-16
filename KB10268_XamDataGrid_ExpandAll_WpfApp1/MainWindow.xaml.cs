using Infragistics.Windows.DataPresenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KB10268_XamDataGrid_ExpandAll_WpfApp1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        // XamDataGridに表示されているレコードコレクションを全展開する。
        ExpandAll(xamDataGrid1.ViewableRecords);
    }

    private void ExpandAll(ViewableRecordCollection records)
    {
        // 各レコードに関して
        foreach(var record in records)
        {
            // 展開する
            record.IsExpanded = true;
            // 子レコードがある場合は、子レコードのコレクションを渡してExpandAllを再帰的に呼び出す。
            if (record.HasChildren)
            {
                ExpandAll(record.ViewableChildRecords);
            }
        }
    }
}

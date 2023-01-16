using KB10268_XamDataGrid_ExpandAll_WpfApp1.Infrastructure;
using KB10268_XamDataGrid_ExpandAll_WpfApp1.Model;
using System.Collections.Generic;
using System.Windows.Documents;

namespace KB10268_XamDataGrid_ExpandAll_WpfApp1;

internal class MainWindowViewModel : ObservableObject
{
    private List<SampleDataItem> _sampleData;

    public List<SampleDataItem> SampleData
    {
        get { return _sampleData; }
        set { _sampleData = value; OnPropertyChanged(); }
    }

    public MainWindowViewModel()
    {
        _sampleData = new List<SampleDataItem>()
        {
            new SampleDataItem() { Code = "1", Description = "文学部",
                Children = new List<SampleDataItem>()
                {
                    new SampleDataItem() { Code = "11", Description = "人文社会学科",
                        Children = new List<SampleDataItem>()
                        {
                            new SampleDataItem() { Code = "111", Description = "哲学系" },
                            new SampleDataItem() { Code = "112", Description = "史学系" },
                            new SampleDataItem() { Code = "113", Description = "文学・語学系" },
                            new SampleDataItem() { Code = "114", Description = "教育系" },
                        }
                    }
                }
            },
            new SampleDataItem() { Code = "2", Description = "経済学部",
                Children = new List<SampleDataItem>()
                {
                    new SampleDataItem() { Code = "21", Description = "経済学科" },
                    new SampleDataItem() { Code = "22", Description = "経営学科" }
                }
            },
            new SampleDataItem() { Code = "3", Description = "法学部",
                Children = new List<SampleDataItem>()
                {
                    new SampleDataItem() {Code = "31", Description = "法律学科"},
                    new SampleDataItem() {Code = "32", Description = "政治学科"}
                }
            },
            new SampleDataItem() { Code = "4", Description = "医歯学部",
                Children = new List<SampleDataItem>()
                {
                    new SampleDataItem() {Code = "41", Description = "医学科"},
                    new SampleDataItem() {Code = "42", Description = "歯学科"}
                }
            },
            new SampleDataItem() { Code = "5", Description = "理工学部",
                Children = new List<SampleDataItem>()
                {
                    new SampleDataItem() { Code = "52", Description = "化学科"},
                    new SampleDataItem() { Code = "53", Description = "情報工学科"},
                    new SampleDataItem() { Code = "54", Description = "数理科学科"},
                    new SampleDataItem() { Code = "55", Description = "物理学科"},
                    new SampleDataItem() { Code = "56", Description = "機械工学科"},
                    new SampleDataItem() { Code = "56", Description = "生命情報学科"},
                }
            },
        };
    }
}

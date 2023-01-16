using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB10268_XamDataGrid_ExpandAll_WpfApp1.Model;

internal class SampleDataItem
{
    public String Code { get; set; } = "";
    public String Description { get; set; } = "";
    public List<SampleDataItem> Children { get; set; } = new List<SampleDataItem>();

    public SampleDataItem()
    {
    }
}

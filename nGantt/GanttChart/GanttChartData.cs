using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace nGantt.GanttChart
{
    public class GanttChartData
    {
        public GanttChartData()
        {
            RowGroups = new ObservableCollection<GanttRowGroup>();
            TimeLines = new ObservableCollection<TimeLine>();
            Lines = new ObservableCollection<Line>();
        }
        public ObservableCollection<GanttRowGroup> RowGroups { get; set; }
        public ObservableCollection<TimeLine> TimeLines { get; set; }
        public ObservableCollection<Line> Lines { get; set; }
        public DateTime MinDate { get; set; }
        public DateTime MaxDate { get; set; }
    }
}

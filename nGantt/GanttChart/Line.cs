using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace nGantt.GanttChart
{
    public class Line : DependencyObject
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Line(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
            IsEnabled = true;
        }

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof (bool), typeof (GanttTask),
                new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsMeasure));

        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.Register("IsEnabled", typeof (bool), typeof (GanttTask),
                new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsMeasure));

        public bool IsEnabled
        {
            get { return (bool) GetValue(IsEnabledProperty); }
            set { SetValue(IsEnabledProperty, value); }
        }

        public bool IsSelected
        {
            get { return (bool) GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }
        
    }
}

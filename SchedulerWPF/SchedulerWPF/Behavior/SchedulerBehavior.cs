using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        SfScheduler scheduler;
        protected override void OnAttached()
        {
            base.OnAttached();
            scheduler = this.AssociatedObject;
            this.AssociatedObject.CellTapped += Schedule_CellTapped;
        }
        private void Schedule_CellTapped(object sender, CellTappedEventArgs e)
        {
            this.AssociatedObject.ViewType = SchedulerViewType.Day;
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.CellTapped += Schedule_CellTapped;
            this.scheduler = null;
        }
    }
}


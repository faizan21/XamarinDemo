using Foundation;
using System;
using UIKit;

namespace SampleTableView
{
    public partial class MyTableViewController : UITableViewController
    {
		public MyTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.TableView.ContentInset = new UIEdgeInsets(20,0,0,0);
			//this.TableView.Source = new TableSource();
			this.TableView.Source = new TableSource(this);

		}
    }
}
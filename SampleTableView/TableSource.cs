using System;
using Foundation;
using UIKit;

namespace SampleTableView
{
	public class TableSource : UITableViewSource
	{
		EmailServer emailServer = new EmailServer();
		UIViewController owner;

		public TableSource(UIViewController owner)
		{
			this.owner = owner;
		}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return emailServer.Email.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			/*UITableViewCell cell = new UITableViewCell();
			var email = emailServer.Email[indexPath.Row];
			cell.TextLabel.Text = email.Subject;
			return cell;*/
			/*UITableViewCell cell = new UITableViewCell(UITableViewCellStyle.Default,null);
			var item = emailServer.Email[indexPath.Row];
			cell.ImageView.Image = item.GetImage();
			cell.TextLabel.Text = item.Subject;
			return cell;*/


			/*UITableViewCell cell = new UITableViewCell(UITableViewCellStyle.Subtitle,null);
			var item = emailServer.Email[indexPath.Row];
			cell.ImageView.Image = item.GetImage();
			cell.TextLabel.Text = item.Subject;
			cell.DetailTextLabel.Text = item.Body;
			cell.DetailTextLabel.TextColor = UIColor.Brown;
			return cell;*/

			/*
			UITableViewCell cell = new UITableViewCell(UITableViewCellStyle.Value1, null);
			var item = emailServer.Email[indexPath.Row];
			cell.ImageView.Image = item.GetImage();
			cell.TextLabel.Text = item.Subject;
			cell.DetailTextLabel.Text = item.Body;
			cell.DetailTextLabel.TextColor = UIColor.Brown;
			return cell;
			*/


			//var cell= 
			UITableViewCell cell = new UITableViewCell(UITableViewCellStyle.Value1, null);
			var item = emailServer.Email[indexPath.Row];
			cell.ImageView.Image = item.GetImage();
			cell.TextLabel.Text = item.Subject;
			cell.DetailTextLabel.Text = item.Body;
			cell.DetailTextLabel.TextColor = UIColor.Brown;
			return cell;


		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			//base.RowSelected(tableView, indexPath);

			var storyBoard = UIStoryboard.FromName("Main",null);
			var detailViewController = (DetailsViewController)storyBoard.InstantiateViewController("DetailsViewController");
			var item = emailServer.Email[indexPath.Row];
			detailViewController.Item = item;

			owner.ShowDetailViewController(detailViewController, owner);
		}
	}
}

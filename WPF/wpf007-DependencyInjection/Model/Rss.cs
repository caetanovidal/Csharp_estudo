using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace wpf007_DependencyInjection.Model
{
	public class CData
	{
		public string ActualString { get; set; }
	}


	public class Item
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Link { get; set; }

		private string _pubDate;

		public string PubDate
		{
			get { return _pubDate; }
			set
			{
				_pubDate = value;
				PublishedDate = DateTime.ParseExact(_pubDate, "ddd, dd MMM yyyy HH:mm:ss GMT", CultureInfo.InvariantCulture);
			}
		}
		public DateTime PublishedDate { get; set; }
		public string Creator { get; set; }
	}

	public class Channel
	{
		public List<Item> Item { get; set; }
		public string Link { get; set; }
	}

	public class Rsss
	{
		public Channel Chan { get; set; }
	}

	public class W3schools
	{
		public Rsss Rs { get; set; }
	}
		
	
}

using System;
using System.Collections.ObjectModel;

namespace CustomerPortal
{
	public class Color
	{
		public string Name { get; set; }
	}
	public class ColorsViewModel
	{
		public ObservableCollection<Color> Colors { get; set; }
		public ColorsViewModel()
		{
			Colors = new ObservableCollection<Color>
			{
				new Color
				{
					Name = "Red"
				},new Color
				{
					Name = "Blue"
				},new Color
				{
					Name = "Green"
				}
			};
		}
	}
}
	

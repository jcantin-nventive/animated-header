using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AnimatedHeaderTest
{
	public class MyViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private double _relativeOffset;
		public double RelativeOffset
		{
			get { return _relativeOffset; }
			set
			{
				_relativeOffset = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RelativeOffset)));
			}
		}
	}
}

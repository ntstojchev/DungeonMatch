namespace Code.PlayerModel
{
	public class Status
	{
		public int Minimum { get; private set; }

		public int Maximum { get; private set; }

		public int Current { get; private set; }

		public Status(int minimum, int maximum)
		{
			Minimum = minimum;
			Maximum = maximum;
			Current = maximum;
		}

		public void Add(int value)
		{
			int newValue = Current + value;
			if (newValue <= Maximum)
			{
				Current = newValue;
			}
		}

		public void Subtract(int value)
		{
			int newValue = Current - value;
			if (newValue >= Minimum)
			{
				Current = newValue;
			}
		}

		public static Status operator +(Status status, int value)
		{
			if (value <= status.Maximum)
			{
				status.Current += value;
			}
			return status;
		}

		public static Status operator -(Status status, int value)
		{
			if (value <= status.Maximum)
			{
				status.Current -= value;
			}
			return status;
		}
	}
}

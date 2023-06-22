namespace BlazorSortingAlgoVisualizer.Shared
{
	public class Settings
	{
		private int arraySize;
		public int ArraySize
		{
			get => arraySize;
			set => arraySize = value < 2 ? 2 : value > 600 ? 600 : value;
		}

		private int delay;
		public int Delay
		{
			get => delay;
			set => delay = value < 1 ? 1 : value > 100 ? 100 : value;
		}

		public bool IsDisabled { get; set; }

		public Settings(int arraySize, int delay, bool isDisabled) 
		{
			this.arraySize = arraySize;
			this.delay = delay;
			this.IsDisabled = isDisabled;
		}
	}
}

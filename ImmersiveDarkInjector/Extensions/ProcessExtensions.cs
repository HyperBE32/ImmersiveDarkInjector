﻿namespace ImmersiveDarkInjector
{
    public class ProcessExtensions
    {
		/// <summary>
		/// Opens the input URL in the default application.
		/// </summary>
		/// <param name="url">URL to open.</param>
		public static void StartWithDefaultProgram(string url, string arguments = "")
		{
			Process.Start
			(
				new ProcessStartInfo("cmd", $"/c start \"\" \"{url}\" {arguments}")
				{
					CreateNoWindow = true
				}
			);
		}
    }
}

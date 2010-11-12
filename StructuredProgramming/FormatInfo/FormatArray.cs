using System;

namespace StructuredProgramming
{
	public class FormatArray
	{
		public FormatArray()
		{
			SPFmtDirectoriesFind spFmtFileFind = new SPFmtDirectoriesFind();
			foreach (string directory in spFmtFileFind.SPFmtDirectories)
			{
				Console.WriteLine(directory);
			}
		}
	}
}


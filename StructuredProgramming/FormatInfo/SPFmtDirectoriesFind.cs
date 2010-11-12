/*
 * Class SPFmtFileFind get current directory (or directory
 * we set as current) the it gets all subdirectories with
 * different formats.
*/

using System;
using System.IO;

namespace StructuredProgramming
{
	public class SPFmtDirectoriesFind
	{
		public SPFmtDirectoriesFind()
		{
			//currentDirectory = Environment.CurrentDirectory;
			currentDirectory = "C:\\Users\\olik\\Documents\\Projects\\StructuredProgramming";
			GetAllSPFmtDirectories();
			CheckSPFmtDirectories();
		}
		
		//
		private readonly string currentDirectory;
		public string CurrentDirectory
		{
			get
			{
				return currentDirectory;
			}
		}
		//
		
		// Array of directories containts format info
		private string[] spFmtDirectories = null;
		public string[] SPFmtDirectories
		{
			get
			{
				return spFmtDirectories;
			}
		}
		private void GetAllSPFmtDirectories()
		{
			try
			{
				spFmtDirectories = Directory.GetDirectories(CurrentDirectory, "*.spfmt");
			}
			catch (System.Exception exc)
			{
				Console.WriteLine(exc);
				spFmtDirectories = null;
				return;
			}
		}
		//
		
		// Check directory
		private void CheckSPFmtDirectories()
		{
			if (SPFmtDirectories == null) return;
			for (int i = 0; i < spFmtDirectories.Length; i++)
			{
				string directory = spFmtDirectories[i];
				try
				{
					string [] spFmtFiles = Directory.GetFiles(spFmtDirectories[i], "*.spfmt");
				}		
				catch
				{
					
				}
			}
		}
		//
	}
};
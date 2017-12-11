using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace MyBaby
{
	class ParseTXT
	{
		private static string Path = @"C:\Users\petrs.PETR\Desktop\Discrete-Math\MyBaby\graphs.txt";
		public static void getGraphFromFile()
		{
			Graph graph = new Graph();
			using (StreamReader FileWithGraphs = new StreamReader(Path))
			{


				string buffer = FileWithGraphs.ReadLine();
				Regex digitsReg = new Regex("[0-9]");
				Regex optionReg = new Regex("^[0-9]");
				var digitRegMacth = digitsReg.Match(buffer);
				var optionRegmatch = optionReg.Match(buffer);
				


			}
		}
	}
}
	

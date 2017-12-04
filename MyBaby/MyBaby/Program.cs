using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBaby
{
	class Program
	{
		public static List<Graph> graphs;
		public static void Main(int[] args)
		{
			int dialog = 0;
			while (dialog != 4)
			{
				Console.WriteLine("create graph:1");
				Console.WriteLine("add edge:2");
				Console.WriteLine("add node:3");
				Console.WriteLine("exit:4");
				switch (dialog)
				{
					case 1:
						graphs.Add(new Graph());
						break;
					case 2:
						try
						{
							int numb = returnCountOfgraph();
							Console.WriteLine("enter stasrt node");
							int start = int.Parse(Console.ReadLine());
							Console.WriteLine("enter finish node");
							int finish = int.Parse(Console.ReadLine());
							graphs[numb].addEdge(graphs[numb].Nods[start], graphs[numb].Nods[finish]);
							break;
						}
						catch(Exception e){
							Console.WriteLine(e.Message);
							break;
						}
					case 3:
						try
						{
							int numb2 = returnCountOfgraph();
							Console.WriteLine("enter value of Node");
							int value = int.Parse(Console.ReadLine());
							graphs[numb2].addNode(value);
							break;
						}
						catch(Exception e)
						{
							Console.WriteLine(e.Message);
							break;
						}
					case 4:
						break;
					default:
						Console.WriteLine("error input");
						break;

				}
				


			}
			
		}
		static Graph unionGraphs(Graph gr1, Graph gr2)
		{
			Graph gr3 = new Graph();
			gr1.Nods.Union(gr2.Nods);
		}
		static int returnCountOfgraph()
		{
			Console.WriteLine("number of graph");
			int numb = int.Parse(Console.ReadLine());
			return numb;
		}
	}
}

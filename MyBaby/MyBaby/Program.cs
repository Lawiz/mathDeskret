using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MyBaby
{	
	class Program
	{
		public static void Main()
		{
			var random = new Random((int)DateTime.Now.Ticks);

			Graph graph = new Graph();
			for(int i=0;i<30;i++){
				graph.addNode(i);
			}
			for(int i=0;i<30;i++){
				graph.addEdge(graph.Nods[random.Next(30)],graph.Nods[random.Next(30)]);
			}
			PrintInFile(graph.Edges);
		}
		public static void PrintInFile(List<Edge> edge)
		{
	
			using(StreamWriter stream=new StreamWriter(@"C:\Users\petrs.PETR\Desktop\Discrete-Math\test.txt")){
				foreach(var e in edge){
					stream.WriteLine(e.StartNode.ToString()+"--"+e.FinishNode.ToString());
				}
			}	
		}
		static int returnCountOfgraph()
		{
			Console.WriteLine("number of graph");
			int numb = int.Parse(Console.ReadLine());
			return numb;
		}
	}
}

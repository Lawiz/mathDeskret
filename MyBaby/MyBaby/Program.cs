using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using QuickGraph;
namespace MyBaby
{
	class Program
	{
		public static void Main()
		{
			//	var random = new Random((int)DateTime.Now.Ticks);

			//	Graph graph = new Graph();
			//	for(int i=0;i<30;i++){
			//		graph.addNode(i);
			//	}
			//	for(int i=0;i<30;i++){
			//		graph.addEdge(graph.Nods[random.Next(30)],graph.Nods[random.Next(30)]);
			//	}
			//	PrintInFile(graph.Edges);


			//	Graph graph2 = new Graph();
			//	for (int i = 0; i < 30; i++)
			//	{
			//		graph2.addNode(i);
			//	}
			//	for (int i = 0; i < 30; i++)
			//	{
			//		graph.addEdge(graph2.Nods[random.Next(30)], graph2.Nods[random.Next(30)]);
			//	}
			//	PrintInFile(graph2.Edges);
			//	PrintInFile(union(graph, graph2).Edges);
			//}
			//public static void PrintInFile(List<Edge> edge)
			//{

			//	using(StreamWriter stream=new StreamWriter(@"C:\Users\petrs.PETR\Desktop\Discrete-Math\test.txt")){
			//		foreach(var e in edge){
			//			stream.WriteLine(e.StartNode.ToString()+"--"+e.FinishNode.ToString());
			//		}
			//	}	
			//}
			//static int returnCountOfgraph()
			//{
			//	Console.WriteLine("number of graph");
			//	int numb = int.Parse(Console.ReadLine());
			//	return numb;
			//}
			//static Graph union(Graph e1,Graph e2)
			//{
			//	Graph e3 = new Graph();
			//	e3.Nods =(List<Node>) e1.Nods.Union(e2.Nods);
			//	e3.Edges = (List<Edge>)e1.Edges.Union(e2.Edges);
			//	return e3;
			//}
			ParseTXT.getGraphFromFile();
			Console.ReadKey();
	}
	}
}

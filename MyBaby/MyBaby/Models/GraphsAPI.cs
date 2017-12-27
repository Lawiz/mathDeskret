using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	class GraphsAPI
	{
		public static Graph Uinion(Graph graph1, Graph graph2)
		{
		
			Graph GraphResult = new Graph();
			
			GraphResult.Nods =(List<Node>) graph1.Nods.Union(graph2.Nods);
			GraphResult.Edges = (List<Edge>)graph1.Edges.Union(graph2.Edges);

			return GraphResult;
		}
		public static Graph Intersect(Graph graph1, Graph graph2)
		{
			Graph GraphResult = new Graph();

			GraphResult.Nods = (List<Node>)graph1.Nods.Intersect(graph2.Nods);
			GraphResult.Edges = (List<Edge>)graph1.Edges.Intersect(graph2.Edges);


			return GraphResult;
		}
		//public static InJSON(Graph e)
		//{
			
		//}
	}
}

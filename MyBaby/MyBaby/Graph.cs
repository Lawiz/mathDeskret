using System.Collections.Generic;
using System;
using System.Text;
namespace MyBaby
{
	class Graph
	{
		private List<Node> nods;
		public List<Node> Nods{
			get{
				return nods;
			}
			set{
				nods = value;
			}
		}
		private List<Edge> edges;
		public List<Edge> Edges{
			get{
				return edges;
			}
			set{
				edges = value;
			}
		}
		public Graph()
		{
			new List<Node>();
			new List<Edge>();

		}
		public void addNode(int val)
		{
			Nods.Add(new Node(val));
		}
		public void addEdge(Node start, Node finish)
		{
			Edges.Add(new Edge(start, finish));
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MyBaby
{
	class Graph
	{

		public List<GraphNode> listNode{ get; set; }
		public List<GrapgEdge>listEdge{ get; set; }
		public void addNode(int count)
		{
			for(int countOfNods=0;countOfNods<count;countOfNods++)
			{
				Random rnd = new Random((int)DateTime.Now.Ticks);
				GraphNode node = new GraphNode(rnd.Next(680), rnd.Next(420));
				listNode.Add(node);
			}
		}
		public void addEdge(GraphNode start, GraphNode finish, bool directed)
		{
			listEdge.Add(new GrapgEdge(start, finish, directed));
		}
		
	}
}

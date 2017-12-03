using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBaby
{
	class GraphNode
	{
		public int xPosition{ get; set; }
		public int yPosition{ get; set; }
		public GraphNode(int x,int y)
		{
			xPosition = x;
			yPosition = y;
		}
		
	}
}

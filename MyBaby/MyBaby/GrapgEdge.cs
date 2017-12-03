using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBaby
{
	class GrapgEdge
	{

		public int[] start;
		public int[] finish;
		public bool isDirected;
		public GrapgEdge(GraphNode startPosition, GraphNode finishPosotion,bool directed ){
			start = new int[2] { startPosition.xPosition, startPosition.yPosition };
			finish = new int[2] { finishPosotion.xPosition, finishPosotion.yPosition };
			isDirected = directed;

		}
	}
}

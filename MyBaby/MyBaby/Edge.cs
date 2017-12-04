using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBaby
{
	class Edge
	{
		private int startNode;
		public int StartNode {
			get {
				return startNode;
			}
			set {
				startNode = value;
			}
		}
		private int finishNode;
		public int FinishNode {
			get {
				return finishNode;
			}
			set {
				finishNode = value;
			}
		}
		public Edge(Node start,Node finish)
		{
			StartNode = start.Value;
			FinishNode = finish.Value;
		}
	}
}

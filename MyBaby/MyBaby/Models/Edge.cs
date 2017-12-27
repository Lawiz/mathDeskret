using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
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
		private bool option;
		public bool Option{
			get{
				return option;
			}
			set{
				option = value;
			}
		}
		public Edge(Node start,Node finish,bool option)
		{
			Option = option;
			StartNode = start.Value;
			FinishNode = finish.Value;
		}
	}
}

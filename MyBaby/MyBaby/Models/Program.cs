using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Models
{
	class Program
	{
		public static Graph testGraph1 = new Graph();
		public static Graph testGraph2 = new Graph();

		public static void Main()
		{


			
			//add nods in first graph
			testGraph1.addNode(1);
			testGraph1.addNode(2);
			testGraph1.addNode(3);
			testGraph1.addNode(4);
			testGraph1.addNode(5);
			testGraph1.addNode(6);
			testGraph1.addNode(7);
			// add edgs in fisrst graph
			testGraph1.addEdge(testGraph1.Nods[1], testGraph1.Nods[2], true);
			testGraph1.addEdge(testGraph1.Nods[2], testGraph1.Nods[3], true);
			testGraph1.addEdge(testGraph1.Nods[4], testGraph1.Nods[5], true);
			testGraph1.addEdge(testGraph1.Nods[6], testGraph1.Nods[7], true);
			//add nods in second graph
			testGraph2.addNode(1);
			testGraph2.addNode(2);
			testGraph2.addNode(3);
			testGraph2.addNode(4);
			testGraph2.addNode(8);
			testGraph2.addNode(9);
			testGraph2.addNode(0);
			//add edgs in second graph
			testGraph2.addEdge(testGraph2.Nods[1], testGraph2.Nods[2], true);
			testGraph2.addEdge(testGraph2.Nods[2], testGraph2.Nods[3], true);
			testGraph2.addEdge(testGraph2.Nods[4], testGraph2.Nods[8], true);
			testGraph2.addEdge(testGraph2.Nods[8], testGraph2.Nods[9], true);
			testGraph2.addEdge(testGraph2.Nods[9], testGraph2.Nods[0], true);


		}
	}
}

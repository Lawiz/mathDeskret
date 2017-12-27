using System;

namespace Models
{
	class Node
	{
		private int _value;
		public int Value{
			get{
				return _value;
			}
			set{
				_value = value;
			}
		}
		private string color;
		public string Color{
			get{
				return color;
			}
			set{
				color = value;
			}
		}
		public Node(int val){
			var random = new Random((int)DateTime.Now.Ticks);
			var color = String.Format("#{0:X6}", random.Next(0x1000000));
			Value = val;
			Color = color;
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleUnitTest {
	public class Triangle {
		public int SideA { get; set; }
		public int SideB { get; set; }
		public int SideC { get; set; }

		public Triangle(int a , int b , int c) {
			SideA = a;
			SideB = b;
			SideC = c;
		}

		public bool IsTriangle() {
			return (SideA + SideB >= SideC) && (SideA + SideC >= SideB) && (SideB + SideC >= SideA);
		}

		public bool IsEquilateral() {
			return SideA == SideB && SideB == SideC && SideC == SideA ? true : false; 
		}

		public bool IsIsosceles() {
			var sides = new List<int>() { SideA , SideB , SideC };
			var count = 0;

			for(int i = 0 ; i < sides.Count ; i++ ) {
				if(i < sides.Count - 1) {
					count += sides[i] == sides[i + 1] ? 1 : 0;
				}
				else {
					count += sides[i] == sides[i - i] ? 1 : 0;
				}
			}

			return count == 1;
		}

		public bool IsScalene() {
			return SideA != SideB && SideB != SideC && SideC != SideA ? true : false; 
		}
	}
}

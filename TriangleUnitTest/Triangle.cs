using System.Collections.Generic;

namespace TriangleUnitTest {
	
	/// <summary>
	/// The possible types of triangles that it could be.
	/// </summary>
	public enum TriangleType {
		Equilateral , Isosoceles , Scalene , None
	}

	public class Triangle {

		/// <summary>
		/// Side A of a triangle.
		/// </summary>
		public int SideA { get; set; }

		/// <summary>
		/// Side B of a triangle
		/// </summary>
		public int SideB { get; set; }

		/// <summary>
		/// Side C of a triangle
		/// </summary>
		public int SideC { get; set; }

		/// <summary>
		/// Flag determining the type of triangle it is.
		/// </summary>
		public TriangleType TriangleType { get; set; }

		/// <summary>
		/// Constructor assigning the default values of a triangle.
		/// </summary>
		/// <param name="a">Side a</param>
		/// <param name="b">Side b</param>
		/// <param name="c">Side c</param>
		public Triangle(int a , int b , int c) {

			//. Assign values.
			SideA = a;
			SideB = b;
			SideC = c;

			//. Assign TriangleType flag.
			if(!this.IsTriangle()) {
				TriangleType = TriangleType.None;
			}
			else if(this.IsEquilateral()) {
				TriangleType = TriangleType.Equilateral;
			}
			else if(this.IsIsosceles()) {
				TriangleType = TriangleType.Isosoceles;
			}
			else if(this.IsScalene()) {
				TriangleType = TriangleType.None;
			}

		}

		/// <summary>
		/// Check to see if the angles are indeed a triangle.
		/// </summary>
		/// <returns>Returns if the the three sides are indeed a proper triangle.</returns>
		public bool IsTriangle() {
			return (SideA + SideB >= SideC) && (SideA + SideC >= SideB) && (SideB + SideC >= SideA);
		}

		/// <summary>
		/// Checks to see if the three sides make up an Equilateral triangle.
		/// </summary>
		/// <returns>Returns if the triangle is Equilateral.</returns>
		public bool IsEquilateral() {
			return SideA == SideB && SideB == SideC && SideC == SideA ? true : false; 
		}

		/// <summary>
		/// Checks to see if the three sides make up an Isosceles triangle.
		/// </summary>
		/// <returns>Returns if the triangle is Isosceles</returns>
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

		/// <summary>
		/// Checks to see if the three sides make up a Scalene triangle.
		/// </summary>
		/// <returns>Returns if the triangle is Scalene</returns>
		public bool IsScalene() {
			return SideA != SideB && SideB != SideC && SideC != SideA ? true : false; 
		}
	}
}

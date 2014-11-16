using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TriangleUnitTest;

namespace Triangle_Tests {

	/// <summary>
	/// Unit test class for testing the Triangle class.
	/// </summary>
	[TestClass]
	public class Triangle_Test {

		List<Triangle> TArray = new List<Triangle>() {
			new Triangle(5 , 5 , 5) ,	//. Is an Equilateral triangle
			new Triangle(2 , 3 , 2) ,	//. Is an Isosceles triangle
			new Triangle(3 , 4 , 5) ,	//. Is a Scalene triangle
			new Triangle(4 , 2 , 1)		//. Is not a triangle at all
		};


		/// <summary>
		/// Test the methed IsTriangle for returning the proper result.
		/// </summary>
		[TestMethod]
		public void IsTriangle_Test() {
			var expected = 3;
			var actual = TArray.Where(a => a.IsTriangle()).Count();

			Assert.AreEqual(expected , actual);
		}

		/// <summary>
		/// Tests the method IsEquilateral for returning the proper result.
		/// </summary>
		[TestMethod]
		public void IsEquilateral_Test() {
			var expected = 1;
			if(TArray[0].IsEquilateral()) {
				var actual = TArray.Where(a => a.IsEquilateral()).Count();
				Assert.AreEqual(expected , actual);
			}
			else {
				Assert.Fail();
			}
		}

		/// <summary>
		/// Tests the method IsIsosceles for returning the proper result.
		/// </summary>
		[TestMethod]
		public void IsIsosceles_Test() {
			var expected = 1;
			if(TArray[1].IsIsosceles()) {
				var actual = TArray.Where(a => a.IsIsosceles() && a.IsTriangle()).Count();
				Assert.AreEqual(expected , actual);
			}
			else {
				Assert.Fail();
			}
		}

		/// <summary>
		/// Tests the method IsScalene for returning the proper result.
		/// </summary>
		[TestMethod]
		public void IsScalene_Test() {
			var expected = 1;
			if(TArray[2].IsScalene()) {
				var actual = TArray.Where(a => a.IsScalene() && a.IsTriangle()).Count();
				Assert.AreEqual(expected , actual);
			}
			else {
				Assert.Fail();
			}
		}
	}
}

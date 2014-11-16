using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleUnitTest;
using System.Collections.Generic;
using System.Linq;

namespace Triangle_Tests {
	[TestClass]
	public class Triangle_Test {

		List<Triangle> TArray = new List<Triangle>() {
			new Triangle(5 , 5 , 5) ,
			new Triangle(2 , 3 , 2) ,
			new Triangle(3 , 4 , 5) ,
			new Triangle(4 , 2 , 1)
		};

		[TestMethod]
		public void IsTriangle_Test() {
			var expected = 3;
			var actual = TArray.Where(a => a.IsTriangle()).Count();

			Assert.AreEqual(expected , actual);
		}

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

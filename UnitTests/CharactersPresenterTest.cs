using System;
using NUnit.Framework;

namespace UnitTests
{
	[TestFixture]
	public class CharactersPresenterTests
	{
    //    CharactersPresenter presenter;

		[SetUp]
		public void Setup() {

 //           presenter = new CharactersPresenterImpl();
        }


		[TearDown]
		public void Tear() { }

		[Test]
		public void Pass()
		{
            //prese
   //         presenter.Start();
		}

       

		[Test]
		public void Fail()
		{
			Assert.False(true);
		}

		[Test]
		[Ignore("another time")]
		public void Ignore()
		{
			Assert.True(false);
		}

		[Test]
		public void Inconclusive()
		{
			Assert.Inconclusive("Inconclusive");
		}
	}
}

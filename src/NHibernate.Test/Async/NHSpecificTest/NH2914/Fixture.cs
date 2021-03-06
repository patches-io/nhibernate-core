﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Linq;
using NHibernate.Dialect;
using NHibernate.Linq;
using NUnit.Framework;

namespace NHibernate.Test.NHSpecificTest.NH2914
{
	using System.Threading.Tasks;
	[TestFixture]
	public class FixtureAsync : BugTestCase
	{
		protected override bool AppliesTo(Dialect.Dialect dialect)
		{
			return dialect is Oracle8iDialect;
		}

		protected override void OnSetUp()
		{
			using (ISession session = OpenSession())
			using (ITransaction tx = session.BeginTransaction())
			{
				var entity = new Entity { CreationTime = DateTime.Now };

				session.Save(entity);

				tx.Commit();
			}
		}

		protected override void OnTearDown()
		{
			base.OnTearDown();

			using (ISession session = OpenSession())
			using (ITransaction tx = session.BeginTransaction())
			{
				session.Delete("from Entity");
				tx.Commit();
			}
		}

		[Test]
		public async Task Linq_DateTimeDotYear_WorksInOracleAsync()
		{
			using (ISession session = OpenSession())
			using (ITransaction tx = session.BeginTransaction())
			{
				var result = await (session.Query<Entity>()
					.Where(x => x.CreationTime.Year == DateTime.Today.Year)
					.ToListAsync());

				await (tx.CommitAsync());

				Assert.AreEqual(1, result.Count);
			}
		}

		[Test]
		public async Task Linq_DateTimeDotMonth_WorksInOracleAsync()
		{
			using (ISession session = OpenSession())
			using (ITransaction tx = session.BeginTransaction())
			{
				var result = await (session.Query<Entity>()
					.Where(x => x.CreationTime.Month == DateTime.Today.Month)
					.ToListAsync());

				await (tx.CommitAsync());

				Assert.AreEqual(1, result.Count);
			}
		}

		[Test]
		public async Task Linq_DateTimeDotDay_WorksInOracleAsync()
		{
			using (ISession session = OpenSession())
			using (ITransaction tx = session.BeginTransaction())
			{
				var result = await (session.Query<Entity>()
					.Where(x => x.CreationTime.Day == DateTime.Today.Day)
					.ToListAsync());

				await (tx.CommitAsync());

				Assert.AreEqual(1, result.Count);
			}
		}

		[Test]
		public async Task Linq_DateTimeDotHour_WorksInOracleAsync()
		{
			using (ISession session = OpenSession())
			using (ITransaction tx = session.BeginTransaction())
			{
				var result = await (session.Query<Entity>()
					.Where(x => x.CreationTime.Hour <= 24)
					.ToListAsync());

				await (tx.CommitAsync());

				Assert.AreEqual(1, result.Count);
			}
		}

		[Test]
		public async Task Linq_DateTimeDotMinute_WorksInOracleAsync()
		{
			using (ISession session = OpenSession())
			using (ITransaction tx = session.BeginTransaction())
			{
				var result = await (session.Query<Entity>()
					.Where(x => x.CreationTime.Minute <= 60)
					.ToListAsync());

				await (tx.CommitAsync());

				Assert.AreEqual(1, result.Count);
			}
		}

		[Test]
		public async Task Linq_DateTimeDotSecond_WorksInOracleAsync()
		{
			using (ISession session = OpenSession())
			using (ITransaction tx = session.BeginTransaction())
			{
				var result = await (session.Query<Entity>()
					.Where(x => x.CreationTime.Second <= 60)
					.ToListAsync());

				await (tx.CommitAsync());

				Assert.AreEqual(1, result.Count);
			}
		}

		[Test]
		public async Task Linq_DateTimeDotDate_WorksInOracleAsync()
		{
			using (ISession session = OpenSession())
			using (ITransaction tx = session.BeginTransaction())
			{
				var result = await (session.Query<Entity>()
					.Where(x => x.CreationTime.Date == DateTime.Today)
					.ToListAsync());

				await (tx.CommitAsync());

				Assert.AreEqual(1, result.Count);
			}
		}
	}
}

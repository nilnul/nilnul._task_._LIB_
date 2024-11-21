using nilnul.order;
using nilnul.task.co_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.task._prj_
{
	/// <summary>
	///  intransitive directed as order
	/// </summary>
	/// alias:
	///		precedence
	///		dependency
	///		dep
	public  class Priors
		:
		//nilnul.rel_._net_...<Duration>
		nilnul.rel_.Net1<Duration>
		

		//IntransitiveDirectedRelation<Duration>
		,
		IEnumerable<Prior>
		//,
		//nilnul.rel_.INonCelibate
		
	{
		//public List<Precedence> list=new List<Precedence>();

		public Priors()
		{


		}

		public IEnumerable<Duration> precedents(Duration task) {
			foreach (var item in this)
			{
				if (item.second==task)
				{
					yield return item.first;
				}
			}
		
		}

		/// <summary>
		/// maximal of the subgraph
		/// </summary>
		/// <param name="tasks"></param>
		/// <returns></returns>
		/// alias:
		///		极大值
		/// vs:
		///		maximum|最大值, which is unique;

		public IEnumerable<Duration> maximal(IEnumerable<Duration> tasks) {

			//fiter the precedence.

			var filteredPrecedences=(
				this as IEnumerable<Prior>
			).Where(
				c=>tasks.Contains(c.first) && tasks.Contains(c.second)
			).ToArray();

			foreach (var item in tasks)
			{
				if (filteredPrecedences.Any(c => c.second == item)) {
					continue;  /// the indegree is positive;
				}
				yield return item; /// the in-degree is 0; isnot this minimal?

				
			}
		
		}

	


		public Duration start {
			get {
				foreach (var item in tasks)
				{
					if (precedents(item).Count()==0)
					{
						return item;
						
					}
					
				}
				///if no tasks
				return null;
			}
		}

		public Duration end {
			get {
				foreach (var item in tasks)
				{
					if (subsequents(item).Count()==0)
					{
						return item;
						
					}
					
					
				}
				//if the lattice is empty.
				return null;
			
			}
		}



		public IEnumerable<Duration> subsequents(Duration task) {
			foreach (var item in this)
			{
				if (item.first==task)
				{
					yield return item.second;
					
				}
				
			}
		}


		//public void add(Duration a,Duration b) {
		//	base.add(new Dep(a, b));
		//}

		public HashSet<Duration> tasks {
			get {
				var r = new HashSet<Duration>();
				foreach (var item in this)
				{
					r.Add(item.first);
					r.Add(item.second);
					
				}
				return r;

			}
		}




		public IEnumerator<Prior> GetEnumerator()
		{
			foreach (var item in (this.mate))
			{
				yield return new Prior(item.component, item.component1);
				
			}
			
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return /*(this as IEnumerable<Dep>).*/GetEnumerator();
		}
	}
}

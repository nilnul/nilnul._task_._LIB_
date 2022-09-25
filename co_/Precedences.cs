using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.task.proj
{
	/// <summary>
	///  intransitive directed as order
	/// </summary>
	public partial class Precedences
		:IntransitiveDirectedRelation<Task>
		,
		IEnumerable<Precedence>
		
	{
		//public List<Precedence> list=new List<Precedence>();

		public Precedences()
		{


		}

		public IEnumerable<Task> precedents(Task task) {
			foreach (var item in this)
			{
				if (item.second==task)
				{
					yield return item.first;
				}
			}
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tasks"></param>
		/// <returns></returns>

		public IEnumerable<Task> maximal(IEnumerable<Task> tasks) {

			//fiter the precedence.

			IEnumerable<Precedence> filteredPrecedences=(this as IEnumerable<Precedence>).Where(c=>(tasks.Contains(c.first) && tasks.Contains(c.second)));

			

			foreach (var item in tasks)
			{
				if (filteredPrecedences.Any(c => c.second == item)) {
					continue;
				}
				yield return item;

				
			}
		
		}

	


		public Task start {
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

		public Task end {
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



		public IEnumerable<Task> subsequents(Task task) {
			foreach (var item in this)
			{
				if (item.first==task)
				{
					yield return item.second;
					
				}
				
			}
		}


		public void add(Task a,Task b) {
			Add( new Precedence(a, b));
		}

		public HashSet<Task> tasks {
			get {
				var r = new HashSet<Task>();
				foreach (var item in this)
				{
					r.Add(item.first);
					r.Add(item.second);
					
				}
				return r;

			}
		}




		public IEnumerator<Precedence> GetEnumerator()
		{
			foreach (var item in (this as IntransitiveDirected2<Task>))
			{
				yield return new Precedence(item.first, item.second);
				
			}
			
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return (this as IEnumerable<Precedence>).GetEnumerator();
		}
	}
}

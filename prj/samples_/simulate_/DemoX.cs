using nilnul.prob.rationalMeasure.empirical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.task.prj.samples_.simulate_
{
	static public class DemoX
	{
		static private nilnul.task.prj.samples_.Simulate _simulation=new nilnul.task.prj.samples_.Simulate(nilnul.task.prj.samples_.simulate_.Demo.proj);

		static public nilnul.task.prj.samples_.Simulate simulation
		{
			get {
				return _simulation; }
			set { _simulation = value; }
		}

		static public Cdf samples {
			get {

				var densityBenchMarks=simulation.getCdf();
				return densityBenchMarks;
			}
		}

		static public Cdf cdf
		{
			get
			{

				var densityBenchMarks = simulation.getCdf();
				return densityBenchMarks;
			}
		}

	}
}

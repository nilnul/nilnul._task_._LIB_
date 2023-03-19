using nilnul.prob.rationalMeasure.empirical;
using nilnul.task.co_;
using nilnul.task.prj.sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.task.prj.survey_
{
	/// <summary>
	/// simulate a project to get the distribution of the time of prj
	/// </summary>
	public  class Simulate
	{
		private Prj _project;

		public Prj project
		{
			get { return _project; }
			set { _project = value.EnsureNotNull(); }
		}



		public Simulate(Prj project)
		{
			this.project = project;

		}

		//output duration and times.

		public Pmf getPmf() {

			var sampleBag2 = new nilnul.num.rational.collection.Bag3();

			for (int i = 0; i < 1000; i++)
			{
				var realization = Sample_quotient.Realize(project);

				var duration = Cpm_quotient.Duration(realization);

				//sampleBag.add(duration);
				sampleBag2.add(duration);

			}

			return Pmf._Create(sampleBag2);
		

		}

		public Cdf getCdf() {

			//
			//Dictionary<nilnul.num.rational.Rational_InheritFraction, int> sampleCount=new Dictionary<num.rational.Rational_InheritFraction,int>();
			//var sampleBag =new nilnul.collection.bag.Bag_dictPositive<nilnul.num.rational.Rational_InheritFraction>();
			var sampleBag2 = new nilnul.num.rational.collection.Bag3();

			for (int i = 0; i < 1000; i++)
			{
				var realization=Sample_quotient.Realize(project);

				var duration = Cpm_quotient.Duration(realization);

				//sampleBag.add(duration);
				sampleBag2.add(duration);
				
			}

			//nilnul.prob.rationalMeasure.rationalSample.NonEmptyCollectionOfPositiveSample samples = new prob.rationalMeasure.rationalSample.NonEmptyCollectionOfPositiveSample(sampleBag);
			//EmpiricalDistribution dist = new EmpiricalDistribution();


			//dist.samples = samples;
			Cdf densityFuncByIntervalRight = Cdf._Create(sampleBag2);

			return densityFuncByIntervalRight;
			


			throw new NotImplementedException();
		
		}



		
					

	}
}

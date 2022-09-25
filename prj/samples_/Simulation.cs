using nilnul.prob.rationalMeasure.empirical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.task.proj
{
	public partial class Simulation
	{
		private Project _project;

		public Project project
		{
			get { return _project; }
			set { _project = value.EnsureNotNull(); }
		}




		public Simulation(Project project)
		{
			this.project = project;

		}

		//output duration and times.

		public DensityBenchmarks getEmpiricalDistribution() {

			//
			Dictionary<nilnul.num.rational.Rational_InheritFraction, int> sampleCount=new Dictionary<num.rational.Rational_InheritFraction,int>();

			num.rational.collection.Dict2 sampleCount2 = new num.rational.collection.Dict2();

			var sampleBag =new nilnul.collection.bag.Bag_dictPositive<nilnul.num.rational.Rational_InheritFraction>();

			var sampleBag2 = new nilnul.num.rational.collection.Bag3();

			for (int i = 0; i < 1000; i++)
			{
				var realization=Realization_rational.Realize(project);

				var duration = Cpm_rational.Duration(realization);

				sampleBag.add(duration);
				sampleBag2.add(duration);
			}

			nilnul.prob.rationalMeasure.rationalSample.NonEmptyCollectionOfPositiveSample samples = new prob.rationalMeasure.rationalSample.NonEmptyCollectionOfPositiveSample(sampleBag);

			


			EmpiricalDistribution dist = new EmpiricalDistribution();




			dist.samples = samples;
			DensityBenchmarks densityFuncByIntervalRight = DensityBenchmarks._Create(sampleBag2);


			return densityFuncByIntervalRight;
			
			



			throw new NotImplementedException();
		
		}

		
					

	}
}

using System;
using Ch24.Contest03.A;
using Ch24.Contest03.B;
using Ch24.Contest03.C;
using Ch24.Contest03.D;
using Ch24.Contest03.E;
using Ch24.Contest03.F;
using Cmn.Util;

namespace Ch24
{
	class Program
	{
		[STAThreadAttribute]
		static void Main()
		{
			Lg.dgIlgFromTy = ty => new LgLog4net(ty);

			//new Ch24Runner<ALettersSolver>("A-{0}.in", "A{0}.out", "A-{0}.refout")
			//	.SelectProblems()
			//	.Run(fParallel: false);

			//new Ch24Runner<BExpressionsSolver>("B-{0}.in", "B{0}.out", "B-{0}.refout")
			//	.SelectProblems()
			//	.Run(fParallel: false);


			//new Ch24Runner<CDNA4Solver>("C-{0}.in", "C{0}.out", "C-{0}.refout")
			//	.SelectProblems()
			//	.Run(fParallel: false);

			//new Ch24Runner<DIslandSolver>("D-{0}.in", "D{0}.png", "D-{0}.refout")
			//	.SelectProblems()
			//	.Run(fParallel: false);

			//new Ch24Runner<ECryptoSolver>("E-{0}.in", "E{0}.out", "E-{0}.refout")
			//	.SelectProblems()
			//	.Run(fParallel: false);

			new Ch24Runner<FEcologySolver>("F-{0}.in", "F{0}.out", "F-{0}.refout")
				.SelectProblems()
				.Run(fParallel: false);

			
			Console.ReadLine();
		}

	}
}

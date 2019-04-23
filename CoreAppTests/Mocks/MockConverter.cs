using DinkToPdf.Contracts;
using DinkToPdf.EventDefinitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppTests.Mocks
{
	public class MockConverter : IConverter
	{
		public event EventHandler<PhaseChangedArgs> PhaseChanged;
		public event EventHandler<ProgressChangedArgs> ProgressChanged;
		public event EventHandler<FinishedArgs> Finished;
		public event EventHandler<ErrorArgs> Error;
		public event EventHandler<WarningArgs> Warning;

		public byte[] Convert(IDocument document)
		{
			return new byte[] { };
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turan.Shared.Utilities.Results
{
	public class Result : IResult
	{
		public Result(bool success, string message) : this(success)
		{
			Message = message;
		}

		public Result(bool success)
		{
			Success = success;
		}

		public string Message { get; }

		public bool Success { get; }
	}
}

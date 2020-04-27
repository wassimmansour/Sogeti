using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
	internal class CustomDelimiterParserFactory : DelimiterParserFactory
	{
		internal override DelimiterParser CreateDelimiterParser()
		{
			return new CustomDelimiterParserImp();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
	internal class DefaultDelimiterParserFactory : DelimiterParserFactory
	{
		internal override DelimiterParser CreateDelimiterParser()
		{
			return new DefaultDelimiterParserImp();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
	internal class DelimiterParserFactory
	{
		internal static DelimiterParser CreateDelimiterParser(string numbersString)
		{
			if (numbersString?.StartsWith("//") ?? false)
			{
				return new CustomDelimiterParserImp();
			}
			else
			{
				return new DefaultDelimiterParserImp();
			}
		}
	}
}

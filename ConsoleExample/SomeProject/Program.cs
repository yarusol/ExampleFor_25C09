﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeProject
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "\n\n\n" );
			Console.WriteLine( "Hello, Git !" );
			Console.WriteLine( "\n\n\n" );

			int iv;
			string str;
			do
			{
				Console.WriteLine( "Enter integer value, please : " );
				str = Console.ReadLine();
			} while ( ! Int32.TryParse( str, out iv ) );
			Console.WriteLine( "\n\nYou've entered: {0}. It is cool! Thank you!!!\n\n", iv );

			Console.WriteLine( "\n\n\n" );
			string str1;
			do
			{
				Console.WriteLine( "Enter some string : " );
				str1 = Console.ReadLine();
			} while ( str1.Length < 5 );
			Console.WriteLine( "You have entered \"{0}\".\n Thank you!\n\n\n", str1 );

			Console.WriteLine( "\n\n\n" );
		}
	}
}

using System;
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

			string str;
			do
			{
				Console.WriteLine( "Enter some string : " );
				str = Console.ReadLine();
			} while ( str.Length < 5 );
			Console.WriteLine( "You have entered \"{0}\".\n Thank you!\n\n\n", str );



		}
	}
}

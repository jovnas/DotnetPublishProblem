using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ConsoleApp16
{
	class Program
	{
		static async Task Main(string[] args)
		{
			await using var connection = new SqlConnection();

			Console.WriteLine("Test");
		}
	}
}

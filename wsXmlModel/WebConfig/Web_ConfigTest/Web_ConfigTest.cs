//
// Web_ConfigTest.cs
//
// This file was generated by XMLSpy 2008r2sp2 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using Altova.Types;

namespace Web_Config
{
	/// <summary>
	/// Summary description for Web_ConfigTest.
	/// </summary>
	class Web_ConfigTest
	{
		protected static void Example()
		{
            /*
            <?xml version="1.0" encoding="utf-8"?>
<connectionStrings>
	<add name="MSSQL" connectionString="Data Source=localhost;Initial Catalog=test;User ID=sa;password=sa;" providerName="System.Data.SqlClient" />
	<add name="Oracle" connectionString="Data Source=TEST;User ID=sa;Password=sa;" providerName="System.Data.OracleClient" />
</connectionStrings>
             * 
             * */
			//
			// TODO:
			//   Insert your code here...
			//
			// Example code to create and save a structure:
			   Web_Config.Web_Config2 doc = Web_Config.Web_Config2.CreateDocument();
               Web_Config.connectionStringsType root = doc.connectionStrings.Append();
               Web_Config.addType a = root.add.Append();
               a.name.Value = "MSSQL";
               a.connectionString.Value = "Data Source=localhost;Initial Catalog=test;User ID=sa;password=sa;";
               a.providerName.Value = "System.Data.SqlClient";


               Web_Config.addType b = root.add.Append();
               b.name.Value = "Oracle";
               b.connectionString.Value = "Data Source=TEST;User ID=sa;Password=sa;";
               b.providerName.Value = "System.Data.OracleClient";
               //root.CreateElement(
               //Web_Config.
               //root.CreateElement(
           // 
            
               //root.CreateElement(

			 //  ...
			   doc.SaveToFile("Web_Config1.xml", true);
			
			// Example code to load and save a structure:
			  Web_Config.Web_Config2 doc1 = Web_Config.Web_Config2.LoadFromFile("Web_Config1.xml");
			  Web_Config.connectionStringsType root1 = doc1.connectionStrings.First;

              Console.WriteLine(root1.add.First.name.Value);
              Console.WriteLine(root1.add.First.connectionString.Value);
              Console.WriteLine(root1.add.First.providerName.Value);
              Console.WriteLine(root1.add.Last.name.Value);
              Console.WriteLine(root1.add.Last.connectionString.Value);
              Console.WriteLine(root1.add.Last.providerName.Value);
              

              Console.WriteLine(root1.add.Count);
     

              for (int i = 0; i < root1.add.Count; i++)
                  Console.WriteLine(root1.add.At(i).connectionString.Value);
                  //foreach (Web_Config.connectionStringsType roots in root1.add)
                  //{

                  //    Console.WriteLine(roots.add.First.name.Value);
                  //}
                  Console.ReadKey();

             


            //a.name.Value
			//   ...
			 // doc.SaveToFile("Web_Config1.xml", true);

		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static int Main(string[] args)
		{
			try
			{
				Console.WriteLine("Web_Config Test Application");
				Example();
				Console.WriteLine("OK");
				return 0;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return 1;
			}
		}
	}
}

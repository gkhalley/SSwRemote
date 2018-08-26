using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Xml;

namespace SSwRemote.Model
{
    using System.Xml.XPath;

    using Xamarin.Forms;

    class TimeSeries
    {
        /// <summary>
        /// The connection will connect to the database.
        /// </summary>
        private static SqliteConnection connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeries"/> class.
        /// </summary>
        /// <param name="rawFile">
        /// The raw file comes from the Netduino.
        /// </param>
        /// <param name="readerSettings">
        /// The reader Settings.
        /// </param>
        public TimeSeries(TextReader rawFile, XmlReaderSettings readerSettings)
        {
            this.ReaderSettings = readerSettings;
            var xmlReader = XmlReader.Create(rawFile, this.ReaderSettings);
        }

        public void Value()
        {
            
        }

        public string ArchiveValue { get; set; }

        /// <summary>
        /// Gets the reader settings.
        /// </summary>
        public XmlReaderSettings ReaderSettings { get; }
        /*
public static string DoSomeDataAccess ()
{
// determine the path for the database file
string dbPath = Path.Combine (
Environment.GetFolderPath (Environment.SpecialFolder.Personal),
"SSw.db3");

bool exists = File.Exists (dbPath);

if (!exists) {
Console.WriteLine("Creating database");
Connection = new SqliteConnection ("Data Source=" + dbPath);

var commands = new[] {
"CREATE TABLE [Items] (_id ntext, Symbol ntext);",
"INSERT INTO [Items] ([_id], [Symbol]) VALUES ('1', 'AAPL')",
"INSERT INTO [Items] ([_id], [Symbol]) VALUES ('2', 'GOOG')",
"INSERT INTO [Items] ([_id], [Symbol]) VALUES ('3', 'MSFT')"
};
// Open the database connection and create table with data
Connection.Open ();
foreach (var command in commands) {
using (var c = Connection.CreateCommand ()) {
c.CommandText = command;
var rowcount = c.ExecuteNonQuery ();
Console.WriteLine("\tExecuted " + command);
}
}
} else {
Console.WriteLine("Database already exists");
// Open connection to existing database file
Connection = new SqliteConnection ("Data Source=" + dbPath);
Connection.Open ();
}

// query the database to prove data was inserted!
using (var contents = Connection.CreateCommand ()) {
contents.CommandText = "SELECT [_id], [Symbol] from [Items]";
var r = contents.ExecuteReader ();
Console.WriteLine("Reading data");
while (r.Read ())
Console.WriteLine("\tKey={0}; Value={1}",
r ["_id"].ToString (),
r ["Symbol"].ToString ());
}

return "Glen";
Connection.Close ();
}
*/
    }
}

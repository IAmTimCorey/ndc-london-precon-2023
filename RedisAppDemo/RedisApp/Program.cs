using StackExchange.Redis;

var connection = ConnectionMultiplexer.Connect("localhost:6379");
var db = connection.GetDatabase();

db.StringSet("TimCorey", "The person in front");

Console.WriteLine(db.StringGet("TimCorey"));
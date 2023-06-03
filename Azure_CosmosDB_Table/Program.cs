using Azure;
using Azure.Data.Tables;

string connectionString = "";
string tableName = "Orders";

/* Adding Entity to Table Storage */

AddEntity("01", "Mobile", 123);
AddEntity("02", "Laptop", 23);
AddEntity("03", "Desktop", 123);
AddEntity("04", "Laptop", 13);
AddEntity("05", "Mobile", 33);

void AddEntity(string orderID, string category, int quantity)
{
    TableClient tableClient = new TableClient(connectionString, tableName);

    TableEntity tableEntity = new TableEntity(category, orderID)
    {
        {"quantity", quantity }
    };
    tableClient.AddEntity(tableEntity);
    Console.WriteLine("Added Entity order id {0}", orderID);
}
using Azure.Data.Tables;

string connectionString = "";
string tableName = "Orders";

/* Adding Entity to CosmosDB Table */

AddCosmosDBEntity("01", "Mobile", 123);
AddCosmosDBEntity("02", "Laptop", 23);
AddCosmosDBEntity("03", "Desktop", 123);
AddCosmosDBEntity("04", "Laptop", 13);
AddCosmosDBEntity("05", "Mobile", 33);

void AddCosmosDBEntity(string orderID, string category, int quantity)
{
    TableClient tableClient = new TableClient(connectionString, tableName);

    TableEntity tableEntity = new TableEntity(category, orderID)
    {
        {"quantity", quantity }
    };
    tableClient.AddEntity(tableEntity);
    Console.WriteLine("Added Entity order id {0}", orderID);
}
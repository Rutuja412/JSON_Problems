internal class Program
{
    private static void Main(string[] args)
    {
        JsonInventoy.JsonMain json = new JsonInventoy.JsonMain();
        json.convert("E:\\RFP 232 BATCH\\JSON_Problems\\JsonInventoy\\Inventory.json");
    }
}
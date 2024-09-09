// Example usage with integers

using GenericsAdvanced;

GenericCache<int> intCache = new GenericCache<int>();

intCache.AddItem("Number1", 42, TimeSpan.FromSeconds(5));

intCache.Display();


Console.WriteLine($"Retrieved item: {intCache.GetItem("Number1")}");

intCache.Display();


// Wait for the item to expire

Console.WriteLine("Waiting for item to expire...");

System.Threading.Thread.Sleep(6000);


// Attempt to retrieve an expired item

try

{

    Console.WriteLine($"Retrieved item: {intCache.GetItem("Number1")}");

}

catch (Exception ex)

{

    Console.WriteLine($"Error: {ex.Message}");

}


// Example usage with strings

GenericCache<string> stringCache = new GenericCache<string>();

stringCache.AddItem("Message1", "Hello, World!", TimeSpan.FromMinutes(1));

stringCache.Display();


Console.WriteLine($"Retrieved item: {stringCache.GetItem("Message1")}");

stringCache.Display();
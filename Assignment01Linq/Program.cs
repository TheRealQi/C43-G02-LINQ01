namespace Assignment01Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = ListGenerator.ProductsList;
        List<Customer> customers = ListGenerator.CustomersList;

        #region LINQ - Restriction Operators

        // var outOfStockProducts = products.Where(p => p.UnitsInStock == 0);
        // Console.WriteLine("Out of stock products:");
        // foreach (var product in outOfStockProducts)
        // {
        //     Console.WriteLine(product.ProductName);
        // }
        //
        // var greaterThan3Products = products.Where(p => p.UnitPrice > 3 && p.UnitsInStock > 0);
        // Console.WriteLine("Products with price greater than 3 and in stock:");
        // foreach (var product in greaterThan3Products)
        // {
        //     Console.WriteLine(product.ProductName);
        // }
        //
        // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //
        // var shortDigits = Arr.Where((d, i) => d.Length < i);
        // Console.WriteLine("Short digits:");
        // foreach (var digit in shortDigits)
        // {
        //     Console.WriteLine(digit);
        // }

        #endregion

        #region LINQ - Element Operators

        // var firstOutOfStockProduct = products.FirstOrDefault(p => p.UnitsInStock == 0);
        // Console.WriteLine(firstOutOfStockProduct.ProductName);
        //
        // var fistProductWithPriceGreaterThan1000 = products.FirstOrDefault(p => p.UnitPrice > 1000);
        // Console.WriteLine(fistProductWithPriceGreaterThan1000);
        //
        // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // var secondGreaterThan5 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
        // Console.WriteLine($"Second greater than 5 number: {secondGreaterThan5}");

        #endregion

        #region LINQ - Aggregate Operators

        // int[] Arr31 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // int oddNumbersCount = Arr31.Count(n => n % 2 != 0);
        // Console.WriteLine($"Odd numbers count: {oddNumbersCount}");
        //
        // var ordersPerCustomer = customers.Select(c => new { c.CustomerID, OrdersCount = c.Orders.Count() });
        // Console.WriteLine("Orders per customer:");
        // foreach (var order in ordersPerCustomer)
        // {
        //     Console.WriteLine($"CustomerID: {order.CustomerID}, OrdersCount: {order.OrdersCount}");
        // }
        //
        // var productsPerCategory = products.GroupBy(p => p.Category)
        //     .Select(g => new { Category = g.Key, ProductsCount = g.Count() });
        // Console.WriteLine("Products per category:");
        // foreach (var product in productsPerCategory)
        // {
        //     Console.WriteLine($"Category: {product.Category}, ProductsCount: {product.ProductsCount}");
        // }
        //
        // int[] Arr32 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // int totalNumber = Arr32.Sum();
        // Console.WriteLine($"Total number: {totalNumber}");
        //
        // string[] englishDictionary = System.IO.File.ReadAllLines("./dictionary_english.txt");
        // int totalCharacters = englishDictionary.Sum(w => w.Length);
        // Console.WriteLine($"Total characters: {totalCharacters}");
        //
        // int shortestWordLength = englishDictionary.Min(w => w.Length);
        // Console.WriteLine($"Shortest word length: {shortestWordLength}");
        //
        // int longestWordLength = englishDictionary.Max(w => w.Length);
        // Console.WriteLine($"Longest word length: {longestWordLength}");
        //
        // int averageWordLength = (int) englishDictionary.Average(w => w.Length);
        // Console.WriteLine($"Average word length: {averageWordLength}");

        #endregion

        #region LINQ - Ordering Operators

        // var sortedProducts = products.OrderBy(p => p.ProductName);
        // Console.WriteLine("Sorted products:");
        // foreach (var product in sortedProducts)
        // {
        //     Console.WriteLine(product.ProductName);
        // }
        //
        // string[] Arr41 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        // var caseInsensitiveSortedWords = Arr41.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
        // Console.WriteLine("Case insensitive sorted words:");
        // foreach (var word in caseInsensitiveSortedWords)
        // {
        //     Console.WriteLine(word);
        // }
        //
        // var sortedProductsByStock = products.OrderByDescending(p => p.UnitsInStock);
        // Console.WriteLine("Sorted products by stock:");
        // foreach (var product in sortedProductsByStock)
        // {
        //     Console.WriteLine($"ProductName: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
        // }
        //
        // string[] Arr42 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        // var sortedDigitsByNameAndLength = Arr42.OrderBy(d => d.Length).ThenBy(d => d);
        // Console.WriteLine("Sorted digits by name and length:");
        // foreach (var digit in sortedDigitsByNameAndLength)
        // {
        //     Console.WriteLine(digit);
        // }
        //
        // var sortedProductsByCategoryAndPrice = products.OrderBy(p => p.Category).ThenBy(p => p.UnitPrice);
        // Console.WriteLine("Sorted products by category and price:");
        // foreach (var product in sortedProductsByCategoryAndPrice)
        // {
        //     Console.WriteLine(
        //         $"Category: {product.Category}, ProductName: {product.ProductName}, UnitPrice: {product.UnitPrice}");
        // }
        //
        //
        // string[] Arr43 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        // var sortedWordsByLengthAndName = Arr43.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
        // Console.WriteLine("Sorted words by length and name:");
        // foreach (var word in sortedWordsByLengthAndName)
        // {
        //     Console.WriteLine(word);
        // }
        //
        // string[] Arr44 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        // var reversedDigitsWithi = Arr44.Where(d => d[1] == 'i').Reverse();
        // Console.WriteLine("Reversed digits with i:");
        // foreach (var digit in reversedDigitsWithi)
        // {
        //     Console.WriteLine(digit);
        // }

        #endregion

        #region LINQ – Transformation Operators

        var productNames = products.Select(p => p.ProductName);
        Console.WriteLine("Product names:");
        foreach (var productName in productNames)
        {
            Console.WriteLine(productName);
        }

        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
        var upperLowerCaseWords = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
        Console.WriteLine("Upper and lower case words:");
        foreach (var word in upperLowerCaseWords)
        {
            Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
        }

        var productProjections = products.Select(p => new { p.ProductName, Price = p.UnitPrice });
        Console.WriteLine("Product projections:");
        foreach (var productProjection in productProjections)
        {
            Console.WriteLine($"Product Name: {productProjection.ProductName}, Price: {productProjection.Price}");
        }

        int[] Arr51 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var indexMatch = Arr51.Select((n, i) => new { Number = n, Inplace = i == n });
        Console.WriteLine("Index match:");
        foreach (var match in indexMatch)
        {
            Console.WriteLine($"{match.Number}: {match.Inplace}");
        }

        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };
        var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(pair => pair.a < pair.b);
        Console.WriteLine("Pairs:");
        foreach(var pair in pairs)
        {
            Console.WriteLine($"{pair.a} is less than {pair.b}");
        }
        
        var ordersLessThan500 = customers.SelectMany(c => c.Orders).Where(o => o.Total < 500);
        Console.WriteLine("Orders less than 500:");
        foreach (var order in ordersLessThan500)
        {
            Console.WriteLine($"OrderID: {order.OrderID}, Total: {order.Total}");
        }
        
        var ordersLaterThan1998 = customers.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
        Console.WriteLine("Orders later than 1998:");
        foreach (var order in ordersLaterThan1998)
        {
            Console.WriteLine($"OrderID: {order.OrderID}, Order Date: {order.OrderDate.Year}");
        }
        

    #endregion
    }
}
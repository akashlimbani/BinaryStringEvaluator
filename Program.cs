public class Program
{
    public static void Main()
    {
        TestIsGoodBinaryString();
    }

    private static void TestIsGoodBinaryString()
    {
        Console.WriteLine("Running Tests...\n");
        // Test Cases
        var testCases = new (string Input, bool Expected)[]
        {
            ("1100", true),
            ("1010", true),
            ("111000", false),
            ("0011", true),
            ("1001", false),
            ("11110000", false),
            ("", false),
            (null, false),
            ("110011", true),
            ("101010", true),
            ("101001", false)
        };

        foreach (var (input, expected) in testCases)
        {
            bool result = Function.IsGoodBinaryString(input);
            Console.WriteLine($"Input: {input ?? "null"}, Expected: {expected}, Result: {result}");
            Console.WriteLine(result == expected ? "Test Passed" : "Test Failed");
            Console.WriteLine();
        }
    }
}

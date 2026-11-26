using System.Net.Http;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Dia chi API
string apiUrl = args.Length > 0
    ? args[0]
    : "http://localhost:5100";

using var client = new HttpClient
{
    BaseAddress = new Uri(apiUrl)
};

Console.WriteLine("==================================");
Console.WriteLine("HE THONG THU VIEN PHAN TAN");
Console.WriteLine("==================================");

try
{
    Console.WriteLine("Dang ket noi den Library.Api...");

    var response = await client.GetAsync("/api/status");

    Console.WriteLine(
        $"HTTP Status: {(int)response.StatusCode}"
    );

    if (response.IsSuccessStatusCode)
    {
        var content =
            await response.Content.ReadAsStringAsync();

        Console.WriteLine("Ket noi API thanh cong!");
        Console.WriteLine(content);
    }
    else
    {
        Console.WriteLine("Ket noi API khong thanh cong.");
    }
}
catch (HttpRequestException ex)
{
    Console.WriteLine("Khong the ket noi den API.");
    Console.WriteLine(ex.Message);
}
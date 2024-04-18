using Azure.AI.OpenAI;
using Azure;

namespace OpenAIapp.Services;
public class OpenAIService
{
    OpenAIClient client;
    static readonly char[] trimChars = new char[] { '\n', '?' };
    public void Initialize(string openAIKey, string? openAIEndpoint = null)
    {
        client = !string.IsNullOrWhiteSpace(openAIEndpoint)
            ? new OpenAIClient(
                new Uri(openAIEndpoint),
                new AzureKeyCredential(openAIKey))
            : new OpenAIClient(openAIKey);
    }


    internal async Task<string> CallOpenAIChat()
    {
        
        Response<Completions> response = await client.GetCompletionsAsync(
            "samsungstudentchat");
        StringWriter sw = new StringWriter();
        foreach (Choice choice in response.Value.Choices)
        {
            var text = choice.Text.TrimStart(trimChars);
            sw.WriteLine(text);
        }
        var message = sw.ToString();
        return message;
    }

    internal void Initialize(object openAIKey, object openAIEndpoint)
    {
        throw new NotImplementedException();
    }
}

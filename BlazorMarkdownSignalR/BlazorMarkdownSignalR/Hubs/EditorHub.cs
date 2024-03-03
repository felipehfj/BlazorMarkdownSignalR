using Microsoft.AspNetCore.SignalR;

namespace BlazorMarkdownSignalR.Hubs
{
    public class EditorHub : Hub
    {
        public async Task SendMarkdown(string markdown)
        {
            await Clients.All.SendAsync("ReceiveMarkdown", markdown);
        }
    }
}

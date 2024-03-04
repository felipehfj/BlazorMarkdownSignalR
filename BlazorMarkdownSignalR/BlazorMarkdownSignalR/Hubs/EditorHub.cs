using Microsoft.AspNetCore.SignalR;

namespace BlazorMarkdownSignalR.Hubs
{
    public class EditorHub : Hub
    {
        public async Task SendMarkdown(string markdown)
        {
            await Clients.All.SendAsync("ReceiveMarkdown", markdown);
        }

        public async Task SendTextArea(string markdown)
        {
            await Clients.All.SendAsync("ReceiveTextArea", markdown);
        }
    }
}

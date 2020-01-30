using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StatusBot.Commands
{
    public class ImportantCommands : BaseCommandModule
    {
        [Command("status")]
        public async Task Status(CommandContext context, string message)
        {
            if (message.ToLower() == "kitsune")
            {
                await context.Channel.SendMessageAsync("Detected").ConfigureAwait(false);
            }
        }
    }
}

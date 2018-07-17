using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    [Group("DiscordBot")]
    public class BotCommands : ModuleBase<SocketCommandContext>
    {
        [Command("Hello")]
        public async Task HelloCommand()
        {
            await ReplyAsync($"Hello, {Context.User.Mention}!");
        }
    }
}

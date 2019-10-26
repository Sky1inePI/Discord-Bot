using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Gachimuchenik.Modules
{    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("SLAVE")]
        public async Task Ping() {
            await Context.Channel.SendMessageAsync($"{Context.User.Mention} ♂ YES SIR ♂");
        }

        [Command("created")]
        public async Task CreatedAt() {
            await Context.Channel.SendMessageAsync($"{Context.User.CreatedAt}");
        }
    }
}

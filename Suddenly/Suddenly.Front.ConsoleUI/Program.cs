using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Suddenly.Front.ConsoleUI
{
	class Program
    {
		static readonly TelegramBotClient bot = new TelegramBotClient("597165994:AAFdfBb17uwcr74c1L0En5iEz1Wktxd9cVs");

		static void Main(string[] args)
        {
			User me = bot.GetMeAsync().Result;
			Console.Title = me.Username;

			bot.OnMessage += BotOnMessageReceived;

			bot.StartReceiving(Array.Empty<UpdateType>());
			Console.WriteLine($"Start listening for @{me.Username}");

			Console.ReadLine();
			bot.StopReceiving();

			//MainAsync().Wait();
			//Console.ReadKey();
        }

		static async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
		{
			Message message = messageEventArgs.Message;

			if (message == null || message.Type != MessageType.TextMessage) return;

			Console.WriteLine(message.Text);
			await bot.SendTextMessageAsync(message.Chat.Id, $"Echo: {message.Text}");

		}

		static async Task MainAsync()
		{
			var botClient = new TelegramBotClient("597165994:AAFdfBb17uwcr74c1L0En5iEz1Wktxd9cVs");
			var me = await botClient.GetMeAsync();
			var updates = botClient.GetUpdatesAsync();

			Console.WriteLine($"Hello! My name is {me.FirstName}");
		}
    }
}

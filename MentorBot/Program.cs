using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace MentorBot
{
    class Program
    {

        static async Task Main(string[] args)
        {

            var botClient = new TelegramBotClient("6948772174:AAEQJ8u9P_7zqNnaiM1O0ALqe6Vn02eXmvY"); // Присваиваем нашей переменной значение, в параметре передаем Token, полученный от BotFather


            var me = botClient.GetMeAsync().Result;
            await Console.Out.WriteLineAsync($"Телеграм бот {me.FirstName} запущен!");
            botClient.StartReceiving(Update, Error);
            Console.ReadLine();
        }

        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            Console.WriteLine($"An error occurred: {exception.Message}");
            return Task.CompletedTask;
        }

        async static Task Update(ITelegramBotClient bot, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message?.Text != null)
            {
                switch (message.Text)
                {
                    case "/start":
                        var keyboard = new ReplyKeyboardMarkup(new[]
                        {
                    new[] { new KeyboardButton("Как стать C# разработчиком") },
                    new[] { new KeyboardButton("Направления в C# разработке") }
                });

                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "Выберите одну из следующих опций:",
                            replyMarkup: keyboard
                        );
                        break;

                    case "Как стать C# разработчиком":
                        // Здесь вы можете добавить ссылки на учебные ресурсы и наставников.
                        keyboard = new ReplyKeyboardMarkup(new[]
                                  {
                                new[] { new KeyboardButton("Где учиться") },
                                 new[] { new KeyboardButton("Наставник") },
                                  new[] { new KeyboardButton("Назад") }
                            });

                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "Выберите одну из следующих опций:",
                            replyMarkup: keyboard
                        );
                        break;

                    case "Где учиться":
                        var text = "Для этого вам поможеть Школа Iron Programmer:\n\n" +
                       "(https://ironprogrammer.ru/program)\n";

                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;

                    case "Наставник":
                        text = "Контакт для связа с Наставником:\n\n" +
                        "(https://ironprogrammer.ru/#contact)\n";

                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;

                    case "Направления в C# разработке":
                        // Здесь вы можете добавить описание пяти направлений в C# разработке.
                        keyboard = new ReplyKeyboardMarkup(new[]
                                    {
                                  new[] { new KeyboardButton("Разработка веб-приложений и веб-сервисов") },
                                  new[] { new KeyboardButton("Разработка настольных приложений") },
                                  new[] { new KeyboardButton("Разработка облачных сервисов") },
                                  new[] { new KeyboardButton("Разработка игр") },
                                  new[] { new KeyboardButton("Разработка мобильных приложений") },
                                  new[] { new KeyboardButton("Назад") }
                            });

                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "Выберите одно из следующих направлений в C# разработке :",
                            replyMarkup: keyboard
                        );
                        break;
                    case "Разработка веб-приложений и веб-сервисов":
                        text = "С# часто используется для разработки веб-приложений и веб-сервисов. Для этого могут применяться различные фреймворки, такие как ASP.NET и ASP.NET Core. С# обладает широкими возможностями для работы с HTTP-запросами, реализации бизнес-логики на сервере, а также взаимодействия с базами данных..";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;
                    case "Разработка настольных приложений":
                        text = "Настольные приложения также могут быть разработаны с использованием С#. Для создания таких приложений можно использовать Windows Forms или WPF. С помощью С# можно создавать графические интерфейсы, обрабатывать пользовательский ввод, работать с файловой системой, и многое другое.";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;
                    case "Разработка облачных сервисов":
                        text = "Разработка облачных сервисов с помощью С# также вполне возможна. Для этого можно использовать платформу Azure и инструменты, предоставляемые Microsoft. С помощью C# можно создавать облачные приложения, реализовывать масштабируемые решения, работать с базами данных в облаке, и многое другое.";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;
                    case "Разработка игр":
                        text = "С# также может использоваться для разработки игр. С помощью фреймворков и библиотек, таких как Unity3D, можно создавать разнообразные игры для различных платформ. С# обладает хорошей производительностью и оснащен инструментами для работы с графикой, аудио и управлением игровым процессом.";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;
                    case "Разработка мобильных приложений":
                        text = "Мобильные приложения также могут быть разработаны на C#. Для этого можно использовать фреймворки Xamarin или Xamarin.Forms, которые позволяют создавать кросс-платформенные приложения под iOS и Android. С помощью C# можно создавать пользовательские интерфейсы, работать с устройственными функциями (камера, GPS, сеть), и многое другое.";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;
                    case "Назад":
                        keyboard = new ReplyKeyboardMarkup(new[]
                        {
                new[] { new KeyboardButton("Как стать C# разработчиком") },
                new[] { new KeyboardButton("Направления в C# разработке") }
            });
                        await bot.SendTextMessageAsync(
                           chatId: message.Chat.Id,
                           text: "Выберите одну из следующих опций:",
                           replyMarkup: keyboard
                       );
                        break;
                    //Диалог
                    case "Привет":
                        text = "Привет ";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;

                    case "Здраствуйте":
                        text = "Здраствуйте ";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;

                    case "Как дела":
                        text = "Спасибо хорошо! как у вас?";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;

                    case "Как у вас дела":
                        text = "Спасибо хорошо! как у вас?";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;

                    case "Как тебя зовут":
                        text = "Меня зовут Мурад! а как вас зовут?";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;

                    case "Кто тебя создал":
                        text = "Я робот мне создали С# разработчики";
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: text,
                            parseMode: ParseMode.Markdown
                        );
                        break;

                    default:
                        await bot.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "Извините, я не понимаю эту команду. Пожалуйста, выберите одну из предложенных опций"
                        );
                        break;
                }
            }

        }


    }
}




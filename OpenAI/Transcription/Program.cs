using Newtonsoft.Json;
using OpenAI_API.Chat;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using OpenAI_API.Moderation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OpenAI_Examples
{
    public class Transcription
    {
        public static async Task Main()
        {
            OpenAI_API.APIAuthentication.Default = new OpenAI_API.APIAuthentication("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");

            var api = new OpenAI_API.OpenAIAPI();

            string result = await api.Transcriptions.GetTextAsync("english-test.m4a", "en");
            Console.WriteLine(result);
        }
    }
}

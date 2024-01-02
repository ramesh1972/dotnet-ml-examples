﻿using Azure.AI.OpenAI;

OpenAIClient client = new OpenAIClient("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");

string deploymentOrModelName = "gpt-3.5-turbo";

var requestOptions = new ChatCompletionsOptions()
{
    DeploymentName = deploymentOrModelName,
    Messages =
                {
                    new ChatRequestSystemMessage("You are a helpful assistant."),
                    new ChatRequestUserMessage("Can you help me?"),
                    new ChatRequestAssistantMessage("Of course! What do you need help with?"),
                    new ChatRequestUserMessage("What temperature should I bake pizza at?"),
                },
};

ChatCompletions response =  client.GetChatCompletions(requestOptions);
ChatChoice choice = response.Choices[0];
Console.WriteLine(choice.Message.Content);

requestOptions = new ChatCompletionsOptions()
{
    DeploymentName = deploymentOrModelName,
    Messages =
                {
                    new ChatRequestSystemMessage("You are a helpful assistant."),
                    new ChatRequestUserMessage("Can you help me?"),
                    new ChatRequestAssistantMessage("Of course! What do you need help with?"),
                    new ChatRequestUserMessage("What temperature should I bake pizza at?"),
                    new ChatRequestUserMessage(choice.Message.Content),
                    new ChatRequestUserMessage("give the tempearature in degree celsius")
                },
};

response =  client.GetChatCompletions(requestOptions);
choice = response.Choices[0];
Console.WriteLine(choice.Message.Content);

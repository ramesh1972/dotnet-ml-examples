using Azure.AI.OpenAI;
using OpenAI_API.Models;

OpenAIClient client = new OpenAIClient("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");

string deploymentOrModelName = "gpt-3.5-turbo";

List<Model> models = client.GetModels();
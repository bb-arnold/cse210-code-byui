using System;

class PromptGenerator
{
    public string GeneratePrompt(List<string> prompts)
    {
        int _randomIndex = Random.Shared.Next(prompts.Count);
        return prompts[_randomIndex];
    }
}

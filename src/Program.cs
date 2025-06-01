using System;
using System.Threading.Tasks;

namespace Aspenlaub.Net.GitHub.CSharp.PakledConsumer;

#pragma warning disable IDE0210

internal class Program {
    private static async Task Main() {
        await StoryWriter.WriteAStoryAsync(Console.WriteLine);
        Console.ReadLine();
    }
}
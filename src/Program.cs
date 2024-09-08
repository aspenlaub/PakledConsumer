using System;
using System.Threading.Tasks;

namespace Aspenlaub.Net.GitHub.CSharp.PakledConsumer;

internal class Program {
    private static async Task Main() {
        await StoryWriter.WriteAStoryAsync(Console.WriteLine);
        Console.ReadLine();
    }
}
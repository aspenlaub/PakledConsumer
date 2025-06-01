using Aspenlaub.Net.GitHub.CSharp.Pakled;
using Autofac;
using System;
using System.Threading.Tasks;

namespace Aspenlaub.Net.GitHub.CSharp.PakledConsumer;

public class StoryWriter {
    public static async Task WriteAStoryAsync(Action<string> writeLine) {
        IContainer container = (await new ContainerBuilder().UsePakledAsync()).Build();
        var thing = new Thing { State = ThingState.Broken };
        writeLine($"Grebnedlog's log, star date 42723.8: we have a {thing.GetType().Name} that is {Enum.GetName(typeof(ThingState), thing.State)}");
        IGoMaker goMaker = container.Resolve<IGoMaker>();
        writeLine($"Asking the {goMaker.GetType().Name} to make it go");
        goMaker.MakeItGo(thing);
        writeLine($"The {thing.GetType().Name} is now {Enum.GetName(typeof(ThingState), thing.State)}");
    }
}
using System;
using Aspenlaub.Net.GitHub.CSharp.PakledCore;

namespace Aspenlaub.Net.GitHub.CSharp.PakledConsumerCore {
    internal class Program {
        private static void Main() {
            Console.WriteLine("A small story from the star trek universe:");
            var thing = new Thing {State = ThingState.Broken};
            Console.WriteLine($"Grebnedlog's log, star date 42723.8: we have a {thing.GetType().Name} that is {Enum.GetName(typeof(ThingState), thing.State)}");
            var goMaker = new GoMaker();
            Console.WriteLine($"Asking the {goMaker.GetType().Name} to make it go");
            goMaker.MakeItGo(thing);
            Console.WriteLine($"The {thing.GetType().Name} is now {Enum.GetName(typeof(ThingState), thing.State)}");
            Console.ReadLine();
        }
    }
}

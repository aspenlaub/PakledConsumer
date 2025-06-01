using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspenlaub.Net.GitHub.CSharp.PakledConsumer.Test;

[TestClass]
public class StoryWriterTest {
    [TestMethod]
    public async Task CanWriteAStory() {
        var story = new List<string>();
        await StoryWriter.WriteAStoryAsync(story.Add);
        Assert.AreEqual(3, story.Count);
    }
}
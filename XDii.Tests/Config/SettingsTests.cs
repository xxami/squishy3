using System.IO;
using System.IO.Abstractions;
using System.Text;
using FakeItEasy;
using Ribbon.MarkdownTests.Xunit;
using XDii.Config.Reader;

namespace XDii.Tests.Config
{
    using Shouldly;
    using Xunit;
    using global::XDii.Config;

    public class SettingsTests
    {
        [Theory]
        [MarkdownFileData("TestData/Config/settings.yaml.md", "Minimal")]
        public void ReadsBasicSettings(string fileData)
        {
            var fs = A.Fake<IFileSystem>();
            A.CallTo(() => fs.File.OpenRead("settings.yaml"))
                .Returns(new MemoryStream(Encoding.UTF8.GetBytes(fileData)));

            var reader = new ConfigReader(fs);
            var settings = new Settings(reader);

            settings.ProfileName.ShouldBe("test");
            settings.Resolution.X.ShouldBe(1280);
            settings.Resolution.Y.ShouldBe(720);
        }
    }
}
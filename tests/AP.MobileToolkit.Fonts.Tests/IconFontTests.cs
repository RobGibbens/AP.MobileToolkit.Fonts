﻿using System.Linq;
using AP.MobileToolkit.Fonts.Tests.Mocks;
using Xunit;
using Xunit.Abstractions;

namespace AP.MobileToolkit.Fonts.Tests
{
    public class IconFontTests : TestBase
    {
        public IconFontTests(ITestOutputHelper testOutputHelper)
            : base(testOutputHelper)
        {
        }

        [Fact]
        public void IconClassReturnsRegisteredIcons()
        {
            var iconFont = new EmbeddedMappedFont("Test.otf", "test", typeof(MockFontA));

            Assert.NotNull(iconFont._mappings);
            Assert.Equal(2, iconFont._mappings.Count());
        }

        [Theory]
        [InlineData("test-foo", MockFontAMapping.Foo)]
        [InlineData("test-Foo", MockFontAMapping.Foo)]
        [InlineData("test-FooBar", MockFontAMapping.FooBar)]
        [InlineData("test-foobar", MockFontAMapping.FooBar)]
        [InlineData("test-Foo-Bar", MockFontAMapping.FooBar)]
        [InlineData("test-foo-bar", MockFontAMapping.FooBar)]
        [InlineData("test foo", MockFontAMapping.Foo)]
        [InlineData("test Foo", MockFontAMapping.Foo)]
        [InlineData("test FooBar", MockFontAMapping.FooBar)]
        [InlineData("test foobar", MockFontAMapping.FooBar)]
        [InlineData("test Foo-Bar", MockFontAMapping.FooBar)]
        [InlineData("test foo-bar", MockFontAMapping.FooBar)]
        public void LocatesIconWithKey(string key, string expectedGlyph)
        {
            var iconFont = new EmbeddedMappedFont("Test.otf", "test", typeof(MockFontAMapping));

            var glyph = iconFont.GetGlyph(key);

            Assert.False(string.IsNullOrWhiteSpace(glyph));

            Assert.Equal(expectedGlyph, glyph);
        }
    }
}

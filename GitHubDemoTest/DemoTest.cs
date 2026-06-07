using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GitHubDemoTest
{
    public class DemoTests
    {
        [Fact]
        public void SumaCorrecta()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Fact]
        public void TextoCorrecto()
        {
            Assert.Equal("Hola Mundo", "Hola Mundo");
        }
    }
}

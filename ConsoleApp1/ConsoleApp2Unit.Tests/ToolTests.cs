using Xunit;
using ConsoleApp2;

namespace ConsoleApp2.Unit.tests;

    public class ToolTests
    {
        [Fact]
        public void ToolStoreData()
        {
            var myTool = new Tool { Brand = "Versace", Name = "Golden Hammer" };
            string actualBrand = myTool.Brand;
            string actualName = myTool.Name;
            Assert.Equal("Versace", actualBrand);
            Assert.Equal("Golden Hammer", actualName);
            
        }
    }



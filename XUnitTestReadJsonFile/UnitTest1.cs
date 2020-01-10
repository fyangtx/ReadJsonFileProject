using System;
using System.Collections.Generic;
using System.IO;
using Moq;
using Newtonsoft.Json;
using ReadJsonFile;
using Xunit;

namespace XUnitTestReadJsonFile
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 46)]
        [InlineData(1, 0)]
        [InlineData(2, 248)]
        public void LabelSumIsExpected(int index, int expected)
        {
            //arrange
            var myJsonString = File.ReadAllText("UTIMCO.JSON");
            var mockList = JsonConvert.DeserializeObject<MenuList[]>(myJsonString);
            JsonData sut = new JsonData(mockList);

            //act
            int actual = sut.LabelSum(sut.Menus[index].Menu);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}

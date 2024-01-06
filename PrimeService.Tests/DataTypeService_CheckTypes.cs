using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class DataTypeService_CheckTypes
    {
        private DataTypeService _dataTypeService;

        [SetUp]
        public void SetUp()
        {
            _dataTypeService = new DataTypeService();
        }

        [Test]
        public void CheckTypes()
        {
            var array = new int[] { 1, 2, 3 };

            var obj = new Object;

            var nan = double.NaN;
        }
    }
}

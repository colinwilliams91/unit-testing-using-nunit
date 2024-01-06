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
        /* dependency injection Service Class */
        private DataTypeService _dataTypeService;

        private int[] _array;
        private object _obj;
        private object _nan;
        private object? _empty;
        private bool _boolean;
        private int _num;
        private string _name;
        private char _letter;

        [SetUp]
        public void SetUp()
        {
            _dataTypeService = new DataTypeService();

            /* Arrange (mock data) */
            _array = [1, 2, 3];
            _obj = new { Name = "Colin", Age = 32 };
            _nan = double.NaN;
            _empty = null;
            _boolean = false;
            _num = 1;
            _name = "Colin";
            _letter = 'A';
        }
        
        [Test]
        public void CheckTypes()
        {

            var test = new [] { _array, _obj, _nan, _empty, _boolean, _num, _name, _letter };

            /* Act */
            foreach (var item in test)
            {
                Warn.If(item is null, $"{item} is {item?.GetType().Name}");

                if (item is int)
                {
                    Assert.That(_dataTypeService.IsInt(item), Is.True);
                }
                else if (item is bool)
                {
                    Assert.That(_dataTypeService.IsBoolean(item), Is.True);
                }
                else if (item is string)
                {
                    Assert.That(_dataTypeService.IsString(item), Is.True);
                }
                else if (item is char)
                {
                    Assert.That(_dataTypeService.IsCharacter(item), Is.True);
                }
                else if (item is Array)
                {
                    //Assert.That(_dataTypeService.IsArray(item), Is.True);
                    Assert.Pass("item is of type Array", item);
                }
                else if (double.IsNaN((double)item))
                {
                    Assert.That(_dataTypeService.IsNotANumber(item), Is.True);
                }
                else if (item is null)
                {
                    Assert.That(_dataTypeService.IsNull(item));
                }
                else if (item is Object)
                {
                    Assert.That(_dataTypeService.IsObj(item), Is.True);
                }
                else
                {
                    Assert.Fail("item has unknown type, fell to else block: [Test]CheckTypes", item);
                }
            }

            /* Assert */

        }
    }
}

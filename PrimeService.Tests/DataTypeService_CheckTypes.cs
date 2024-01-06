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

        /* Act */
        #region Integers
        [Test]
        public void IsInt_NotInt_ReturnFalse()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_dataTypeService.IsInt(_boolean), Is.False);
                Assert.That(_dataTypeService.IsInt(_name), Is.False);
                Assert.That(_dataTypeService.IsInt(_letter), Is.False);
            });
        }

        public void IsInt_Nullish_ReturnFalse()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_dataTypeService.IsInt(_nan), Is.False);
                Assert.That(_dataTypeService.IsInt(_empty), Is.False);
            });
        }

        public void IsInt_Int_ReturnTrue()
        {
            Assert.That(_dataTypeService.IsInt(_num), Is.True);
        }
        #endregion

        #region Booleans

        #endregion

        #region Strings

        #endregion

        #region Characters

        #endregion

        /* Complex Data Types */
        #region Arrays

        #endregion

        #region Anonymous Objects

        #endregion

        #region Not a Number

        #endregion

        #region Null Reference

        #endregion

        /* Assert */

    }
}


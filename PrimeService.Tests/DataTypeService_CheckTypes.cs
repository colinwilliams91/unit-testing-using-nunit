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

        [TestCase()]

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


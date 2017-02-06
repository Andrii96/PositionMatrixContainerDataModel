﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionMatrixContainerDataModel.Models.Models
{
    public abstract class NumericType<T>
    {
        #region Constructor
        protected NumericType()
        {
            //TODO Create custom exception and throw it if the type is not numeric
            if (!IsNumericType(typeof(T)))
            {
                
            }
        }
        #endregion

        #region Helpers

        private static bool IsNumericType(Type type)
        {
            return Type.GetTypeCode(type) == TypeCode.Byte || Type.GetTypeCode(type) == TypeCode.Decimal ||
                   Type.GetTypeCode(type) == TypeCode.Double || Type.GetTypeCode(type) == TypeCode.Int16 ||
                   Type.GetTypeCode(type) == TypeCode.Int32 || Type.GetTypeCode(type) == TypeCode.Int64 ||
                   Type.GetTypeCode(type) == TypeCode.SByte || Type.GetTypeCode(type) == TypeCode.Single ||
                   Type.GetTypeCode(type) == TypeCode.UInt16 || Type.GetTypeCode(type) == TypeCode.UInt32 ||
                   Type.GetTypeCode(type) == TypeCode.UInt64;
        }


        #endregion
    }
}
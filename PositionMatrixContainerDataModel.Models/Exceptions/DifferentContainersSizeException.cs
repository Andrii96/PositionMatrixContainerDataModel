﻿using System;
using System.Runtime.Serialization;

namespace PositionMatrixContainer.Models.Exceptions
{
    [Serializable]
    public class DifferentContainersSizeException:ApplicationException
    {
        #region Properties
        public int ContainerSize { get; set; }
        #endregion
        #region Constructor

        public DifferentContainersSizeException() : base() { }

        public DifferentContainersSizeException(string message) : base(message) { }

        public DifferentContainersSizeException(string message, Exception innerException):base(message,innerException) { }

        public DifferentContainersSizeException(int size):this(string.Format("Each container should have equal number of matrices - {0}", size))
        {
            ContainerSize = size;
        }

        protected DifferentContainersSizeException(SerializationInfo info,StreamingContext context) : base(info, context) { }
        #endregion
    }
}

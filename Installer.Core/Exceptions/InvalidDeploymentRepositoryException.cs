﻿using System;

namespace Installer.Core.Exceptions
{
    public class InvalidDeploymentRepositoryException : Exception
    {
        public InvalidDeploymentRepositoryException(string str) : base(str)
        {            
        }

        public InvalidDeploymentRepositoryException(string str, Exception inner) : base(str, inner)
        {            
        }
    }
}
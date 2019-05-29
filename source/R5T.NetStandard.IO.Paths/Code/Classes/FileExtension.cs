﻿using System;


namespace R5T.NetStandard.IO.Paths
{
    /// <summary>
    /// The file extension part of a file name.
    /// </summary>
    public class FileExtension : FileNameSegment
    {
        public FileExtension(string value)
            : base(value)
        {
        }
    }
}

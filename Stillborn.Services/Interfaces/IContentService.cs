﻿using Stillborn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stillborn.Services.Interfaces
{
    public interface IContentService
    {
        MediaType GenerateMediaType(int typeId);
        Media GenerateMedia(byte[] Bytes,int typeId);
        Content GenerateContent();
        void AddMediaInContent(int mediaId,int contentId);
    }
}
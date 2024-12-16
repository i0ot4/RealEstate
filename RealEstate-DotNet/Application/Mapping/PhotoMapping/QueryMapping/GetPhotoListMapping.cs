﻿using Application.Features.Photos.Queries.Result;
using Domain.Entities;

namespace Application.Mapping.PhotoMapping
{
    public partial class PhotoProfile
    {
        public void GetPhotoListMapping()
        {
            CreateMap<Photo, GetPhotoListResponse>();
        }
    }
}

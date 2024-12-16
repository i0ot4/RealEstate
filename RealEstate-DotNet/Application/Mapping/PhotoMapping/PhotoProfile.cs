using AutoMapper;

namespace Application.Mapping.PhotoMapping
{
    public partial class PhotoProfile : Profile
    {
        public PhotoProfile()
        {
            CreatePhotoMapping();
            CreatePhotosListMapping();

            GetPhotoListMapping();
            GetPhotoListByApartmentMapping();
        }
    }
}

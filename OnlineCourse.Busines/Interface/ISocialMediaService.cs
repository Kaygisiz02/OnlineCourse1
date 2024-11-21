namespace OnlineCourse.Busines
{
    public interface ISocialMediaService
    {
        SocialMediaDto GetSocialMediaById(int id);
        IEnumerable<SocialMediaDto> GetAllSocialMedia();
        bool AddSocialMedia(SocialMediaDto socialMediaDto);
        bool UpdateSocialMedia(SocialMediaDto socialMediaDto);
        bool DeleteMessage(int id);
    }
}

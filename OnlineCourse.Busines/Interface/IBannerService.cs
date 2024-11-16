namespace OnlineCourse.Busines
{
    public interface IBannerService
    {
        BannerDto GetBannerById(int id);
        List<BannerDto> GetAllBanners();
        bool AddBanner(BannerDto aboutDto);
        bool UpdateBanner(BannerDto bannerDto);
        bool DeleteBanner(int id);

    }
}

namespace OnlineCourse.Busines
{
    public interface IBannerService
    {
        BannerDto GetBannerById(int id);
        List<BannerDto> GetAllBanners();
        bool AddBanner(BannerDto bannerDto);
        bool UpdateBanner(BannerDto bannerDto);
        bool DeleteBanner(int id);

    }
}

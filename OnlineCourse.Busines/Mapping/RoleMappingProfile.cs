namespace OnlineCourse.Busines.Mapping
{
    public class RoleMappingProfile:Profile
    {
        public RoleMappingProfile()
        {
            CreateMap<RoleDto,AppRole>().ReverseMap();
        }
    } 
}

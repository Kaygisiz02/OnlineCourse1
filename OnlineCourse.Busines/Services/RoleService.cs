using Microsoft.EntityFrameworkCore;
using OnlineCourse.Busines.Interface;
namespace OnlineCourse.Busines
{
    public class RoleService(RoleManager<AppRole> _roleManager,IMapper _mapper) : IRoleService
    {
        public async Task CreateRoleAsync(RoleDto roleDto)
        {
            var role=_mapper.Map<AppRole>(roleDto);
            var result=await _roleManager.CreateAsync(role);
        }

        public async Task DeleteRoleAsync(int id)
        { 
            var value = await _roleManager.Roles.FirstOrDefaultAsync(x=>x.Id==id);
            await _roleManager.DeleteAsync(value);
        }

        public async Task<RoleDto> GetRoleByIdAsync(int id)
        {
           var values= await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<RoleDto>(values);
        }

        public async Task<List<RoleDto>> GetAllRolesAsync()
        {
            var values= await _roleManager.Roles.ToListAsync();
            return _mapper.Map<List<RoleDto>>(values);
        }
    }
}

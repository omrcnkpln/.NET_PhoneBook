using Contact.Core.Models;
using Contact.Core.Requests;
using Contact.Repository.Abstract;
using Contact.Service.Abstract;

namespace Contact.Service.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<User>> GetAllAsync()
        {
            try
            {
                return await _unitOfWork.User.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> AddAsync(UserRequest userRequest)
        {
            try
            {
                var addEntity = await _unitOfWork.User.AddAsync(new User
                {
                    Name = userRequest.Name,
                    Surname = userRequest.Surname,
                    Company = userRequest.Company,
                });

                await _unitOfWork.SaveChanges();

                if(addEntity != null)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public async Task<User> GetAsync(int userId)
        //{
        //    try
        //    {
        //        Log.Information("Get Mattress From Service");
        //        var mattress = await _unitOfWork.Mattress.GetAllWithThenInclude()
        //            //.Include(x => x.Mattress_Sizes)
        //            .Include(x => x.SelectedVariations)
        //            .Include(x => x.Customer)
        //            .Include(x => x.MattressTypeVersion).ThenInclude(x => x.Components)
        //            .Include(x => x.MattressTypeVersion).ThenInclude(x => x.MattressType)
        //            .Include(m => m.Component_RawMaterials).ThenInclude(cr => cr.Component)
        //            .Include(m => m.Component_RawMaterials).ThenInclude(cr => cr.RawMaterial).ThenInclude(r => r.RawCategory)
        //            .Include(m => m.Company)
        //            .FirstOrDefaultAsync(x => x.Id == mattressId);

        //    }
        //    catch (Exception ex)
        //    {
        //        return StaticResult<MattressTypeResponseDtoRawsInComponents>.Fail(ex.Message);
        //    }
        //}
    }
}

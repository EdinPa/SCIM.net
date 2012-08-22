using System;
using System.Collections.Generic;
using System.Linq;
using EnjoyDialogs.SCIM.Models;

namespace EnjoyDialogs.SCIM.Services
{
    public interface IUserService
    {
        void Update(UserModel updatedUser);

        UserModel Get(Guid id);

        IQueryable<UserModel> GetAll();

        void Post(UserModel user);

        UserModel Delete(Guid id); 

    }

    public class InMemoryUserService : IUserService
    {
        private readonly List<UserModel> _repository;

        public InMemoryUserService()
        {
            _repository = new List<UserModel>();
        }

        public void Update(UserModel updatedUser)
        {
            var existing = Get(updatedUser.Id);
            if (existing != null)
            {
                existing.DisplayName = updatedUser.DisplayName;
                existing.UserName = updatedUser.UserName;
                existing.ExternalId = updatedUser.ExternalId;
                existing.Name = updatedUser.Name;
                existing.DisplayName = updatedUser.DisplayName;
                existing.NickName = updatedUser.NickName;
                existing.ProfileUrl = updatedUser.ProfileUrl;
                existing.Emails = updatedUser.Emails;
                existing.Addresses = updatedUser.Addresses;
                existing.PhoneNumbers = updatedUser.PhoneNumbers;
                existing.Ims = updatedUser.Ims;
                existing.Photos = updatedUser.Photos;
                existing.UserType = updatedUser.UserType;
                existing.Title = updatedUser.Title;
                existing.PreferredLanguage = updatedUser.PreferredLanguage;
                existing.Locale = updatedUser.Locale;
                existing.Timezonoe = updatedUser.Timezonoe;
                existing.Active = updatedUser.Active;
                existing.Password = updatedUser.Password;
                existing.Groups = updatedUser.Groups;
                existing.X509Certificates = updatedUser.X509Certificates;
                existing.Meta = updatedUser.Meta;
            }
        }

        public UserModel Get(Guid id)
        {
            return _repository.Find(x => x.Id == id);
        }

        public IQueryable<UserModel> GetAll()
        {
            return _repository.AsQueryable();
        }

        public void Post(UserModel user)
        {
            _repository.Add(user);
        }

        public UserModel Delete(Guid id)
        {
            var existing = Get(id);
            if (existing == null)
            {
                return null;
            }
            _repository.Remove(existing);

            return existing;
        }
    }

    public class UserService : IUserService
    {
        public void Update(UserModel updatedUser)
        {
            throw new NotImplementedException();
        }

        public UserModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Post(UserModel user)
        {
            throw new NotImplementedException();
        }

        public UserModel Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
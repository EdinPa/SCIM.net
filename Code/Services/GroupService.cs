using System;
using System.Collections.Generic;
using System.Linq;
using EnjoyDialogs.SCIM.Models;

namespace EnjoyDialogs.SCIM.Services
{
    public interface IGroupService
    {
        void Update(GroupModel updatedGroup);

        GroupModel Get(Guid id);

        IQueryable<GroupModel> GetAll();

        void Post(GroupModel group);

        GroupModel Delete(Guid id); 
    }

    public class InMemoryGroupService : IGroupService
    {
        private readonly List<GroupModel> _repository; 
        public InMemoryGroupService()
        {
            _repository = new List<GroupModel>();
        }

        public void Update(GroupModel updatedGroup)
        {
            var existing = Get(updatedGroup.Id);
            if (existing != null)
            {
                existing.DisplayName = updatedGroup.DisplayName;
                existing.Members = updatedGroup.Members;
            }
        }

        public GroupModel Get(Guid id)
        {
            return _repository.Find(x => x.Id == id);
        }

        public IQueryable<GroupModel> GetAll()
        {
            return _repository.AsQueryable();
        }

        public void Post(GroupModel @group)
        {
            _repository.Add(group);
        }

        public GroupModel Delete(Guid id)
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

    public class GroupService : IGroupService
    {
        public void Update(GroupModel updatedGroup)
        {
            throw new NotImplementedException();
        }

        public GroupModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<GroupModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Post(GroupModel @group)
        {
            throw new NotImplementedException();
        }

        public GroupModel Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
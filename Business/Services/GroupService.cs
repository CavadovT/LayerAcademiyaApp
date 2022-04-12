﻿using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class GroupService : IGroup
    {
        public static int Count { get; set; }
        private GroupRepository _groupRepository; 
        public GroupRepository GroupRepository 
        { 
            get 
            {
                return _groupRepository;
            }
            set
            {
                _groupRepository = value;
            }
        }

        public GroupService()
        {
            
            _groupRepository=new GroupRepository();

        }
        public Group Create(Group group)
        {
            group.Id = Count;
            _groupRepository.Create(group);
            return group;
            
        }

        public Group Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Group GetGroup(string name)
        {
            throw new NotImplementedException();
        }

        public Group Update(int id, Group group)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll()
        {
          return _groupRepository.GetAll();
        }
    }
}

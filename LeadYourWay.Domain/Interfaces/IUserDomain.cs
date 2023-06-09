﻿using LeadYourWay.Infrastructure.Models;

namespace LeadYourWay.Domain;

public interface IUserDomain
{
    Task<List<User>> GetAllAsync();
    User GetById(int id);
    public int Login(User user);
    public bool save(User value);
    public bool update(int id, UserUpdateModel value);
    public bool delete(int id);
}
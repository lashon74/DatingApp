using System;
using API.Entities;

namespace API.Interfaces;
//using this interface to inject into controller later on as a service to create tokens 
public interface ITokenService
{
  string CreateToken(AppUser user);
}

using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.Exceptions;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.Repositories.MainRepository;
using BakeryShoppingCart.Repository;


namespace BakeryShoppingCart.Repositories.Implementation
{
    public class UserRespository : IMainRepository<User>, MainRepository.MainRepository
    {
        private IEnumerable<object> currentDatabase;

        public UserRespository()
        {
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void GetAllUsersByName(string name)
        {
            Console.WriteLine("I am looking for a user with " +
                       "the name: " + name);
            
        }

       public void GetAllComments(string comment)
        {
            Console.WriteLine("I am looking for the " +
                "the comment: " + comment);
        }

        public void Save(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        string MainRepository.MainRepository.GetAllUsersByName(string name)
        {
            throw new NotImplementedException();
        }

        internal void GetAllComments(List<Comment> commentList)
        {
            throw new NotImplementedException();
        }

        internal void GetAllUsersByName(object userName)
        {
            throw new NotImplementedException();
        }

        string IMainRepository<User>.GetAllUsersByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        string IMainRepository<T>.GetAllUsersByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
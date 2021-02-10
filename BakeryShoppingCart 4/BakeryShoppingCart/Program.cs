using System;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.Exceptions;
using BakeryShoppingCart.Repositories.Implementation;
using System.Collections.Generic;

namespace BakeryShoppingCart
{
    class Program
    {
        public static string UserName { get; private set; }

        static void Main()
        {
            try
            {
                ShoppingCart myShoppingCart = new ShoppingCart();

                myShoppingCart.ExecuteMainMenu();
            }
            catch (ShoppingCartException exception)
            {
                Console.WriteLine(exception.Message);
            }
            string response = "";
            while (response!= "5")
            {
                List<User> userList = new List<User>();
                List<Comment> commentList = new List<Comment>();
                UserRespository userRepo = new UserRespository();
                UserRespository userComment = new UserRespository();

                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Print List of Users");
                Console.WriteLine("4. Print List of Comments");
                Console.WriteLine("5. Look for a User");
                Console.WriteLine("6. Look for a Comment");
                Console.WriteLine("7. Create a Data File");

                Console.WriteLine("8. Exit the Program");

                Console.WriteLine("");
                Console.WriteLine("Please select an option: ");
                Console.ReadLine();

                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        User user = new User();
                        user.UserName = "Luis";

                        User user2 = new User();
                        user2.UserName = "Myra";
                        userList.Add(user2);

                        User user3 = new User();
                        user3.UserName = "Roman";

                        Console.WriteLine("You have created a user");
                        break;

                    case "2":
                        Comment hisComment = new Comment();
                        hisComment.TheBestComment = "The best is yet to Come!";
                        commentList.Add(hisComment);
                        Console.WriteLine("You have created a comment");
                        break;

                    case "3":
                        Console.WriteLine("This is the list you wanted: ");
                        foreach (var insideUser in userList)
                        {
                            Console.WriteLine(insideUser.UserId);
                            Console.WriteLine(insideUser.UserName);
                        }
                        break;

                    case "4":
                        Console.WriteLine("This is the list you wanted: ");
                        foreach (var insideComment in commentList)
                        {
                            Console.WriteLine(insideComment.CommentId);
                            Console.WriteLine(insideComment.TheBestComment);
                        }
                        break;

                    case "5":
                        userRepo.GetAllUsersByName(UserName);
                        break;

                    case "6":
                        userComment.GetAllComments(commentList);
                        break;




                }
            }
        }
    }
}

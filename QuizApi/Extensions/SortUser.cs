using QuizData;
using System.Linq;

namespace QuizApi.Extensions
{
    public static class Extensions
    {
        public static IQueryable<UserData> sortUser(this IQueryable<UserData> user, string sort)
        {
            switch (sort)
            {
                case "FirstName":
                    return user.OrderBy(u => u.FirstName);
                case "LastName":
                    return user.OrderBy(u => u.LastName);
                case "Email":
                    return user.OrderBy(u => u.Email);
                case "DOB":
                    return user.OrderBy(u => u.DateOfBirth);
                case "Salary":
                    return user.OrderBy(u => u.Salary);
                case "ID":
                    return user.OrderBy(u => u.Id);
                default:
                    return user.OrderBy(u => u.Id);
            }
        }
    }
}

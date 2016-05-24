using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizzy
{
    class User
    {
        private string lastName;
        private string firstName;
        private string email;
        private string password;
        private string socialMedia;
        private string pathBodypic;
        private string pathPicture;
        private string shirtSize;
        private bool gender;
        private int age;
        private int id;
        private int pentSize;
        private int shoeSize;
        private double height;
        private double weight;
        private Category clothesCategory;
        private Dressing dressing;

        public User()
        {

        }

        public User(string LastName, string FirstName, string Email, string Password, string SocialMedia, string PathBodypic,
                    string PathPicture, string ShirtSize, bool Gender, int Age, int Id, int PentSize, int ShoeSize, double Height,
                    double Weight, Category ClothesCategory, Dressing Dressing)
        {
            this.lastName = LastName;
            this.firstName = FirstName;
            this.email = Email;
            this.password = Password;
            this.socialMedia = SocialMedia;
            this.pathBodypic = PathBodypic;
            this.pathPicture = PathPicture;
            this.shirtSize = ShirtSize;
            this.gender = Gender;
            this.age = Age;
            this.id = Id;
            this.pentSize = PentSize;
            this.shoeSize = ShoeSize;
            this.height = Height;
            this.weight = Weight;
            this.clothesCategory = ClothesCategory;
            this.dressing = Dressing;




        }
    

    }
}

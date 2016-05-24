using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizzy.Models
{
    class Man : User
    {
        #region Attributes

        private int shoulderSize;

        #endregion

        #region Constructor

        public Man (int ShoulderSize, string LastName, string FirstName, string Email,string Password, List<SocialMedia> SocialMediaEl, 
                    string PathBodypic, string PathPicture, string ShirtSize, bool Gender,int Age, int Id, int PantSize, int ShoeSize, 
                    double Height, double Weight, List<Category> ClothesCategory, List<Dressing> DressingList)
                    : base(LastName, FirstName, Email, Password, SocialMediaEl, PathBodypic, PathPicture, ShirtSize, Gender, Age, Id, PantSize,
                          ShoeSize, Height, Weight)
        {
            this.shoulderSize = ShoulderSize;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizzy.Models
{
    class Woman : User
    {
        #region Attributes

        private int braSize;
        private char cupSize;
        private int hipSize;
        private int waistSize;

        #endregion

        #region Constructor

        public Woman (int BraSize, char CupSize, int HipSize, int WaistSize, string LastName, string FirstName, string Email, 
                    string Password, List<SocialMedia> SocialMediaEl, string PathBodypic, string PathPicture, string ShirtSize, bool Gender, 
                    int Age, int Id, int PantSize, int ShoeSize, double Height,double Weight, List<Category> ClothesCategory,
                    List<Dressing> DressingList)
                    : base(LastName, FirstName, Email, Password, SocialMediaEl, PathBodypic, PathPicture, ShirtSize, Gender, Age, Id, PantSize, 
                          ShoeSize, Height, Weight, ClothesCategory, DressingList) 
        {
            this.braSize = BraSize;
            this.cupSize = CupSize;
            this. hipSize = HipSize;
            this.waistSize = WaistSize;
        }

        #endregion
    }
}
